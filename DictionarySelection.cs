using System;
using System.Collections.Generic;
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
    public partial class DictionarySelection : Form
    {
        public DictionarySelection()
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

                        Dict.Items.Add( reader.GetString(1));

                    }
                }

                reader.Close();
            }

            Console.Read();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            string name = "";

            foreach (object itemChecked in Dict.CheckedItems)
            {
                name += " d.NAME = '" + itemChecked + "' OR"; 

            }

           name = name.Remove(name.Length - 2, 2);
            

            List<Words> word = new List<Words>();
            int num = 1;
            string connectionString = @"Data Source=DESKTOP-KMTN101;Initial Catalog=CLAZARI;Integrated Security=True";



            string sqlExpression = "SELECT v.ID, v.RUS, v.ENG FROM VOCABULARY v JOIN DICTIONARY_VOCABULARY l ON l.ID_WORD = v.ID JOIN DICTIONARY d ON l.ID_DIC = d.ID WHERE" + name+ ";";
            MessageBox.Show(sqlExpression);
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
                        num += 1;
                    }
                }

                reader.Close();
            }

            Console.Read();




            

        }
    }
}
