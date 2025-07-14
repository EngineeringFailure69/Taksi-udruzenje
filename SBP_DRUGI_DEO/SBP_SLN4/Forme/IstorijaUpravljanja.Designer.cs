namespace SBP_SLN4.Forme
{
    partial class IstorijaUpravljanja
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
            label1 = new Label();
            SuspendLayout();
            // 
            // lwPrikaz
            // 
            lwPrikaz.Location = new Point(12, 59);
            lwPrikaz.Name = "lwPrikaz";
            lwPrikaz.Size = new Size(444, 315);
            lwPrikaz.TabIndex = 0;
            lwPrikaz.UseCompatibleStateImageBehavior = false;
            lwPrikaz.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(444, 20);
            label1.TabIndex = 1;
            label1.Text = "Ovde mozete videti istoriju upravljanja za vozilo koje sto odabrali";
            // 
            // IstorijaUpravljanja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 386);
            Controls.Add(label1);
            Controls.Add(lwPrikaz);
            Name = "IstorijaUpravljanja";
            Text = "Istorija upravljanja";
            Load += IstorijaUpravljanja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lwPrikaz;
        private Label label1;
    }
}