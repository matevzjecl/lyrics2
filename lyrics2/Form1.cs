using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Connection;




namespace lyrics2
{
	
	public partial class Form1 : Form
	{
		//Public Server
		public static string connectString = "datasource=den1.mysql6.gear.host;username=lyrics;password=Wd40I11~-5gj;database=lyrics;";
		//Local Server
		//public static string connectString = "datasource=localhost;username=root;password=;database=lyrics;";
		MySqlConnection DBconnect = new MySqlConnection(connectString);

		public static string user;
		int mode = 0;
		int rank = 0;
		public Form1()
		{
			InitializeComponent();
		}

		

		private void buttonPrijava_Click(object sender, EventArgs e)
		{
			string emptyUser = "Vnesi uporabniško ime";
			string emptyPass = "Vnesi geslo";
			if (mode == 1)
			{
				if (textBoxUser.Text == emptyUser)
				{
					textBoxUser.Text = "Vnesi uporabniško ime";
					textBoxUser.ForeColor = System.Drawing.Color.Red;
					DBconnect.Close();
				}
				else if (textBoxPass.Text == emptyPass)
				{
					textBoxPass.Text = "Vnesi geslo";
					textBoxPass.ForeColor = System.Drawing.Color.Red;
					DBconnect.Close();

				}
				else
				{
					DBconnect.Open();
					bool exists = false;
					string check = "SELECT count(*) FROM uporabniki WHERE uporabnisko_ime = @uporabnisko_ime";
					MySqlCommand cmd = new MySqlCommand(check, DBconnect);


					cmd.Parameters.AddWithValue("uporabnisko_ime", textBoxUser.Text);


					//exists = int.Parse(cmd.ExecuteScalar()) > 0;
					//exists = true;
					exists = (long)cmd.ExecuteScalar() > 0;
					//MessageBox.Show(exists.ToString());
					/*MySqlDataReader read = cmd.ExecuteReader();
					MessageBox.Show(read.ToString());*/

					if (exists)
					{
						textBoxUser.Text = "Uporabniško ime že obstaja!";
						textBoxUser.ForeColor = System.Drawing.Color.Red;
						DBconnect.Close();
					}
					else
					{
						string query = "INSERT INTO uporabniki (id,uporabnisko_ime,geslo, email, rank) VALUES (NULL,'" + textBoxUser.Text + "','" + textBoxPass.Text + "', 'a@gmail.com',"+rank+ ")";
						MySqlCommand dbcommand = new MySqlCommand(query, DBconnect);
						dbcommand.CommandTimeout = 60;
						try
						{
							//DBconnect.Open();
							MySqlDataReader myReader = dbcommand.ExecuteReader();
							MessageBox.Show("Registracija uspešna!");
							//MessageBox.Show(myReader.ToString());
							DBconnect.Close();

							textBoxUser.Text = "Vnesi uporabniško ime";
							textBoxUser.ForeColor = SystemColors.ScrollBar;
							textBoxPass.Text = "Vnesi geslo";
							textBoxPass.ForeColor = SystemColors.ScrollBar;
							textBoxPass.PasswordChar = '\0';
							buttonReg_Click(sender, e);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}

			}


			else if (mode == 0)
			{
				DBconnect.Open();
				bool success = false;
				string check = "SELECT count(*) FROM uporabniki WHERE (uporabnisko_ime = @uporabnisko_ime) AND (geslo = @geslo)";
				MySqlCommand com = new MySqlCommand(check, DBconnect);

				com.Parameters.AddWithValue("uporabnisko_ime", textBoxUser.Text);
				com.Parameters.AddWithValue("geslo", textBoxPass.Text);

				success = (long)com.ExecuteScalar() > 0;
				if (success)
				{
					user = textBoxUser.Text;
					MessageBox.Show("Prijava uspešna!");
					new Home().Show();
					Visible = false;
				}
				else
				{
					MessageBox.Show("Napačno uporabniško ime ali geslo!");
					textBoxUser.Text = "Vnesi uporabniško ime";
					textBoxUser.ForeColor = SystemColors.ScrollBar;
					textBoxPass.Text = "Vnesi geslo";
					textBoxPass.ForeColor = SystemColors.ScrollBar;
					textBoxPass.PasswordChar = '\0';
				}
				DBconnect.Close();

			}
		}

		private void buttonReg_Click(object sender, EventArgs e)
		{
			if (mode == 0)
			{
				labelHead.Text = "Vnesi podatke za registracijo";
				buttonPrijava.Text = "Registracija";
				buttonReg.Text = "Prijava";
				mode = 1;
				checkBox1.Visible = true;
			}

			else if (mode == 1)
			{
				labelHead.Text = "Vnesi podatke za prijavo";
				buttonPrijava.Text = "Prijava";
				buttonReg.Text = "Registracija";
				mode = 0;
			}

		}

		private void textBoxUser_TextChanged(object sender, EventArgs e)
		{

		}

		private void labelHead_Click(object sender, EventArgs e)
		{

		}

		private void textBoxPass_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBoxUser_Click(object sender, EventArgs e)
		{
			if (textBoxUser.ForeColor == SystemColors.ScrollBar || textBoxUser.ForeColor == System.Drawing.Color.Red)
			{
				textBoxUser.Clear();
				textBoxUser.ForeColor = SystemColors.ControlText;
			}
		}

		private void textBoxPass_Click(object sender, EventArgs e)
		{
			if (textBoxPass.ForeColor == SystemColors.ScrollBar || textBoxPass.ForeColor == System.Drawing.Color.Red)
			{
				textBoxPass.Clear();
				textBoxPass.ForeColor = SystemColors.ControlText;
				textBoxPass.PasswordChar = '•';
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				rank = 1;
			}
			else if (!checkBox1.Checked)
			{
				rank = 0;
			}
		}
	}
}
	

