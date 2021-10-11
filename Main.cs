using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glazariy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        private void learn_Click(object sender, EventArgs e)
        {
            Learn newForm = new Learn();
            newForm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            newForm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            newForm.Show(); // отображаем Form2
            this.Hide(); // скрываем Form1 (this - текущая форма)
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(this);
            addForm.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search(this);
            searchForm.Show();
            this.Hide();
        }
    }
}
