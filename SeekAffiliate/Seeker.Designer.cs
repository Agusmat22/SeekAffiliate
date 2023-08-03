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
            richTextBox1 = new RichTextBox();
            txbNameSeeked = new TextBox();
            txbDniSeeked = new TextBox();
            txbNAffiliateSeeked = new TextBox();
            btnSearch = new Button();
            btnCancelSearch = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(21, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(344, 402);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // txbNameSeeked
            // 
            txbNameSeeked.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbNameSeeked.Location = new Point(463, 116);
            txbNameSeeked.Name = "txbNameSeeked";
            txbNameSeeked.PlaceholderText = "Nombre";
            txbNameSeeked.Size = new Size(242, 27);
            txbNameSeeked.TabIndex = 1;
            txbNameSeeked.TextAlign = HorizontalAlignment.Center;
            // 
            // txbDniSeeked
            // 
            txbDniSeeked.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbDniSeeked.Location = new Point(463, 182);
            txbDniSeeked.Name = "txbDniSeeked";
            txbDniSeeked.PlaceholderText = "Dni";
            txbDniSeeked.Size = new Size(242, 27);
            txbDniSeeked.TabIndex = 2;
            txbDniSeeked.TextAlign = HorizontalAlignment.Center;
            // 
            // txbNAffiliateSeeked
            // 
            txbNAffiliateSeeked.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txbNAffiliateSeeked.Location = new Point(463, 250);
            txbNAffiliateSeeked.Name = "txbNAffiliateSeeked";
            txbNAffiliateSeeked.PlaceholderText = "N* Afiliado";
            txbNAffiliateSeeked.Size = new Size(242, 27);
            txbNAffiliateSeeked.TabIndex = 3;
            txbNAffiliateSeeked.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(463, 332);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancelSearch
            // 
            btnCancelSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelSearch.Location = new Point(616, 332);
            btnCancelSearch.Name = "btnCancelSearch";
            btnCancelSearch.Size = new Size(89, 31);
            btnCancelSearch.TabIndex = 5;
            btnCancelSearch.Text = "Salir";
            btnCancelSearch.UseVisualStyleBackColor = true;
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
            // Seeker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCancelSearch);
            Controls.Add(btnSearch);
            Controls.Add(txbNAffiliateSeeked);
            Controls.Add(txbDniSeeked);
            Controls.Add(txbNameSeeked);
            Controls.Add(richTextBox1);
            Name = "Seeker";
            Text = "Seeker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox txbNameSeeked;
        private TextBox txbDniSeeked;
        private TextBox txbNAffiliateSeeked;
        private Button btnSearch;
        private Button btnCancelSearch;
        private Label label1;
    }
}