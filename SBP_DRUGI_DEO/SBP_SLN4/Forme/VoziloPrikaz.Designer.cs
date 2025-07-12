namespace SBP_SLN4.Forme
{
    partial class VoziloPrikaz
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
            btnDodajVozilo = new Button();
            btnIzmeniVozilo = new Button();
            lwPrikazVozila = new ListView();
            btnUpravljanja = new Button();
            groupBox1 = new GroupBox();
            btnIzabrno = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDodajVozilo
            // 
            btnDodajVozilo.Location = new Point(17, 26);
            btnDodajVozilo.Name = "btnDodajVozilo";
            btnDodajVozilo.Size = new Size(154, 59);
            btnDodajVozilo.TabIndex = 1;
            btnDodajVozilo.Text = "Dodaj vozilo ";
            btnDodajVozilo.UseVisualStyleBackColor = true;
            btnDodajVozilo.Click += btnDodajVozilo_Click;
            // 
            // btnIzmeniVozilo
            // 
            btnIzmeniVozilo.Location = new Point(17, 100);
            btnIzmeniVozilo.Name = "btnIzmeniVozilo";
            btnIzmeniVozilo.Size = new Size(154, 59);
            btnIzmeniVozilo.TabIndex = 2;
            btnIzmeniVozilo.Text = "Izmeni vozilo";
            btnIzmeniVozilo.UseVisualStyleBackColor = true;
            btnIzmeniVozilo.Click += btnIzmeniVozilo_Click;
            // 
            // lwPrikazVozila
            // 
            lwPrikazVozila.Location = new Point(12, 12);
            lwPrikazVozila.Name = "lwPrikazVozila";
            lwPrikazVozila.Size = new Size(462, 426);
            lwPrikazVozila.TabIndex = 3;
            lwPrikazVozila.UseCompatibleStateImageBehavior = false;
            lwPrikazVozila.SelectedIndexChanged += lwPrikazVozila_SelectedIndexChanged;
            // 
            // btnUpravljanja
            // 
            btnUpravljanja.Location = new Point(17, 26);
            btnUpravljanja.Name = "btnUpravljanja";
            btnUpravljanja.Size = new Size(154, 59);
            btnUpravljanja.TabIndex = 4;
            btnUpravljanja.Text = "Upravljaj vozilima";
            btnUpravljanja.UseVisualStyleBackColor = true;
            btnUpravljanja.Click += btnUpravljanja_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIzabrno);
            groupBox1.Controls.Add(btnUpravljanja);
            groupBox1.Location = new Point(508, 249);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 175);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacije o upravljanu";
            // 
            // btnIzabrno
            // 
            btnIzabrno.Location = new Point(17, 101);
            btnIzabrno.Name = "btnIzabrno";
            btnIzabrno.Size = new Size(154, 59);
            btnIzabrno.TabIndex = 5;
            btnIzabrno.Text = "Za izabrano vozilo";
            btnIzabrno.UseVisualStyleBackColor = true;
            btnIzabrno.Click += btnIzabrno_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDodajVozilo);
            groupBox2.Controls.Add(btnIzmeniVozilo);
            groupBox2.Location = new Point(508, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 174);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacije o vozilu";
            // 
            // VoziloPrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lwPrikazVozila);
            Name = "VoziloPrikaz";
            Text = "Vozilo prikaz";
            Load += VoziloPrikaz_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDodajVozilo;
        private Button btnIzmeniVozilo;
        private ListView lwPrikazVozila;
        private Button btnUpravljanja;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnIzabrno;
    }
}