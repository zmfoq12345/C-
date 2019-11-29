using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm10_DialogBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            //form2.ShowDialog(); // 2번 폼이 끝나야 1번 폼 사용가능
            //form2.Show(); // 모두 사용 가능
            if(form2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("정상 종료");
            }
        }

        public string msg { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // form2에서 form1을 참조할 수 있는 참조 전달
            form2.Owner = this; // this = Form1()

            msg = textBox1.Text;
            form2.ShowDialog();

            label1.Text = $"합계 : {form2.num1 + form2.num2}";
        }
    }
}
