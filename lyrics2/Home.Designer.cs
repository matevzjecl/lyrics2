namespace lyrics2
{
	partial class Home
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
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAvtor = new System.Windows.Forms.TextBox();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxLeto = new System.Windows.Forms.TextBox();
            this.textBoxBesedilo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pozdravljen ";
            // 
            // dropdown
            // 
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(12, 89);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(121, 21);
            this.dropdown.TabIndex = 1;
            this.dropdown.Text = "Nimate nobenih besedil";
            this.dropdown.SelectionChangeCommitted += new System.EventHandler(this.dropdown_SelectionChangeCommitted);
            this.dropdown.Click += new System.EventHandler(this.dropdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moja besedila";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj Besedilo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(134, 403);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 35);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Izbriši Besedilo";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Leto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Avtor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Naslov";
            // 
            // textBoxAvtor
            // 
            this.textBoxAvtor.Location = new System.Drawing.Point(331, 67);
            this.textBoxAvtor.Name = "textBoxAvtor";
            this.textBoxAvtor.Size = new System.Drawing.Size(124, 20);
            this.textBoxAvtor.TabIndex = 12;
            this.textBoxAvtor.Tag = "Vnesi Avtorja";
            this.textBoxAvtor.Text = "Vnesi Avtorja";
            this.textBoxAvtor.Click += new System.EventHandler(this.textBoxAvtor_Click);
            this.textBoxAvtor.TextChanged += new System.EventHandler(this.textBoxAvtor_TextChanged_1);
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(331, 106);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(124, 20);
            this.textBoxAlbum.TabIndex = 13;
            this.textBoxAlbum.Tag = "Vnesi Album";
            this.textBoxAlbum.Text = "Vnesi Album";
            this.textBoxAlbum.Click += new System.EventHandler(this.textBoxAlbum_Click);
            this.textBoxAlbum.TextChanged += new System.EventHandler(this.textBoxAlbum_TextChanged_1);
            // 
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(331, 28);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.Size = new System.Drawing.Size(124, 20);
            this.textBoxNaslov.TabIndex = 11;
            this.textBoxNaslov.Tag = "Vnesi Naslov";
            this.textBoxNaslov.Text = "Vnesi Naslov";
            this.textBoxNaslov.Click += new System.EventHandler(this.textBoxNaslov_Click);
            this.textBoxNaslov.TextChanged += new System.EventHandler(this.textBoxNaslov_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "URL";
            this.label7.Visible = false;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(215, 239);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(240, 20);
            this.textBoxURL.TabIndex = 15;
            this.textBoxURL.Tag = "Vnesi naslov povezave";
            this.textBoxURL.Text = "Vnesi naslov povezave";
            this.textBoxURL.Visible = false;
            this.textBoxURL.Click += new System.EventHandler(this.textBoxURL_Click);
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(256, 403);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(116, 35);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Shrani Spremembe";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxLeto
            // 
            this.textBoxLeto.Location = new System.Drawing.Point(331, 145);
            this.textBoxLeto.Name = "textBoxLeto";
            this.textBoxLeto.Size = new System.Drawing.Size(124, 20);
            this.textBoxLeto.TabIndex = 14;
            this.textBoxLeto.Tag = "Vnesi Leto";
            this.textBoxLeto.Text = "Vnesi Leto";
            this.textBoxLeto.Click += new System.EventHandler(this.textBoxLeto_Click);
            this.textBoxLeto.TextChanged += new System.EventHandler(this.textBoxLeto_TextChanged_1);
            this.textBoxLeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLeto_KeyPress);
            // 
            // textBoxBesedilo
            // 
            this.textBoxBesedilo.Location = new System.Drawing.Point(461, 12);
            this.textBoxBesedilo.Multiline = true;
            this.textBoxBesedilo.Name = "textBoxBesedilo";
            this.textBoxBesedilo.Size = new System.Drawing.Size(327, 426);
            this.textBoxBesedilo.TabIndex = 22;
            this.textBoxBesedilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBesedilo.Click += new System.EventHandler(this.textBoxBesedilo_Click);
            this.textBoxBesedilo.TextChanged += new System.EventHandler(this.textBoxBesedilo_TextChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBesedilo);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLeto);
            this.Controls.Add(this.textBoxAvtor);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.textBoxNaslov);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox dropdown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxAvtor;
		private System.Windows.Forms.TextBox textBoxAlbum;
		private System.Windows.Forms.TextBox textBoxNaslov;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxURL;
		private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxLeto;
        private System.Windows.Forms.TextBox textBoxBesedilo;
    }
}