namespace SeekAffiliate
{
    partial class FileCharge
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
            btnSelect = new Button();
            txbPath = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            txbPosName = new TextBox();
            txbPosEntity = new TextBox();
            txbPosNumber = new TextBox();
            txbPosIntern = new TextBox();
            txbPosTypeDu = new TextBox();
            txbPosDu = new TextBox();
            lb = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txbPosSurname = new TextBox();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelect.Location = new Point(45, 171);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(281, 43);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Seleccionar";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txbPath
            // 
            txbPath.Location = new Point(45, 236);
            txbPath.Name = "txbPath";
            txbPath.ReadOnly = true;
            txbPath.Size = new Size(281, 23);
            txbPath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(245, -2);
            label1.Name = "label1";
            label1.Size = new Size(307, 65);
            label1.TabIndex = 7;
            label1.Text = "Cargar archivo";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(245, 398);
            button1.Name = "button1";
            button1.Size = new Size(81, 40);
            button1.TabIndex = 8;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(450, 398);
            button3.Name = "button3";
            button3.Size = new Size(81, 40);
            button3.TabIndex = 10;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txbPosName
            // 
            txbPosName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosName.Location = new Point(733, 96);
            txbPosName.Name = "txbPosName";
            txbPosName.Size = new Size(27, 23);
            txbPosName.TabIndex = 11;
            // 
            // txbPosEntity
            // 
            txbPosEntity.Location = new Point(733, 175);
            txbPosEntity.Name = "txbPosEntity";
            txbPosEntity.Size = new Size(27, 23);
            txbPosEntity.TabIndex = 12;
            // 
            // txbPosNumber
            // 
            txbPosNumber.Location = new Point(733, 216);
            txbPosNumber.Name = "txbPosNumber";
            txbPosNumber.Size = new Size(27, 23);
            txbPosNumber.TabIndex = 13;
            // 
            // txbPosIntern
            // 
            txbPosIntern.Location = new Point(733, 255);
            txbPosIntern.Name = "txbPosIntern";
            txbPosIntern.Size = new Size(27, 23);
            txbPosIntern.TabIndex = 14;
            // 
            // txbPosTypeDu
            // 
            txbPosTypeDu.Location = new Point(733, 299);
            txbPosTypeDu.Name = "txbPosTypeDu";
            txbPosTypeDu.Size = new Size(27, 23);
            txbPosTypeDu.TabIndex = 15;
            // 
            // txbPosDu
            // 
            txbPosDu.Location = new Point(733, 340);
            txbPosDu.Name = "txbPosDu";
            txbPosDu.Size = new Size(27, 23);
            txbPosDu.TabIndex = 16;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lb.Location = new Point(633, 99);
            lb.Name = "lb";
            lb.Size = new Size(68, 20);
            lb.TabIndex = 17;
            lb.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(633, 178);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 18;
            label2.Text = "ENTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(633, 219);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 19;
            label3.Text = "NUMERO AF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(633, 258);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 20;
            label4.Text = "INTERNO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(633, 302);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 21;
            label5.Text = "TIPO DU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(633, 343);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 22;
            label6.Text = "Nº DU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Sienna;
            label7.Location = new Point(624, 52);
            label7.Name = "label7";
            label7.Size = new Size(143, 37);
            label7.TabIndex = 23;
            label7.Text = "Posicion Col";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(633, 139);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 25;
            label8.Text = "APELLIDO";
            // 
            // txbPosSurname
            // 
            txbPosSurname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbPosSurname.Location = new Point(733, 136);
            txbPosSurname.Name = "txbPosSurname";
            txbPosSurname.Size = new Size(27, 23);
            txbPosSurname.TabIndex = 24;
            // 
            // FileCharge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txbPosSurname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb);
            Controls.Add(txbPosDu);
            Controls.Add(txbPosTypeDu);
            Controls.Add(txbPosIntern);
            Controls.Add(txbPosNumber);
            Controls.Add(txbPosEntity);
            Controls.Add(txbPosName);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txbPath);
            Controls.Add(btnSelect);
            Name = "FileCharge";
            Text = "FileCharge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelect;
        private TextBox txbPath;
        private Label label1;
        private Button button1;
        private Button button3;
        private TextBox txbPosName;
        private TextBox txbPosEntity;
        private TextBox txbPosNumber;
        private TextBox txbPosIntern;
        private TextBox txbPosTypeDu;
        private TextBox txbPosDu;
        private Label lb;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txbPosSurname;
    }
}