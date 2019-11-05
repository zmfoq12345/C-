using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm05_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            if (TextBoxChecker(this.textBox1))
            {
                this.comboBox1.Items.Add(this.textBox1.Text);
                MessageBox.Show("메뉴가 추가됨");
                this.textBox1.Clear();
            }    
        }

        private bool TextBoxChecker(TextBox textBox)
        {
            if (textBox.Text != "")
                return true;
            else
            {
                MessageBox.Show("메뉴를 입력하세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox1.Focus();
                return false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && TextBoxChecker(this.textBox1))
            {
                BTNADD_Click(sender, e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label1.Text = "선택 결과 :" + this.comboBox1.Text;
        }
    }
}
