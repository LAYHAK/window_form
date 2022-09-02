using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ENUM
{
    public partial class SumValue : Form
    {
        public SumValue()
        {
            InitializeComponent();
        }

        private void SumValue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
           var num1=double.Parse(txt1.Text.Trim());
            var num2 = double.Parse(txt2.Text.Trim());
            var sum = $"{num1 + num2}";
            // this.textBox3.Text = $"{num1}+{num2}={sum}";
            textBox3.AppendText($"{num1}+{num2}={sum}\r\n");
            this.txt1.Text = null;
            this.txt2.Text = null;
        }

        private void SumValue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
