namespace RPG
{
    partial class RPGForm
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
            nevTextBox = new TextBox();
            kasztComboBox = new ComboBox();
            randomStatButton = new Button();
            label1 = new Label();
            karakterListBox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            mentesButton = new Button();
            sotetVilagosButton = new Button();
            tulajdonsagLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            ugyLabel = new Label();
            intLabel = new Label();
            eroLabel = new Label();
            SuspendLayout();
            // 
            // nevTextBox
            // 
            nevTextBox.Location = new Point(387, 41);
            nevTextBox.Margin = new Padding(3, 4, 3, 4);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.Size = new Size(234, 23);
            nevTextBox.TabIndex = 0;
            // 
            // kasztComboBox
            // 
            kasztComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kasztComboBox.FormattingEnabled = true;
            kasztComboBox.Items.AddRange(new object[] { "Harcos", "Mágus", "Íjász", "Tolvaj" });
            kasztComboBox.Location = new Point(387, 85);
            kasztComboBox.Margin = new Padding(3, 4, 3, 4);
            kasztComboBox.Name = "kasztComboBox";
            kasztComboBox.Size = new Size(234, 24);
            kasztComboBox.TabIndex = 1;
            // 
            // randomStatButton
            // 
            randomStatButton.Location = new Point(467, 130);
            randomStatButton.Margin = new Padding(3, 4, 3, 4);
            randomStatButton.Name = "randomStatButton";
            randomStatButton.Size = new Size(154, 41);
            randomStatButton.TabIndex = 2;
            randomStatButton.Text = "Random Statisztikák";
            randomStatButton.UseVisualStyleBackColor = true;
            randomStatButton.Click += randomStatButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.Location = new Point(258, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 16);
            label1.TabIndex = 3;
            label1.Text = "Karakter neve:";
            // 
            // karakterListBox
            // 
            karakterListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            karakterListBox.Font = new Font("Cascadia Code", 10F);
            karakterListBox.FormattingEnabled = true;
            karakterListBox.ItemHeight = 17;
            karakterListBox.Location = new Point(12, 41);
            karakterListBox.Margin = new Padding(3, 4, 3, 4);
            karakterListBox.Name = "karakterListBox";
            karakterListBox.Size = new Size(219, 429);
            karakterListBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 5;
            label2.Text = "Karakterek:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.Location = new Point(258, 88);
            label3.Name = "label3";
            label3.Size = new Size(123, 16);
            label3.TabIndex = 6;
            label3.Text = "Karakter kasztja:";
            // 
            // mentesButton
            // 
            mentesButton.Location = new Point(307, 452);
            mentesButton.Margin = new Padding(3, 4, 3, 4);
            mentesButton.Name = "mentesButton";
            mentesButton.Size = new Size(218, 23);
            mentesButton.TabIndex = 7;
            mentesButton.Text = "Hozzáadás a csapathoz";
            mentesButton.UseVisualStyleBackColor = true;
            mentesButton.Click += mentesButton_Click;
            // 
            // sotetVilagosButton
            // 
            sotetVilagosButton.Location = new Point(546, 452);
            sotetVilagosButton.Margin = new Padding(3, 4, 3, 4);
            sotetVilagosButton.Name = "sotetVilagosButton";
            sotetVilagosButton.Size = new Size(75, 23);
            sotetVilagosButton.TabIndex = 8;
            sotetVilagosButton.Text = "sötét";
            sotetVilagosButton.UseVisualStyleBackColor = true;
            sotetVilagosButton.Click += sotetVilagosButton_Click;
            // 
            // tulajdonsagLabel
            // 
            tulajdonsagLabel.BorderStyle = BorderStyle.Fixed3D;
            tulajdonsagLabel.Location = new Point(258, 199);
            tulajdonsagLabel.Name = "tulajdonsagLabel";
            tulajdonsagLabel.Size = new Size(184, 220);
            tulajdonsagLabel.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(258, 183);
            label5.Name = "label5";
            label5.Size = new Size(122, 16);
            label5.TabIndex = 10;
            label5.Text = "Karakter leírása:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 200);
            label4.Name = "label4";
            label4.Size = new Size(33, 16);
            label4.TabIndex = 11;
            label4.Text = "Erő:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 234);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 12;
            label6.Text = "Intelligencia:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(467, 268);
            label7.Name = "label7";
            label7.Size = new Size(74, 16);
            label7.TabIndex = 13;
            label7.Text = "Ügyesség:";
            // 
            // ugyLabel
            // 
            ugyLabel.AutoSize = true;
            ugyLabel.Location = new Point(594, 268);
            ugyLabel.Name = "ugyLabel";
            ugyLabel.Size = new Size(15, 16);
            ugyLabel.TabIndex = 16;
            ugyLabel.Text = "0";
            ugyLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // intLabel
            // 
            intLabel.AutoSize = true;
            intLabel.Location = new Point(594, 234);
            intLabel.Name = "intLabel";
            intLabel.Size = new Size(15, 16);
            intLabel.TabIndex = 15;
            intLabel.Text = "0";
            intLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // eroLabel
            // 
            eroLabel.AutoSize = true;
            eroLabel.Location = new Point(594, 199);
            eroLabel.Name = "eroLabel";
            eroLabel.Size = new Size(15, 16);
            eroLabel.TabIndex = 14;
            eroLabel.Text = "0";
            eroLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RPGForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 495);
            Controls.Add(ugyLabel);
            Controls.Add(intLabel);
            Controls.Add(eroLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(tulajdonsagLabel);
            Controls.Add(sotetVilagosButton);
            Controls.Add(mentesButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(karakterListBox);
            Controls.Add(label1);
            Controls.Add(randomStatButton);
            Controls.Add(kasztComboBox);
            Controls.Add(nevTextBox);
            Font = new Font("Arial", 10F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RPGForm";
            Text = "RPG generáror";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nevTextBox;
        private ComboBox kasztComboBox;
        private Button randomStatButton;
        private Label label1;
        private ListBox karakterListBox;
        private Label label2;
        private Label label3;
        private Button mentesButton;
        private Button sotetVilagosButton;
        private Label tulajdonsagLabel;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label ugyLabel;
        private Label intLabel;
        private Label eroLabel;
    }
}
