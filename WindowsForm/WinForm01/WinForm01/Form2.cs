using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string strResult;
        private void Form2_Load(object sender, EventArgs e)
        {
            strResult = this.label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TextChecker())
                this.label1.Text = strResult + this.textBox1.Text;

        }
        private bool TextChecker()
        {
            if (this.textBox1.Text != "")
                return true;
            else{
                MessageBox.Show("텍스트를 입력하세요!");
                this.textBox1.Focus();
                return false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && TextChecker()){
                button1_Click(sender, e);
                this.textBox1.Text = "";
            }
        }
    }
}
