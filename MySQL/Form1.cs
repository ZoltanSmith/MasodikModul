using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySQL.Data;
using MySQL.DTO;
using MySQL.Model;
using System.ComponentModel;
using System.Data;

namespace MySQL
{
    public partial class Form1 : Form
    {
        const int PAGESIZE = 10;
        static GyakorloDbContext db;
        Queries queries;
        Rendeles rendeles;
        DataTable tetelDataTable;

        // Pagination fields
        private int currentPage = 1;
        private int totalPages = 1;

        public Form1()
        {
            InitializeComponent();
            splitContainer.SplitterDistance = (splitContainer.Width + splitContainer.SplitterWidth) / 2;
            ConnectWithEF();
            RendelesBetoltesEsModositas();
            GetDataWithDbConn();
            InitData();
            //queries.GetDataWithEF(queries.GetRendelesLM());
        }

        private void InitData()
        {
            FelhasznaloList.DataSource = db.Felhasznalok.ToList();
            FelhasznaloList.DisplayMember = "Nev";

            rendeles = new();

            // Initialize DataTable for TetelGrid (ADG native support)
            tetelDataTable = new DataTable();
            tetelDataTable.Columns.Add("TermekId", typeof(int));
            tetelDataTable.Columns.Add("TermekNev", typeof(string));
            tetelDataTable.Columns.Add("Ar", typeof(int));
            tetelDataTable.Columns.Add("Mennyiseg", typeof(int));

            TermekGrid.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Edit",
                Text = "Szerk.",
                DataPropertyName = "",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
            });

            // Load all products and initialize pagination
            TermekGrid.DataSource = queries.GetTermekService().GetPage(0, PAGESIZE, out totalPages);
            TermekGrid.Columns[1].Visible = false; // Id oszlop elrejtése, mert nem fontos a felhasználónak látni
            currentPage = 1;
            actualPage.Text = $"{currentPage}";
            LoadTermekPage();

            TetelGrid.DataSource = tetelDataTable;
            TetelGrid.Columns["TermekNev"].ReadOnly = true;
            TetelGrid.Columns["Ar"].ReadOnly = true;
            TetelGrid.Columns["TermekId"].Visible = false;

            TermekGrid.Columns["Ar"].ValueType = typeof(Int32);
        }

        private void LoadTermekPage()
        {
            TermekGrid.DataSource = queries.GetTermekService().GetPage((currentPage - 1) * PAGESIZE, PAGESIZE, out totalPages);
            actualPage.Text = $"{currentPage}";

            btnTermekFirst.Enabled = currentPage > 1;
            btnTermekPrev.Enabled = currentPage > 1;
            btnTermekNext.Enabled = currentPage < totalPages;
            btnTermekLast.Enabled = currentPage < totalPages;
        }

        private void ConnectWithEF()
        {
            db = new();
            queries = new(db);
        }


        private static void GetDataWithDbConn()
        {
            MySqlCommand cmd = new MySqlCommand(
                "WITH tisztitott_varos AS (select id, lower(trim(varos)) varos from felhasznalok) " +
                "select varos, count(1)" +
                " from rendelesek r join tisztitott_varos f on(f.id=r.felhasznalo_id) group by varos;",
                Connection.dbConn);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                foreach (System.Data.Common.DbDataRecord item in reader)
                {
                    item.ToString();
                    item.GetName(0);
                    item.GetValue(0).ToString();
                }
            }

            cmd = new MySqlCommand(
                "SELECT COUNT(id) FROM felhasznalok",
                Connection.dbConn);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                foreach (System.Data.Common.DbDataRecord item in reader)
                {
                    Console.WriteLine(item.GetValue(0));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception"></exception>
        private static void RendelesBetoltesEsModositas()
        {
            Rendeles? rendeles;
            //rendeles = db.Rendelesek.Find(1);
            rendeles = db.Rendelesek.Include(r => r.Tetelek)
                .Where(r => r.Id == 6).FirstOrDefault();
            if (rendeles == null)
                return;
            rendeles.Tetelek[0].Mennyiseg = 2;
            if (rendeles.Osszesen == null)
            {
                rendeles.Osszesen = 0m;
                foreach (var tetel in rendeles.Tetelek)
                {
                    var termek = db.Termekek.Find(tetel.TermekId);
                    if (termek == null)
                    {
                        //throw new Exception($"Nincs {tetel.TermekId} azonosítójú termék!");
                        continue;
                    }
                    rendeles.Osszesen += termek.Ar * tetel.Mennyiseg;
                }
            }
            db.SaveChanges();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            FelhasznaloList.Visible = !FelhasznaloList.Visible;
        }

        private void FelhasznaloList_DoubleClick(object sender, EventArgs e)
        {
            Felhasznalo.Tag = FelhasznaloList.SelectedItem;
            Felhasznalo.Text = ((Felhasznalo)Felhasznalo.Tag).Nev;
            FelhasznaloList.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            splitContainer.SplitterDistance = (splitContainer.Width + splitContainer.SplitterWidth) / 2;
        }

        /// <summary>
        /// Dblclk event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TermekGrid_Select(object sender, DataGridViewCellEventArgs e)
        {
            int row = -1;

            row = e?.RowIndex ?? TermekGrid.CurrentRow?.Index ?? -1;

            if (!(TermekGrid.DataSource is List<DTO.Termek>))
            {
                return;
            }

            var t = (List<DTO.Termek>)TermekGrid.DataSource;

            if (row < 0 || row >= t.Count)
            {
                return;
            }

            var selectedTermek = t[row];

            rendeles.Tetelek.Add(new()
            {
                TermekId = selectedTermek.Id,
                Mennyiseg = 1
            });

            // Add to DataTable
            tetelDataTable.Rows.Add(selectedTermek.Id, selectedTermek.TermekNev, selectedTermek.Ar, 1);
        }

        private void TermekGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //TermekGrid_Select(TermekGrid, new DataGridViewCellEventArgs(TermekGrid.CurrentRow.Index, TermekGrid.SelectedColumns[0].Index));
                TermekGrid_Select(null, null);
            }
        }

        private void TetelGrid_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            if (tetelDataTable == null)
                return;
            
            try
            {
                tetelDataTable.DefaultView.RowFilter = e.FilterString;
            }
            catch
            {
                tetelDataTable.DefaultView.RowFilter = "";
            }

            TetelGrid.Invalidate();
        }

        private void BtnTermekFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadTermekPage();
        }

        private void BtnTermekPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadTermekPage();
            }
        }

        private void BtnTermekNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadTermekPage();
            }
        }

        private void BtnTermekLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadTermekPage();
        }

        private void TermekGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != TermekGrid.Columns["Edit"].Index
                || e.RowIndex < 0 || e.RowIndex >= PAGESIZE)
                return;

            if (TermekGrid?.Columns["Edit"] == null)
                return;

            var dataSource = TermekGrid.DataSource as List<DTO.Termek>;
            if (dataSource == null || e.RowIndex >= dataSource.Count)
                return;

            DTO.Termek dtoTermek = dataSource[e.RowIndex];

            var modelTermek = queries.GetTermekService().GetById(dtoTermek.Id);
            if (modelTermek == null)
                return;

            using (var editor = new TermekEditor(db, modelTermek))
            {
                if (editor.ShowDialog(this) == DialogResult.OK)
                {
                    LoadTermekPage();
                }
            }
        }
    }
}
