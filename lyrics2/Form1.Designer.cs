namespace lyrics2
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
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.labelHead = new System.Windows.Forms.Label();
			this.buttonReg = new System.Windows.Forms.Button();
			this.buttonPrijava = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// textBoxPass
			// 
			this.textBoxPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.textBoxPass.Location = new System.Drawing.Point(170, 157);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(258, 29);
			this.textBoxPass.TabIndex = 15;
			this.textBoxPass.Text = "Vnesi geslo";
			this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
			// 
			// textBoxUser
			// 
			this.textBoxUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.textBoxUser.Location = new System.Drawing.Point(170, 122);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(258, 29);
			this.textBoxUser.TabIndex = 14;
			this.textBoxUser.Text = "Vnesi uporabniško ime";
			this.textBoxUser.Click += new System.EventHandler(this.textBoxUser_Click);
			// 
			// labelHead
			// 
			this.labelHead.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHead.Location = new System.Drawing.Point(166, 44);
			this.labelHead.Name = "labelHead";
			this.labelHead.Size = new System.Drawing.Size(405, 37);
			this.labelHead.TabIndex = 13;
			this.labelHead.Text = "Vnesi podatke za prijavo";
			// 
			// buttonReg
			// 
			this.buttonReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReg.Location = new System.Drawing.Point(469, 327);
			this.buttonReg.Name = "buttonReg";
			this.buttonReg.Size = new System.Drawing.Size(136, 36);
			this.buttonReg.TabIndex = 12;
			this.buttonReg.Text = "Registracija";
			this.buttonReg.UseVisualStyleBackColor = true;
			this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
			// 
			// buttonPrijava
			// 
			this.buttonPrijava.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPrijava.Location = new System.Drawing.Point(307, 209);
			this.buttonPrijava.Name = "buttonPrijava";
			this.buttonPrijava.Size = new System.Drawing.Size(121, 36);
			this.buttonPrijava.TabIndex = 11;
			this.buttonPrijava.Text = "Prijava";
			this.buttonPrijava.UseVisualStyleBackColor = true;
			this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Geslo:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 32);
			this.label1.TabIndex = 9;
			this.label1.Text = "Uporabniško ime:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(170, 209);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(51, 17);
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Band";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Visible = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 407);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxUser);
			this.Controls.Add(this.labelHead);
			this.Controls.Add(this.buttonReg);
			this.Controls.Add(this.buttonPrijava);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.Label labelHead;
		private System.Windows.Forms.Button buttonReg;
		private System.Windows.Forms.Button buttonPrijava;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

