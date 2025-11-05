namespace SBP_SLN4.Forme
{
    partial class OsobaPrikaz
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
            groupBox1 = new GroupBox();
            btnPrikaziZaposlene = new Button();
            btnDodajZaposlenog = new Button();
            groupBox2 = new GroupBox();
            btnPrikaziMusterije = new Button();
            btnDodajMusteriju = new Button();
            btnPrikazImenik = new Button();
            btnPrikazi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lwPrikaz
            // 
            lwPrikaz.Location = new Point(12, 12);
            lwPrikaz.Name = "lwPrikaz";
            lwPrikaz.Size = new Size(496, 740);
            lwPrikaz.TabIndex = 0;
            lwPrikaz.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPrikazi);
            groupBox1.Controls.Add(btnPrikaziZaposlene);
            groupBox1.Controls.Add(btnDodajZaposlenog);
            groupBox1.Location = new Point(567, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zaposleni";
            // 
            // btnPrikaziZaposlene
            // 
            btnPrikaziZaposlene.Location = new Point(23, 127);
            btnPrikaziZaposlene.Name = "btnPrikaziZaposlene";
            btnPrikaziZaposlene.Size = new Size(184, 67);
            btnPrikaziZaposlene.TabIndex = 7;
            btnPrikaziZaposlene.Text = "Prikazi zaposlene";
            btnPrikaziZaposlene.UseVisualStyleBackColor = true;
            btnPrikaziZaposlene.Click += btnPrikaziZaposlene_Click;
            // 
            // btnDodajZaposlenog
            // 
            btnDodajZaposlenog.Location = new Point(23, 26);
            btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            btnDodajZaposlenog.Size = new Size(184, 67);
            btnDodajZaposlenog.TabIndex = 4;
            btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            btnDodajZaposlenog.UseVisualStyleBackColor = true;
            btnDodajZaposlenog.Click += btnDodajZaposlenog_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrikaziMusterije);
            groupBox2.Controls.Add(btnDodajMusteriju);
            groupBox2.Location = new Point(567, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 217);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Musterija";
            // 
            // btnPrikaziMusterije
            // 
            btnPrikaziMusterije.Location = new Point(23, 126);
            btnPrikaziMusterije.Name = "btnPrikaziMusterije";
            btnPrikaziMusterije.Size = new Size(184, 67);
            btnPrikaziMusterije.TabIndex = 6;
            btnPrikaziMusterije.Text = "Prikazi musterije";
            btnPrikaziMusterije.UseVisualStyleBackColor = true;
            btnPrikaziMusterije.Click += btnPrikaziMusterije_Click;
            // 
            // btnDodajMusteriju
            // 
            btnDodajMusteriju.Location = new Point(23, 26);
            btnDodajMusteriju.Name = "btnDodajMusteriju";
            btnDodajMusteriju.Size = new Size(184, 67);
            btnDodajMusteriju.TabIndex = 4;
            btnDodajMusteriju.Text = "Dodaj musteriju";
            btnDodajMusteriju.UseVisualStyleBackColor = true;
            btnDodajMusteriju.Click += btnDodajMusteriju_Click;
            // 
            // btnPrikazImenik
            // 
            btnPrikazImenik.Location = new Point(590, 671);
            btnPrikazImenik.Name = "btnPrikazImenik";
            btnPrikazImenik.Size = new Size(184, 67);
            btnPrikazImenik.TabIndex = 3;
            btnPrikazImenik.Text = "Prikazi imenik";
            btnPrikazImenik.UseVisualStyleBackColor = true;
            btnPrikazImenik.Click += btnPrikazImenik_Click;
            // 
            // btnPrikazi
            // 
            btnPrikazi.Location = new Point(23, 231);
            btnPrikazi.Name = "btnPrikazi";
            btnPrikazi.Size = new Size(184, 67);
            btnPrikazi.TabIndex = 8;
            btnPrikazi.Text = "Prikazi kategorije";
            btnPrikazi.UseVisualStyleBackColor = true;
            btnPrikazi.Click += btnPrikazi_Click;
            // 
            // OsobaPrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 764);
            Controls.Add(btnPrikazImenik);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lwPrikaz);
            Name = "OsobaPrikaz";
            Text = "Osoba prikaz";
            Load += OsobaPrikaz_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lwPrikaz;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnDodajZaposlenog;
        private Button btnPrikaziMusterije;
        private Button btnDodajMusteriju;
        private Button btnPrikazImenik;
        private Button btnPrikaziZaposlene;
        private Button btnPrikazi;
    }
}