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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }


        public static string connStr = "server=localhost;user=root;database=Avtosalon;password=;SslMode=none";  // строка подключения к БД
        
       
        //--кнопка апдейта
        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "";


            if (Main.dlg == 5)
            {
                Query = "update dogovor set id_dogovora='" + this.textBox1.Text +
                    "',data_oformlen='" + this.textBox2.Text +
                    "',oplata='" + this.textBox3.Text +
                    "',id_klienta='" + this.textBox4.Text +
                    "',id_sotr='" + this.textBox5.Text +
                    "' where id_dogovora='" + Main.id.ToString() + "';";
            }
            if (Main.dlg == 4)
            {
                Query = "update Avto set id_avto='" + this.textBox25.Text +
                    "',№_kyzova='" + this.textBox24.Text +
                    "',№_pts='" + this.textBox23.Text +
                    "',№_dvigatel='" + this.textBox22.Text +
                    "',marka='" + this.textBox21.Text +
                    "',cvet='" + this.textBox20.Text +
                    "',data_post='" + this.textBox19.Text +
                    "',data_vypysk='" + this.textBox18.Text +
                    "',komplect='" + this.textBox17.Text +
                    "',id_dogovora='" + this.textBox16.Text +
                    "',cena_a='" + this.textBox15.Text +
                    "' where id_avto='" + Main.id.ToString() + "';";
            }
            if (Main.dlg == 3)
            {
                Query = "update sotrudnik set id_sotr='" + this.textBox31.Text +
                    "',familia='" + this.textBox30.Text +
                    "',imya='" + this.textBox29.Text +
                    "',otchestvo='" + this.textBox28.Text +
                    "',pasport_dan='" + this.textBox27.Text +
                    "',adres='" + this.textBox26.Text +
                    "',dolgnost='" + this.textBox32.Text +
                    "' where id_sotr='" + Main.id.ToString() + "';";
            }
            if (Main.dlg == 2)
            {
                Query = "update Uslugi set id_uslugi='" + this.textBox14.Text +
                    "',vid='" + this.textBox13.Text +
                    "',cena='" + this.textBox12.Text +
                    "' where id_uslugi='" + Main.id.ToString() + "';";
            }
            if (Main.dlg == 1)
            {
                Query = "update Klient set id_klieta='" + this.textBox11.Text +
                    "',familia='" + this.textBox10.Text +
                    "',imya='" + this.textBox9.Text +
                    "',otchestvo='" + this.textBox8.Text +
                    "',pasport_dan='" + this.textBox7.Text +
                    "',adres='" + this.textBox6.Text +
                    "' where id_klieta='" + Main.id.ToString() + "';";
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
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
            MessageBox.Show("Данные изменены, выполните Обновить данные");
            this.Close();
        


        }

        public void Update_Load(object sender, EventArgs e)
        {
            string Query = "";
            if (Main.dlg == 5) { Query = "select  * from dogovor where id_dogovora='" + Main.id + "';"; }
            if (Main.dlg == 4) { Query = "select  * from Avto where id_avto='" + Main.id + "';"; }
            if (Main.dlg == 3) { Query = "select  * from sotrudnik where id_sotr='" + Main.id + "';"; }
            if (Main.dlg == 2) { Query = "select  * from Uslugi where id_uslugi='" + Main.id + "';"; }
            if (Main.dlg == 1) { Query = "select  * from Klient where id_klieta='" + Main.id + "';"; }


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

                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                //достаём данные по договорам
                conn.Open();
                MySqlCommand thisCommand = conn.CreateCommand();
                thisCommand.CommandText = @"" + Query + "";
                MySqlDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    if (Main.dlg == 5)
                    {
                        textBox1.Text = thisReader[0].ToString();
                        textBox2.Text = thisReader[1].ToString();
                        textBox3.Text = thisReader[2].ToString();
                        textBox4.Text = thisReader[3].ToString();
                        textBox5.Text = thisReader[4].ToString();
                    }
                    if (Main.dlg == 1)
                    {
                        textBox11.Text = thisReader[0].ToString();
                        textBox10.Text = thisReader[1].ToString();
                        textBox9.Text = thisReader[2].ToString();
                        textBox8.Text = thisReader[3].ToString();
                        textBox7.Text = thisReader[4].ToString();
                        textBox6.Text = thisReader[5].ToString();
                    }
                    if (Main.dlg == 2)
                    {
                        textBox14.Text = thisReader[0].ToString();
                        textBox13.Text = thisReader[1].ToString();
                        textBox12.Text = thisReader[2].ToString();
                    }
                    if (Main.dlg == 4)
                    {
                        textBox25.Text = thisReader[0].ToString();
                        textBox24.Text = thisReader[1].ToString();
                        textBox23.Text = thisReader[2].ToString();
                        textBox22.Text = thisReader[3].ToString();
                        textBox21.Text = thisReader[4].ToString();
                        textBox20.Text = thisReader[5].ToString();
                        textBox19.Text = thisReader[6].ToString();
                        textBox18.Text = thisReader[7].ToString();
                        textBox17.Text = thisReader[8].ToString();
                        textBox16.Text = thisReader[9].ToString();
                        textBox15.Text = thisReader[10].ToString();
                    }
                    if (Main.dlg == 3)
                    {
                        textBox31.Text = thisReader[0].ToString();
                        textBox30.Text = thisReader[1].ToString();
                        textBox29.Text = thisReader[2].ToString();
                        textBox28.Text = thisReader[3].ToString();
                        textBox27.Text = thisReader[4].ToString();
                        textBox26.Text = thisReader[5].ToString();
                        textBox32.Text = thisReader[6].ToString();
                    }

                }
                thisReader.Close();
                conn.Close();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                string Query = "";
           if( Main.dlg == 5)   { Query = "delete from dogovor where id_dogovora='" + Main.id + "';";}
           if( Main.dlg == 4)   {  Query = "delete from Avto where id_avto='" + Main.id + "';";}
           if (Main.dlg == 3) {  Query = "delete from sotrudnik where id_sotr='" + Main.id + "';"; }
           if( Main.dlg == 2)     { Query = "delete from Uslugi where id_uslugi='" + Main.id + "';";}
           if( Main.dlg == 1)      { Query = "delete from Klient where id_klieta='" + Main.id + "';";}
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
            MessageBox.Show("Данные удалены, выполните Обновить данные");
            this.Close();
        }
    }
}
