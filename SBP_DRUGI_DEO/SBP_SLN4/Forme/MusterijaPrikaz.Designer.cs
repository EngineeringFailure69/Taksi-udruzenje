namespace SBP_SLN4.Forme
{
    partial class MusterijaPrikaz
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
            btnIzmeniMusteriju = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lwPrikaz
            // 
            lwPrikaz.Location = new Point(12, 12);
            lwPrikaz.Name = "lwPrikaz";
            lwPrikaz.Size = new Size(776, 328);
            lwPrikaz.TabIndex = 0;
            lwPrikaz.UseCompatibleStateImageBehavior = false;
            // 
            // btnIzmeniMusteriju
            // 
            btnIzmeniMusteriju.Location = new Point(80, 371);
            btnIzmeniMusteriju.Name = "btnIzmeniMusteriju";
            btnIzmeniMusteriju.Size = new Size(184, 67);
            btnIzmeniMusteriju.TabIndex = 6;
            btnIzmeniMusteriju.Text = "Izmeni musteriju";
            btnIzmeniMusteriju.UseVisualStyleBackColor = true;
            btnIzmeniMusteriju.Click += btnIzmeniMusteriju_Click;
            // 
            // button1
            // 
            button1.Location = new Point(531, 371);
            button1.Name = "button1";
            button1.Size = new Size(184, 67);
            button1.TabIndex = 7;
            button1.Text = "Prikazi musterije sa popustima";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MusterijaPrikaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnIzmeniMusteriju);
            Controls.Add(lwPrikaz);
            Name = "MusterijaPrikaz";
            Text = "Musterija prikaz";
            Load += MusterijaPrikaz_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lwPrikaz;
        private Button btnIzmeniMusteriju;
        private Button button1;
    }
}