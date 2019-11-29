using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=world;username=root;password=zotb1026!!";
            conn = new MySqlConnection(connectionString);
            try
            {
                //연결하기
                conn.Open();
                ShowDataConnectionState();

                //쿼리를 쓰기위한 준비
                string queryString = "select distinct continent from country";

                MySqlCommand command = new MySqlCommand(queryString, conn);

                //쿼리 실행 결과 가져오기
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()){ //가져올 레코드(행)이 있으면 true
                    comboBox1.Items.Add(reader.GetString("continent"));
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("연결되지 않았습니다.");
            }
        }

        private void ShowDataConnectionState()
        {
            if (conn.State == ConnectionState.Open)
            {
                label1.Text = "Connected";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Not Connected";
                label1.ForeColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString = $"select name from country where continent='{comboBox1.SelectedItem}'";

            MySqlCommand command = new MySqlCommand(queryString, conn);

            //쿼리 실행 결과 가져오기
            MySqlDataReader reader = command.ExecuteReader();
            comboBox2.Items.Clear();
            while (reader.Read())
            { //가져올 레코드(행)이 있으면 true
                comboBox2.Items.Add(reader.GetString("name"));
            }
            reader.Close();
        }
    }
}
