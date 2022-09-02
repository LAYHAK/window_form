using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalaryTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cal_Click(object sender, EventArgs e)
        {
            double salary = double.Parse(textBox1.Text);
            double bonus = double.Parse(textBox4.Text);
            int spouse = int.Parse(textBox3.Text);
            int child = int.Parse(textBox2.Text);
            if (salary >= 0 && bonus >= 0)
            {
              
                spouse = spouse >= 1 ? 1 : 0;

                if (child >= 9)
                {
                    child = 9;
                }
                else if (child <= 0)
                {
                    child = 0;
                }
                double family = 150000 * (spouse + child);
                double tax, l_salary;
                salary = salary - family;
                if (salary <= 1200000)
                {
                    tax = 0;
                }
                else if (salary <= 2000000)
                {
                    tax = salary * 0.05 - 60000;
                }
                else if (salary <= 8500000)
                {
                    tax = salary * 0.1 - 160000;
                }
                else if (salary <= 12500000)
                {
                    tax = salary * 0.15 - 585000;
                }
                else
                {
                    tax = salary * 0.2 - 1210000;
                }

                tax += bonus * 0.2;
                l_salary = (salary + family + bonus) - tax;

                this.tax.Text = $"{tax:#,##0.##}R";
                this.lastsalary.Text = $"{l_salary:#,##0.##}R";
                
            }
            else
            {
              
                MessageBox.Show("Invalid Value");
            }
        }
    }
}
