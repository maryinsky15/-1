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
    public partial class Автомобиль : Form
    {
        public Автомобиль()
        {
            InitializeComponent();
        }

        public static string connStr = "server=localhost;user=root;database=Avtosalon;password=;SslMode=none";  // строка подключения к БД
        public static string id_avto = "";
        public static string _kyzova = "";
        public static string _pts = "";
        public static string _dvigatel = "";
        public static string markal = "";
        public static string cvet = "";
        public static string data_post = "";
        public static string data_vypysk = "";
        public static string komplect = "";
        public static string id_dogovora = "";
        public static string cena_a = "";


        private void Автомобиль_Load(object sender, EventArgs e)
        {


            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;


            //////////////////////
            //ПОДКЛЮЧЕНИЕ К БАЗЕ//
            //////////////////////
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(Автомобиль.connStr);
            // устанавливаем соединение с БД
            conn.Open();

            //ЗАГРУЖАЕМ ТАБЛИЦУ Договор
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from Avto", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "Avto");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //переименовываем столбцы
            dataGridView1.Columns[0].HeaderText = "Ид авто";
            dataGridView1.Columns[1].HeaderText = "Номер кузова";
            dataGridView1.Columns[2].HeaderText = "Номер ПТС";
            dataGridView1.Columns[3].HeaderText = "Номер двигателя";
            dataGridView1.Columns[4].HeaderText = "Марка";
            dataGridView1.Columns[4].HeaderText = "Цвет";
            dataGridView1.Columns[4].HeaderText = "Дата посупления";
            dataGridView1.Columns[4].HeaderText = "Дата выпуска";
            dataGridView1.Columns[4].HeaderText = "Комплектация";
            dataGridView1.Columns[4].HeaderText = "Ид договра";
            dataGridView1.Columns[4].HeaderText = "Цена автомобиля";
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Клиент MyКлиент = new Клиент();
            MyКлиент.ShowDialog();
            Close();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Услуги MyУслуги = new Услуги();
            MyУслуги.ShowDialog();
            Close();
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Сотрудники MyПерсонал = new Сотрудники();
            MyПерсонал.ShowDialog();
            Close();
        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(Автомобиль.connStr);
            // устанавливаем соединение с БД
            conn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter("Select * from Avto", conn);// параметры- команда для выполнения + connection;
            ad.Fill(ds, "Avto");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = ds.Tables[0];



            Hide();
            Договор MyАвтомобиль = new Договор();
            MyАвтомобиль.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Добавить_автомобиль MyАвтомобиль = new Добавить_автомобиль();
            MyАвтомобиль.ShowDialog();
            Close();
        }

        private void Автомобиль_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Договор.connStr);
            conn.Open();
        }
    }
}
