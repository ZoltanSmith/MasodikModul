namespace TermekSzerkeszto
{
    partial class TermekSzerkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            myButton1 = new EgyediKomponensek.Components.MyButton();
            SuspendLayout();
            // 
            // myButton1
            // 
            myButton1.FlatStyle = FlatStyle.Flat;
            myButton1.Location = new Point(289, 129);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(166, 159);
            myButton1.TabIndex = 0;
            myButton1.Text = "Háttér módosítás";
            myButton1.UseVisualStyleBackColor = true;
            myButton1.Click += myButton1_Click;
            // 
            // TermekSzerkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myButton1);
            Name = "TermekSzerkForm";
            Text = "TermekSzerkForm";
            ResumeLayout(false);
        }

        #endregion

        private EgyediKomponensek.Components.MyButton myButton1;
    }
}