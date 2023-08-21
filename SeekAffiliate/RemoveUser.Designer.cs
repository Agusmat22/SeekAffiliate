namespace SeekAffiliate
{
    partial class RemoveUser
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
            cmbUser = new ComboBox();
            label2 = new Label();
            btnCancel = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(223, 18);
            label1.Name = "label1";
            label1.Size = new Size(344, 65);
            label1.TabIndex = 5;
            label1.Text = "Eliminar Usuario";
            // 
            // cmbUser
            // 
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(271, 212);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(249, 29);
            cmbUser.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(327, 162);
            label2.Name = "label2";
            label2.Size = new Size(135, 37);
            label2.TabIndex = 7;
            label2.Text = "Seleccionar";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SaddleBrown;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(480, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.SaddleBrown;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(223, 343);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 40);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Eliminar";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnRemove);
            Controls.Add(label2);
            Controls.Add(cmbUser);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "RemoveUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveUser";
            Load += RemoveUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbUser;
        private Label label2;
        private Button btnCancel;
        private Button btnRemove;
    }
}