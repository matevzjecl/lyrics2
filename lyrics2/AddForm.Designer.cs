namespace lyrics2
{
	partial class AddForm
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.textBoxNaslov = new System.Windows.Forms.TextBox();
			this.textBoxAlbum = new System.Windows.Forms.TextBox();
			this.textBoxAvtor = new System.Windows.Forms.TextBox();
			this.textBoxLeto = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// textBoxNaslov
			// 
			this.textBoxNaslov.Location = new System.Drawing.Point(12, 25);
			this.textBoxNaslov.Name = "textBoxNaslov";
			this.textBoxNaslov.Size = new System.Drawing.Size(124, 20);
			this.textBoxNaslov.TabIndex = 2;
			// 
			// textBoxAlbum
			// 
			this.textBoxAlbum.Location = new System.Drawing.Point(12, 103);
			this.textBoxAlbum.Name = "textBoxAlbum";
			this.textBoxAlbum.Size = new System.Drawing.Size(124, 20);
			this.textBoxAlbum.TabIndex = 3;
			// 
			// textBoxAvtor
			// 
			this.textBoxAvtor.Location = new System.Drawing.Point(12, 64);
			this.textBoxAvtor.Name = "textBoxAvtor";
			this.textBoxAvtor.Size = new System.Drawing.Size(124, 20);
			this.textBoxAvtor.TabIndex = 4;
			// 
			// textBoxLeto
			// 
			this.textBoxLeto.Location = new System.Drawing.Point(12, 142);
			this.textBoxLeto.Name = "textBoxLeto";
			this.textBoxLeto.Size = new System.Drawing.Size(124, 20);
			this.textBoxLeto.TabIndex = 5;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(392, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(283, 490);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Naslov";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Avtor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Album";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Leto";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 514);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBoxLeto);
			this.Controls.Add(this.textBoxAvtor);
			this.Controls.Add(this.textBoxAlbum);
			this.Controls.Add(this.textBoxNaslov);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox textBoxNaslov;
		private System.Windows.Forms.TextBox textBoxAlbum;
		private System.Windows.Forms.TextBox textBoxAvtor;
		private System.Windows.Forms.TextBox textBoxLeto;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}