namespace Tamagocsi
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
            eledelCombo = new ComboBox();
            allatListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            generalasButton = new Button();
            SuspendLayout();
            // 
            // eledelCombo
            // 
            eledelCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            eledelCombo.BackColor = Color.LightCyan;
            eledelCombo.FormattingEnabled = true;
            eledelCombo.Location = new Point(335, 29);
            eledelCombo.Name = "eledelCombo";
            eledelCombo.Size = new Size(144, 26);
            eledelCombo.TabIndex = 0;
            // 
            // allatListBox
            // 
            allatListBox.BackColor = Color.LightCyan;
            allatListBox.FormattingEnabled = true;
            allatListBox.ItemHeight = 18;
            allatListBox.Location = new Point(26, 54);
            allatListBox.Name = "allatListBox";
            allatListBox.Size = new Size(181, 454);
            allatListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 3;
            label1.Text = "Állatok:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(274, 33);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 4;
            label2.Text = "Eledel:";
            // 
            // generalasButton
            // 
            generalasButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            generalasButton.FlatAppearance.BorderColor = Color.LightCyan;
            generalasButton.FlatStyle = FlatStyle.Flat;
            generalasButton.ForeColor = Color.Coral;
            generalasButton.Location = new Point(314, 459);
            generalasButton.Name = "generalasButton";
            generalasButton.Size = new Size(165, 51);
            generalasButton.TabIndex = 5;
            generalasButton.Text = "Adatok generálása";
            generalasButton.UseVisualStyleBackColor = true;
            generalasButton.Click += generalasButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(491, 542);
            Controls.Add(generalasButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(allatListBox);
            Controls.Add(eledelCombo);
            Font = new Font("Open Sans", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Tamagoccsi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox eledelCombo;
        private ListBox allatListBox;
        private Label label1;
        private Label label2;
        private Button generalasButton;
    }
}
