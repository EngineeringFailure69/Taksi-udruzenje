namespace SBP_SLN4.Forme
{
    partial class IzmeniVozilo
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
            btnIzmeni = new Button();
            tbMarka = new TextBox();
            label1 = new Label();
            tbDatIstekaReg = new TextBox();
            tbGodinaProizvodnje = new TextBox();
            tbTip = new TextBox();
            tbBoja = new TextBox();
            tbRegistarskaOznaka = new TextBox();
            tbTipVozila = new TextBox();
            tbVlasnikId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(12, 383);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(308, 29);
            btnIzmeni.TabIndex = 0;
            btnIzmeni.Text = "Izmeni vozilo";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // tbMarka
            // 
            tbMarka.Location = new Point(195, 22);
            tbMarka.Name = "tbMarka";
            tbMarka.Size = new Size(125, 27);
            tbMarka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Marka";
            // 
            // tbDatIstekaReg
            // 
            tbDatIstekaReg.Location = new Point(195, 186);
            tbDatIstekaReg.Name = "tbDatIstekaReg";
            tbDatIstekaReg.Size = new Size(125, 27);
            tbDatIstekaReg.TabIndex = 3;
            // 
            // tbGodinaProizvodnje
            // 
            tbGodinaProizvodnje.Location = new Point(195, 143);
            tbGodinaProizvodnje.Name = "tbGodinaProizvodnje";
            tbGodinaProizvodnje.Size = new Size(125, 27);
            tbGodinaProizvodnje.TabIndex = 4;
            // 
            // tbTip
            // 
            tbTip.Location = new Point(195, 64);
            tbTip.Name = "tbTip";
            tbTip.Size = new Size(125, 27);
            tbTip.TabIndex = 5;
            // 
            // tbBoja
            // 
            tbBoja.Location = new Point(195, 320);
            tbBoja.Name = "tbBoja";
            tbBoja.Size = new Size(125, 27);
            tbBoja.TabIndex = 6;
            // 
            // tbRegistarskaOznaka
            // 
            tbRegistarskaOznaka.Location = new Point(195, 233);
            tbRegistarskaOznaka.Name = "tbRegistarskaOznaka";
            tbRegistarskaOznaka.Size = new Size(125, 27);
            tbRegistarskaOznaka.TabIndex = 7;
            // 
            // tbTipVozila
            // 
            tbTipVozila.Location = new Point(195, 104);
            tbTipVozila.Name = "tbTipVozila";
            tbTipVozila.Size = new Size(125, 27);
            tbTipVozila.TabIndex = 8;
            tbTipVozila.TextChanged += tbTipVozila_TextChanged;
            tbTipVozila.Leave += tbTipVozila_Leave;
            // 
            // tbVlasnikId
            // 
            tbVlasnikId.Location = new Point(195, 276);
            tbVlasnikId.Name = "tbVlasnikId";
            tbVlasnikId.Size = new Size(125, 27);
            tbVlasnikId.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 10;
            label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 11;
            label3.Text = "Tip vozila";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 67);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 12;
            label4.Text = "Tip";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 236);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 13;
            label5.Text = "Registarska oznaka";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 189);
            label6.Name = "label6";
            label6.Size = new Size(173, 20);
            label6.TabIndex = 14;
            label6.Text = "Datum isteka registracije";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 323);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 15;
            label7.Text = "Boja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 279);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 16;
            label8.Text = "VlasnikID";
            // 
            // IzmeniVozilo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbVlasnikId);
            Controls.Add(tbTipVozila);
            Controls.Add(tbRegistarskaOznaka);
            Controls.Add(tbBoja);
            Controls.Add(tbTip);
            Controls.Add(tbGodinaProizvodnje);
            Controls.Add(tbDatIstekaReg);
            Controls.Add(label1);
            Controls.Add(tbMarka);
            Controls.Add(btnIzmeni);
            Name = "IzmeniVozilo";
            Text = "Izmeni vozilo";
            Load += IzmeniVozilo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIzmeni;
        private TextBox tbMarka;
        private Label label1;
        private TextBox tbDatIstekaReg;
        private TextBox tbGodinaProizvodnje;
        private TextBox tbTip;
        private TextBox tbBoja;
        private TextBox tbRegistarskaOznaka;
        private TextBox tbTipVozila;
        private TextBox tbVlasnikId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}