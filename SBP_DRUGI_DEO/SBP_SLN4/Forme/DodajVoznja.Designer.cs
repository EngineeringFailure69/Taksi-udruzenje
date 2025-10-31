namespace SBP_SLN4.Forme
{
    partial class DodajVoznja
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
            tbPocetnaStanica = new TextBox();
            tbKrajnjaStanica = new TextBox();
            tbVremeJavljanja = new TextBox();
            tbVremePocetka = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnDodaj = new Button();
            cmbIdAdmin = new ComboBox();
            cmbIdVozac = new ComboBox();
            tbVremeKraja = new TextBox();
            cmbIdMusterija = new ComboBox();
            cmbBrTelMusterije = new ComboBox();
            cmbBrTelAdmin = new ComboBox();
            SuspendLayout();
            // 
            // tbPocetnaStanica
            // 
            tbPocetnaStanica.Location = new Point(165, 73);
            tbPocetnaStanica.Name = "tbPocetnaStanica";
            tbPocetnaStanica.Size = new Size(125, 27);
            tbPocetnaStanica.TabIndex = 2;
            // 
            // tbKrajnjaStanica
            // 
            tbKrajnjaStanica.Location = new Point(165, 127);
            tbKrajnjaStanica.Name = "tbKrajnjaStanica";
            tbKrajnjaStanica.Size = new Size(125, 27);
            tbKrajnjaStanica.TabIndex = 3;
            // 
            // tbVremeJavljanja
            // 
            tbVremeJavljanja.Location = new Point(576, 22);
            tbVremeJavljanja.Name = "tbVremeJavljanja";
            tbVremeJavljanja.Size = new Size(125, 27);
            tbVremeJavljanja.TabIndex = 6;
            // 
            // tbVremePocetka
            // 
            tbVremePocetka.Location = new Point(576, 187);
            tbVremePocetka.Name = "tbVremePocetka";
            tbVremePocetka.Size = new Size(125, 27);
            tbVremePocetka.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 253);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 13;
            label2.Text = "Vreme kraja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 190);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 14;
            label3.Text = "Vreme pocetka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 76);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 15;
            label4.Text = "Br. tel. primljenog poziva";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 25);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 16;
            label5.Text = "Vreme javljanja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 130);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 17;
            label6.Text = "VozacID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 253);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 18;
            label7.Text = "AdministratorID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 190);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 19;
            label8.Text = "Br. tel. narucivanja";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 130);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 20;
            label9.Text = "Krajnja stanica";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 76);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 21;
            label10.Text = "Pocetna stanica";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 25);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 22;
            label11.Text = "MusterijaID";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(242, 350);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(324, 70);
            btnDodaj.TabIndex = 23;
            btnDodaj.Text = "Dodaj voznju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbIdAdmin
            // 
            cmbIdAdmin.FormattingEnabled = true;
            cmbIdAdmin.Location = new Point(165, 250);
            cmbIdAdmin.Name = "cmbIdAdmin";
            cmbIdAdmin.Size = new Size(151, 28);
            cmbIdAdmin.TabIndex = 24;
            cmbIdAdmin.SelectedIndexChanged += cmbIdAdmin_SelectedIndexChanged;
            // 
            // cmbIdVozac
            // 
            cmbIdVozac.FormattingEnabled = true;
            cmbIdVozac.Location = new Point(576, 127);
            cmbIdVozac.Name = "cmbIdVozac";
            cmbIdVozac.Size = new Size(151, 28);
            cmbIdVozac.TabIndex = 25;
            // 
            // tbVremeKraja
            // 
            tbVremeKraja.Location = new Point(576, 250);
            tbVremeKraja.Name = "tbVremeKraja";
            tbVremeKraja.Size = new Size(125, 27);
            tbVremeKraja.TabIndex = 9;
            // 
            // cmbIdMusterija
            // 
            cmbIdMusterija.FormattingEnabled = true;
            cmbIdMusterija.Location = new Point(165, 22);
            cmbIdMusterija.Name = "cmbIdMusterija";
            cmbIdMusterija.Size = new Size(151, 28);
            cmbIdMusterija.TabIndex = 26;
            cmbIdMusterija.SelectedIndexChanged += cmbIdMusterija_SelectedIndexChanged;
            // 
            // cmbBrTelMusterije
            // 
            cmbBrTelMusterije.FormattingEnabled = true;
            cmbBrTelMusterije.Location = new Point(165, 187);
            cmbBrTelMusterije.Name = "cmbBrTelMusterije";
            cmbBrTelMusterije.Size = new Size(151, 28);
            cmbBrTelMusterije.TabIndex = 27;
            // 
            // cmbBrTelAdmin
            // 
            cmbBrTelAdmin.FormattingEnabled = true;
            cmbBrTelAdmin.Location = new Point(576, 73);
            cmbBrTelAdmin.Name = "cmbBrTelAdmin";
            cmbBrTelAdmin.Size = new Size(151, 28);
            cmbBrTelAdmin.TabIndex = 28;
            // 
            // DodajVoznja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBrTelAdmin);
            Controls.Add(cmbBrTelMusterije);
            Controls.Add(cmbIdMusterija);
            Controls.Add(cmbIdVozac);
            Controls.Add(cmbIdAdmin);
            Controls.Add(btnDodaj);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbVremePocetka);
            Controls.Add(tbVremeKraja);
            Controls.Add(tbVremeJavljanja);
            Controls.Add(tbKrajnjaStanica);
            Controls.Add(tbPocetnaStanica);
            Name = "DodajVoznja";
            Text = "Dodaj voznju";
            Load += DodajVoznja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbPocetnaStanica;
        private TextBox tbKrajnjaStanica;
        private TextBox tbVremeJavljanja;
        private TextBox tbVremePocetka;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnDodaj;
        private ComboBox cmbIdAdmin;
        private ComboBox cmbIdVozac;
        private TextBox tbVremeKraja;
        private ComboBox cmbIdMusterija;
        private ComboBox cmbBrTelMusterije;
        private ComboBox cmbBrTelAdmin;
    }
}