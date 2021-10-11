/*
Название: Result
Язык: C#
Краткое описание: Данная форма предназаначена для выбора вывода результата тестирования.
Переменные используемые в форме:
*home - форма начальной страницы;
Функции используемые в форме:
*Home_Click - возврат на главную форму
 */


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
    public partial class Result : Form
    {


        public Result(string name, int mark, List<Words> word)
        {
            InitializeComponent();
     
            Name.Text = name;
            Res.Text = mark.ToString();
            Answer.DataSource = word;


        }


        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Home_Click - переход на главную
         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */

        private void Home_Click(object sender, EventArgs e)
        {
            Form home = Application.OpenForms[0];
            home.Show();
            this.Hide();

        }

    }
}
