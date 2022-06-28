
namespace SIMS_project.view.vodjaView
{
	partial class IzvestajForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pocetakTextBox = new System.Windows.Forms.TextBox();
			this.krajTextBox = new System.Windows.Forms.TextBox();
			this.izvestajTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.naslov = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Datum pocetka:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(35, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Datum kraja:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Format datuma: dd.MM.yyyy.";
			// 
			// pocetakTextBox
			// 
			this.pocetakTextBox.Location = new System.Drawing.Point(179, 114);
			this.pocetakTextBox.Name = "pocetakTextBox";
			this.pocetakTextBox.Size = new System.Drawing.Size(100, 22);
			this.pocetakTextBox.TabIndex = 3;
			// 
			// krajTextBox
			// 
			this.krajTextBox.Location = new System.Drawing.Point(179, 179);
			this.krajTextBox.Name = "krajTextBox";
			this.krajTextBox.Size = new System.Drawing.Size(100, 22);
			this.krajTextBox.TabIndex = 4;
			// 
			// izvestajTextBox
			// 
			this.izvestajTextBox.AllowDrop = true;
			this.izvestajTextBox.Location = new System.Drawing.Point(334, 114);
			this.izvestajTextBox.Multiline = true;
			this.izvestajTextBox.Name = "izvestajTextBox";
			this.izvestajTextBox.ReadOnly = true;
			this.izvestajTextBox.Size = new System.Drawing.Size(428, 307);
			this.izvestajTextBox.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(78, 302);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(158, 49);
			this.button1.TabIndex = 6;
			this.button1.Text = "Prikazi izvestaj";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.PrikaziIzvestaj);
			// 
			// naslov
			// 
			this.naslov.AutoSize = true;
			this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.naslov.Location = new System.Drawing.Point(31, 35);
			this.naslov.Name = "naslov";
			this.naslov.Size = new System.Drawing.Size(72, 25);
			this.naslov.TabIndex = 7;
			this.naslov.Text = "Naslov";
			// 
			// IzvestajForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(793, 433);
			this.Controls.Add(this.naslov);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.izvestajTextBox);
			this.Controls.Add(this.krajTextBox);
			this.Controls.Add(this.pocetakTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "IzvestajForm";
			this.Text = "IzvestajForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox pocetakTextBox;
		private System.Windows.Forms.TextBox krajTextBox;
		private System.Windows.Forms.TextBox izvestajTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label naslov;
	}
}