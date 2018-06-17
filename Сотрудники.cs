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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
        }

        private void дToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Услуги MyУслуги = new Услуги();
            MyУслуги.ShowDialog();
            Close();
        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Договор MyАвтомобиль = new Договор();
            MyАвтомобиль.ShowDialog();
            Close();
        }
    }
}
