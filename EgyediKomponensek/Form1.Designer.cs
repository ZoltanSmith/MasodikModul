using EgyediKomponensek.Components;

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
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            myButton1 = new MyButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            listView1 = new ListView();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // termekKartya1
            // 
            termekKartya1.Location = new Point(3, 3);
            termekKartya1.MinimumSize = new Size(173, 157);
            termekKartya1.Name = "termekKartya1";
            termekKartya1.OnKlikk = null;
            termekKartya1.Size = new Size(173, 157);
            termekKartya1.TabIndex = 0;
            termekKartya1.Termek = null;
            // 
            // osszegLabel
            // 
            osszegLabel.AutoSize = true;
            osszegLabel.Location = new Point(420, 0);
            osszegLabel.Name = "osszegLabel";
            osszegLabel.Size = new Size(38, 15);
            osszegLabel.TabIndex = 1;
            osszegLabel.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(191, 116);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(216, 3);
            button2.Name = "button2";
            button2.Size = new Size(191, 116);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(termekKartya1);
            flowLayoutPanel1.Location = new Point(9, 438);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(833, 193);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // myButton1
            // 
            myButton1.FlatStyle = FlatStyle.Flat;
            myButton1.Location = new Point(420, 104);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(75, 23);
            myButton1.TabIndex = 2;
            myButton1.Text = "myButton1";
            myButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(9, 634);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 123);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0600243F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9399757F));
            tableLayoutPanel1.Controls.Add(osszegLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(listView1, 0, 0);
            tableLayoutPanel1.Controls.Add(myButton1, 1, 1);
            tableLayoutPanel1.Location = new Point(9, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(833, 202);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Margin = new Padding(0);
            listView1.Name = "listView1";
            listView1.Size = new Size(417, 101);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(9, 220);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(833, 205);
            splitContainer1.SplitterDistance = 277;
            splitContainer1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 769);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(200, 0);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TermekKartya termekKartya1;
        private Label osszegLabel;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private ListView listView1;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private MyButton myButton1;
    }
}
