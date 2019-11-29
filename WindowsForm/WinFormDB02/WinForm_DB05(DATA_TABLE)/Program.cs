using System;
using System.Data;

namespace WinForm_DB05_DATA_TABLE_
{
    class Program
    {
        // 메모리 창에서 구현되는 DataTable 연습
        static void Main(string[] args)
        {
            // 1. 테이블과 컬럼 만들기
            DataTable dataTable = new DataTable("table1");
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

            // 3. 모든 데이터 출력
            foreach (DataRow SelectedRow in dataTable.Rows)
            {
                string gender;
                if (SelectedRow["male"].ToString() == "True")
                {
                    gender = "남자";
                }
                else
                {
                    gender = "여자";
                }
                Console.WriteLine($"Name:{SelectedRow["name"]}\n Age:{SelectedRow["age"]}\n Gender:{gender}");
                Console.WriteLine();
            }

        }
    }
}
