namespace EgyediKomponensek
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
            termekKartya1 = new TermekKartya();
            osszegLabel = new Label();
            SuspendLayout();
            // 
            // termekKartya1
            // 
            termekKartya1.Location = new Point(38, 25);
            termekKartya1.Name = "termekKartya1";
            termekKartya1.OnKlikk = null;
            termekKartya1.Size = new Size(131, 135);
            termekKartya1.TabIndex = 0;
            termekKartya1.Termek = null;
            // 
            // osszegLabel
            // 
            osszegLabel.AutoSize = true;
            osszegLabel.Location = new Point(65, 395);
            osszegLabel.Name = "osszegLabel";
            osszegLabel.Size = new Size(38, 15);
            osszegLabel.TabIndex = 1;
            osszegLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(osszegLabel);
            Controls.Add(termekKartya1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TermekKartya termekKartya1;
        private Label osszegLabel;
    }
}
