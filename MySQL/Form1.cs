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
        RawMySqlRendelesRepo RendelesRaw;
        RawMySqlFelhasznaloRepo FelhasznaloRaw;
        LinqQueryFelhasznaloRepo FelhasznaloLQ;
        LinqMethodFelhasznaloRepo FelhasznaloLM;

        public Form1()
        {
            InitializeComponent();
            ConnectWithEF();
            RendelesBetoltesEsModositas();
            GetDataWithDbConn();
            GetDataWithEF();
        }

        private void ConnectWithEF()
        {
            db = new();

            RendelesRaw = new()
            {
                Conn = db
            };

            FelhasznaloRaw = new()
            {
                Conn = db
            };

            FelhasznaloLQ = new()
            {
                Conn = db
            };

            FelhasznaloLM = new()
            {
                Conn = db
            };
        }

        private void GetDataWithEF()
        {
            //System.Collections.IEnumerable enumerable = raw.GetRendelesWithAllData();
            //foreach (var item in enumerable)
            //{
            //    System.Console.WriteLine(item);
            //}

            List<Felhasznalo> felhasznalok;
            // raw query-vel:
            felhasznalok = FelhasznaloRaw.GetAll();
            foreach (var item in felhasznalok)
            {
                Console.WriteLine(item);
            }

            // Linq query-vel
            felhasznalok = FelhasznaloLQ.GetAll();
            foreach (var item in felhasznalok)
            {
                Console.WriteLine(item);
            }

            // Linq method-dal
            felhasznalok = FelhasznaloLM.GetAll();
            foreach (var item in felhasznalok)
            {
                Console.WriteLine(item);
            }

            var kj = FelhasznaloRaw.GetKovacsJanos();
            Console.WriteLine(kj);
        }

        private static void GetDataWithDbConn()
        {
            MySqlCommand cmd = new MySqlCommand(
                "WITH tisztitott_varos AS (select id, lower(trim(varos)) varos from felhasznalok) " +
                "select varos, count(1)" +
                " from rendelesek r join tisztitott_varos f on(f.id=r.felhasznalo_id) group by varos;",
                Connection.dbConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            foreach (System.Data.Common.DbDataRecord item in reader)
            {
                item.ToString();
                item.GetName(0);
                item.GetValue(0).ToString();
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
            rendeles = db.Rendelesek.Include(r => r.RendelesTetelek)
                .Where(r => r.Id == 6).FirstOrDefault();
            if (rendeles == null)
                return;
            rendeles.RendelesTetelek[0].Mennyiseg = 2;
            if (rendeles.Osszesen == null)
            {
                rendeles.Osszesen = 0m;
                foreach (var tetel in rendeles.RendelesTetelek)
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
    }
}
