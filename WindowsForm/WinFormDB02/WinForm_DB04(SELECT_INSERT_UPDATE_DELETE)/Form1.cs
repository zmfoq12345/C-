using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinForm_DB04_SELECT_INSERT_UPDATE_DELETE_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnStr = 
                "server=localhost;" +
                "port=3306;" +
                "database=world;" +
                "username=root;" +
                "password=zotb1026!!";
            conn = new MySqlConnection(ConnStr);

            try
            {
                //연결하기
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    labelConnectionState.Text = "DB 연결 성공";
                    labelConnectionState.ForeColor = Color.Green;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SELECT_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM city WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader.GetString("id");
                    textBox2.Text = reader.GetString("Name");
                    textBox4.Text = reader.GetString("CountryCode");
                    textBox3.Text = reader.GetString("District");
                    textBox5.Text = reader.GetString("Population");
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_INSERT_Click(object sender, EventArgs e)
        {
            string sql = "insert into city(name, countryCode, district, population) values(@name, @countryCode, @district, @population)";
            Excute_Query(sql, "Data Inserted completely");
        }
        private void Excute_Query(string sql, string msg)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@countryCode", textBox4.Text);
            cmd.Parameters.AddWithValue("@district", textBox3.Text);
            cmd.Parameters.AddWithValue("@population", textBox5.Text);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData(msg);
                    TextBox_Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ShowData(string caption)
        {
            string sql = "select * from city where name = @name and countryCode = @countryCode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@countryCode", textBox3.Text);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                string msg = "";

                if (reader.Read()) // select 결과가 있으면 True
                {
                    msg += $"id = {reader.GetString("id")}\n";
                    msg += $"CountryCode = {reader.GetString("CountryCode")}\n";
                    msg += $"District = {reader.GetString("District")}\n";
                    msg += $"Population = {reader.GetString("Population")}\n";

                    MessageBox.Show(msg, caption);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            string sql = "update city set " + "name = @name, countryCode = @countryCode, district = @district, population = @population" + "where id = @id";
            Excute_Query(sql, "Data Updated completely");
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            string sql = "delete from city where id = @id";
            Excute_Query(sql, "Data Deleted");
        }

        void TextBox_Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }
        private void TextboxClear_Click(object sender, EventArgs e)
        {
            TextBox_Clear();
        }

    }
}
