namespace SBP_SLN4.Forme
{
    partial class UpravljaPrikaz1
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
            dgwPrikaz = new DataGridView();
            btnUnesi = new Button();
            btnIzmeni = new Button();
            ((ISupportInitialize)dgwPrikaz).BeginInit();
            SuspendLayout();
            // 
            // dgwPrikaz
            // 
            dgwPrikaz.AllowUserToAddRows = false;
            dgwPrikaz.AllowUserToDeleteRows = false;
            dgwPrikaz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPrikaz.Location = new Point(12, 12);
            dgwPrikaz.Name = "dgwPrikaz";
            dgwPrikaz.ReadOnly = true;
            dgwPrikaz.RowHeadersWidth = 51;
            dgwPrikaz.Size = new Size(555, 426);
            dgwPrikaz.TabIndex = 1;
            // 
            // btnUnesi
            // 
            btnUnesi.Location = new Point(619, 31);
            btnUnesi.Name = "btnUnesi";
            btnUnesi.Size = new Size(133, 71);
            btnUnesi.TabIndex = 7;
            btnUnesi.Text = "Unesi upravljanje";
            btnUnesi.UseVisualStyleBackColor = true;
            btnUnesi.Click += btnUnesi_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(619, 156);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(133, 77);
            btnIzmeni.TabIndex = 8;
            btnIzmeni.Text = "Izmeni upravljanje";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // UpravljaPrikaz1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIzmeni);
            Controls.Add(btnUnesi);
            Controls.Add(dgwPrikaz);
            Name = "UpravljaPrikaz1";
            Text = "Upravlja prikaz";
            Load += UpravljaPrikaz_Load;
            ((ISupportInitialize)dgwPrikaz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwPrikaz;
        private Button btnUnesi;
        private Button btnIzmeni;
    }
}