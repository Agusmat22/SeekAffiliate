namespace SeekAffiliate
{
    partial class Seeker
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
            txbSeeked = new TextBox();
            btnSearch = new Button();
            btnCancelSearch = new Button();
            label1 = new Label();
            rdbName = new RadioButton();
            rdbDni = new RadioButton();
            rdbNumber = new RadioButton();
            rtb_affiliate = new RichTextBox();
            SuspendLayout();
            // 
            // txbSeeked
            // 
            txbSeeked.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbSeeked.Location = new Point(463, 174);
            txbSeeked.Name = "txbSeeked";
            txbSeeked.PlaceholderText = "Ingrese el dato";
            txbSeeked.Size = new Size(242, 27);
            txbSeeked.TabIndex = 1;
            txbSeeked.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(463, 300);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancelSearch
            // 
            btnCancelSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelSearch.Location = new Point(616, 300);
            btnCancelSearch.Name = "btnCancelSearch";
            btnCancelSearch.Size = new Size(89, 31);
            btnCancelSearch.TabIndex = 5;
            btnCancelSearch.Text = "Salir";
            btnCancelSearch.UseVisualStyleBackColor = true;
            btnCancelSearch.Click += btnCancelSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(454, 22);
            label1.Name = "label1";
            label1.Size = new Size(261, 57);
            label1.TabIndex = 6;
            label1.Text = "Buscar afiliado";
            // 
            // rdbName
            // 
            rdbName.AutoSize = true;
            rdbName.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbName.Location = new Point(463, 108);
            rdbName.Name = "rdbName";
            rdbName.Size = new Size(68, 17);
            rdbName.TabIndex = 7;
            rdbName.TabStop = true;
            rdbName.Text = "Nombre";
            rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbDni
            // 
            rdbDni.AutoSize = true;
            rdbDni.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbDni.Location = new Point(557, 108);
            rdbDni.Name = "rdbDni";
            rdbDni.Size = new Size(43, 17);
            rdbDni.TabIndex = 8;
            rdbDni.TabStop = true;
            rdbDni.Text = "Dni";
            rdbDni.UseVisualStyleBackColor = true;
            // 
            // rdbNumber
            // 
            rdbNumber.AutoSize = true;
            rdbNumber.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbNumber.Location = new Point(624, 108);
            rdbNumber.Name = "rdbNumber";
            rdbNumber.Size = new Size(83, 17);
            rdbNumber.TabIndex = 9;
            rdbNumber.TabStop = true;
            rdbNumber.Text = "N* Afiliado";
            rdbNumber.UseVisualStyleBackColor = true;
            // 
            // rtb_affiliate
            // 
            rtb_affiliate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rtb_affiliate.Location = new Point(29, 22);
            rtb_affiliate.Name = "rtb_affiliate";
            rtb_affiliate.ReadOnly = true;
            rtb_affiliate.Size = new Size(346, 404);
            rtb_affiliate.TabIndex = 10;
            rtb_affiliate.Text = "";
            // 
            // Seeker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_affiliate);
            Controls.Add(rdbNumber);
            Controls.Add(rdbDni);
            Controls.Add(rdbName);
            Controls.Add(label1);
            Controls.Add(btnCancelSearch);
            Controls.Add(btnSearch);
            Controls.Add(txbSeeked);
            Name = "Seeker";
            Text = "Seeker";
            Load += Seeker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbSeeked;
        private Button btnSearch;
        private Button btnCancelSearch;
        private Label label1;
        private RadioButton rdbName;
        private RadioButton rdbDni;
        private RadioButton rdbNumber;
        private RichTextBox rtb_affiliate;
    }
}