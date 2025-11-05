namespace SBP_SLN4.Forme
{
    partial class DodajBrojTelefona
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
            cmbIdOsobe = new ComboBox();
            tbBroj = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // cmbIdOsobe
            // 
            cmbIdOsobe.FormattingEnabled = true;
            cmbIdOsobe.Location = new Point(104, 12);
            cmbIdOsobe.Name = "cmbIdOsobe";
            cmbIdOsobe.Size = new Size(151, 28);
            cmbIdOsobe.TabIndex = 0;
            cmbIdOsobe.SelectedIndexChanged += cmbIdOsobe_SelectedIndexChanged;
            // 
            // tbBroj
            // 
            tbBroj.Location = new Point(424, 12);
            tbBroj.Name = "tbBroj";
            tbBroj.Size = new Size(125, 27);
            tbBroj.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "OsobaID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 15);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Broj telefona";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(212, 99);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(149, 58);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj broj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // DodajBrojTelefona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 169);
            Controls.Add(btnDodaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbBroj);
            Controls.Add(cmbIdOsobe);
            Name = "DodajBrojTelefona";
            Text = "Dodaj broj telefona";
            Load += DodajBrojTelefona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIdOsobe;
        private TextBox tbBroj;
        private Label label1;
        private Label label2;
        private Button btnDodaj;
    }
}