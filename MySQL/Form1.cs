using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySQL.Data;
using MySQL.DTO;
using MySQL.Model;
using MySQL.Repository;
using System.ComponentModel;

namespace MySQL
{
    public partial class Form1 : Form
    {
        static GyakorloDbContext db;
        Queries queries;
        Rendeles rendeles;
        BindingList<Tetel> tetelek;

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
            tetelek = new();

            TermekGrid.DataSource = queries.GetTermekService().GetAll();
            TetelGrid.DataSource = tetelek;
            TetelGrid.Columns["TermekNev"].ReadOnly = true;
            // TODO: Reflexióval megkeresni a property-t
            TetelGrid.Columns[0].ReadOnly = true;

            TermekGrid.Columns["Ar"].ValueType = typeof(Int32);
            //foreach (DataGridViewColumn col in TermekGrid.Columns)
            //{
            //    MessageBox.Show($"{col.Name}, {col.DataPropertyName}");
            //}
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
            //if (sender == null)
            //{
            //    row = TermekGrid.CurrentRow.Index;
            //}
            //row = e.RowIndex;

            row = e?.RowIndex ?? TermekGrid.CurrentRow.Index;

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
            //MessageBox.Show($"Hurrá! Megvan a {selectedTermek.TermekNev}!");
            // TODO: ellenőrizni, hogy van-e már ilyen termék a rendeles.Tetelek-ben, ha igen, akkor csak növelni a mennyiséget, ha nincs, akkor új tételt hozzáadni
            rendeles.Tetelek.Add(new()
            {
                //RendelesId = rendeles.Id, // marad üresen egyelőre, mert még nincs rendeles.Id érték, csak majd a db-ben lesz, amikor elmentjük
                TermekId = selectedTermek.Id,
                Mennyiseg = 1
            });

            //TetelGrid.DataSource = rendeles.Tetelek;
            tetelek.Add(new Tetel
            {
                TermekNev = selectedTermek.TermekNev,
                Ar = selectedTermek.Ar,
                Mennyiseg = 1
            });
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
            MessageBox.Show(e.FilterString);
        }
    }
}
