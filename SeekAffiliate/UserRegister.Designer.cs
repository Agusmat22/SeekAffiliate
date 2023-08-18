namespace SeekAffiliate
{
    partial class UserRegister
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
            txbUser = new TextBox();
            txbPass = new TextBox();
            txbPassAgain = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            cmbTypeUser = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txbUser
            // 
            txbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUser.Location = new Point(78, 127);
            txbUser.Name = "txbUser";
            txbUser.PlaceholderText = "Nuevo usuario";
            txbUser.Size = new Size(148, 29);
            txbUser.TabIndex = 0;
            txbUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPass
            // 
            txbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPass.Location = new Point(82, 235);
            txbPass.Name = "txbPass";
            txbPass.PlaceholderText = "Nueva Contraseña";
            txbPass.Size = new Size(294, 29);
            txbPass.TabIndex = 1;
            txbPass.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPassAgain
            // 
            txbPassAgain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassAgain.Location = new Point(82, 283);
            txbPassAgain.Name = "txbPassAgain";
            txbPassAgain.PlaceholderText = "Ingresar Nuevamente";
            txbPassAgain.Size = new Size(294, 29);
            txbPassAgain.TabIndex = 2;
            txbPassAgain.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(115, 79);
            label2.Name = "label2";
            label2.Size = new Size(87, 33);
            label2.TabIndex = 6;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Sienna;
            label3.Location = new Point(170, 185);
            label3.Name = "label3";
            label3.Size = new Size(124, 33);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SaddleBrown;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(46, 358);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(87, 40);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SaddleBrown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(345, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbTypeUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txbUser);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(txbPass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbPassAgain);
            groupBox1.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.SaddleBrown;
            groupBox1.Location = new Point(157, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 410);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(277, 79);
            label1.Name = "label1";
            label1.Size = new Size(56, 33);
            label1.TabIndex = 11;
            label1.Text = "Tipo";
            // 
            // cmbTypeUser
            // 
            cmbTypeUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTypeUser.FormattingEnabled = true;
            cmbTypeUser.Location = new Point(232, 127);
            cmbTypeUser.Name = "cmbTypeUser";
            cmbTypeUser.Size = new Size(144, 29);
            cmbTypeUser.TabIndex = 10;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "UserRegister";
            Text = "UserRegister";
            Load += UserRegister_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbUser;
        private TextBox txbPass;
        private TextBox txbPassAgain;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbTypeUser;
    }
}