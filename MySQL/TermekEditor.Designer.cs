namespace MySQL
{
    partial class TermekEditor
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
            lblNev = new Label();
            tbNev = new TextBox();
            lblAr = new Label();
            nudAr = new NumericUpDown();
            lblKategoria = new Label();
            cbKategoria = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAr).BeginInit();
            SuspendLayout();
            // 
            // lblNev
            // 
            lblNev.AutoSize = true;
            lblNev.Location = new Point(12, 15);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(35, 18);
            lblNev.TabIndex = 0;
            lblNev.Text = "Név:";
            // 
            // tbNev
            // 
            tbNev.Location = new Point(100, 12);
            tbNev.Name = "tbNev";
            tbNev.Size = new Size(280, 25);
            tbNev.TabIndex = 1;
            // 
            // lblAr
            // 
            lblAr.AutoSize = true;
            lblAr.Location = new Point(12, 55);
            lblAr.Name = "lblAr";
            lblAr.Size = new Size(56, 18);
            lblAr.TabIndex = 2;
            lblAr.Text = "Ár (Ft):";
            // 
            // nudAr
            // 
            nudAr.Location = new Point(100, 52);
            nudAr.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudAr.Name = "nudAr";
            nudAr.Size = new Size(150, 25);
            nudAr.TabIndex = 3;
            // 
            // lblKategoria
            // 
            lblKategoria.AutoSize = true;
            lblKategoria.Location = new Point(12, 95);
            lblKategoria.Name = "lblKategoria";
            lblKategoria.Size = new Size(73, 18);
            lblKategoria.TabIndex = 4;
            lblKategoria.Text = "Kategória:";
            // 
            // cbKategoria
            // 
            cbKategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategoria.Location = new Point(100, 92);
            cbKategoria.Name = "cbKategoria";
            cbKategoria.Size = new Size(200, 26);
            cbKategoria.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 140);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Mentés";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 140);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Mégse";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // TermekEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 185);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbKategoria);
            Controls.Add(lblKategoria);
            Controls.Add(nudAr);
            Controls.Add(lblAr);
            Controls.Add(tbNev);
            Controls.Add(lblNev);
            Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TermekEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Termék szerkesztése";
            ((System.ComponentModel.ISupportInitialize)nudAr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNev;
        private TextBox tbNev;
        private Label lblAr;
        private NumericUpDown nudAr;
        private Label lblKategoria;
        private ComboBox cbKategoria;
        private Button btnSave;
        private Button btnCancel;
    }
}
