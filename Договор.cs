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

namespace Бибика
{
    public partial class Договор : Form
    {
        public Договор()
        {
            InitializeComponent();
        }

        public static string connStr = "server=localhost;user=root;database=Avtosalon;password=;SslMode=none";  // строка подключения к БД
        public static string id_dogovora = "";
        public static string data_oformlen = "";
        public static string oplata = "";
        public static string id_klienta = "";
        public static string id_sotr = "";


        private void Form1_Load(object sender, EventArgs e)
        {

           
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;


            //////////////////////
            //ПОДКЛЮЧЕНИЕ К БАЗЕ//
            //////////////////////
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(Договор.connStr);
            // устанавливаем соединение с БД
            conn.Open();

            //ЗАГРУЖАЕМ ТАБЛИЦУ Договор
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from dogovor", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "dogovor");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид договора";
            dataGridView1.Columns[1].HeaderText = "Дата оформления";
            dataGridView1.Columns[2].HeaderText = "Оплата";
            dataGridView1.Columns[3].HeaderText = "Ид клиента";
            dataGridView1.Columns[4].HeaderText = "Ид сторудника";
           
            
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
           Сотрудники MyПерсонал = new Сотрудники();
            MyПерсонал.ShowDialog();
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Изменить_Click(object sender, EventArgs e)
        {

        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Договор.connStr);
            // устанавливаем соединение с БД
            conn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from avto", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "avto");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид авто";
            dataGridView1.Columns[1].HeaderText = "№ Кузова";
            dataGridView1.Columns[2].HeaderText = "№ Pts";
            dataGridView1.Columns[3].HeaderText = "Ид клиента";
            dataGridView1.Columns[4].HeaderText = "Ид сторудника";
            conn.Close();


            Hide();
            Автомобиль MyДоговор = new Автомобиль();
            MyДоговор.ShowDialog();



            Close();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Клиент MyКлиент = new Клиент();
            MyКлиент.ShowDialog();
            Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Услуги MyУслуги = new Услуги();
            MyУслуги.ShowDialog();
            Close();
        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Добавить_договор MyАвтомобиль = new Добавить_договор();
            MyАвтомобиль.ShowDialog();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Договор.connStr);
            conn.Open();


        }
    }
}
