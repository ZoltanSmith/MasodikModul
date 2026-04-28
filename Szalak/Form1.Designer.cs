namespace Szalak
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
            SyncPB = new ProgressBar();
            label1 = new Label();
            SyncButton = new Button();
            AsyncButton = new Button();
            label2 = new Label();
            AysncPB = new ProgressBar();
            TaskButton = new Button();
            label3 = new Label();
            TaskPB = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            SuspendLayout();
            // 
            // SyncPB
            // 
            SyncPB.Location = new Point(199, 47);
            SyncPB.Name = "SyncPB";
            SyncPB.Size = new Size(374, 23);
            SyncPB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 51);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Szinkron";
            // 
            // SyncButton
            // 
            SyncButton.Location = new Point(608, 47);
            SyncButton.Name = "SyncButton";
            SyncButton.Size = new Size(75, 23);
            SyncButton.TabIndex = 2;
            SyncButton.Text = "mehet";
            SyncButton.UseVisualStyleBackColor = true;
            SyncButton.Click += SyncButton_Click;
            // 
            // AsyncButton
            // 
            AsyncButton.Location = new Point(608, 128);
            AsyncButton.Name = "AsyncButton";
            AsyncButton.Size = new Size(75, 23);
            AsyncButton.TabIndex = 5;
            AsyncButton.Text = "mehet";
            AsyncButton.UseVisualStyleBackColor = true;
            AsyncButton.Click += AsyncButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 132);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "async/await";
            // 
            // AysncPB
            // 
            AysncPB.Location = new Point(199, 128);
            AysncPB.Name = "AysncPB";
            AysncPB.Size = new Size(374, 23);
            AysncPB.TabIndex = 3;
            // 
            // TaskButton
            // 
            TaskButton.Location = new Point(608, 207);
            TaskButton.Name = "TaskButton";
            TaskButton.Size = new Size(75, 23);
            TaskButton.TabIndex = 8;
            TaskButton.Text = "mehet";
            TaskButton.UseVisualStyleBackColor = true;
            TaskButton.Click += TaskButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 211);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "Task";
            // 
            // TaskPB
            // 
            TaskPB.Location = new Point(199, 207);
            TaskPB.Name = "TaskPB";
            TaskPB.Size = new Size(374, 23);
            TaskPB.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 281);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(TaskButton);
            Controls.Add(label3);
            Controls.Add(TaskPB);
            Controls.Add(AsyncButton);
            Controls.Add(label2);
            Controls.Add(AysncPB);
            Controls.Add(SyncButton);
            Controls.Add(label1);
            Controls.Add(SyncPB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar SyncPB;
        private Label label1;
        private Button SyncButton;
        private Button AsyncButton;
        private Label label2;
        private ProgressBar AysncPB;
        private Button TaskButton;
        private Label label3;
        private ProgressBar TaskPB;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
    }
}
