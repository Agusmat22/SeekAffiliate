namespace SeekAffiliate
{
    partial class CompanyRegister
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
            groupBox1 = new GroupBox();
            lb = new Label();
            txbPosSurname = new TextBox();
            label8 = new Label();
            label2 = new Label();
            txbPosDu = new TextBox();
            label3 = new Label();
            txbPosTypeDu = new TextBox();
            label4 = new Label();
            txbPosIntern = new TextBox();
            label6 = new Label();
            txbPosNumber = new TextBox();
            label5 = new Label();
            txbPosEntity = new TextBox();
            txbPosName = new TextBox();
            button3 = new Button();
            button1 = new Button();
            txbCompanyName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(385, 62);
            label1.TabIndex = 8;
            label1.Text = "Registro de empresa";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cornsilk;
            groupBox1.Controls.Add(lb);
            groupBox1.Controls.Add(txbPosSurname);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbPosDu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbPosTypeDu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txbPosIntern);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txbPosNumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txbPosEntity);
            groupBox1.Controls.Add(txbPosName);
            groupBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Sienna;
            groupBox1.Location = new Point(114, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 192);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Posicion Columna";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lb.ForeColor = Color.Black;
            lb.Location = new Point(51, 36);
            lb.Name = "lb";
            lb.Size = new Size(73, 21);
            lb.TabIndex = 17;
            lb.Text = "NOMBRE";
            // 
            // txbPosSurname
            // 
            txbPosSurname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosSurname.Location = new Point(183, 75);
            txbPosSurname.Name = "txbPosSurname";
            txbPosSurname.Size = new Size(27, 25);
            txbPosSurname.TabIndex = 24;
            txbPosSurname.KeyPress += txbPosSurname_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(51, 76);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 25;
            label8.Text = "APELLIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(323, 40);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 18;
            label2.Text = "ENTIDAD";
            // 
            // txbPosDu
            // 
            txbPosDu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosDu.Location = new Point(455, 123);
            txbPosDu.Name = "txbPosDu";
            txbPosDu.Size = new Size(27, 25);
            txbPosDu.TabIndex = 16;
            txbPosDu.KeyPress += txbPosDu_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(323, 81);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 19;
            label3.Text = "NUMERO AF";
            // 
            // txbPosTypeDu
            // 
            txbPosTypeDu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosTypeDu.Location = new Point(183, 155);
            txbPosTypeDu.Name = "txbPosTypeDu";
            txbPosTypeDu.Size = new Size(27, 25);
            txbPosTypeDu.TabIndex = 15;
            txbPosTypeDu.KeyPress += txbPosTypeDu_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(54, 119);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 20;
            label4.Text = "INTERNO";
            // 
            // txbPosIntern
            // 
            txbPosIntern.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosIntern.Location = new Point(183, 115);
            txbPosIntern.Name = "txbPosIntern";
            txbPosIntern.Size = new Size(27, 25);
            txbPosIntern.TabIndex = 14;
            txbPosIntern.KeyPress += txbPosIntern_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(323, 124);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 22;
            label6.Text = "Nº DU";
            // 
            // txbPosNumber
            // 
            txbPosNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosNumber.Location = new Point(455, 80);
            txbPosNumber.Name = "txbPosNumber";
            txbPosNumber.Size = new Size(27, 25);
            txbPosNumber.TabIndex = 13;
            txbPosNumber.KeyPress += txbPosNumber_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(55, 155);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 21;
            label5.Text = "TIPO DU";
            // 
            // txbPosEntity
            // 
            txbPosEntity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosEntity.Location = new Point(455, 39);
            txbPosEntity.Name = "txbPosEntity";
            txbPosEntity.Size = new Size(27, 25);
            txbPosEntity.TabIndex = 12;
            txbPosEntity.KeyPress += txbPosEntity_KeyPress;
            // 
            // txbPosName
            // 
            txbPosName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosName.Location = new Point(183, 35);
            txbPosName.Name = "txbPosName";
            txbPosName.Size = new Size(27, 25);
            txbPosName.TabIndex = 11;
            txbPosName.KeyPress += txbPosName_KeyPress;
            // 
            // button3
            // 
            button3.BackColor = Color.BurlyWood;
            button3.FlatAppearance.MouseOverBackColor = Color.Peru;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(469, 386);
            button3.Name = "button3";
            button3.Size = new Size(81, 40);
            button3.TabIndex = 29;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.BurlyWood;
            button1.FlatAppearance.MouseOverBackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(259, 386);
            button1.Name = "button1";
            button1.Size = new Size(81, 40);
            button1.TabIndex = 28;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txbCompanyName
            // 
            txbCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbCompanyName.Location = new Point(297, 116);
            txbCompanyName.Name = "txbCompanyName";
            txbCompanyName.PlaceholderText = "Nombre";
            txbCompanyName.Size = new Size(200, 29);
            txbCompanyName.TabIndex = 30;
            // 
            // CompanyRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(txbCompanyName);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CompanyRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompanyRegister";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label lb;
        private TextBox txbPosSurname;
        private Label label8;
        private Label label2;
        private TextBox txbPosDu;
        private Label label3;
        private TextBox txbPosTypeDu;
        private Label label4;
        private TextBox txbPosIntern;
        private Label label6;
        private TextBox txbPosNumber;
        private Label label5;
        private TextBox txbPosEntity;
        private TextBox txbPosName;
        private Button button3;
        private Button button1;
        private TextBox txbCompanyName;
    }
}