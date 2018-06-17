using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бибика
{
    public partial class Услуги : Form
    {
        public Услуги()
        {
            InitializeComponent();
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Сотрудники MyПерсонал = new Сотрудники();
            MyПерсонал.ShowDialog();
            Close();
        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Договор MyАвтомобиль = new Договор();
            MyАвтомобиль.ShowDialog();
            Close();
        }

        private void Услуги_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Добавить_услугу MyАвтомобиль = new Добавить_услугу();
            MyАвтомобиль.ShowDialog();
            Close();
        }
    }
}
