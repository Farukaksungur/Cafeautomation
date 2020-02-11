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

namespace MaviKose
{
    

    public partial class Form1 : Form
    {
        Database data = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Ac();
            MySqlCommand cmd = new MySqlCommand("SELECT * from kullanici WHERE k_user='"+textBox1.Text+ "'and k_pass='"+textBox2.Text+"'",Database.baglan);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                mainpage ana = new mainpage();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            data.Kapat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
