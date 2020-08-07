namespace Calcul_Buget
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miVenituri = new System.Windows.Forms.ToolStripMenuItem();
            this.miCheltuieli = new System.Windows.Forms.ToolStripMenuItem();
            this.balantaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vexploatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vfinanciareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vextraordinareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cexploatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cfinanciareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cextraordinareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVenituri,
            this.miCheltuieli,
            this.balantaToolStripMenuItem,
            this.vexploatareToolStripMenuItem,
            this.vfinanciareToolStripMenuItem,
            this.vextraordinareToolStripMenuItem,
            this.cexploatareToolStripMenuItem,
            this.cfinanciareToolStripMenuItem,
            this.cextraordinareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MsMain";
            // 
            // miVenituri
            // 
            this.miVenituri.Name = "miVenituri";
            this.miVenituri.Size = new System.Drawing.Size(59, 20);
            this.miVenituri.Text = "Venituri";
            this.miVenituri.Click += new System.EventHandler(this.miVenituri_Click);
            // 
            // miCheltuieli
            // 
            this.miCheltuieli.Name = "miCheltuieli";
            this.miCheltuieli.Size = new System.Drawing.Size(69, 20);
            this.miCheltuieli.Text = "Cheltuieli";
            this.miCheltuieli.Click += new System.EventHandler(this.miCheltuieli_Click);
            // 
            // balantaToolStripMenuItem
            // 
            this.balantaToolStripMenuItem.Name = "balantaToolStripMenuItem";
            this.balantaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.balantaToolStripMenuItem.Text = "Balanta";
            this.balantaToolStripMenuItem.Click += new System.EventHandler(this.balantaToolStripMenuItem_Click);
            // 
            // vexploatareToolStripMenuItem
            // 
            this.vexploatareToolStripMenuItem.Name = "vexploatareToolStripMenuItem";
            this.vexploatareToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.vexploatareToolStripMenuItem.Text = "V-exploatare";
            this.vexploatareToolStripMenuItem.Click += new System.EventHandler(this.vexploatareToolStripMenuItem_Click);
            // 
            // vfinanciareToolStripMenuItem
            // 
            this.vfinanciareToolStripMenuItem.Name = "vfinanciareToolStripMenuItem";
            this.vfinanciareToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.vfinanciareToolStripMenuItem.Text = "V-financiare";
            this.vfinanciareToolStripMenuItem.Click += new System.EventHandler(this.vfinanciareToolStripMenuItem_Click);
            // 
            // vextraordinareToolStripMenuItem
            // 
            this.vextraordinareToolStripMenuItem.Name = "vextraordinareToolStripMenuItem";
            this.vextraordinareToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.vextraordinareToolStripMenuItem.Text = "V-extraordinare";
            this.vextraordinareToolStripMenuItem.Click += new System.EventHandler(this.vextraordinareToolStripMenuItem_Click);
            // 
            // cexploatareToolStripMenuItem
            // 
            this.cexploatareToolStripMenuItem.Name = "cexploatareToolStripMenuItem";
            this.cexploatareToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cexploatareToolStripMenuItem.Text = "C-exploatare";
            this.cexploatareToolStripMenuItem.Click += new System.EventHandler(this.cexploatareToolStripMenuItem_Click);
            // 
            // cfinanciareToolStripMenuItem
            // 
            this.cfinanciareToolStripMenuItem.Name = "cfinanciareToolStripMenuItem";
            this.cfinanciareToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cfinanciareToolStripMenuItem.Text = "C-financiare";
            this.cfinanciareToolStripMenuItem.Click += new System.EventHandler(this.cfinanciareToolStripMenuItem_Click);
            // 
            // cextraordinareToolStripMenuItem
            // 
            this.cextraordinareToolStripMenuItem.Name = "cextraordinareToolStripMenuItem";
            this.cextraordinareToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.cextraordinareToolStripMenuItem.Text = "C-extraordinare";
            this.cextraordinareToolStripMenuItem.Click += new System.EventHandler(this.cextraordinareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 591);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul Buget";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miVenituri;
        private System.Windows.Forms.ToolStripMenuItem miCheltuieli;
        private System.Windows.Forms.ToolStripMenuItem balantaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vexploatareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vfinanciareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vextraordinareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cexploatareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cfinanciareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cextraordinareToolStripMenuItem;
    }
}

