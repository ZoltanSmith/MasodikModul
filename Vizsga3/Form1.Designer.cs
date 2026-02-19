namespace Vizsga3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            button2 = new Button();
            progressBar2 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(progressBar1);
            splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(progressBar2);
            splitContainer1.Panel2MinSize = 250;
            splitContainer1.Size = new Size(694, 269);
            splitContainer1.SplitterDistance = 348;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 54);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "1. játékos";
            // 
            // button1
            // 
            button1.Location = new Point(112, 105);
            button1.Name = "button1";
            button1.Size = new Size(119, 50);
            button1.TabIndex = 1;
            button1.Text = "Dobás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(79, 184);
            progressBar1.Maximum = 21;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(187, 23);
            progressBar1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 54);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "2. játékos";
            // 
            // button2
            // 
            button2.Location = new Point(110, 105);
            button2.Name = "button2";
            button2.Size = new Size(119, 50);
            button2.TabIndex = 4;
            button2.Text = "Dobás";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(78, 184);
            progressBar2.Maximum = 21;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(187, 23);
            progressBar2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 269);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button button1;
        private ProgressBar progressBar1;
        private Label label2;
        private Button button2;
        private ProgressBar progressBar2;
    }
}
