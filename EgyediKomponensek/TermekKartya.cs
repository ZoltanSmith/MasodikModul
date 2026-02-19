using KozosResz.objects;

namespace EgyediKomponensek
{
    internal class TermekKartya : UserControl
    {
        public event EventHandler KosarhozAdasEsemeny;
        public Action OnKlikk { get; set; }

        public Termek Termek { get; set; }


        public TermekKartya()
        {
            Termek.Teszt();
            //OnCreateControl();
        }


        private void KosarhozAdas_Click(object sender, EventArgs e)
        {
            //if (KosarhozAdasEsemeny == null)
            //    return;
            KosarhozAdasEsemeny?.Invoke(this, EventArgs.Empty);
            // Termek = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnKlikk?.Invoke();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Termeknev jó hosszan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(24, 45);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(24, 70);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(42, 108);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 3;
            button1.Text = "Hozzáad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TermekKartya
            // 
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(173, 157);
            Name = "TermekKartya";
            Size = new Size(173, 157);
            ResumeLayout(false);

        }
    }
}
