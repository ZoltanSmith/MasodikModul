namespace EgyediKomponensek.Components
{
    public partial class MyButton : Button
    {
        public MyButton()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            MouseEnter += button1_MouseEnter;
            MouseLeave += button1_MouseLeave;
        }

        /// <summary>
        /// Amikor az egérmutató a gomb fölé ér
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;
            //button1.BackColor = Color.FromArgb(255/*0-255*/, 100, 80, 120);
        }

        /// <summary>
        /// Amikor az egérmutató elhagyja a gombot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            ForeColor = SystemColors.ControlText;
        }
    }
}
