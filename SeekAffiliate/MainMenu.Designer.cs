namespace SeekAffiliate
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            afiliadoToolStripMenuItem = new ToolStripMenuItem();
            chargeToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            chargeFileToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Sienna;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(16, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { afiliadoToolStripMenuItem, systemToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // afiliadoToolStripMenuItem
            // 
            afiliadoToolStripMenuItem.BackColor = Color.Sienna;
            afiliadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chargeToolStripMenuItem, searchToolStripMenuItem1 });
            afiliadoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            afiliadoToolStripMenuItem.ForeColor = Color.White;
            afiliadoToolStripMenuItem.Name = "afiliadoToolStripMenuItem";
            afiliadoToolStripMenuItem.Size = new Size(83, 31);
            afiliadoToolStripMenuItem.Text = "Afiliado";
            // 
            // chargeToolStripMenuItem
            // 
            chargeToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chargeToolStripMenuItem.Name = "chargeToolStripMenuItem";
            chargeToolStripMenuItem.Size = new Size(123, 24);
            chargeToolStripMenuItem.Text = "Cargar";
            chargeToolStripMenuItem.Click += chargeToolStripMenuItem_Click_1;
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.Size = new Size(123, 24);
            searchToolStripMenuItem1.Text = "Buscar";
            searchToolStripMenuItem1.Click += searchToolStripMenuItem1_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chargeFileToolStripMenuItem1, acercaDelSistemaToolStripMenuItem });
            systemToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            systemToolStripMenuItem.ForeColor = Color.White;
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(82, 31);
            systemToolStripMenuItem.Text = "Sistema";
            // 
            // chargeFileToolStripMenuItem1
            // 
            chargeFileToolStripMenuItem1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chargeFileToolStripMenuItem1.Name = "chargeFileToolStripMenuItem1";
            chargeFileToolStripMenuItem1.Size = new Size(205, 24);
            chargeFileToolStripMenuItem1.Text = "Cargar archivo";
            chargeFileToolStripMenuItem1.Click += chargeFileToolStripMenuItem1_Click;
            // 
            // acercaDelSistemaToolStripMenuItem
            // 
            acercaDelSistemaToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            acercaDelSistemaToolStripMenuItem.Name = "acercaDelSistemaToolStripMenuItem";
            acercaDelSistemaToolStripMenuItem.Size = new Size(205, 24);
            acercaDelSistemaToolStripMenuItem.Text = "Acerca del Sistema";
            acercaDelSistemaToolStripMenuItem.Click += acercaDelSistemaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, eliminarToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(81, 31);
            toolStripMenuItem1.Text = "Usuario";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(133, 24);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(133, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(215, 97);
            label1.Name = "label1";
            label1.Size = new Size(362, 71);
            label1.TabIndex = 5;
            label1.Text = "Gestion Afiliados";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(804, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem afiliadoToolStripMenuItem;
        private ToolStripMenuItem chargeToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem chargeFileToolStripMenuItem1;
        private Label label1;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem acercaDelSistemaToolStripMenuItem;
    }
}