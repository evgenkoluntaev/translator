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
    public partial class Search : Form
    {
        public Search(Main m)
        {
            mShow = m;
            InitializeComponent();
        }

        Main mShow;
        const string path = @"Data Source=DESKTOP-KMTN101; Initial Catalog = CLAZARI; Integrated Security = True";
        DataGridView dataGrid = new DataGridView();
        List<DatabaseWord> databaseWords = new List<DatabaseWord>();

        private void WriteIntoList(DataGridView dt)
        {
            for(int i = 0; i < dt.RowCount; i++)
            {
                databaseWords.Add(new DatabaseWord(Convert.ToInt32(dt.Rows[i].Cells[0].Value), 
                    dt.Rows[i].Cells[1].Value.ToString(), 
                    dt.Rows[i].Cells[2].Value.ToString(), 
                    dt.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void SearchLine_TextChanged(object sender, EventArgs e)
        {
            var Query = from dw in databaseWords
                        where dw.WordName == SearchLine.Text
                        select dw;

            foreach(var dbWord in Query)
            {
                Words.Items.Add(dbWord.WordName);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            mShow.Show();
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {            
            SqlConnection connect = new SqlConnection(path);
            connect.Open();

            SqlCommand checkCommand = new SqlCommand();
            checkCommand.Connection = connect;
            checkCommand.CommandText = $"SELECT * VOCABULARY;";
            SqlDataReader Reader = checkCommand.ExecuteReader();
            
            if(Reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(Reader);
                dataGrid.DataSource = dt;
            }

            connect.Close();
        }
    }
}
