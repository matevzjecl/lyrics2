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

namespace lyrics2
{
    public partial class Home : Form
    {
        public int userID;
        public long avtorID;
        public int albumID;
        public int naslovID;
        public int APID;
        public int change = 0;

        string user1;
        //Public Server
        public static string connectString = "datasource=den1.mysql6.gear.host;username=lyrics;password=Wd40I11~-5gj;database=lyrics;";
        //Local Server
        //public static string connectString = "datasource=localhost;username=root;password=;database=lyrics;";
        MySqlConnection DBconnect = new MySqlConnection(connectString);
        

        public Home()
        {
            
            InitializeComponent();
        }

        public string naslov;
        public string avtor;


        private void Home_Load(object sender, EventArgs e)

        {
            user1 = Form1.user;
            label1.Text = label1.Text + user1;
            populate();

        }

        void populate()
        {

            using (DBconnect)
            {
               
                DBconnect.Open();
                using (MySqlCommand select = new MySqlCommand("SELECT p.id AS id, p.ime AS naslov, a.ime AS avtor FROM pesmi p INNER JOIN avtorji a ON p.avtor_id=a.id INNER JOIN uporabniki u ON p.uporabnik_id=u.id WHERE(u.uporabnisko_ime = '" + user1 + "')", DBconnect))
                {
                    MySqlDataAdapter dAdapter = new MySqlDataAdapter();

                    DataTable dt = new DataTable();
                    dAdapter.SelectCommand = select;
                    dAdapter.Fill(dt);
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {

                            dt.Columns.Add("naslovAvtor", typeof(string), "naslov + ' - ' + avtor");
                           
                            dropdown.DataSource = dt;

                            dropdown.ValueMember = "id";
                            dropdown.DisplayMember = "naslovAvtor";
                           

                            dropdown.Enabled = true;
                        }
                        else if (dt.Rows.Count <= 0)
                        {
                            dropdown.Enabled = false;
                            dropdown.Text = "Nimate nobenih besedil";
                        }
                    }
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (DBconnect)
            {
                DBconnect.Open();
                using (MySqlCommand check = new MySqlCommand("SELECT * FROM avtorji a INNER JOIN pesmi p ON p.avtor_id=a.id WHERE (a.ime=@avtor) && (p.ime=@naslov)", DBconnect))
                {
                    bool existsA;
                    check.Parameters.AddWithValue("naslov", textBoxNaslov.Text);
                    check.Parameters.AddWithValue("avtor", textBoxAvtor.Text);
                    existsA = (int?)check.ExecuteScalar() > 0;

                    if (existsA)
                    {
                        MessageBox.Show("Besedilo že obstaja!");
                    }
                    else if (!existsA)
                    {


                        using (MySqlCommand selectAv = new MySqlCommand("SELECT * FROM avtorji WHERE ime=@avtor LIMIT 1", DBconnect))
                        {
                            bool exists;
                            selectAv.Parameters.AddWithValue("avtor", textBoxAvtor.Text);

                            exists = (int?)selectAv.ExecuteScalar() > 0;
                            if (!exists)
                            {
                                using (MySqlCommand insertAv = new MySqlCommand("INSERT INTO avtorji (ime) VALUES(@avtor)", DBconnect))
                                {

                                    insertAv.Parameters.AddWithValue("avtor", textBoxAvtor.Text);
                                   
                                    insertAv.ExecuteNonQuery();

                                }
                            }

                        }

                        using (MySqlCommand selectAl = new MySqlCommand("SELECT count(*) FROM albumi WHERE ime=@album LIMIT 1", DBconnect))
                        {
                            bool exists;
                            selectAl.Parameters.AddWithValue("album", textBoxAlbum.Text);

                            exists = (long)selectAl.ExecuteScalar() > 0;
                            if (!exists)
                            {

                                using (MySqlCommand insertAl = new MySqlCommand("INSERT INTO albumi (ime, leto) VALUES(@album, @leto)", DBconnect))
                                {

                                    insertAl.Parameters.AddWithValue("album", textBoxAlbum.Text);
                                    insertAl.Parameters.AddWithValue("leto", textBoxLeto.Text);

                                    insertAl.ExecuteNonQuery();

                                }
                            }


                        }


                        using (MySqlCommand selectAl = new MySqlCommand("SELECT count(*) FROM albumi WHERE ime=@album LIMIT 1", DBconnect))
                        {
                            bool exists;
                            selectAl.Parameters.AddWithValue("album", textBoxAlbum.Text);

                            exists = (long)selectAl.ExecuteScalar() > 0;
                            if (!exists)
                            {



                                using (MySqlCommand insertAl = new MySqlCommand("INSERT INTO albumi (ime, leto) VALUES(@album, @leto)", DBconnect))
                                {

                                    insertAl.Parameters.AddWithValue("album", textBoxAlbum.Text);
                                    insertAl.Parameters.AddWithValue("leto", textBoxLeto.Text);

                                    insertAl.ExecuteNonQuery();
                                    Task.Delay(5000);
                                }
                            }
                        }
                        using (MySqlCommand selectU = new MySqlCommand("SELECT id FROM uporabniki WHERE(uporabnisko_ime = @user)", DBconnect))
                        {
                            selectU.Parameters.AddWithValue("user", user1);
                            using (MySqlDataReader reader = selectU.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    userID = reader.GetInt16(0);
                                }
                            }
                        }
                        using (MySqlCommand selectA = new MySqlCommand("SELECT id FROM avtorji WHERE(ime = @avtor)", DBconnect))
                        {
                            selectA.Parameters.AddWithValue("avtor", textBoxAvtor.Text);
                            using (MySqlDataReader reader = selectA.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    avtorID = reader.GetInt16(0);
                                }
                            }
                        }
                        using (MySqlCommand insert = new MySqlCommand("INSERT INTO pesmi (uporabnik_id, avtor_id, ime, url, besedilo) VALUES(@user, @avtor, @naslov, @url, @besedilo)", DBconnect))
                        {

                            insert.Parameters.AddWithValue("user", userID);
                            insert.Parameters.AddWithValue("avtor", avtorID);
                            insert.Parameters.AddWithValue("naslov", textBoxNaslov.Text);
                            insert.Parameters.AddWithValue("url", textBoxURL.Text);
                            insert.Parameters.AddWithValue("besedilo", textBoxBesedilo.Text);

                            insert.ExecuteNonQuery();
                            Task.Delay(5000);

                        }
                        using (MySqlCommand selectU = new MySqlCommand("SELECT id FROM albumi WHERE(ime = @album)", DBconnect))
                        {
                            selectU.Parameters.AddWithValue("album", textBoxAlbum.Text);
                            using (MySqlDataReader reader = selectU.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    albumID = reader.GetInt16(0);
                                }
                            }
                        }
                        using (MySqlCommand selectA = new MySqlCommand("SELECT id FROM pesmi WHERE(ime = @naslov)", DBconnect))
                        {
                            selectA.Parameters.AddWithValue("naslov", textBoxNaslov.Text);
                            using (MySqlDataReader reader = selectA.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    naslovID = reader.GetInt16(0);
                                }
                            }
                        }

                        using (MySqlCommand insertAP = new MySqlCommand("INSERT INTO albumi_pesmi (album_id, pesem_id) VALUES (@album, @naslov)", DBconnect))
                        {


                            insertAP.Parameters.AddWithValue("album", albumID);
                            insertAP.Parameters.AddWithValue("naslov", naslovID);

                            using (MySqlDataReader reader6 = insertAP.ExecuteReader())
                            {


                                MessageBox.Show("Uspešen Vnos");

                            }
                        }
                    }
                }
            }
            populate();
        }

        private void dropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /* string naslov = dropdown.Text.Substring(0, (dropdown.Text.LastIndexOf('-') - 1));
             string avtor = dropdown.Text.Substring(dropdown.Text.LastIndexOf('-') + 1);

             textBoxAvtor.Text = avtor;
             textBoxNaslov.Text = naslov;
             change = 1;*/
            fill();
            buttonDelete.Enabled = true;

        }

        void fill()
        {
            string naslov = dropdown.Text.Substring(0, (dropdown.Text.LastIndexOf('-') - 1));
            string avtor = dropdown.Text.Substring(dropdown.Text.LastIndexOf('-')+2);

            textBoxAvtor.Text = avtor;
            textBoxNaslov.Text = naslov;                                 

            using (DBconnect)
            {
                DBconnect.Open();
                using (MySqlCommand selectAl = new MySqlCommand("SELECT p.id AS id, a.ime AS album, a.leto AS leto FROM albumi a INNER JOIN albumi_pesmi ap ON ap.album_id=a.id INNER JOIN pesmi p ON p.id=ap.pesem_id WHERE (p.ime=@naslov)",DBconnect))
                {
                    selectAl.Parameters.AddWithValue("naslov", naslov);
                    using (MySqlDataReader reader = selectAl.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            string album = (string)reader["album"];
                            int leto = (int)reader["leto"];
                            naslovID = (int)reader["id"];
                            textBoxAlbum.Text = album;
                            textBoxLeto.Text = leto.ToString();
                        }
                        
                    }
                }

                using (MySqlCommand selectP = new MySqlCommand("SELECT url, besedilo FROM pesmi WHERE (ime=@naslov)",DBconnect))
                {
                    selectP.Parameters.AddWithValue("naslov", naslov);
                    using (MySqlDataReader reader = selectP.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string url = (string)reader["url"];
                            string besedilo = (string)reader["besedilo"];
                            textBoxBesedilo.Text = besedilo;
                            textBoxURL.Text = url;
                        }

                    }
                }
            }


            change = 1;
        }

        private void dropdown_Click(object sender, EventArgs e)
        {
            fill();
            buttonDelete.Enabled = true;
        }

        private void textBoxNaslov_TextChanged(object sender, EventArgs e)
        {
            if (change == 1)
            {
                buttonUpdate.Enabled = true;
                

            }

        }

        private void textBoxAvtor_TextChanged_1(object sender, EventArgs e)
        {
            if (change == 1)
            {
                buttonUpdate.Enabled = true;
             
            }

        }

        private void textBoxAlbum_TextChanged_1(object sender, EventArgs e)
        {
            if (change == 1)
            {
                buttonUpdate.Enabled = true;
             
            }

        }

        private void textBoxLeto_TextChanged_1(object sender, EventArgs e)
        {
            if (change == 1)
            {
                buttonUpdate.Enabled = true;
                
            }

        }

        private void textBoxURL_TextChanged_1(object sender, EventArgs e)
        {
            if (change == 1)
            {
                buttonUpdate.Enabled = true;
              
            }

        }
 

        private void textBoxBesedilo_TextChanged(object sender, EventArgs e)
        {
            if (change == 1)
            {
                buttonUpdate.Enabled = true;

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (DBconnect)
            {
                DBconnect.Open();
                /* if (AvtorChange == 1)
                 {
                     using (MySqlCommand updateAv = new MySqlCommand("UPDATE avtorji SET ime=@avtor WHERE(u.uporabnisko_ime = " + user1 + ")", DBconnect))
                     {

                     }
                 }*/

                using (MySqlCommand selectAv = new MySqlCommand("SELECT * FROM avtorji WHERE ime=@avtor LIMIT 1", DBconnect))
                {
                    bool exists;
                    
                   

                    selectAv.Parameters.AddWithValue("avtor", textBoxAvtor.Text);

                    exists = (int?)selectAv.ExecuteScalar() > 0;

                    if (!exists)
                    {
                        using (MySqlCommand insertAv = new MySqlCommand("INSERT INTO avtorji (ime) VALUES (@avtor)", DBconnect))
                        {
                            bool exists1;
                          
                            insertAv.Parameters.AddWithValue("avtor", textBoxAvtor.Text);
                            exists1 = (int?)insertAv.ExecuteScalar() > 0;



                            insertAv.ExecuteNonQuery();
                            avtorID = insertAv.LastInsertedId;


                        }
                    }
                    else if (exists)
                    {
                        using (MySqlDataReader reader = selectAv.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                avtorID = reader.GetInt16(0);
                            }
                        }
                        
                    }
                }


                using (MySqlCommand selectAl = new MySqlCommand("SELECT * FROM albumi WHERE ime=@album LIMIT 1", DBconnect))
                {
                    bool exists;
                    selectAl.Parameters.AddWithValue("album", textBoxAlbum.Text);

                    exists = (int?)selectAl.ExecuteScalar() > 0;

                    if (!exists)
                    {
                        using (MySqlCommand insertAl = new MySqlCommand("INSERT INTO albumi (ime, leto) VALUES (@album, @leto)", DBconnect))
                        {
                            insertAl.Parameters.AddWithValue("album", textBoxAlbum.Text);
                            insertAl.Parameters.AddWithValue("leto", textBoxLeto.Text);

                            insertAl.ExecuteNonQuery();
                        }
                    }
                    else if (exists)
                    {
                        using (MySqlDataReader reader = selectAl.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                albumID = reader.GetInt16(0);
                            }
                        }

                        using (MySqlCommand updateL = new MySqlCommand("UPDATE albumi SET leto=@leto WHERE (ime=@album)", DBconnect))
                        {
                            updateL.Parameters.AddWithValue("leto", textBoxLeto.Text);
                            updateL.Parameters.AddWithValue("album", textBoxAlbum.Text);
                            updateL.ExecuteNonQuery();
                        }

                    }
                }


                using (MySqlCommand update = new MySqlCommand("UPDATE pesmi SET uporabnik_id=(SELECT id FROM uporabniki WHERE (uporabnisko_ime=@user)), avtor_id=@avtorID, ime=@naslov, url=@url, besedilo=@besedilo WHERE (id=@naslovID)",DBconnect))
                {
                    MessageBox.Show("AvtorID: " + avtorID);
                    MessageBox.Show("NaslovID: " + naslovID);
                    update.Parameters.AddWithValue("user", user1);
                    update.Parameters.AddWithValue("avtorID", avtorID);
                    update.Parameters.AddWithValue("naslov", textBoxNaslov.Text);
                    update.Parameters.AddWithValue("besedilo", textBoxBesedilo.Text);
                    update.Parameters.AddWithValue("url", textBoxURL.Text);
                    update.Parameters.AddWithValue("naslovID", naslovID);

                    update.ExecuteNonQuery();
                }

                using (MySqlCommand selectAl = new MySqlCommand("SELECT * FROM albumi WHERE (ime=@album)",DBconnect))
                {
                    selectAl.Parameters.AddWithValue("album", textBoxAlbum.Text);
                    using (MySqlDataReader reader = selectAl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            albumID = reader.GetInt16(0);
                        }
                    }
                }

                using (MySqlCommand selectN = new MySqlCommand("SELECT * FROM pesmi WHERE (ime=@naslov)", DBconnect))
                {
                    selectN.Parameters.AddWithValue("naslov", textBoxNaslov.Text);

                    using (MySqlDataReader reader = selectN.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            naslovID = reader.GetInt16(0);
                        }
                    }
                }

                using (MySqlCommand selectAP = new MySqlCommand("SELECT * FROM albumi_pesmi WHERE (album_id=@albumID) && (pesem_id=@naslovID)", DBconnect))
                {
                    bool exists;
                    
                    
                    selectAP.Parameters.AddWithValue("naslovID", naslovID);
                    selectAP.Parameters.AddWithValue("albumID", albumID);

                    using (MySqlDataReader reader = selectAP.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            APID = reader.GetInt16(0);
                        }
                    }
                      

                    exists = (int?)selectAP.ExecuteScalar() > 0;


                        if (exists)
                        {
                            using (MySqlCommand updateAP = new MySqlCommand("UPDATE albumi_pesmi SET album_id=@albumID, pesem_id=@naslovID WHERE (id=id)", DBconnect))
                            {
                                updateAP.Parameters.AddWithValue("naslovID", naslovID);
                                updateAP.Parameters.AddWithValue("albumID", albumID);
                                updateAP.Parameters.AddWithValue("id", APID);

                            updateAP.ExecuteNonQuery();
                            }
                        }
                        else if (!exists)
                        {
                            using (MySqlCommand insertAP = new MySqlCommand("INSERT INTO albumi_pesmi (album_id, pesem_id) VALUES (@albumID, @naslovID)", DBconnect))
                            {
                                insertAP.Parameters.AddWithValue("naslovID", naslovID);
                                insertAP.Parameters.AddWithValue("albumID", albumID);

                                insertAP.ExecuteNonQuery();
                            }
                        }

                }

            }
            MessageBox.Show("Uspešno urejanje");
            populate();
            buttonUpdate.Enabled = false;
        }

        private void textBoxNaslov_Click(object sender, EventArgs e)
        {
            if(change==0)
            {
                textBoxNaslov.Clear();
            }
        }

        private void textBoxAvtor_Click(object sender, EventArgs e)
        {
            if (change == 0)
            {
                textBoxAvtor.Clear();
            }
        }

        private void textBoxAlbum_Click(object sender, EventArgs e)
        {
            if (change == 0)
            {
                textBoxAlbum.Clear();
            }
        }

        private void textBoxLeto_Click(object sender, EventArgs e)
        {
            if (change == 0)
            {
                textBoxLeto.Clear();
            }
        }

        private void textBoxURL_Click(object sender, EventArgs e)
        {
            if (change == 0)
            {
                textBoxURL.Clear();
            }
        }

        private void textBoxBesedilo_Click(object sender, EventArgs e)
        {
            if (change == 0)
            {
                textBoxBesedilo.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (DBconnect)
            {
                string naslov = dropdown.Text.Substring(0, (dropdown.Text.LastIndexOf('-') - 1));
                DBconnect.Open();

                using(MySqlCommand delete = new MySqlCommand("DELETE FROM pesmi WHERE (ime=@naslov)",DBconnect))
                {
                    delete.Parameters.AddWithValue("naslov", naslov);
                    delete.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Uspešno Brisanje");
            textBoxNaslov.Text = textBoxNaslov.Tag.ToString();
            textBoxAvtor.Text = textBoxNaslov.Tag.ToString();
            textBoxAlbum.Text = textBoxNaslov.Tag.ToString();
            textBoxLeto.Text = textBoxNaslov.Tag.ToString();
            textBoxURL.Text = textBoxNaslov.Tag.ToString();
            textBoxBesedilo.Text = textBoxNaslov.Tag.ToString();
            populate();
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill();
        }

        private void textBoxLeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
