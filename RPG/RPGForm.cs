using RPG.Model;

namespace RPG
{
    public partial class RPGForm : Form
    {
        Random random = new Random();
        Karakter? karakter;

        public RPGForm()
        {
            InitializeComponent();
            //innen is inicializálható a kasztComboBox
        }

        private void randomStatButton_Click(object sender, EventArgs e)
        {
            karakter = generateKarater();
            //TODO: itt csak a statokat kellene randomizálni
        }

        private Karakter generateKarater() //kell egy másik a statok generálására is
        {
            Karakter karakter = new Karakter();
            karakter.Nev = nevTextBox.Text;
            karakter.Kaszt = kasztComboBox.SelectedItem?./*Object?.*/ToString() ?? "hiányzó kaszt";
            karakter.Ero = random.Next(1, 21);
            karakter.Intelligencia = random.Next(1, 21);
            karakter.Ugyesseg = random.Next(1, 21);

            eroLabel.Text = karakter.Ero.ToString();
            intLabel.Text = karakter.Intelligencia + "";
            ugyLabel.Text = Convert.ToString(karakter.Ugyesseg);

            tulajdonsagLabel.Text = karakter.ToNiceString();
            return karakter;
        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            karakter = generateKarater();
            try
            {
                validateKarakter(karakter);
                karakterListBox.Items.Add(karakter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //bool valid = validateKarakterBool(karakter);
            //if (valid)
            //{
            //    karakterListBox.Items.Add(karakter);
            //}
            //else
            //{
            //    MessageBox.Show("A karakter adatai nem megfelelőek!");
            //}
        }

        /// <summary>
        /// Ellenőrzi a karakter adatait, hogy megfelelnek
        /// </summary>
        /// <param name="karakter"></param>
        /// <exception cref="Exception"></exception>
        private void validateKarakter(Karakter? karakter)
        {
            if (karakter == null)
                throw new NullReferenceException();
            if (String.IsNullOrWhiteSpace(karakter.Nev))
                throw new Exception("A név nem lehet üres!");
            if (String.IsNullOrWhiteSpace(karakter.Kaszt))
                throw new Exception("A kaszt nem lehet üres!");
            if (karakter.Ero < 1 || karakter.Ero > 20)
                throw new Exception("Az erő értéke 1 és 20 között kell legyen!");
            if (karakter.Intelligencia < 1 || karakter.Intelligencia > 20)
                throw new Exception("Az intelligencia értéke 1 és 20 között kell legyen!");
            if (karakter.Ugyesseg < 1 || karakter.Ugyesseg > 20)
                throw new Exception("Az ügyesség értéke 1 és 20 között kell legyen!");
        }

        private bool validateKarakterBool(Karakter? karakter)
        {
            if (karakter == null)
                return false;
            //...
            return true;
        }

        private void sotetVilagosButton_Click(object sender, EventArgs e)
        {
            if (sotetVilagosButton.Tag == "sotet")
            {
                foreach (Control control in Controls)
                {
                    control.BackColor = SystemColors.Control;
                    control.ForeColor = Color.FromArgb(10, 10, 10);
                }
                //BackColor = SystemColors.Control;
                //ForeColor = Color.FromArgb(10, 10, 10);
                sotetVilagosButton.Tag = "vilagos";
            } else {
                sotetVilagosButton.Tag = "sotet";
                BackColor = Color.DarkGray;
                ForeColor = Color.WhiteSmoke;
            }

        }
    }
}
