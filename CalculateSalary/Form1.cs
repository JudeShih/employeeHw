using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateSalary
{
    public partial class Form1 : Form
    {
        Employee 施昊廷 = new Employee();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
             int BaseSalary  = int.Parse(baseSalary.Text);
             int Benefit= int.Parse(benefit.Text);
             施昊廷.BaseSalary = BaseSalary;
             施昊廷.Benefit = Benefit;
            MessageBox.Show((施昊廷.Salary).ToString());
        }
    }
}
