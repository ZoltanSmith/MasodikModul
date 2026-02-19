using KozosResz.objects;

namespace KozosResz.delegates
{
    public static class RendelesErtesitesek
    {
        public static void EmailErtesites(Rendeles rendeles, Vevo vevo)
        {
            Console.WriteLine("E-mail értesítés: Rendelés státusza megváltozott: " + rendeles.Statusz); } public static void SmsErtesites(Rendeles rendeles) { Console.WriteLine("SMS értesítés: Rendelés státusza megváltozott: " + rendeles.Statusz);
            // nem tudunk mbox-ot hívni, mert dll project
            //EmailKuldo.SendEmail(vevo.email, "Rendelés értesítés", "Rendelés státusza megváltozott: " + rendeles.Statusz);
        }

        public static void SmsErtesites(Rendeles rendeles, Vevo vevo)
        {
            Console.WriteLine("SMS értesítés: Rendelés státusza megváltozott: " + rendeles.Statusz);
            //SmsKuldo.SendSms(vevo.telefonszam, "Rendelés státusza megváltozott: " + rendeles.Statusz);
        }
    }
}
