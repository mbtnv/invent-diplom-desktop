using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarisation
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        public static string fio;

        public string TxtBox
        {
            get { return login.Text; }
        }

        public bool trylogin(string login, string pass)
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root;database=mybase");
            MySqlCommand cmd = new MySqlCommand("SELECT fio FROM auth WHERE login = '" + login + "'AND pass = '" + pass + "';");
            cmd.Connection = con;
            con.Open();
            fio = (string)cmd.ExecuteScalar();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                if (reader.IsDBNull(0) == true)
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
                else
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trylogin(login.Text, password.Text) == true)
            {
                //MessageBox.Show(fio);
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль");
            }
        }

        }
    }

