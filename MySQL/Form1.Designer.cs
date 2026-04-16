namespace MySQL
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
            Felhasznalo = new TextBox();
            label1 = new Label();
            FelhasznaloList = new ListBox();
            TermekGrid = new DataGridView();
            TetelGrid = new Zuby.ADGV.AdvancedDataGridView();
            splitContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)TermekGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TetelGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // Felhasznalo
            // 
            Felhasznalo.Enabled = false;
            Felhasznalo.ForeColor = Color.Black;
            Felhasznalo.Location = new Point(95, 6);
            Felhasznalo.Margin = new Padding(3, 4, 3, 4);
            Felhasznalo.Name = "Felhasznalo";
            Felhasznalo.Size = new Size(382, 23);
            Felhasznalo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 1;
            label1.Text = "Megrendelő:";
            // 
            // FelhasznaloList
            // 
            FelhasznaloList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FelhasznaloList.FormattingEnabled = true;
            FelhasznaloList.IntegralHeight = false;
            FelhasznaloList.ItemHeight = 18;
            FelhasznaloList.Location = new Point(483, 6);
            FelhasznaloList.Name = "FelhasznaloList";
            FelhasznaloList.Size = new Size(299, 548);
            FelhasznaloList.TabIndex = 2;
            FelhasznaloList.Visible = false;
            FelhasznaloList.DoubleClick += FelhasznaloList_DoubleClick;
            // 
            // TermekGrid
            // 
            TermekGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TermekGrid.Dock = DockStyle.Fill;
            TermekGrid.Location = new Point(0, 0);
            TermekGrid.MultiSelect = false;
            TermekGrid.Name = "TermekGrid";
            TermekGrid.ReadOnly = true;
            TermekGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TermekGrid.Size = new Size(383, 518);
            TermekGrid.TabIndex = 3;
            TermekGrid.CellDoubleClick += TermekGrid_Select;
            TermekGrid.KeyDown += TermekGrid_KeyDown;
            // 
            // TetelGrid
            // 
            TetelGrid.AllowUserToAddRows = false;
            TetelGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TetelGrid.Dock = DockStyle.Fill;
            TetelGrid.FilterAndSortEnabled = true;
            TetelGrid.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            TetelGrid.Location = new Point(0, 0);
            TetelGrid.MaxFilterButtonImageHeight = 23;
            TetelGrid.Name = "TetelGrid";
            TetelGrid.RightToLeft = RightToLeft.No;
            TetelGrid.Size = new Size(383, 518);
            TetelGrid.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            TetelGrid.TabIndex = 4;
            TetelGrid.FilterStringChanged += TetelGrid_FilterStringChanged;
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer.Location = new Point(12, 36);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(TermekGrid);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(TetelGrid);
            splitContainer.Size = new Size(770, 518);
            splitContainer.SplitterDistance = 383;
            splitContainer.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 566);
            Controls.Add(FelhasznaloList);
            Controls.Add(splitContainer);
            Controls.Add(label1);
            Controls.Add(Felhasznalo);
            Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)TermekGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TetelGrid).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Felhasznalo;
        private Label label1;
        private ListBox FelhasznaloList;
        private DataGridView TermekGrid;
        private Zuby.ADGV.AdvancedDataGridView TetelGrid;
        private SplitContainer splitContainer;
    }
}
