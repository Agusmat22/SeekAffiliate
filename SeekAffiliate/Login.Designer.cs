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
            txbUser = new TextBox();
            txbPassword = new TextBox();
            btnJoin = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // txbUser
            // 
            txbUser.BackColor = Color.White;
            txbUser.BorderStyle = BorderStyle.None;
            txbUser.Cursor = Cursors.IBeam;
            txbUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbUser.ForeColor = Color.Black;
            txbUser.Location = new Point(265, 132);
            txbUser.Multiline = true;
            txbUser.Name = "txbUser";
            txbUser.PlaceholderText = "Usuario";
            txbUser.Size = new Size(250, 35);
            txbUser.TabIndex = 0;
            txbUser.TextAlign = HorizontalAlignment.Center;
            txbUser.WordWrap = false;
            // 
            // txbPassword
            // 
            txbPassword.BorderStyle = BorderStyle.None;
            txbPassword.Cursor = Cursors.IBeam;
            txbPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(265, 230);
            txbPassword.Multiline = true;
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.PlaceholderText = "Clave";
            txbPassword.Size = new Size(250, 35);
            txbPassword.TabIndex = 2;
            txbPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.SaddleBrown;
            btnJoin.Cursor = Cursors.Hand;
            btnJoin.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnJoin.FlatAppearance.BorderSize = 3;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnJoin.ForeColor = Color.White;
            btnJoin.Location = new Point(342, 350);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(106, 43);
            btnJoin.TabIndex = 3;
            btnJoin.Text = "Ingresar";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 71);
            label1.TabIndex = 4;
            label1.Text = "Gestion Afiliados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(262, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 5);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Location = new Point(267, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 5);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SaddleBrown;
            panel3.Location = new Point(262, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 40);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SaddleBrown;
            panel4.Location = new Point(512, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 40);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SaddleBrown;
            panel5.Location = new Point(262, 227);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 40);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SaddleBrown;
            panel6.Location = new Point(247, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 62);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SaddleBrown;
            panel7.Controls.Add(panel6);
            panel7.Location = new Point(265, 227);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 5);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SaddleBrown;
            panel8.Location = new Point(267, 262);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 5);
            panel8.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.BackColor = Color.SaddleBrown;
            panel9.Location = new Point(512, 227);
            panel9.Name = "panel9";
            panel9.Size = new Size(5, 40);
            panel9.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnJoin);
            Controls.Add(txbPassword);
            Controls.Add(txbUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbUser;
        private TextBox txbPassword;
        private Button btnJoin;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
    }
}