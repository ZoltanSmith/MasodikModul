namespace Vizsga1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        const bool runExceptionTest = false;

        public Form1()
        {
            InitializeComponent();
            #region 2. és 4. elméleti
            if (runExceptionTest)
            {
                int szam = -1;
                try
                {
                    // itt keletkezhet kivétel
                    szam++; //vmi mûvelet
                    if (szam == 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex) //catch-bõl több is lehet
                {
                    //itt kezeljük a kivételt
                    MessageBox.Show(ex.Message);
                    // throw ex; // újra dobjuk a kivételt, hogy tovább kezelje a hívó
                    return;
                }
                finally
                {
                    MessageBox.Show("Test finally");
                    // itt helyezzük el a kódot, ami mindenképpen lefut, akár volt kivétel, akár nem
                }
                MessageBox.Show("Test utána");
            }
            #endregion


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dobott = rnd.Next(1, 7);
            MessageBox.Show("Dobott: " + dobott);
        }
    }
}
