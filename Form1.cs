using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spendenlauf
{
    public partial class Form1 : Form
    {
        public MySqlConnection conn;
        public String color;
        private Random r = new Random();
        private List<string> names = new List<string>();
        public Form1()
        {
            // Form Setup
            InitializeComponent();


            // MySQl Connection
            string myConnectionString = "server=example.com;uid=mydbuser;" +
                "pwd=mydbuserpassword;database=mydb;";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Application.Exit();
            }

            // Show only the login box
            eingabe.Visible = false;
            ausgabe.Visible = false;
            outbox.Visible = false;
            this.AcceptButton = loginbutton;

        }

        /**
         * Display the right panel after a simple authentifikation check
         * */
        private void loginbutton_Click(object sender, EventArgs e)
        {
            // Show panel to count rounds
            if (pinbox.Text.Equals("9928280"))
            {
                login.Visible = false;
                eingabe.Visible = true;
                this.AcceptButton = add;
                nr.Focus();
                return;
            }
            // Show panel to search for users
            if (pinbox.Text.Equals("992818"))
            {
                listBox1.SelectedItem = "Nummer";
                login.Visible = false;
                ausgabe.Visible = true;
                ausgabe_in.Focus();
                this.AcceptButton = ausgabeaccept;
                return;
            }
            // Show panel to create a new user
            if (pinbox.Text.Equals("992899"))
            {
                login.Visible = false;
                ausgabe.Visible =false;
                eingabe.Visible = false;
                groupBox.Visible = true;
                this.AcceptButton = addbutton;
                return;
            }
            // Call a test function! Be aware! This could be everything
            if (pinbox.Text.Equals("9928283"))
            {
                test();
                return;
            }
            // Show the top 10 leaderboard
            if (pinbox.Text.Equals("992831"))
            {
                new Top10(this, conn).Show();
                this.Hide();
                return;
            }

            pinbox.Text = "";
            MessageBox.Show("Ungültiger Pin!","Fehler!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void test()
        {
            timer1.Enabled = true;
        }

        /**
         * This timer is used to randomly populate the database with round.
         * Use this to test your setup but keep in mind, that this IS changing the live/produktiv data
         * */
        private void timer1_Tick(object sender, EventArgs e)
        {
            add_Round("" + r.Next(1, 1000));
            timer1.Interval = r.Next(100,2000);
        }

        /**
         * OnClick for the add Button in the Main Window
         * adds a round for the number currently in the textbox and resets the textbox
         * */
        private void add_Click(object sender, EventArgs e)
        {
            add_Round(nr.Text);
            
            nr.Text = "";
            nr.Focus();
        }

        /**
         * Writes the new round into the database
         * Logs the result in the outbox
         * */
        private void add_Round(String number)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE `rounds` SET `runden`=`runden`+1 "
               + "WHERE `nummer`=" + number;
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "INSERT INTO `timestamps`(`nummer`) VALUES ('" + number + "')";
            cmd2.ExecuteNonQuery();
            outbox.Visible = true;
            outbox.AppendText(Environment.NewLine + "Dem Läufer " + number + " wurde eine Runde hinzugefügt!");
        }

        /**
         * Searches the database for a person based on different options
         * If 'Nummer' or 'Name': Display the details for this person
         * */
        private void ausgabeaccept_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            switch (listBox1.SelectedItem.ToString())
            {
                case "Nummer":
                    cmd.CommandText = "SELECT * FROM `rounds` WHERE `nummer`= "+ausgabe_in.Text;
                    break;
                case "Klasse":
                    cmd.CommandText = "SELECT * FROM `rounds` WHERE `klasse`='"+ausgabe_in.Text+"'";
                    readclass(cmd,ausgabe_in.Text);
                    return;
                case "Name":
                    String[] name = ausgabe_in.Text.Split(new Char[]{','});
                    if (name.Length != 2)
                    {
                        MessageBox.Show("Ungültiges Format!", "Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                    cmd.CommandText = "SELECT * FROM `rounds` WHERE `name`='"+name[0].Trim()
                        +"' AND `vorname` = '"+name[1].Trim()+"'";
                    break;
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                last.Visible = true;
                last_name.Text = reader.GetString("name") + ", " + reader.GetString("vorname");
                last_klasse.Text = reader.GetString("klasse");
                last_nr.Text = ""+reader.GetInt16("nummer");
                last_runden.Text = "" + reader.GetInt16("runden");

                ausgabe_in.Text = "";
            }
            else
            {
                MessageBox.Show("Konnte nichts finden!", "Spendenlauf",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ausgabe_in.Text = "";
            }
            reader.Close();
        }

        /**
         * Add all people of the klasse into a listbox
         * */
        private void readclass(MySqlCommand cmd,string klasse)
        {
            ausgabeout.Visible = true;
            names.Clear();
            ausgabeout.Items.Clear();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                string s = reader.GetString("name") + ", " + reader.GetString("vorname");
                ausgabeout.Items.Add(s);
            }
            reader.Close();
        }


        /**
         * Create a new person in the db
         * Used by Admin Panel
         * */
        private void addbutton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `rounds`(`name`, `vorname`, `klasse`) VALUES ('" + nachname.Text + "','" 
                + vorname.Text+ "','"+klasse.SelectedItem+"')";
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "SELECT `nummer` FROM `rounds` WHERE `name`='"+nachname.Text+"' AND `vorname`='"+vorname.Text+"'";
            int nummer = (int) cmd2.ExecuteScalar();
            MessageBox.Show("Laufer mit der Nummer: "+nummer+" hinzugefügt","Spendenlauf",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            vorname.Text = "";
            nachname.Text = "";
            vorname.Focus();
        }

        /**
         * Blocks the writing of non-digit numbers (not 0-9) into the search textfield if number is selected
         * Used by the Ausgabe Panel
         * */
        private void ausgabenr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (listBox1.SelectedItem.Equals("Nummer"))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            
        }

        /**
         * Blocks the writing of non-digit numbers (not 0-9) into the nummer textfield
         * Used by the Main Panel
         * */
        private void nr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /**
         * Change the Size of the input textfield based on the expected input
         * Used by Ausgabe Panel
         * */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ausgabeout.Visible = false;
            formatlabel.Visible = false;
            ausgabe_in.Text = "";
            if (listBox1.SelectedItem.Equals("Nummer"))
            {
                ausgabe_in.Size = new Size(45,25);
            }
            if (listBox1.SelectedItem.Equals("Name"))
            {
                formatlabel.Visible = true;
                ausgabe_in.Size = new Size(150, 25);
            }
            if (listBox1.SelectedItem.Equals("Klasse"))
            {
                ausgabe_in.Size = new Size(45, 25);
            }
        }

        /**
         * Get and display the details for a person in the class listbox
         * */
        private void ausgabeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String[] name = ausgabeout.SelectedItem.ToString().Split(new Char[] { ',' });
            cmd.CommandText = "SELECT * FROM `rounds` WHERE `name`='" + name[0].Trim()
                        + "' AND `vorname` = '" + name[1].Trim() + "'";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                last.Visible = true;
                last_name.Text = reader.GetString("name") + ", " + reader.GetString("vorname");
                last_klasse.Text = reader.GetString("klasse");
                last_nr.Text = "" + reader.GetInt16("nummer");
                last_runden.Text = "" + reader.GetInt16("runden");

                ausgabe_in.Text = "";
            }
            reader.Close();
        }


    }
}
