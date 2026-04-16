using MySQL.Model;
using MySQL.Repository;
using System.Runtime.CompilerServices;

namespace MySQL.Data
{
    internal class Queries
    {
        RawMySqlRendelesRepo RendelesRaw;
        LinqMethodRendelesRepo RendelesLM;
        RawMySqlFelhasznaloRepo FelhasznaloRaw;
        LinqQueryFelhasznaloRepo FelhasznaloLQ;
        LinqMethodFelhasznaloRepo FelhasznaloLM;
        LinqMethodTermekRepo TermekLM;

        public Queries(GyakorloDbContext db)
        {
            RendelesRaw = new()
            {
                Conn = db
            };

            RendelesLM = new()
            {
                Context = db
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

            TermekLM = new()
            {
                Context = db
            };

        }

        internal LinqMethodRendelesRepo GetRendelesLM()
        {
            return RendelesLM;
        }

        public LinqMethodTermekRepo GetTermekService()
        {
            return TermekLM;
        }

        internal void GetDataWithEF(LinqMethodRendelesRepo rendelesLM)
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
            foreach (Felhasznalo item in felhasznalok)
            {
                Console.WriteLine(item);
            }

            var kj = FelhasznaloRaw.GetKovacsJanos();
            Console.WriteLine(kj);

            FelhasznaloLQ.GetKovacsJanos();
            FelhasznaloLM.GetKovacsJanos();
            
            List<string> lista = FelhasznaloRaw.GetEmaillessUsers();
            lista = FelhasznaloLQ.GetEmaillessUsers();
            lista = FelhasznaloLM.GetEmaillessUsers();

            felhasznalok = FelhasznaloRaw.GetNamesWithDoubleA();
            felhasznalok = FelhasznaloLQ.GetNamesWithDoubleA();
            felhasznalok = FelhasznaloLM.GetNamesWithDoubleA();

            lista = FelhasznaloLM.GetNamesWithLower();

            long szam = FelhasznaloLQ.CountUsers();
            szam = FelhasznaloLM.CountUsers();
            //szam = FelhasznaloRaw.CountUsers();

            TermekLM.GetPriceBetween5And15Th().ForEach(t => Console.WriteLine(t));
            
            List<Rendeles> last5 = rendelesLM.GetLast5();

            List<Termek> termekek = TermekLM.GetNameContainsVezetek();

            var x = TermekLM.GetNameLength();

            int? i = TermekLM.LegbovebbKategoriaId();
            
            var y = TermekLM.GetAtlagArByKategoria();
            var y2 = TermekLM.GetAtlagArObjectByKategoria();

            i = RendelesLM.GetFullIncome();

            var rwfn = RendelesLM.GetRendelesekNevvel();

            var tetelek = RendelesLM.GetTetelek();
        }
    }
}
