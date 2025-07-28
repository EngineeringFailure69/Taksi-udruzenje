namespace SBP_SLN4.Forme
{
    partial class DodajUpravlja
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
            label1 = new Label();
            btnDodaj = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbDatumDo = new TextBox();
            tbDatumOd = new TextBox();
            cmbVoziloID = new ComboBox();
            cmbVozacID = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "VozacID";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(12, 242);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(278, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj upravlja";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Datum do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Datum od";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 79);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "VoziloID";
            // 
            // tbDatumDo
            // 
            tbDatumDo.Location = new Point(139, 174);
            tbDatumDo.Name = "tbDatumDo";
            tbDatumDo.Size = new Size(125, 27);
            tbDatumDo.TabIndex = 8;
            // 
            // tbDatumOd
            // 
            tbDatumOd.Location = new Point(139, 124);
            tbDatumOd.Name = "tbDatumOd";
            tbDatumOd.Size = new Size(125, 27);
            tbDatumOd.TabIndex = 9;
            // 
            // cmbVoziloID
            // 
            cmbVoziloID.FormattingEnabled = true;
            cmbVoziloID.Location = new Point(139, 76);
            cmbVoziloID.Name = "cmbVoziloID";
            cmbVoziloID.Size = new Size(151, 28);
            cmbVoziloID.TabIndex = 29;
            // 
            // cmbVozacID
            // 
            cmbVozacID.FormattingEnabled = true;
            cmbVozacID.Location = new Point(139, 28);
            cmbVozacID.Name = "cmbVozacID";
            cmbVozacID.Size = new Size(151, 28);
            cmbVozacID.TabIndex = 30;
            // 
            // DodajUpravlja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 310);
            Controls.Add(cmbVozacID);
            Controls.Add(cmbVoziloID);
            Controls.Add(tbDatumOd);
            Controls.Add(tbDatumDo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDodaj);
            Controls.Add(label1);
            Name = "DodajUpravlja";
            Text = "Dodaj upravlja";
            Load += DodajUpravlja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnDodaj;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbDatumDo;
        private TextBox tbDatumOd;
        private ComboBox cmbVoziloID;
        private ComboBox cmbVozacID;
    }
}