namespace Szalak
{
    public partial class Form1 : Form
    {
        int threadId = 0;
        public Form1()
        {
            InitializeComponent();
            threadId = Thread.CurrentThread.ManagedThreadId;
        }

        private bool CsinaljunkValamit(ProgressBar pb)
        {
            for (int i = 0; i < 10; i++)
            {
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                //Task.Delay(500).Wait();
                try
                {
                    Invoke(() =>
                    {
                        pb.Value += 10;
                    });
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        async Task<bool> CsinaljunkValamitHatterben(ProgressBar pb)
        {
            return await Task.Run(() =>
            {
                return CsinaljunkValamit(pb);
            });
        }

        private void AmikorKesz(bool kesz)
        {
            threadId = Thread.CurrentThread.ManagedThreadId;

            if (kesz)
            {
                MessageBox.Show("Kész!");
            }
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            bool kesz = CsinaljunkValamit(SyncPB);
            AmikorKesz(kesz);
        }

        private async void AsyncButton_Click(object sender, EventArgs e)
        {
            //await File.WriteAllBytesAsync("", new byte[21]);

            bool kesz = await CsinaljunkValamitHatterben(AysncPB);
            AmikorKesz(kesz);
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => CsinaljunkValamit(TaskPB)).ContinueWith((task) =>
            {
                AmikorKesz(task.Result);
            });

            //File.WriteAllBytesAsync("", new byte[21]).ContinueWith((task) => AmikorKesz(true));

            //bool kesz = Task.Run(() => CsinaljunkValamit(TaskPB)).Result;
            //AmikorKesz(kesz);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = $"Aktuális szál: {threadId}";
        }
    }
}
