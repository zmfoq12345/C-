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

namespace WinForm_DB03_CRUD_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string sql;
        private MySql.Data.MySqlClient.MySqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;database=world;username=root;password=zotb1026!!");
            try
            {
                //연결하기
                conn.Open();
                if(conn.State == ConnectionState.Open)
                {
                    labelConnectionState.Text = "DB 연결 성공";
                    labelConnectionState.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_SELECT_Click(object sender, EventArgs e)
        {
            sql = "select * from city where id =@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            // cmd.Parameters.Add("@id", MySqlDbType.Int32); // @id에 대한 
            // cmd.Parameters["@id"].Value = textBox1.Text;
            cmd.Parameters.AddWithValue("@id", textBox1.Text); // 위 두줄 대신

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // select 결과가 있으면 True
                {
                    textBox1.Text = reader.GetString("id"); // 해당 이름의 컬럼 데이터 가져오기
                    textBox2.Text = reader.GetString("Name");
                    textBox3.Text = reader.GetString("CountryCode");
                    textBox4.Text = reader.GetString("District");
                    textBox5.Text = reader.GetString("Population"); //대소문자 구분x
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_INSERT_Click(object sender, EventArgs e)
        {
            sql = "insert into city(name, countryCode, district, population)" +
                 "values(@name, @countryCode, @district, @population)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar);
            cmd.Parameters.Add("@countryCode", MySqlDbType.VarChar, 3);
            cmd.Parameters.Add("@district", MySqlDbType.VarChar);
            cmd.Parameters.Add("@population", MySqlDbType.Int32);

            cmd.Parameters["@name"].Value = textBox2.Text;
            cmd.Parameters["@countryCode"].Value = textBox3.Text;
            cmd.Parameters["@district"].Value = textBox4.Text;
            cmd.Parameters["@population"].Value = textBox5.Text;

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData("Data Inserted");
                    TextBox_Clear();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void TextBox_Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // 삽입 성공한 레코드 메세지박스로 출력
        void ShowData(string caption)
        {
            sql = "select * from city where name = @name and countryCode = @countryCode";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBox2.Text); // 위 두줄 대신
            cmd.Parameters.AddWithValue("@countryCode", textBox3.Text); // 위 두줄 대신

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                string row = "";

                if (reader.Read()) // select 결과가 있으면 True
                {
                    row += $"id = {reader.GetString("id")}\n";
                    row += $"CountryCode = {reader.GetString("CountryCode")}\n";
                    row += $"District = {reader.GetString("District")}\n";
                    row += $"Population = {reader.GetString("Population")}\n";

                    MessageBox.Show(row, caption);
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
            sql = "update city set " + "name = @name, countryCode = @countryCode, district = @district, population = @population" + "where id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar);
            cmd.Parameters.Add("@countryCode", MySqlDbType.VarChar, 3);
            cmd.Parameters.Add("@district", MySqlDbType.VarChar);
            cmd.Parameters.Add("@population", MySqlDbType.Int32);

            cmd.Parameters["@id"].Value = textBox1.Text;
            cmd.Parameters["@name"].Value = textBox2.Text;
            cmd.Parameters["@countryCode"].Value = textBox3.Text;
            cmd.Parameters["@district"].Value = textBox4.Text;
            cmd.Parameters["@population"].Value = textBox5.Text;

            try
            {
                cmd.ExecuteNonQuery();
                ShowData("Data updated");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            sql = "delete from city where id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            try
            {
                if(cmd.ExecuteNonQuery() == 1){
                    MessageBox.Show("Data Deleted");
                    TextBox_Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextboxClear_Click(object sender, EventArgs e)
        {
            TextBox_Clear();
        }

    }
}
