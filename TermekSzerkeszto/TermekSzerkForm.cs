using KozosResz.objects;

namespace TermekSzerkeszto
{
    public partial class TermekSzerkForm : Form
    {
        Random r = new Random();
        Keszlet k;
        internal int Id { get; set; }

        internal Color HatterSzin { get; set; }
        internal Termek Termek { get; set; }

        public delegate void TermekSzerkEventHandler(object sender, EventArgs e);
        public TermekSzerkEventHandler TermekSzerk;

        public TermekSzerkForm(int id, Keszlet k)
        {
            InitializeComponent();
            this.k = k;
            Id = id;
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            k.Darab = new Random().Next(0, 100);
        }

        internal int GetWidth(ref int w, string h)
        {
            w = Width;
            return this.Width;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            TermekSzerk(this, e);
            base.OnFormClosed(e);
        }
    }
}
