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
    public partial class Main : Form
    {
        public static int dlg = 0; //переменная определения диалогового окна

        public Main()
        {
            InitializeComponent();
        }
        public static string connStr = "server=localhost;user=root;database=Avtosalon;password=;SslMode=none";  // строка подключения к БД
         //--------------ПОДКЛЮЧЕНИЕ К БАЗЕ
         // создаём объект для подключения к БД
         MySqlConnection conn = new MySqlConnection(connStr);
            


        public static int id ;


        public void Main_Load(object sender, EventArgs e)
        {
            // устанавливаем соединение с БД
            conn.Open();
            MessageBox.Show("Статус соединения с БД: " + conn.State.ToString());
            conn.Close();

           
            автомобильToolStripMenuItem_Click(sender, e);  //по умолчанию переходим в диалог автомобили
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автосалон БД \n Моя супер прога");
        }

        public void клиенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            groupBox1.Text = "Клиент";
            dlg = 1;
            conn.Open();

            //ЗАГРУЖАЕМ ТАБЛИЦУ Клиентов
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from Klient", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "Klient");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид клиента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Паспорт";
            dataGridView1.Columns[5].HeaderText = "Адрес";
        }

        public void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            groupBox1.Text = "Услуги";
            dlg = 2;
            conn.Open();

            //ЗАГРУЖАЕМ ТАБЛИЦУ Услуг
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from Uslugi", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "Uslugi");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид услуги";
            dataGridView1.Columns[1].HeaderText = "Услуга";
            dataGridView1.Columns[2].HeaderText = "Стоимость";
        }

        public void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            groupBox1.Text = "Персонал";
            dlg = 3;
            conn.Open();

            //ЗАГРУЖАЕМ ТАБЛИЦУ Персонала
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from sotrudnik", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "sotrudnik");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид клиента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Паспорт";
            dataGridView1.Columns[5].HeaderText = "Адрес";
            dataGridView1.Columns[6].HeaderText = "Должность";

        }

        public void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            groupBox1.Text = "Автомобиль";
            dlg = 4;
            conn.Open();

            //ЗАГРУЖАЕМ ТАБЛИЦУ Автомобилей
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from Avto", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "Avto");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид авто";
            dataGridView1.Columns[1].HeaderText = "Номер кузова";
            dataGridView1.Columns[2].HeaderText = "Номер ПТС";
            dataGridView1.Columns[3].HeaderText = "Номер двигателя";
            dataGridView1.Columns[4].HeaderText = "Марка";
            dataGridView1.Columns[5].HeaderText = "Цвет";
            dataGridView1.Columns[6].HeaderText = "Дата посупления";
            dataGridView1.Columns[7].HeaderText = "Дата выпуска";
            dataGridView1.Columns[8].HeaderText = "Комплектация";
            dataGridView1.Columns[9].HeaderText = "Ид договра";
            dataGridView1.Columns[10].HeaderText = "Цена автомобиля";
        }

       

        public void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.Close();
            groupBox1.Text = "Договор";
            dlg = 5;
            conn.Open();

            //ЗАГРУЖАЕМ ТАБЛИЦУ Договор
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from dogovor", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "dogovor");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид договора";
            dataGridView1.Columns[1].HeaderText = "Дата оформления";
            dataGridView1.Columns[2].HeaderText = "Оплата";
            dataGridView1.Columns[3].HeaderText = "Ид клиента";
            dataGridView1.Columns[4].HeaderText = "Ид сторудника";      
           
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (dlg == 1) {клиенToolStripMenuItem_Click(sender,  e);}
            if (dlg == 2) { услугиToolStripMenuItem_Click(sender, e); }
            if (dlg == 3) { персоналToolStripMenuItem_Click(sender, e); }
            if (dlg == 4) { автомобильToolStripMenuItem_Click(sender, e); }
            if (dlg == 5) { договорToolStripMenuItem_Click(sender, e); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

            Update MyUp = new Update();
            MyUp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            Insert MyIns = new Insert();
            MyIns.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

           













        }

       

    }
}
