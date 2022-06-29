
namespace SIMS_project.view.referentView
{
    partial class DojavaKvaraForma
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
            this.cbUredjaji = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbObustavi = new System.Windows.Forms.CheckBox();
            this.btnDojavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUredjaji
            // 
            this.cbUredjaji.FormattingEnabled = true;
            this.cbUredjaji.Location = new System.Drawing.Point(57, 121);
            this.cbUredjaji.Margin = new System.Windows.Forms.Padding(4);
            this.cbUredjaji.Name = "cbUredjaji";
            this.cbUredjaji.Size = new System.Drawing.Size(363, 33);
            this.cbUredjaji.TabIndex = 0;
            this.cbUredjaji.SelectionChangeCommitted += new System.EventHandler(this.CbUredjaji_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite uredjaj:";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(57, 259);
            this.tbOpis.Margin = new System.Windows.Forms.Padding(4);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(363, 30);
            this.tbOpis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis kvara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obustavi rad mesta?";
            // 
            // chbObustavi
            // 
            this.chbObustavi.AutoSize = true;
            this.chbObustavi.Location = new System.Drawing.Point(392, 375);
            this.chbObustavi.Margin = new System.Windows.Forms.Padding(4);
            this.chbObustavi.Name = "chbObustavi";
            this.chbObustavi.Size = new System.Drawing.Size(22, 21);
            this.chbObustavi.TabIndex = 5;
            this.chbObustavi.UseVisualStyleBackColor = true;
            // 
            // btnDojavi
            // 
            this.btnDojavi.Location = new System.Drawing.Point(169, 531);
            this.btnDojavi.Margin = new System.Windows.Forms.Padding(4);
            this.btnDojavi.Name = "btnDojavi";
            this.btnDojavi.Size = new System.Drawing.Size(303, 61);
            this.btnDojavi.TabIndex = 6;
            this.btnDojavi.Text = "Dojavi";
            this.btnDojavi.UseVisualStyleBackColor = true;
            this.btnDojavi.Click += new System.EventHandler(this.BtnDojavi_Click);
            // 
            // DojavaKvaraForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 664);
            this.Controls.Add(this.btnDojavi);
            this.Controls.Add(this.chbObustavi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUredjaji);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DojavaKvaraForma";
            this.Text = "Dojava Kvara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUredjaji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbObustavi;
        private System.Windows.Forms.Button btnDojavi;
    }
}