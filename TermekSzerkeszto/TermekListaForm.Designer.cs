namespace TermekSzerkeszto
{
    partial class TermekListaForm
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
            myButton1 = new EgyediKomponensek.Components.MyButton();
            myButton2 = new EgyediKomponensek.Components.MyButton();
            SuspendLayout();
            // 
            // myButton1
            // 
            myButton1.FlatStyle = FlatStyle.Flat;
            myButton1.Location = new Point(191, 138);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(125, 125);
            myButton1.TabIndex = 0;
            myButton1.Text = "Új ablak Dialog";
            myButton1.UseVisualStyleBackColor = true;
            myButton1.Click += myButton1_Click;
            // 
            // myButton2
            // 
            myButton2.FlatStyle = FlatStyle.Flat;
            myButton2.Location = new Point(445, 138);
            myButton2.Name = "myButton2";
            myButton2.Size = new Size(125, 125);
            myButton2.TabIndex = 1;
            myButton2.Text = "Új ablak Standalone";
            myButton2.UseVisualStyleBackColor = true;
            myButton2.Click += myButton2_Click;
            // 
            // TermekListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myButton2);
            Controls.Add(myButton1);
            Name = "TermekListaForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private EgyediKomponensek.Components.MyButton myButton1;
        private EgyediKomponensek.Components.MyButton myButton2;
    }
}
