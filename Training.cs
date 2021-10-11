
/*
Название: Training
Язык: C#
Краткое описание: Данная форма предназаначена для тестирования пользователя.
Переменные используемые в форме:
*newForm - созданная новая форма;
*home - форма начальной страницы;
*words - список слов;
*count - количсевто слов в тесте;
*amount - текущее слово;
*l - выбранный режим;
*nam - имя пользователя;
*res - количество правильных ответов;
*mark - итговая оценка;
Функции используемые в форме:
*Next_Click - переход к следующему слову тестирование и запись введенного ответа
*start_Click - начало етстирования, выводит первое слово теста, отображает кнопки для теста
*Finish_Click - окончания тестирование, подведение итогов и открытие формы результата.
*Prev_Click  - переход к предыдущему слову и запись введенного ответа
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
    public partial class Training : Form
    {
        List<Words> words;
        int count;
        int amount = 0;
        string nam;
        bool l;

        public Training(List<Words> word, string name, bool lang)
        {
            InitializeComponent();
            words = word;
            count = words.Count;
            nam = name;
            l = lang;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Next_Click - переход к следующему слову тестирование и запись введенного ответа
         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */


        private void Next_Click(object sender, EventArgs e)
        {
            Prev.Enabled = true;
            words[amount].Answer = Translate.Text;
            if (l)
            {
                if (words[amount].Answer.ToLower() == words[amount].Translete.ToLower())
                {
                    words[amount].Right = true;
                }
                else words[amount].Right = false;
            }
            else
            {
                if (words[amount].Answer.ToLower() == words[amount].Word.ToLower())
                {
                    words[amount].Right = true;
                }
                else words[amount].Right = false;
            }
            amount += 1;

            if (l) Word.Text = words[amount].Word;
            else Word.Text = words[amount].Translete;

            if (amount == count - 1)
            {
                Next.Enabled = false;
            }

            Count.Text = (amount + 1).ToString() + "/" + count.ToString();
            Translate.Text = words[amount].Answer;

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*start_Click - начало етстирования, выводит первое слово теста, отображает кнопки для теста

         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */

        private void start_Click(object sender, EventArgs e)
        {
            if (l) Word.Text = words[0].Word;
            else Word.Text = words[0].Translete;

            Finish.Enabled = true;
            Next.Enabled = true;
            start.Visible = false;
            Count.Text = (amount + 1).ToString() + "/" + count.ToString();

        }


        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Finish_Click - окончания тестирование, подведение итогов и открытие формы результата.

         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */


        private void Finish_Click(object sender, EventArgs e)
        {
            words[amount].Answer = Translate.Text;


            if (l)
            {
                if (words[amount].Answer.ToLower() == words[amount].Translete.ToLower())
                {
                    words[amount].Right = true;
                }
                else words[amount].Right = false;
            }
            else
            {
                if (words[amount].Answer.ToLower() == words[amount].Word.ToLower())
                {
                    words[amount].Right = true;
                }
                else words[amount].Right = false;
            }


            double res = 0;

            for (int i = 0; i < count; i++)
            {
                if (words[i].Right)
                {
                    res += 1;
                }
            }

            double result = res / count * 100;

            int mark;
            if (result > 90)
            {
                mark = 5;
            }
            else if (result > 70)
            {
                mark = 4;
            }
            else if (result > 50)
            {
                mark = 3;
            }
            else { mark = 2; }



            Result newForm = new Result(nam, mark, words);
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            newForm.Show();
            this.Hide();
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Prev_Click  - переход к предыдущему слову и запись введенного ответа

         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */


        private void Prev_Click(object sender, EventArgs e)
        {
            words[amount].Answer = Translate.Text;

            amount -= 1;
            Count.Text = (amount + 1).ToString() + "/" + count.ToString();

            if (l) Word.Text = words[amount].Word;
            else Word.Text = words[amount].Translete;

            Translate.Text = words[amount].Answer;
            if (amount == 0)
            {
                Prev.Enabled = false;
            }


            if (amount != count - 1)
            {
                Next.Enabled = true;
            }

        }



        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Home_Click - возврат на главную форму
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
