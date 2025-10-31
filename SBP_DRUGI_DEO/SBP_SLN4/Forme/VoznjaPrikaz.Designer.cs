namespace SBP_SLN4.Forme
{
    partial class VoznjaPrikaz
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
            lwVoznjaPrikaz = new ListView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            SuspendLayout();
            // 
            // lwVoznjaPrikaz
            // 
            lwVoznjaPrikaz.Location = new Point(12, 12);
            lwVoznjaPrikaz.Name = "lwVoznjaPrikaz";
            lwVoznjaPrikaz.Size = new Size(533, 426);
            lwVoznjaPrikaz.TabIndex = 0;
            lwVoznjaPrikaz.UseCompatibleStateImageBehavior = false;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(610, 50);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(118, 73);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj voznju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(610, 173);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(118, 73);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni voznju";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(610, 304);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(118, 71);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi voznju";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // VoznjaPrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(lwVoznjaPrikaz);
            Name = "VoznjaPrikaz";
            Text = "Voznja prikaz";
            Load += VoznjaPrikazcs_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lwVoznjaPrikaz;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
    }
}