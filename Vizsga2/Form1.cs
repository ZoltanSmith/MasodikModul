namespace Vizsga2
{
    public partial class Form1 : Form
    {
        List<int> szamok = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBox1.Text, out int szam))
                {
                    szamok.Add(szam);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Kérem, számot adjon meg!");
                }

                try
                {
                    int szam2 = Convert.ToInt32(textBox1.Text);
                    szamok.Add(szam2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kérem, számot adjon meg!");
                }

                int szam3 = (int)numericUpDown1.Value;
                szamok.Add(szam3);
                OsszegFrissitese();
            }

            void OsszegFrissitese()
            {
                var osszeg = 0;
                foreach (var szam in szamok)
                {
                    osszeg += szam;
                }

                osszeg = szamok.Sum();
                label1.Text = osszeg.ToString();
            }
        }
    }
}
