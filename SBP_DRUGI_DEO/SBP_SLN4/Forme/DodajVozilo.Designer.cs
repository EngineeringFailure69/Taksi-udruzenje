namespace SBP_SLN4.Forme
{
    partial class DodajVozilo
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
            tbMarka = new TextBox();
            label1 = new Label();
            rbUdruzenje = new RadioButton();
            btnVozilo = new Button();
            tbGodiste = new TextBox();
            tbRegistracija = new TextBox();
            tbTablice = new TextBox();
            tbBoja = new TextBox();
            tbTip = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rbLicno = new RadioButton();
            cmbVlasnikID = new ComboBox();
            SuspendLayout();
            // 
            // tbMarka
            // 
            tbMarka.Location = new Point(211, 20);
            tbMarka.Name = "tbMarka";
            tbMarka.Size = new Size(125, 27);
            tbMarka.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Marka";
            // 
            // rbUdruzenje
            // 
            rbUdruzenje.AutoSize = true;
            rbUdruzenje.Location = new Point(12, 90);
            rbUdruzenje.Name = "rbUdruzenje";
            rbUdruzenje.Size = new Size(144, 24);
            rbUdruzenje.TabIndex = 2;
            rbUdruzenje.TabStop = true;
            rbUdruzenje.Text = "Vozilo_Udruzenja";
            rbUdruzenje.UseVisualStyleBackColor = true;
            rbUdruzenje.CheckedChanged += rbUdruzenje_CheckedChanged;
            // 
            // btnVozilo
            // 
            btnVozilo.Location = new Point(12, 321);
            btnVozilo.Name = "btnVozilo";
            btnVozilo.Size = new Size(350, 29);
            btnVozilo.TabIndex = 3;
            btnVozilo.Text = "Dodaj vozilo";
            btnVozilo.UseVisualStyleBackColor = true;
            btnVozilo.Click += btnVozilo_Click;
            // 
            // tbGodiste
            // 
            tbGodiste.Location = new Point(211, 116);
            tbGodiste.Name = "tbGodiste";
            tbGodiste.Size = new Size(125, 27);
            tbGodiste.TabIndex = 4;
            // 
            // tbRegistracija
            // 
            tbRegistracija.Location = new Point(211, 157);
            tbRegistracija.Name = "tbRegistracija";
            tbRegistracija.Size = new Size(125, 27);
            tbRegistracija.TabIndex = 5;
            // 
            // tbTablice
            // 
            tbTablice.Location = new Point(211, 197);
            tbTablice.Name = "tbTablice";
            tbTablice.Size = new Size(125, 27);
            tbTablice.TabIndex = 7;
            // 
            // tbBoja
            // 
            tbBoja.Location = new Point(211, 273);
            tbBoja.Name = "tbBoja";
            tbBoja.Size = new Size(125, 27);
            tbBoja.TabIndex = 8;
            // 
            // tbTip
            // 
            tbTip.Location = new Point(211, 57);
            tbTip.Name = "tbTip";
            tbTip.Size = new Size(125, 27);
            tbTip.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 10;
            label2.Text = "Tip";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 11;
            label3.Text = "Godina proizvodnje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 12;
            label4.Text = "Datum isteka registracije";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 200);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 13;
            label5.Text = "Registarska oznaka";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 239);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 14;
            label6.Text = "VlasnikID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 276);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 15;
            label7.Text = "Boja";
            // 
            // rbLicno
            // 
            rbLicno.AutoSize = true;
            rbLicno.Location = new Point(160, 90);
            rbLicno.Name = "rbLicno";
            rbLicno.Size = new Size(112, 24);
            rbLicno.TabIndex = 16;
            rbLicno.TabStop = true;
            rbLicno.Text = "Licno_Vozilo";
            rbLicno.UseVisualStyleBackColor = true;
            rbLicno.CheckedChanged += rbLicno_CheckedChanged;
            // 
            // cmbVlasnikID
            // 
            cmbVlasnikID.FormattingEnabled = true;
            cmbVlasnikID.Location = new Point(211, 236);
            cmbVlasnikID.Name = "cmbVlasnikID";
            cmbVlasnikID.Size = new Size(151, 28);
            cmbVlasnikID.TabIndex = 28;
            // 
            // DodajVozilo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 391);
            Controls.Add(cmbVlasnikID);
            Controls.Add(rbLicno);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbTip);
            Controls.Add(tbBoja);
            Controls.Add(tbTablice);
            Controls.Add(tbRegistracija);
            Controls.Add(tbGodiste);
            Controls.Add(btnVozilo);
            Controls.Add(rbUdruzenje);
            Controls.Add(label1);
            Controls.Add(tbMarka);
            Name = "DodajVozilo";
            Text = "Dodaj vozilo";
            Load += DodajVozilo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMarka;
        private Label label1;
        private RadioButton rbUdruzenje;
        private Button btnVozilo;
        private TextBox tbGodiste;
        private TextBox tbRegistracija;
        private TextBox tbTablice;
        private TextBox tbBoja;
        private TextBox tbTip;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton rbLicno;
        private ComboBox cmbVlasnikID;
    }
}