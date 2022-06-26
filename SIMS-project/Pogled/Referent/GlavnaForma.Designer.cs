
namespace SIMS_project.Pogled.Referent
{
    partial class GlavnaForma
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
            this.naplataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dojaviKvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naplataToolStripMenuItem,
            this.dojaviKvarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // naplataToolStripMenuItem
            // 
            this.naplataToolStripMenuItem.Name = "naplataToolStripMenuItem";
            this.naplataToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.naplataToolStripMenuItem.Text = "Naplata";
            // 
            // dojaviKvarToolStripMenuItem
            // 
            this.dojaviKvarToolStripMenuItem.Name = "dojaviKvarToolStripMenuItem";
            this.dojaviKvarToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dojaviKvarToolStripMenuItem.Text = "Dojavi kvar";
            // 
            // cbMesto
            // 
            this.cbMesto.FormattingEnabled = true;
            this.cbMesto.Location = new System.Drawing.Point(41, 154);
            this.cbMesto.Name = "cbMesto";
            this.cbMesto.Size = new System.Drawing.Size(290, 28);
            this.cbMesto.TabIndex = 1;
            this.cbMesto.SelectionChangeCommitted += new System.EventHandler(this.CbMesto_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izbor naplatnog mesta na kom radite u ovoj smeni:";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMesto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "Referent - Glavna Forma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem naplataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dojaviKvarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbMesto;
        private System.Windows.Forms.Label label1;
    }
}