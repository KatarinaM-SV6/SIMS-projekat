namespace SIMS_project
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mesto = new System.Windows.Forms.TextBox();
            this.nazivAutoputa = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addBooth = new System.Windows.Forms.Button();
            this.updateBooth = new System.Windows.Forms.Button();
            this.deleteBooth = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STANICA: ";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(258, 25);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 25);
            this.Id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Naziv autoputa:";
            // 
            // mesto
            // 
            this.mesto.Location = new System.Drawing.Point(50, 92);
            this.mesto.Name = "mesto";
            this.mesto.Size = new System.Drawing.Size(112, 22);
            this.mesto.TabIndex = 4;
            // 
            // nazivAutoputa
            // 
            this.nazivAutoputa.Location = new System.Drawing.Point(247, 92);
            this.nazivAutoputa.Name = "nazivAutoputa";
            this.nazivAutoputa.Size = new System.Drawing.Size(118, 22);
            this.nazivAutoputa.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(50, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 116);
            this.listBox1.TabIndex = 6;
            // 
            // addBooth
            // 
            this.addBooth.Location = new System.Drawing.Point(50, 271);
            this.addBooth.Name = "addBooth";
            this.addBooth.Size = new System.Drawing.Size(90, 30);
            this.addBooth.TabIndex = 7;
            this.addBooth.Text = "DODAJ";
            this.addBooth.UseVisualStyleBackColor = true;
            this.addBooth.Click += new System.EventHandler(this.addBooth_Click);
            // 
            // updateBooth
            // 
            this.updateBooth.Location = new System.Drawing.Point(162, 271);
            this.updateBooth.Name = "updateBooth";
            this.updateBooth.Size = new System.Drawing.Size(90, 30);
            this.updateBooth.TabIndex = 8;
            this.updateBooth.Text = "AŽURIRAJ";
            this.updateBooth.UseVisualStyleBackColor = true;
            this.updateBooth.Click += new System.EventHandler(this.updateBooth_Click);
            // 
            // deleteBooth
            // 
            this.deleteBooth.Location = new System.Drawing.Point(275, 271);
            this.deleteBooth.Name = "deleteBooth";
            this.deleteBooth.Size = new System.Drawing.Size(90, 30);
            this.deleteBooth.TabIndex = 9;
            this.deleteBooth.Text = "OBRIŠI";
            this.deleteBooth.UseVisualStyleBackColor = true;
            this.deleteBooth.Click += new System.EventHandler(this.deleteBooth_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Naplatna mesta:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBooth);
            this.Controls.Add(this.updateBooth);
            this.Controls.Add(this.addBooth);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nazivAutoputa);
            this.Controls.Add(this.mesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Activated += new System.EventHandler(this.UpdateForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mesto;
        private System.Windows.Forms.TextBox nazivAutoputa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addBooth;
        private System.Windows.Forms.Button updateBooth;
        private System.Windows.Forms.Button deleteBooth;
        private System.Windows.Forms.Label label5;
    }
}