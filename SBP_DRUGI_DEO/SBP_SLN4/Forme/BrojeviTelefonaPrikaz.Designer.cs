namespace SBP_SLN4.Forme
{
    partial class BrojeviTelefonaPrikaz
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
            lwPrikaz = new ListView();
            btnObrisi = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lwPrikaz
            // 
            lwPrikaz.Location = new Point(12, 12);
            lwPrikaz.Name = "lwPrikaz";
            lwPrikaz.Size = new Size(366, 426);
            lwPrikaz.TabIndex = 0;
            lwPrikaz.UseCompatibleStateImageBehavior = false;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(428, 308);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(167, 74);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obrisi broj";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // button1
            // 
            button1.Location = new Point(428, 65);
            button1.Name = "button1";
            button1.Size = new Size(167, 74);
            button1.TabIndex = 3;
            button1.Text = "Dodaj broj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BrojeviTelefonaPrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 450);
            Controls.Add(button1);
            Controls.Add(btnObrisi);
            Controls.Add(lwPrikaz);
            Name = "BrojeviTelefonaPrikaz";
            Text = "IMENIK";
            Load += BrojeviTelefonaPrikaz_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lwPrikaz;
        private Button btnObrisi;
        private Button button1;
    }
}