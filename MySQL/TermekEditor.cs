using MySQL.Model;
using MySQL.Data;

namespace MySQL
{
    public partial class TermekEditor : Form
    {
        private readonly GyakorloDbContext _db;
        private Termek _termek;

        public TermekEditor(GyakorloDbContext db, Termek? termek = null)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _termek = termek ?? new Termek();

            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var kategoriak = _db.Kategoria.ToList();
            cbKategoria.DisplayMember = "Nev";
            cbKategoria.ValueMember = "Id";
            cbKategoria.DataSource = kategoriak;

            if (_termek != null && _termek.Id != 0)
            {
                tbNev.Text = _termek.TermekNev ?? string.Empty;
                nudAr.Value = _termek.Ar ?? 0;
                if (_termek.KategoriaId != null)
                {
                    cbKategoria.SelectedValue = _termek.KategoriaId;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNev.Text))
            {
                MessageBox.Show("A termék neve nem lehet üres.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _termek.TermekNev = tbNev.Text.Trim();
            _termek.Ar = (int)nudAr.Value;
            _termek.KategoriaId = cbKategoria.SelectedItem is Kategoria k ? k.Id : null;

            if (_termek.Id == 0)
            {
                _db.Termekek.Add(_termek);
            }
            else
            {
                _db.Termekek.Update(_termek);
            }

            _db.SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
