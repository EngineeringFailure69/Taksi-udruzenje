namespace SBP_SLN4
{
    partial class PocetnaStranica
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
            btnVoznja = new Button();
            btnZaposleni = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVoznja
            // 
            btnVoznja.BackColor = SystemColors.ControlLightLight;
            btnVoznja.Location = new Point(246, 249);
            btnVoznja.Name = "btnVoznja";
            btnVoznja.Size = new Size(177, 63);
            btnVoznja.TabIndex = 0;
            btnVoznja.Text = "Voznja";
            btnVoznja.UseVisualStyleBackColor = false;
            btnVoznja.Click += btnVoznja_Click;
            // 
            // btnZaposleni
            // 
            btnZaposleni.Location = new Point(246, 434);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(177, 63);
            btnZaposleni.TabIndex = 1;
            btnZaposleni.Text = "Zaposleni/Musterija";
            btnZaposleni.UseVisualStyleBackColor = true;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // button4
            // 
            button4.Location = new Point(246, 343);
            button4.Name = "button4";
            button4.Size = new Size(177, 63);
            button4.TabIndex = 3;
            button4.Text = "Vozilo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(139, 167);
            label1.Name = "label1";
            label1.Size = new Size(373, 54);
            label1.TabIndex = 4;
            label1.Text = "TAKSI UDRUZENJE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.taxi;
            pictureBox1.Location = new Point(129, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 129);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // PocetnaStranica
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(681, 527);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(btnZaposleni);
            Controls.Add(btnVoznja);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "PocetnaStranica";
            Text = "POCETNA STRANICA";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoznja;
        private Button btnZaposleni;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}