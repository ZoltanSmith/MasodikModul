using Konscious.Security.Cryptography;
using ReaLTaiizor.Forms;
using System.Security.Cryptography;
using System.Text;

namespace JelszoGenerator
{
    public partial class Form1 : Form
    {
        Random rnd;
        String availableCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.-,%:_";

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
            genereteRandomPassword();

            //vagy

            password.Text = RandomNumberGenerator.GetString(availableCharacters, 6);
        }

        void genereteRandomPassword()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                sb.Append((char)rnd.Next(49, 123));
            }
            password.Text = sb.ToString();
        }

        void genereteArgon2Password()
        {
            new Argon2id(Encoding.UTF8.GetBytes("password"))
            {
                Salt = Encoding.UTF8.GetBytes("somesalt"),
                DegreeOfParallelism = 8, // szálak száma generáláskor
                Iterations = 4,
                MemorySize = 1024 * 64 // 64 MB
            }.GetBytes(16);
        }
    }
}
