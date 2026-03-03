using KozosResz.objects;

namespace EgyediKomponensek.Components
{
    internal class TermekKartya : UserControl
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button button;
        private Termek? termek;

        public event EventHandler KosarhozAdasEsemeny;

        public Action OnKlikk { get; set; }

        public Termek? Termek { get => termek; set => SetTermek(value); }
        public int Egeszke { get; set; }

        private void SetTermek(Termek? t)
        {
            termek = t;
            label1.Text = termek?.Nev ?? "N/A";
            //termek == null ? checkBox1.Visible = false : checkBox1.Visible = true;
            label2.Text = termek?.Ar.ToString("0.00") + " lei";
            checkBox1.Checked = termek?.Aktiv ?? false; //de lehet true is, ha úgy szeretnénk
        }

        public TermekKartya()
        {
            Termek.Teszt();
            //OnCreateControl();
            InitializeComponent();
            Termek = null;
            button.Click += KosarhozAdas_Click;

        }


        private void KosarhozAdas_Click(object sender, EventArgs e)
        {
            //if (KosarhozAdasEsemeny == null)
            //    return;
            KosarhozAdasEsemeny?.Invoke(this, EventArgs.Empty);
            // Termek = null;
            MessageBox.Show("kosarhozadas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("b1click");
            OnKlikk?.Invoke();
        }


        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Termeknev jó hosszan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(24, 82);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new Point(42, 120);
            button.Name = "button1";
            button.Size = new Size(89, 23);
            button.TabIndex = 3;
            button.Text = "Hozzáad";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.ForeColor = SystemColors.Highlight;
            checkBox1.Location = new Point(81, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "rendelhető: ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TermekKartya
            // 
            Controls.Add(checkBox1);
            Controls.Add(button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(173, 157);
            Name = "TermekKartya";
            Size = new Size(173, 157);
            ResumeLayout(false);
            PerformLayout();

        }

        
    }
}
