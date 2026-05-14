using ReaLTaiizor.Forms;
using System.Text;

namespace JelszoGenerator
{
    public partial class Form1 : Form
    {
        Random rnd;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                sb.Append((char)rnd.Next(49, 123));
            }
            password.Text = sb.ToString();
        }
    }
}
