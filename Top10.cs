using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Spendenlauf
{
    public partial class Top10 : Form
    {
        private Form1 form1;
        private MySql.Data.MySqlClient.MySqlConnection conn;

        public Top10(Form1 form1)
        {
           
            this.form1 = form1;
            reload();
        }

        public Top10(Form1 form1, MySql.Data.MySqlClient.MySqlConnection conn)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.form1 = form1;
            this.conn = conn;
            reload();
        }

        /**
         * Display the top 10 runners
         * */
        private void reload()
        {
            int i = 0;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `rounds` ORDER BY `runden` DESC LIMIT 10";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i = i + 1;
                if (i <= 10)
                {
                    switch (i)
                    {
                        case 1:
                            name1.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden1.Text = "" + reader.GetInt16("runden");
                            break;
                        case 2:
                            name2.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden2.Text = "" + reader.GetInt16("runden");
                            break;
                        case 3:
                            name3.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden3.Text = "" + reader.GetInt16("runden");
                            break;
                        case 4:
                            name4.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden4.Text = "" + reader.GetInt16("runden");
                            break;
                        case 5:
                            name5.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden5.Text = "" + reader.GetInt16("runden");
                            break;
                        case 6:
                            name6.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden6.Text = "" + reader.GetInt16("runden");
                            break;
                        case 7:
                            name7.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden7.Text = "" + reader.GetInt16("runden");
                            break;
                        case 8:
                            name8.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden8.Text = "" + reader.GetInt16("runden");
                            break;
                        case 9:
                            name9.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden9.Text = "" + reader.GetInt16("runden");
                            break;
                        case 10:
                            name10.Text = reader.GetString("vorname") + " " + reader.GetString("name");
                            runden10.Text = "" + reader.GetInt16("runden");
                            break;
                    }
                }
                else
                {
                    timelabel.Text = "Stand: "+System.DateTime.Now.ToString();
                    reader.Close();
                    return;
                }
            }
        }

        /**
         * Timer tick to reload/refresh the table
         * */
        private void timer1_Tick(object sender, EventArgs e)
        {
            reload();
        }

        private void Top10_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Close();
        }
    }
}
