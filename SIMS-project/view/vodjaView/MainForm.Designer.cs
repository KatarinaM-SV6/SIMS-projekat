
namespace SIMS_project.view.vodjaView
{
	partial class MainForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.Location = new System.Drawing.Point(38, 61);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(738, 219);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Redni broj";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Elektronsko naplacivanje";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "U funkciji";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Broj uredjaja";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(60, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 62);
			this.button1.TabIndex = 1;
			this.button1.Text = "Promeni stanje u funkciji";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.PromeniUfunciji);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(345, 331);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(122, 62);
			this.button2.TabIndex = 2;
			this.button2.Text = "Uredjaji";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.UvidUUredjaje);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(622, 331);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(122, 62);
			this.button3.TabIndex = 3;
			this.button3.Text = "Prijava kvarova za stanicu";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.UvidUprijaveKvarova);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(204, 425);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(122, 62);
			this.button4.TabIndex = 4;
			this.button4.Text = "Izvestaj o prometu";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.IzvestajPromet);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(492, 425);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(122, 62);
			this.button5.TabIndex = 5;
			this.button5.Text = "Izvestaj po tipu vozila";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.IzvestajTipVozila);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 517);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}