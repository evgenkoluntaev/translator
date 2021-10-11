/*
Название: Learn
Язык: C#
Краткое описание: Данная форма предназаначена для выбора формата изучения слова пользователя.
Переменные используемые в форме:
*newForm - созданная новая форма;
*home - форма начальной страницы;
Функции используемые в форме:
*LearnWord_Click - переход на форму тестирования
*Home_Click - возврат на главную форму
*Dict_Click - переход на форму словарей
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
    public partial class Learn : Form
    {
        public Learn()
        {
            InitializeComponent();
        }

/////////////////////////////////////////////////////////////////////////////////////////////////
        /*LearnWord_Click - переход на форму тестирования
         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */


        private void LearnWord_Click(object sender, EventArgs e)
        {
            TrainingStart newForm = new TrainingStart();
            newForm.Left = this.Left; 
            newForm.Top = this.Top;
            newForm.Show(); 
            this.Hide(); 
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

        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Dict_Click - переход на форму списка словарей
         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */
        private void Dict_Click(object sender, EventArgs e)
        {
            Dictionaries newForm = new Dictionaries();
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            newForm.Show();
            this.Hide();
        }
    }
}
