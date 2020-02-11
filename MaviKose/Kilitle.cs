using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaviKose
{
    
    
    public partial class Kilitle : Form
    {

        string sifre = "123456";
        public Kilitle()
        {
            InitializeComponent();
        }

        private void Kilitle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==sifre)
            {
                mainpage main = new mainpage();
                main.Show();
                this.Hide();

            }
        }
    }
}
