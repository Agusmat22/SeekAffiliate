namespace SeekAffiliate
{
    partial class AboutSystem
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
            linklbLinkedin = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // linklbLinkedin
            // 
            linklbLinkedin.AutoSize = true;
            linklbLinkedin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linklbLinkedin.LinkColor = Color.FromArgb(192, 0, 0);
            linklbLinkedin.Location = new Point(128, 276);
            linklbLinkedin.Name = "linklbLinkedin";
            linklbLinkedin.Size = new Size(364, 17);
            linklbLinkedin.TabIndex = 0;
            linklbLinkedin.TabStop = true;
            linklbLinkedin.Text = "www.linkedin.com/in/agustin-matias-garcia-navas-8b980524b";
            linklbLinkedin.LinkClicked += linklbLinkedin_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(83, 19);
            label1.Name = "label1";
            label1.Size = new Size(361, 62);
            label1.TabIndex = 6;
            label1.Text = "Acerca del Sistema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 125);
            label2.Name = "label2";
            label2.Size = new Size(283, 25);
            label2.TabIndex = 7;
            label2.Text = "Creador: Agustin Garcia Navas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 176);
            label3.Name = "label3";
            label3.Size = new Size(299, 25);
            label3.TabIndex = 8;
            label3.Text = "Fecha Actualizacion: 23/08/2023";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 270);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 9;
            label4.Text = "Linkedin:";
            // 
            // AboutSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(540, 332);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linklbLinkedin);
            Name = "AboutSystem";
            Text = "AboutSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linklbLinkedin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}