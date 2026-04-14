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
            dataGridView1 = new DataGridView();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            splitContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // Felhasznalo
            // 
            Felhasznalo.Enabled = false;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(383, 518);
            dataGridView1.TabIndex = 3;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Dock = DockStyle.Fill;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(0, 0);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.Size = new Size(383, 518);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 4;
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer.Location = new Point(12, 36);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(advancedDataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private SplitContainer splitContainer;
    }
}
