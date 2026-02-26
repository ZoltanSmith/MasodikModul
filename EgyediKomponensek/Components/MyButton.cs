using System.Drawing.Drawing2D;

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
            DoubleBuffered = true;

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

        override protected void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //pe.Graphics.Clear(SystemColors.Control);
            pe.Graphics.Clear(Color.Transparent);
            pe.Graphics.Clear(Parent.BackColor);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            pe.Graphics.FillEllipse(new SolidBrush(BackColor), rect);
            pe.Graphics.DrawEllipse(Pens.Black, rect);
            pe.Graphics.DrawString(this.Text, this.Font, new SolidBrush(ForeColor), DisplayRectangle, new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            });
            // TextRenderer.DrawText(pe.Graphics, this.Text, this.Font, DisplayRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            // GraphicsPath gp = new GraphicsPath()
            // pe.Graphics.Draw...
            // pe.Graphics.Fill...
        }
    }
}
