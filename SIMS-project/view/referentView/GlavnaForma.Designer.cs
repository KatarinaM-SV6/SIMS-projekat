
namespace SIMS_project.view.referentView
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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naplataToolStripMenuItem,
            this.dojaviKvarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(668, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // naplataToolStripMenuItem
            // 
            this.naplataToolStripMenuItem.Name = "naplataToolStripMenuItem";
            this.naplataToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.naplataToolStripMenuItem.Text = "Naplata";
            this.naplataToolStripMenuItem.Click += new System.EventHandler(this.NaplataToolStripMenuItem_Click);
            // 
            // dojaviKvarToolStripMenuItem
            // 
            this.dojaviKvarToolStripMenuItem.Name = "dojaviKvarToolStripMenuItem";
            this.dojaviKvarToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.dojaviKvarToolStripMenuItem.Text = "Dojavi kvar";
            this.dojaviKvarToolStripMenuItem.Click += new System.EventHandler(this.DojaviKvarToolStripMenuItem_Click);
            // 
            // cbMesto
            // 
            this.cbMesto.FormattingEnabled = true;
            this.cbMesto.Location = new System.Drawing.Point(184, 127);
            this.cbMesto.Margin = new System.Windows.Forms.Padding(4);
            this.cbMesto.Name = "cbMesto";
            this.cbMesto.Size = new System.Drawing.Size(289, 28);
            this.cbMesto.TabIndex = 1;
            this.cbMesto.SelectionChangeCommitted += new System.EventHandler(this.CbMesto_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izbor naplatnog mesta na kom radite u ovoj smeni:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Odjavi se";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMesto);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button2;
    }
}