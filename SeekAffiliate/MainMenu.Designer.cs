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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            afiliadoToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            afiliadoToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, buscarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afiliadoToolStripMenuItem });
            agregarToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            agregarToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(68, 21);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // afiliadoToolStripMenuItem
            // 
            afiliadoToolStripMenuItem.Name = "afiliadoToolStripMenuItem";
            afiliadoToolStripMenuItem.Size = new Size(120, 22);
            afiliadoToolStripMenuItem.Text = "Afiliado";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afiliadoToolStripMenuItem1 });
            buscarToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buscarToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(58, 21);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // afiliadoToolStripMenuItem1
            // 
            afiliadoToolStripMenuItem1.Name = "afiliadoToolStripMenuItem1";
            afiliadoToolStripMenuItem1.Size = new Size(120, 22);
            afiliadoToolStripMenuItem1.Text = "Afiliado";
            afiliadoToolStripMenuItem1.Click += afiliadoToolStripMenuItem1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
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
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem afiliadoToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem afiliadoToolStripMenuItem1;
    }
}