namespace SBP_SLN4.Forme
{
    partial class ZaposleniPrikaz
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
            lwPrikaz = new ListView();
            btnIzmeniZaposlenog = new Button();
            SuspendLayout();
            // 
            // lwPrikaz
            // 
            lwPrikaz.Location = new Point(12, 12);
            lwPrikaz.Name = "lwPrikaz";
            lwPrikaz.Size = new Size(776, 316);
            lwPrikaz.TabIndex = 0;
            lwPrikaz.UseCompatibleStateImageBehavior = false;
            // 
            // btnIzmeniZaposlenog
            // 
            btnIzmeniZaposlenog.Location = new Point(310, 356);
            btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            btnIzmeniZaposlenog.Size = new Size(184, 67);
            btnIzmeniZaposlenog.TabIndex = 6;
            btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            btnIzmeniZaposlenog.Click += btnIzmeniZaposlenog_Click;
            // 
            // ZaposleniPrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(btnIzmeniZaposlenog);
            Controls.Add(lwPrikaz);
            Name = "ZaposleniPrikaz";
            Text = "Zaposleni prikaz";
            Load += ZaposleniPrikaz_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lwPrikaz;
        private Button btnIzmeniZaposlenog;
    }
}