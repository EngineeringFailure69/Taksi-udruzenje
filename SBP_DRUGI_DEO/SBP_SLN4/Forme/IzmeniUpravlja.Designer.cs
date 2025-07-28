namespace SBP_SLN4.Forme
{
    partial class IzmeniUpravlja
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
            tbVozacID = new TextBox();
            tbDatumOd = new TextBox();
            tbDatumDo = new TextBox();
            tbVoziloID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnIzmeni = new Button();
            SuspendLayout();
            // 
            // tbVozacID
            // 
            tbVozacID.Location = new Point(141, 31);
            tbVozacID.Name = "tbVozacID";
            tbVozacID.Size = new Size(125, 27);
            tbVozacID.TabIndex = 2;
            // 
            // tbDatumOd
            // 
            tbDatumOd.Location = new Point(141, 131);
            tbDatumOd.Name = "tbDatumOd";
            tbDatumOd.Size = new Size(125, 27);
            tbDatumOd.TabIndex = 3;
            // 
            // tbDatumDo
            // 
            tbDatumDo.Location = new Point(141, 182);
            tbDatumDo.Name = "tbDatumDo";
            tbDatumDo.Size = new Size(125, 27);
            tbDatumDo.TabIndex = 4;
            // 
            // tbVoziloID
            // 
            tbVoziloID.Location = new Point(141, 79);
            tbVoziloID.Name = "tbVoziloID";
            tbVoziloID.Size = new Size(125, 27);
            tbVoziloID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 185);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Datum do";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Datum od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 8;
            label3.Text = "VoziloID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 34);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 9;
            label4.Text = "VozacID";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(12, 247);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(252, 29);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni upravlja";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // IzmeniUpravlja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 309);
            Controls.Add(btnIzmeni);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbVoziloID);
            Controls.Add(tbDatumDo);
            Controls.Add(tbDatumOd);
            Controls.Add(tbVozacID);
            Name = "IzmeniUpravlja";
            Text = "Izmeni upravlja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbVozacID;
        private TextBox tbDatumOd;
        private TextBox tbDatumDo;
        private TextBox tbVoziloID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnIzmeni;
    }
}