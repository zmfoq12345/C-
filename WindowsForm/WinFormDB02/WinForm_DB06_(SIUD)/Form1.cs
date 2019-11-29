using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_DB06__SIUD_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dataTable;
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. 테이블과 컬럼 만들기
            dataTable = new DataTable("table1");
            DataColumn col;

            col = new DataColumn("name", typeof(string));
            col.MaxLength = 10;
            col.AllowDBNull = false;
            dataTable.Columns.Add(col);

            col = new DataColumn("age", typeof(int));
            dataTable.Columns.Add(col);

            col = new DataColumn("male", typeof(bool));
            dataTable.Columns.Add(col);

            // 2. 행 만들기, 데이터 입력
            DataRow row = dataTable.NewRow();
            row["name"] = "아이유";
            row["age"] = 26;
            row["male"] = false;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["name"] = "조승우";
            row["age"] = 39;
            row["male"] = true;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["name"] = "장만월";
            row["age"] = 1000;
            row["male"] = false;
            dataTable.Rows.Add(row);

            dataGridView1.DataSource = dataTable;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            row["name"] = tb_Name.Text;
            row["age"] = tb_Age.Text;
            row["male"] = rb_male.Checked;
            dataTable.Rows.Add(row);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int SelectedIdx = dataGridView1.SelectedRows[0].Index;
            DataRow row = dataTable.Rows[SelectedIdx];
            row["name"] = tb_Name.Text;
            row["age"] = tb_Age.Text;
            row["male"] = rb_male.Checked;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int SelectedIdx = dataGridView1.SelectedRows[0].Index;
            DataRow row = dataTable.Rows[SelectedIdx];
            dataTable.Rows.Remove(row);
        }
    }
}
