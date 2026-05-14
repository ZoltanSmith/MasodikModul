namespace JelszoGenerator
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
            password = new Label();
            genButton = new Button();
            close = new Label();
            SuspendLayout();
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Consolas", 9F);
            password.Location = new Point(36, 52);
            password.Margin = new Padding(2, 0, 2, 0);
            password.Name = "password";
            password.Size = new Size(49, 14);
            password.TabIndex = 0;
            password.Text = "******";
            // 
            // genButton
            // 
            genButton.FlatStyle = FlatStyle.Flat;
            genButton.Font = new Font("Roboto", 9F);
            genButton.Location = new Point(27, 85);
            genButton.Margin = new Padding(2);
            genButton.Name = "genButton";
            genButton.Size = new Size(68, 53);
            genButton.TabIndex = 1;
            genButton.Text = "Jelszót! Most!";
            genButton.UseVisualStyleBackColor = true;
            genButton.Click += genButton_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Roboto Bk", 10F);
            close.ForeColor = Color.Red;
            close.Location = new Point(99, 7);
            close.Margin = new Padding(2, 0, 2, 0);
            close.Name = "close";
            close.Size = new Size(17, 17);
            close.TabIndex = 2;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(121, 162);
            Controls.Add(close);
            Controls.Add(genButton);
            Controls.Add(password);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label password;
        private Button genButton;
        private Label close;
    }
}
