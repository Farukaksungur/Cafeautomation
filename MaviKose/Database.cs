using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MaviKose
{
    class Database
    {
        public static MySqlConnection baglan = new MySqlConnection("Server=79.98.129.61;Database=markasay_deneme;Uid=markasay_deneme;Pwd='Odalar123.';");
        public void Ac()
        {
            if (baglan.State != System.Data.ConnectionState.Open)
            {
                try
                {

                    baglan.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void Kapat()
        {
            baglan.Close();
        }
    }
}
