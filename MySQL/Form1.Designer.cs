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
            components = new System.ComponentModel.Container();
            Felhasznalo = new TextBox();
            label1 = new Label();
            FelhasznaloList = new ListBox();
            TermekGrid = new DataGridView();
            TetelGrid = new Zuby.ADGV.AdvancedDataGridView();
            rendelesTetelBindingSource = new BindingSource(components);
            splitContainer = new SplitContainer();
            paginationPanel = new Panel();
            actualPage = new Label();
            btnTermekLast = new Button();
            btnTermekNext = new Button();
            btnTermekPrev = new Button();
            btnTermekFirst = new Button();
            ((System.ComponentModel.ISupportInitialize)TermekGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TetelGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            paginationPanel.SuspendLayout();
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
            TermekGrid.Size = new Size(383, 478);
            TermekGrid.TabIndex = 3;
            TermekGrid.CellClick += TermekGrid_CellClick;
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
            // rendelesTetelBindingSource
            // 
            rendelesTetelBindingSource.DataSource = typeof(Model.RendelesTetel);
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(TermekGrid);
            splitContainer.Panel1.Controls.Add(paginationPanel);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(TetelGrid);
            splitContainer.Size = new Size(770, 518);
            splitContainer.SplitterDistance = 383;
            splitContainer.TabIndex = 5;
            // 
            // paginationPanel
            // 
            paginationPanel.Controls.Add(actualPage);
            paginationPanel.Controls.Add(btnTermekLast);
            paginationPanel.Controls.Add(btnTermekNext);
            paginationPanel.Controls.Add(btnTermekPrev);
            paginationPanel.Controls.Add(btnTermekFirst);
            paginationPanel.Dock = DockStyle.Bottom;
            paginationPanel.Location = new Point(0, 478);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(383, 40);
            paginationPanel.TabIndex = 5;
            // 
            // actualPage
            // 
            actualPage.Location = new Point(111, 8);
            actualPage.Name = "actualPage";
            actualPage.Size = new Size(25, 25);
            actualPage.TabIndex = 5;
            actualPage.Text = "0";
            actualPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTermekLast
            // 
            btnTermekLast.Location = new Point(194, 8);
            btnTermekLast.Name = "btnTermekLast";
            btnTermekLast.Size = new Size(50, 25);
            btnTermekLast.TabIndex = 3;
            btnTermekLast.Text = ">>";
            btnTermekLast.Click += BtnTermekLast_Click;
            // 
            // btnTermekNext
            // 
            btnTermekNext.Location = new Point(142, 8);
            btnTermekNext.Name = "btnTermekNext";
            btnTermekNext.Size = new Size(50, 25);
            btnTermekNext.TabIndex = 2;
            btnTermekNext.Text = ">";
            btnTermekNext.Click += BtnTermekNext_Click;
            // 
            // btnTermekPrev
            // 
            btnTermekPrev.Location = new Point(55, 8);
            btnTermekPrev.Name = "btnTermekPrev";
            btnTermekPrev.Size = new Size(50, 25);
            btnTermekPrev.TabIndex = 1;
            btnTermekPrev.Text = "<";
            btnTermekPrev.Click += BtnTermekPrev_Click;
            // 
            // btnTermekFirst
            // 
            btnTermekFirst.Location = new Point(3, 8);
            btnTermekFirst.Name = "btnTermekFirst";
            btnTermekFirst.Size = new Size(50, 25);
            btnTermekFirst.TabIndex = 0;
            btnTermekFirst.Text = "<<";
            btnTermekFirst.Click += BtnTermekFirst_Click;
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
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            paginationPanel.ResumeLayout(false);
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
        private Panel paginationPanel;
        private Button btnTermekFirst;
        private Button btnTermekPrev;
        private Button btnTermekNext;
        private Button btnTermekLast;
        private DataGridViewTextBoxColumn rendelesIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn termekIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private BindingSource rendelesTetelBindingSource;
        private Label actualPage;
    }
}
