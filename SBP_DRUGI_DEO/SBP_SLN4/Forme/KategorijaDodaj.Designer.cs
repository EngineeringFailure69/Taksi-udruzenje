namespace SBP_SLN4.Forme
{
    partial class KategorijaDodaj
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
            cmbIdVozaca = new ComboBox();
            tbKategorija = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // cmbIdVozaca
            // 
            cmbIdVozaca.FormattingEnabled = true;
            cmbIdVozaca.Location = new Point(81, 31);
            cmbIdVozaca.Name = "cmbIdVozaca";
            cmbIdVozaca.Size = new Size(151, 28);
            cmbIdVozaca.TabIndex = 1;
            // 
            // tbKategorija
            // 
            tbKategorija.Location = new Point(375, 31);
            tbKategorija.Name = "tbKategorija";
            tbKategorija.Size = new Size(125, 27);
            tbKategorija.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 34);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "Kategorija";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "VozacID";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(178, 109);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(149, 58);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj kategoriju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // KategorijaDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 185);
            Controls.Add(btnDodaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbKategorija);
            Controls.Add(cmbIdVozaca);
            Name = "KategorijaDodaj";
            Text = "KategorijaDodaj";
            Load += KategorijaDodaj_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIdVozaca;
        private TextBox tbKategorija;
        private Label label1;
        private Label label2;
        private Button btnDodaj;
    }
}