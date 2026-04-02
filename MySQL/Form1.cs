using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.Model;

namespace MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RendelesBetoltesEsModositas();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception"></exception>
        private static void RendelesBetoltesEsModositas()
        {
            Rendeles? rendeles;
            GyakorloDbContext db = new();
            //rendeles = db.Rendelesek.Find(1);
            rendeles = db.Rendelesek.Include(r => r.RendelesTetelek)
                .Where(r => r.Id == 6).FirstOrDefault();
            if (rendeles == null)
                return;
            rendeles.RendelesTetelek[0].Mennyiseg = 2;
            if (rendeles.Osszesen == null)
            {
                foreach (var tetel in rendeles.RendelesTetelek)
                {
                    var termek = db.Termekek.Find(tetel.TermekId);
                    if (termek == null)
                        throw new Exception($"Nincs {tetel.TermekId} azonosítójú termék!");
                    rendeles.Osszesen += termek.Ar * tetel.Mennyiseg;
                }
            }
            db.SaveChanges();
        }
    }
}
