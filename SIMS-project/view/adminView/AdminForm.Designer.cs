namespace SIMS_project
{
    partial class AdminForm
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
        /// the contents of this    method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.NaplatneStanice = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.KorisnickiNaloziLB = new System.Windows.Forms.ListBox();
            this.deleteNalogBt = new System.Windows.Forms.Button();
            this.updateNalogBt = new System.Windows.Forms.Button();
            this.createNalogBt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.poruka = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stanice = new System.Windows.Forms.ComboBox();
            this.radnici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(13, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(505, 330);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NaplatneStanice);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Controls.Add(this.createButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CRUD Stanica i Mesta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naplatne Stanice:";
            // 
            // NaplatneStanice
            // 
            this.NaplatneStanice.FormattingEnabled = true;
            this.NaplatneStanice.ItemHeight = 16;
            this.NaplatneStanice.Location = new System.Drawing.Point(23, 45);
            this.NaplatneStanice.Name = "NaplatneStanice";
            this.NaplatneStanice.Size = new System.Drawing.Size(313, 228);
            this.NaplatneStanice.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "OBRIŠI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(362, 45);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(119, 31);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "AŽURIRAJ";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(362, 164);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(119, 39);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "KREIRAJ";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.KorisnickiNaloziLB);
            this.tabPage2.Controls.Add(this.deleteNalogBt);
            this.tabPage2.Controls.Add(this.updateNalogBt);
            this.tabPage2.Controls.Add(this.createNalogBt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CRUD Korisnicki nalozi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Korisnicki nalozi:";
            // 
            // KorisnickiNaloziLB
            // 
            this.KorisnickiNaloziLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.KorisnickiNaloziLB.FormattingEnabled = true;
            this.KorisnickiNaloziLB.HorizontalScrollbar = true;
            this.KorisnickiNaloziLB.ItemHeight = 16;
            this.KorisnickiNaloziLB.Location = new System.Drawing.Point(21, 51);
            this.KorisnickiNaloziLB.Name = "KorisnickiNaloziLB";
            this.KorisnickiNaloziLB.Size = new System.Drawing.Size(313, 228);
            this.KorisnickiNaloziLB.TabIndex = 8;
            // 
            // deleteNalogBt
            // 
            this.deleteNalogBt.Location = new System.Drawing.Point(360, 109);
            this.deleteNalogBt.Name = "deleteNalogBt";
            this.deleteNalogBt.Size = new System.Drawing.Size(119, 35);
            this.deleteNalogBt.TabIndex = 7;
            this.deleteNalogBt.Text = "OBRIŠI";
            this.deleteNalogBt.UseVisualStyleBackColor = true;
            this.deleteNalogBt.Click += new System.EventHandler(this.deleteNalogBt_Click);
            // 
            // updateNalogBt
            // 
            this.updateNalogBt.Location = new System.Drawing.Point(360, 51);
            this.updateNalogBt.Name = "updateNalogBt";
            this.updateNalogBt.Size = new System.Drawing.Size(119, 31);
            this.updateNalogBt.TabIndex = 6;
            this.updateNalogBt.Text = "AŽURIRAJ";
            this.updateNalogBt.UseVisualStyleBackColor = true;
            this.updateNalogBt.Click += new System.EventHandler(this.updateNalogBt_Click);
            // 
            // createNalogBt
            // 
            this.createNalogBt.Location = new System.Drawing.Point(360, 170);
            this.createNalogBt.Name = "createNalogBt";
            this.createNalogBt.Size = new System.Drawing.Size(119, 39);
            this.createNalogBt.TabIndex = 5;
            this.createNalogBt.Text = "KREIRAJ";
            this.createNalogBt.UseVisualStyleBackColor = true;
            this.createNalogBt.Click += new System.EventHandler(this.createNalogBt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.poruka);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.stanice);
            this.tabPage3.Controls.Add(this.radnici);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(497, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Postavljanje vodja stanica";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // poruka
            // 
            this.poruka.AutoSize = true;
            this.poruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poruka.Location = new System.Drawing.Point(83, 130);
            this.poruka.Name = "poruka";
            this.poruka.Size = new System.Drawing.Size(0, 25);
            this.poruka.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "POSTAVI VODJU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stanice
            // 
            this.stanice.DisplayMember = "Mesto";
            this.stanice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stanice.FormattingEnabled = true;
            this.stanice.Location = new System.Drawing.Point(289, 53);
            this.stanice.Name = "stanice";
            this.stanice.Size = new System.Drawing.Size(149, 28);
            this.stanice.TabIndex = 3;
            // 
            // radnici
            // 
            this.radnici.DisplayMember = "korisnickoIme";
            this.radnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radnici.FormattingEnabled = true;
            this.radnici.Location = new System.Drawing.Point(45, 53);
            this.radnici.Name = "radnici";
            this.radnici.Size = new System.Drawing.Size(155, 28);
            this.radnici.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stanice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Radnici";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 353);
            this.Controls.Add(this.TabControl);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListBox NaplatneStanice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox stanice;
        private System.Windows.Forms.ComboBox radnici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label poruka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox KorisnickiNaloziLB;
        private System.Windows.Forms.Button deleteNalogBt;
        private System.Windows.Forms.Button updateNalogBt;
        private System.Windows.Forms.Button createNalogBt;
    }
}