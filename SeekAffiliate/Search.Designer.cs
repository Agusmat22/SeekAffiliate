namespace SeekAffiliate
{
    partial class Search
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            EntityColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            NumberColumn = new DataGridViewTextBoxColumn();
            InternColumn = new DataGridViewTextBoxColumn();
            TypeDuColumn = new DataGridViewTextBoxColumn();
            DuColumn = new DataGridViewTextBoxColumn();
            rdbNumber = new RadioButton();
            rdbDni = new RadioButton();
            rdbName = new RadioButton();
            btnCancelSearch = new Button();
            btnSearch = new Button();
            txbSearch = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Sienna;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EntityColumn, NameColumn, NumberColumn, InternColumn, TypeDuColumn, DuColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Linen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(896, 257);
            dataGridView1.TabIndex = 0;
            // 
            // EntityColumn
            // 
            EntityColumn.HeaderText = "ENTIDAD";
            EntityColumn.Name = "EntityColumn";
            EntityColumn.ReadOnly = true;
            EntityColumn.Width = 130;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "NOMBRE";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 320;
            // 
            // NumberColumn
            // 
            NumberColumn.HeaderText = "N° AF";
            NumberColumn.Name = "NumberColumn";
            NumberColumn.ReadOnly = true;
            NumberColumn.Width = 130;
            // 
            // InternColumn
            // 
            InternColumn.HeaderText = "INT";
            InternColumn.Name = "InternColumn";
            InternColumn.Width = 50;
            // 
            // TypeDuColumn
            // 
            TypeDuColumn.HeaderText = "TIPO DU";
            TypeDuColumn.Name = "TypeDuColumn";
            TypeDuColumn.ReadOnly = true;
            TypeDuColumn.Width = 110;
            // 
            // DuColumn
            // 
            DuColumn.HeaderText = "DU";
            DuColumn.Name = "DuColumn";
            DuColumn.ReadOnly = true;
            DuColumn.Width = 115;
            // 
            // rdbNumber
            // 
            rdbNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdbNumber.AutoSize = true;
            rdbNumber.Cursor = Cursors.Hand;
            rdbNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbNumber.ForeColor = Color.Black;
            rdbNumber.Location = new Point(235, 77);
            rdbNumber.Name = "rdbNumber";
            rdbNumber.Size = new Size(84, 19);
            rdbNumber.TabIndex = 16;
            rdbNumber.TabStop = true;
            rdbNumber.Text = "N* Afiliado";
            rdbNumber.UseVisualStyleBackColor = true;
            // 
            // rdbDni
            // 
            rdbDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdbDni.AutoSize = true;
            rdbDni.Cursor = Cursors.Hand;
            rdbDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbDni.ForeColor = Color.Black;
            rdbDni.Location = new Point(170, 77);
            rdbDni.Name = "rdbDni";
            rdbDni.Size = new Size(44, 19);
            rdbDni.TabIndex = 15;
            rdbDni.TabStop = true;
            rdbDni.Text = "Dni";
            rdbDni.UseVisualStyleBackColor = true;
            // 
            // rdbName
            // 
            rdbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdbName.AutoSize = true;
            rdbName.Cursor = Cursors.Hand;
            rdbName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbName.ForeColor = Color.Black;
            rdbName.Location = new Point(76, 77);
            rdbName.Name = "rdbName";
            rdbName.Size = new Size(71, 19);
            rdbName.TabIndex = 14;
            rdbName.TabStop = true;
            rdbName.Text = "Nombre";
            rdbName.UseVisualStyleBackColor = true;
            // 
            // btnCancelSearch
            // 
            btnCancelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelSearch.BackColor = Color.BurlyWood;
            btnCancelSearch.Cursor = Cursors.Hand;
            btnCancelSearch.FlatAppearance.BorderSize = 0;
            btnCancelSearch.FlatStyle = FlatStyle.Flat;
            btnCancelSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelSearch.ForeColor = Color.Black;
            btnCancelSearch.Location = new Point(284, 172);
            btnCancelSearch.Name = "btnCancelSearch";
            btnCancelSearch.Size = new Size(99, 31);
            btnCancelSearch.TabIndex = 12;
            btnCancelSearch.Text = "VOLVER";
            btnCancelSearch.UseVisualStyleBackColor = false;
            btnCancelSearch.Click += btnCancelSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = Color.BurlyWood;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(10, 172);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 31);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "BUSCAR";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbSearch.Location = new Point(76, 121);
            txbSearch.Name = "txbSearch";
            txbSearch.PlaceholderText = "Ingresar dato";
            txbSearch.Size = new Size(240, 27);
            txbSearch.TabIndex = 10;
            txbSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnCancelSearch);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rdbNumber);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txbSearch);
            groupBox1.Controls.Add(rdbName);
            groupBox1.Controls.Add(rdbDni);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.SaddleBrown;
            groupBox1.Location = new Point(271, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 209);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Afiliados";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.BurlyWood;
            pictureBox1.Image = Properties.Resources.lup;
            pictureBox1.Location = new Point(10, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(928, 510);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton rdbNumber;
        private RadioButton rdbDni;
        private RadioButton rdbName;
        private Button btnCancelSearch;
        private Button btnSearch;
        private TextBox txbSearch;
        private DataGridViewTextBoxColumn EntityColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn InternColumn;
        private DataGridViewTextBoxColumn TypeDuColumn;
        private DataGridViewTextBoxColumn DuColumn;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}