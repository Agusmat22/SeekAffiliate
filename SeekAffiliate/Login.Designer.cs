namespace SeekAffiliate
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txbUser = new TextBox();
            txbPassword = new TextBox();
            btnJoin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txbUser
            // 
            txbUser.Cursor = Cursors.IBeam;
            txbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUser.Location = new Point(262, 155);
            txbUser.Name = "txbUser";
            txbUser.PlaceholderText = "Usuario";
            txbUser.Size = new Size(260, 29);
            txbUser.TabIndex = 0;
            txbUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txbPassword
            // 
            txbPassword.Cursor = Cursors.IBeam;
            txbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(262, 238);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.PlaceholderText = "Clave";
            txbPassword.Size = new Size(260, 29);
            txbPassword.TabIndex = 2;
            txbPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnJoin
            // 
            btnJoin.Cursor = Cursors.Hand;
            btnJoin.FlatAppearance.BorderColor = Color.Black;
            btnJoin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnJoin.Location = new Point(347, 319);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(95, 31);
            btnJoin.TabIndex = 3;
            btnJoin.Text = "Ingresar";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(222, 44);
            label1.Name = "label1";
            label1.Size = new Size(339, 65);
            label1.TabIndex = 4;
            label1.Text = "Gestion Afiliados";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnJoin);
            Controls.Add(txbPassword);
            Controls.Add(txbUser);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbUser;
        private TextBox txbPassword;
        private Button btnJoin;
        private Label label1;
    }
}