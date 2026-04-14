using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using MySQL.Data;
using MySQL.Model;
using MySQL.Repository;

namespace MySQL
{
    public partial class Form1 : Form
    {
        static GyakorloDbContext db;
        Queries queries;

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
    }
}
