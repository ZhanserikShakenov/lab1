using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int ans = 0;
            int prevNum = 2;
            int prevNum2 = 1;
            for (int i = 3; i <= num; i++) {
                ans = prevNum + prevNum2;
                prevNum2 = prevNum;
                prevNum = ans;
            }
            textBox2.Text = ans.ToString();
        }
    }
}
