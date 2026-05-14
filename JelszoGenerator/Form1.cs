using Konscious.Security.Cryptography;
using KozosResz.extensions;
using ReaLTaiizor.Forms;
using System.Security.Cryptography;
using System.Text;
using UUIDNext;

namespace JelszoGenerator
{
    public partial class Form1 : Form
    {
        Random rnd;
        String availableCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.-,%:_";
        string salt = "enkodom";

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

            //salt = RandomNumberGenerator.GetString(availableCharacters, 6);
            saltText.Text = salt;

            genereteArgon2Hash(password.Text, salt);

            // visszafejtés:

            var saltFromDB = salt;
            var hashFromDB = hashText.Text;
            var hash = genereteArgon2Hash(password.Text, saltFromDB);

            var joAHash = hashFromDB == hash;

            var hashBytesFromDB = Convert.FromBase64String(hashFromDB);
            var hashBytes = Convert.FromBase64String(hash);
            // timing-attack ellen:
            joAHash = CryptographicOperations.FixedTimeEquals(hashBytesFromDB, hashBytes);

            MessageBox.Show(joAHash ? "siker" : "nem jó");

            generateUUID();
        }

        void genereteRandomPassword()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                sb.Append((char)rnd.Next(49, 123));
            }
            password.Text = sb.ToString();
            password.Text = "jelszo";
        }

        string genereteArgon2Hash(string jelszo, string kodkartya)
        {
            using (var argon = new Argon2id(Encoding.UTF8.GetBytes(jelszo))
            {
                Salt = Encoding.UTF8.GetBytes(kodkartya),
                Iterations = 3,
                DegreeOfParallelism = 8, // szálak száma generáláskor
                MemorySize = 1024 * 64 // 64 MB
            })
            {
                var hash = Convert.ToBase64String(argon.GetBytes(16));
                hashText.Text = hash;
                return hash;
            }
        }

        void generateUUID()
        {
            // Guid.NewGuid().ToString(); // UUID v4
            // UUIDNext.Uuid.NewDatabaseFriendly(Database.SQLite).ToString(); // UUID v7

            MessageBox.Show(Guid.NewGuid().ToString());
            MessageBox.Show(Uuid.NewDatabaseFriendly(Database.SQLite).ToString());
        }
    }
}
