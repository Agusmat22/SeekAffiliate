namespace SeekAffiliate
{
    partial class Register
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
            txbNameRegister = new TextBox();
            txbNAffiliateRegister = new TextBox();
            txbEntityRegister = new TextBox();
            txbIntRegister = new TextBox();
            txbNDniRegister = new TextBox();
            cmbTypeDu = new ComboBox();
            btnSaveRegister = new Button();
            btnCancelRegister = new Button();
            txbSurnameRegister = new TextBox();
            SuspendLayout();
            // 
            // txbNameRegister
            // 
            txbNameRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbNameRegister.Location = new Point(65, 63);
            txbNameRegister.Name = "txbNameRegister";
            txbNameRegister.PlaceholderText = "Nombre";
            txbNameRegister.Size = new Size(129, 27);
            txbNameRegister.TabIndex = 0;
            txbNameRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // txbNAffiliateRegister
            // 
            txbNAffiliateRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbNAffiliateRegister.Location = new Point(65, 144);
            txbNAffiliateRegister.Name = "txbNAffiliateRegister";
            txbNAffiliateRegister.PlaceholderText = "Nº Afiliado";
            txbNAffiliateRegister.Size = new Size(274, 27);
            txbNAffiliateRegister.TabIndex = 1;
            txbNAffiliateRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // txbEntityRegister
            // 
            txbEntityRegister.Cursor = Cursors.IBeam;
            txbEntityRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbEntityRegister.Location = new Point(451, 63);
            txbEntityRegister.Name = "txbEntityRegister";
            txbEntityRegister.PlaceholderText = "Entidad";
            txbEntityRegister.Size = new Size(274, 27);
            txbEntityRegister.TabIndex = 3;
            txbEntityRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // txbIntRegister
            // 
            txbIntRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbIntRegister.Location = new Point(451, 144);
            txbIntRegister.Name = "txbIntRegister";
            txbIntRegister.PlaceholderText = "Interno";
            txbIntRegister.Size = new Size(274, 27);
            txbIntRegister.TabIndex = 4;
            txbIntRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // txbNDniRegister
            // 
            txbNDniRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbNDniRegister.Location = new Point(451, 222);
            txbNDniRegister.Name = "txbNDniRegister";
            txbNDniRegister.PlaceholderText = "Nº Dni";
            txbNDniRegister.Size = new Size(274, 27);
            txbNDniRegister.TabIndex = 5;
            txbNDniRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbTypeDu
            // 
            cmbTypeDu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeDu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTypeDu.FormattingEnabled = true;
            cmbTypeDu.Location = new Point(65, 222);
            cmbTypeDu.Name = "cmbTypeDu";
            cmbTypeDu.RightToLeft = RightToLeft.No;
            cmbTypeDu.Size = new Size(274, 28);
            cmbTypeDu.TabIndex = 6;
            // 
            // btnSaveRegister
            // 
            btnSaveRegister.BackColor = Color.SaddleBrown;
            btnSaveRegister.Cursor = Cursors.Hand;
            btnSaveRegister.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnSaveRegister.FlatStyle = FlatStyle.Flat;
            btnSaveRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveRegister.ForeColor = Color.White;
            btnSaveRegister.Location = new Point(127, 307);
            btnSaveRegister.Name = "btnSaveRegister";
            btnSaveRegister.Size = new Size(133, 49);
            btnSaveRegister.TabIndex = 7;
            btnSaveRegister.Text = "Guardar";
            btnSaveRegister.UseVisualStyleBackColor = false;
            btnSaveRegister.Click += btnSave_Click;
            // 
            // btnCancelRegister
            // 
            btnCancelRegister.BackColor = Color.SaddleBrown;
            btnCancelRegister.Cursor = Cursors.Hand;
            btnCancelRegister.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnCancelRegister.FlatStyle = FlatStyle.Flat;
            btnCancelRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelRegister.ForeColor = Color.White;
            btnCancelRegister.Location = new Point(526, 307);
            btnCancelRegister.Name = "btnCancelRegister";
            btnCancelRegister.Size = new Size(133, 49);
            btnCancelRegister.TabIndex = 8;
            btnCancelRegister.Text = "Cancelar";
            btnCancelRegister.UseVisualStyleBackColor = false;
            btnCancelRegister.Click += btnCancelRegister_Click;
            // 
            // txbSurnameRegister
            // 
            txbSurnameRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbSurnameRegister.Location = new Point(210, 63);
            txbSurnameRegister.Name = "txbSurnameRegister";
            txbSurnameRegister.PlaceholderText = "Apellido";
            txbSurnameRegister.Size = new Size(129, 27);
            txbSurnameRegister.TabIndex = 9;
            txbSurnameRegister.TextAlign = HorizontalAlignment.Center;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(txbSurnameRegister);
            Controls.Add(btnCancelRegister);
            Controls.Add(btnSaveRegister);
            Controls.Add(cmbTypeDu);
            Controls.Add(txbNDniRegister);
            Controls.Add(txbIntRegister);
            Controls.Add(txbEntityRegister);
            Controls.Add(txbNAffiliateRegister);
            Controls.Add(txbNameRegister);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNameRegister;
        private TextBox txbNAffiliateRegister;
        private TextBox txbEntityRegister;
        private TextBox txbIntRegister;
        private TextBox txbNDniRegister;
        private ComboBox cmbTypeDu;
        private Button btnSaveRegister;
        private Button btnCancelRegister;
        private TextBox txbSurnameRegister;
    }
}