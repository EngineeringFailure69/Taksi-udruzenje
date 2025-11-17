namespace SBP_SLN4.Forme
{
    partial class IzmeniMusteriju
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
            groupBox2 = new GroupBox();
            tbBrVoznji = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            label1 = new Label();
            label3 = new Label();
            tbUlica = new TextBox();
            tbBroj = new TextBox();
            tbTipOsobe = new TextBox();
            btnIzmeni = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbBrVoznji);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(427, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 93);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacije o musteriji";
            // 
            // tbBrVoznji
            // 
            tbBrVoznji.Location = new Point(180, 34);
            tbBrVoznji.Name = "tbBrVoznji";
            tbBrVoznji.Size = new Size(125, 27);
            tbBrVoznji.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 37);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 5;
            label4.Text = "Broj koriscenih voznji";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbUlica);
            groupBox1.Controls.Add(tbBroj);
            groupBox1.Controls.Add(tbTipOsobe);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 174);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacije o osobi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 117);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 14;
            label11.Text = "Tip osobe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Ulica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Broj";
            // 
            // tbUlica
            // 
            tbUlica.Location = new Point(125, 27);
            tbUlica.Name = "tbUlica";
            tbUlica.Size = new Size(125, 27);
            tbUlica.TabIndex = 1;
            // 
            // tbBroj
            // 
            tbBroj.Location = new Point(125, 70);
            tbBroj.Name = "tbBroj";
            tbBroj.Size = new Size(125, 27);
            tbBroj.TabIndex = 15;
            // 
            // tbTipOsobe
            // 
            tbTipOsobe.Location = new Point(125, 114);
            tbTipOsobe.Name = "tbTipOsobe";
            tbTipOsobe.Size = new Size(125, 27);
            tbTipOsobe.TabIndex = 16;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(495, 134);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(173, 52);
            btnIzmeni.TabIndex = 19;
            btnIzmeni.Text = "Izmeni musteriju";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // IzmeniMusteriju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 236);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnIzmeni);
            Name = "IzmeniMusteriju";
            Text = "Izmeni musteriju";
            Load += IzmeniMusteriju_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox tbBrVoznji;
        private Label label4;
        private GroupBox groupBox1;
        private Label label11;
        private Label label1;
        private Label label3;
        private TextBox tbUlica;
        private TextBox tbBroj;
        private TextBox tbTipOsobe;
        private Button btnIzmeni;
    }
}