namespace Idojaras
{
    partial class IdojarasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdojarasForm));
            CityText = new TextBox();
            WeatherText = new Label();
            WeatherImg = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)WeatherImg).BeginInit();
            SuspendLayout();
            // 
            // CityText
            // 
            CityText.Font = new Font("Segoe UI", 19F);
            CityText.Location = new Point(145, 12);
            CityText.Name = "CityText";
            CityText.Size = new Size(443, 41);
            CityText.TabIndex = 0;
            CityText.KeyDown += CityText_KeyDown;
            // 
            // WeatherText
            // 
            WeatherText.Font = new Font("Roboto", 23F);
            WeatherText.Location = new Point(58, 76);
            WeatherText.Name = "WeatherText";
            WeatherText.Size = new Size(305, 331);
            WeatherText.TabIndex = 1;
            WeatherText.Text = "Mai időjárás:\r\n21 °C";
            // 
            // WeatherImg
            // 
            WeatherImg.Location = new Point(398, 144);
            WeatherImg.Name = "WeatherImg";
            WeatherImg.Size = new Size(190, 190);
            WeatherImg.SizeMode = PictureBoxSizeMode.Zoom;
            WeatherImg.TabIndex = 2;
            WeatherImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 3;
            label1.Text = "Település:";
            // 
            // IdojarasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(label1);
            Controls.Add(WeatherImg);
            Controls.Add(WeatherText);
            Controls.Add(CityText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IdojarasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Aktuális időjárás";
            ((System.ComponentModel.ISupportInitialize)WeatherImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CityText;
        private Label WeatherText;
        private PictureBox WeatherImg;
        private Label label1;
    }
}
