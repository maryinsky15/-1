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
    public partial class Клиент : Form
    {
        public Клиент()
        {
            InitializeComponent();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Услуги MyУслуги = new Услуги();
            MyУслуги.ShowDialog();
            Close();
        }

        private void договорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Автомобиль MyДоговор = new Автомобиль();
            MyДоговор.ShowDialog();
            Close();
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Сотрудники MyПерсонал = new Сотрудники();
            MyПерсонал.ShowDialog();
            Close();
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Договор MyАвтомобиль = new Договор();
            MyАвтомобиль.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Добавить_клиента MyАвтомобиль = new Добавить_клиента();
            MyАвтомобиль.ShowDialog();
            Close();
        }
    }
}
