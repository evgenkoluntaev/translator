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
    public partial class Add : Form
    {
        string connectionString = @"Data Source=DESKTOP-SVQN580;Initial Catalog=CLAZARI;Integrated Security=True";
        string Voc = "";

        public Add(Main m)
        {
            mShow = m;
            InitializeComponent();
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from DICTIONARY";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                bindingSource1.DataSource = dt;
                Vocabulary.DataSource = bindingSource1;
                Vocabulary.DisplayMember = "NAME";
                Vocabulary.SelectedIndex = -1;
                connection.Close();
            }
        }
        Main mShow;


        private bool CheckRepeat() //проверка на повторяющееся слово
        {
            bool legal;

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            SqlCommand checkCommand = new SqlCommand();
            checkCommand.Connection = connect;
            checkCommand.CommandText = $"SELECT * FROM VOCABULARY WHERE rus = '"+Word.Text+"' or eng = '"+Word.Text+"'";//пытаемся найти слово, которое записано в поле Word
            SqlDataReader sqlDataReader = checkCommand.ExecuteReader();
            legal = sqlDataReader.HasRows;
            return legal;
        }

        private void Word_Click(object sender, EventArgs e)
        {
            Word.Text = null;
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            Translate.Text = null;
        }

        private void DownloadHandle_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();//открываем соединение
            if (!CheckRepeat())//выполняем проверку
            {
                string sql3 = "INSERT INTO VOCABULARY VALUES ('" + Word.Text + "', '" + Translate.Text + "', '" + Meaning.Text + "') UPDATE DICTIONARY_VOCABULARY SET ID_DIC=(SELECT DISTINCT ID FROM DICTIONARY WHERE NAME='" + Vocabulary.Text + "') WHERE ID_DIC is null;";
                SqlCommand command = new SqlCommand(sql3, connection);
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Слово было успешно добавлено.");
            }
            else
            {
                MessageBox.Show($"Слово \"{Word.Text}\" уже существует!");
            }
            connection.Close();//закрываем соединение
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
            mShow.Show();
        }

        private void Meaning_Click(object sender, EventArgs e)
        {
            Meaning.Text = null;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "";
                if (File.Text.EndsWith(".xml"))
                {
                    sql1 = "INSERT INTO XMLwithOpenXML(XMLData, LoadedDateTime) SELECT CONVERT(XML, BulkColumn) AS BulkColumn, GETDATE() FROM OPENROWSET(BULK '" + File.Text + "', SINGLE_BLOB) AS x; DECLARE @XML AS XML, @hDoc AS INT, @SQL NVARCHAR(MAX) SELECT @XML = XMLData FROM XMLwithOpenXML EXEC sp_xml_preparedocument @hDoc OUTPUT, @XML INSERT INTO VOCABULARY SELECT Ru, En, About FROM OPENXML(@hDoc, 'ROOT/" + Voc + "/Word') WITH (Ru[varchar](50) 'Ru', En[varchar](100) 'En', About Text 'About') EXEC sp_xml_removedocument @hDoc UPDATE DICTIONARY_VOCABULARY SET ID_DIC=(SELECT DISTINCT ID FROM DICTIONARY WHERE NAME='" + Vocabulary.Text + "') WHERE ID_DIC is null;";
                }
                if (File.Text.EndsWith(".txt"))
                {
                    sql1 = "BULK INSERT Vocabulary FROM '" + File.Text + "' WITH (FIELDTERMINATOR = ' ', ROWTERMINATOR = '\n')";
                }
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command1 = new SqlCommand(sql1, connection);
                SqlDataReader reader = command1.ExecuteReader();
                MessageBox.Show("Слова добавлены в словарь!", "Успешно!");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Файла не существует!", "Ошибка!");
            }
        }

        private void SelectDict_Click(object sender, EventArgs e)
        {
           Voc = Vocabulary.Text;
        }
    }
}
