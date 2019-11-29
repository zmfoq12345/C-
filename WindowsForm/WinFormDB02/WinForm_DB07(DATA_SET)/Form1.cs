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

namespace WinForm_DB07_DATA_SET_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataSet dataSet;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;database=world;username=root;password=zotb1026!!");
            adapter = new MySqlDataAdapter("SELECT * FROM city", conn); // dataSet과 DB 연결
            dataSet = new DataSet(); // 메모리상의 가상 DataTable 관리

            adapter.Fill(dataSet, "city");
            dataGridView1.DataSource = dataSet.Tables["city"];

        }

        private void btn_SELECT_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM city WHERE CountryCode = @CountryCode";
            adapter.SelectCommand = new MySqlCommand(sql, conn);
            if (textBox3.Text == "1") adapter.SelectCommand.Parameters.AddWithValue("@CountryCode", "kor");
            else adapter.SelectCommand.Parameters.AddWithValue("@CountryCode", textBox3.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (adapter.Fill(dataSet, "city") > 0) dataGridView1.DataSource = dataSet.Tables["city"];
                else MessageBox.Show("검색된 데이터가 없습니다..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_INSERT_Click(object sender, EventArgs e)
        {
            string sql = "insert into city(name, countryCode, district, population)" +
                 "values(@name, @countryCode, @district, @population)";

            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@name", textBox2.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@countryCode", textBox3.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@district", textBox4.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@population", textBox5.Text);

            #region MysqlDataAdapter.Insert(Command)를 사용한 처리
            //try
            //{
            //    conn.Open();
            //    if (adapter.InsertCommand.ExecuteNonQuery() > 0) // DB에 반영됨
            //    {
            //        dataSet.Clear();
            //        adapter.Fill(dataSet, "city"); // DB - > 메모리(DataSet)
            //        dataGridView1.DataSource = dataSet.Tables["city"];
            //    }
            //    else
            //    {
            //        MessageBox.Show("추가된 데이터가 없습니다.");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion

            #region DataSet을 먼저 수정하고, DB로 Update() 처리
            DataRow newRow = dataSet.Tables["city"].NewRow();
            newRow["name"] = textBox2.Text;
            newRow["countryCode"] = textBox3.Text;
            newRow["district"] = textBox4.Text;
            newRow["population"] = textBox5.Text;
            dataSet.Tables["city"].Rows.Add(newRow);

            try
            {
                conn.Open();
                adapter.Update(dataSet, "city"); // 메모리 -> DB반영
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            string sql = "update city set district=@district where countrycode = @countrycode";
            adapter.UpdateCommand = new MySqlCommand(sql, conn);
            adapter.UpdateCommand.Parameters.AddWithValue("@district", textBox4.Text);
            adapter.UpdateCommand.Parameters.AddWithValue("@countrycode", textBox3.Text);

            #region UpdateCommand를 이용한 처리
            //try
            //{
            //    conn.Open();
            //    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
            //    {
            //        dataSet.Clear();
            //        adapter.Fill(dataSet, "city"); // DB -> 메모리
            //        dataGridView1.DataSource = dataSet.Tables["city"];
            //    }
            //    else
            //    {
            //        MessageBox.Show("수정된 데이터가 없습니다.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion


            #region Update를 이용한 처리
            int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            string filter = "id=" + id;
            DataRow[] findRows = dataSet.Tables["city"].Select(filter);
            findRows[0]["id"] = id;
            findRows[0]["name"] = textBox2.Text;
            findRows[0]["countrycode"] = textBox3.Text;
            findRows[0]["district"] = textBox4.Text;
            findRows[0]["population"] = textBox5.Text;
            //dataSet.Tables["city"].Rows.Add(findRows[0]);

            try
            {
                conn.Open();
                adapter.Update(dataSet, "city"); // 메모리 -> DB반영
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            string sql = "delete from city where id = @id";
            adapter.DeleteCommand = new MySqlCommand(sql, conn);
            int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            adapter.DeleteCommand.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                if(adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    dataSet.Clear();
                    adapter.Fill(dataSet, "city");
                    dataGridView1.DataSource = dataSet.Tables["city"];
                }
                else
                {
                    MessageBox.Show("삭제된 데이터가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
