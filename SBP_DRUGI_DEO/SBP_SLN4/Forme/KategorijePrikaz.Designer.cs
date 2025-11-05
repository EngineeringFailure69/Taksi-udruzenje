namespace SBP_SLN4.Forme
{
    partial class KategorijePrikaz
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
            btnDodaj = new Button();
            btnObrisi = new Button();
            SuspendLayout();
            // 
            // lwPrikaz
            // 
            lwPrikaz.Location = new Point(12, 12);
            lwPrikaz.Name = "lwPrikaz";
            lwPrikaz.Size = new Size(277, 345);
            lwPrikaz.TabIndex = 1;
            lwPrikaz.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(345, 65);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(184, 67);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj kategoriju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(345, 244);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(184, 67);
            btnObrisi.TabIndex = 6;
            btnObrisi.Text = "Obrisi kategoriju";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // KategorijePrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 381);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(lwPrikaz);
            Name = "KategorijePrikaz";
            Text = "Kategorije prikaz";
            Load += KategorijePrikaz_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lwPrikaz;
        private Button btnDodaj;
        private Button btnObrisi;
    }
}