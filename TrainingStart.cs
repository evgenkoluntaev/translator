/*
Название: TrainingStart
Язык: C#
Краткое описание: Данная форма предназаначена для начала тестирвоания.
Переменные используемые в форме:
*newForm - созданная новая форма;
*home - форма начальной страницы;
*connectionString - имя подключенноq бд;
*sqlExpression - запрос к бд
*word - список слов полученных из бд
*name - строка имен словарей
Функции используемые в форме:
*Home_Click - возврат на главную форму
*Start_Click - начало тестирования, открывает форму тестирования, выбор режима тестирования
*Select_Click - выбор нужных словарей и слов из них
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glazariy
{
    public partial class TrainingStart : Form
    {
        public TrainingStart()
        {
            InitializeComponent();
            string connectionString = @"Data Source=DESKTOP-KMTN101;Initial Catalog=CLAZARI;Integrated Security=True";
            string sqlExpression = "SELECT * FROM DICTIONARY";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));

                    while (reader.Read()) // построчно считываем данные
                    {

                        Dict.Items.Add(reader.GetString(1));

                    }
                }

                reader.Close();
            }

            Console.Read();
        }
        List<Words> word = new List<Words>();

        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Start_Click - начало тестирования, открывает форму тестирования, выбор режима тестирования
         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */

        private void Start_Click(object sender, EventArgs e)
        {
            
            bool lang = Rus.Checked;

            Training newForm = new Training(word, Name.Text, lang);
            newForm.Left = this.Left;
            newForm.Top = this.Top;
            newForm.Show();
            this.Hide();
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


        /////////////////////////////////////////////////////////////////////////////////////////////////
        /*Select_Click - выбор нужных словарей и слов из них
         *Формальные парметры:
         *  sender - эелмент управления, вызывающий функцию;
         *  e - аргумент события.
         */

        private void Select_Click(object sender, EventArgs e)
        {
            string name = "";

            foreach (object itemChecked in Dict.CheckedItems)
            {
                name += " d.NAME = '" + itemChecked + "' OR";

            }

            name = name.Remove(name.Length - 2, 2);



            string connectionString = @"Data Source=DESKTOP-KMTN101;Initial Catalog=CLAZARI;Integrated Security=True";

            string sqlExpression = "SELECT v.ID, v.RUS, v.ENG FROM VOCABULARY v JOIN DICTIONARY_VOCABULARY l ON l.ID_WORD = v.ID JOIN DICTIONARY d ON l.ID_DIC = d.ID WHERE" + name + ";";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read()) // построчно считываем данные
                    {
                        word.Add(new Words() { Word = reader.GetString(1), Translete = reader.GetString(2) });
                    }
                }

                reader.Close();
            }

            Console.Read();

        }
    }
}
