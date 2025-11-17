namespace SBP_SLN4.Forme
{
    partial class MusterijePopusti
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
            label1 = new Label();
            lwPrikaz = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(739, 20);
            label1.TabIndex = 0;
            label1.Text = "Ovde mozete videti sve musterije koje su ostvarile popuste na voznju na osnovu odredjenog broja voznji (>10)";
            // 
            // lwPrikaz
            // 
            lwPrikaz.Location = new Point(12, 76);
            lwPrikaz.Name = "lwPrikaz";
            lwPrikaz.Size = new Size(739, 362);
            lwPrikaz.TabIndex = 1;
            lwPrikaz.UseCompatibleStateImageBehavior = false;
            // 
            // MusterijePopusti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 450);
            Controls.Add(lwPrikaz);
            Controls.Add(label1);
            Name = "MusterijePopusti";
            Text = "Musterije sa popustima";
            Load += MusterijePopusti_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lwPrikaz;
    }
}