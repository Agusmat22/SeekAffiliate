namespace SeekAffiliate
{
    partial class Statistics
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
            lbTotal = new Label();
            label2 = new Label();
            lbDoctored = new Label();
            lbRas = new Label();
            lbOsdic = new Label();
            lbRedArgentina = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(264, 24);
            label1.Name = "label1";
            label1.Size = new Size(244, 65);
            label1.TabIndex = 0;
            label1.Text = "Estadisticas";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(18, 17);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(45, 21);
            lbTotal.TabIndex = 2;
            lbTotal.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 116);
            label2.Name = "label2";
            label2.Size = new Size(214, 30);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de afiliados";
            // 
            // lbDoctored
            // 
            lbDoctored.AutoSize = true;
            lbDoctored.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDoctored.Location = new Point(18, 57);
            lbDoctored.Name = "lbDoctored";
            lbDoctored.Size = new Size(77, 21);
            lbDoctored.TabIndex = 4;
            lbDoctored.Text = "Doctored:";
            // 
            // lbRas
            // 
            lbRas.AutoSize = true;
            lbRas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRas.Location = new Point(18, 97);
            lbRas.Name = "lbRas";
            lbRas.Size = new Size(47, 21);
            lbRas.TabIndex = 5;
            lbRas.Text = "Ras2:";
            // 
            // lbOsdic
            // 
            lbOsdic.AutoSize = true;
            lbOsdic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbOsdic.Location = new Point(18, 142);
            lbOsdic.Name = "lbOsdic";
            lbOsdic.Size = new Size(52, 21);
            lbOsdic.TabIndex = 6;
            lbOsdic.Text = "Osdic:";
            // 
            // lbRedArgentina
            // 
            lbRedArgentina.AutoSize = true;
            lbRedArgentina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRedArgentina.Location = new Point(18, 186);
            lbRedArgentina.Name = "lbRedArgentina";
            lbRedArgentina.Size = new Size(112, 21);
            lbRedArgentina.TabIndex = 7;
            lbRedArgentina.Text = "Red Argentina:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(lbOsdic);
            panel1.Controls.Add(lbRedArgentina);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(lbDoctored);
            panel1.Controls.Add(lbRas);
            panel1.Location = new Point(22, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 277);
            panel1.TabIndex = 8;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Statistics";
            Text = "Statistics";
            Load += Statistics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbTotal;
        private Label label2;
        private Label lbDoctored;
        private Label lbRas;
        private Label lbOsdic;
        private Label lbRedArgentina;
        private Panel panel1;
    }
}