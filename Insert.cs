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
using System.Xml;
using System.Xml.Serialization;

namespace Бибика
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }
        public static string connStr = "server=localhost;user=root;database=Avtosalon;password=;SslMode=none";  // строка подключения к БД

        private void Insert_Load(object sender, EventArgs e)
        {
            if (Main.dlg == 5)
            {
                groupBox1.Visible = true;
            }
            if (Main.dlg == 4)
            {
                groupBox5.Visible = true;
            }
            if (Main.dlg == 3)
            {
                groupBox4.Visible = true;
            }
            if (Main.dlg == 1)
            {
                groupBox2.Visible = true;
            }
            if (Main.dlg == 2)
            {
                groupBox3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                string Query = "";
                if (Main.dlg == 5)
                {
                    Query = "insert into dogovor values('"
                        + this.textBox1.Text + "','"
                        + this.textBox2.Text + "','"
                        + this.textBox3.Text + "','"
                        + this.textBox4.Text + "','"
                        + this.textBox5.Text + "');";
                }
                if (Main.dlg == 4) { Query = "insert into Avto values('"
                   + this.textBox25.Text + "','"
                        + this.textBox24.Text + "','"
                        + this.textBox23.Text + "','"
                        + this.textBox22.Text + "','"
                        + this.textBox21.Text + "','"
                        + this.textBox20.Text + "','"
                        + this.textBox19.Text + "','"
                        + this.textBox18.Text + "','"
                        + this.textBox17.Text + "','"
                        + this.textBox16.Text + "','"
                        + this.textBox15.Text +  "');"; }
                if (Main.dlg == 3)
                {
                    Query = "insert into sotrudnik values('"
                        + this.textBox31.Text + "','"
                        + this.textBox30.Text + "','"
                        + this.textBox29.Text + "','"
                        + this.textBox28.Text + "','"
                        + this.textBox27.Text + "','"
                        + this.textBox26.Text + "','"
                        + this.textBox32.Text + "');";
                }
                if (Main.dlg == 2)
                {
                    Query = "insert into Uslugi values('"
                        + this.textBox14.Text + "','"
                        + this.textBox13.Text + "','"
                        + this.textBox12.Text + "');";
                }
                if (Main.dlg == 1)
                {
                    Query = "insert into Klient values('"
                        + this.textBox11.Text + "','"
                        + this.textBox10.Text + "','"
                        + this.textBox9.Text + "','"
                        + this.textBox8.Text + "','"
                        + this.textBox7.Text + "','"
                        + this.textBox6.Text + "');";
                }
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                MySqlDataReader MyReader2;
                conn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                conn.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Данные добавлены, выполните Обновить данные");
            this.Close();
        }
    }
}
