using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CalculateSalary
{
    class Employee
    {
        private int _baseSalary;
        private int _benefit;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

      

public int BaseSalary
{
  set
  {
      if (value < 0)
      {
          this._baseSalary = 0;
          MessageBox.Show("baseSalary cannot be less than 0");
      }
      else
          this._baseSalary = value;    
  }
     get { return _baseSalary; }
}
public int Benefit
{
    get { return _benefit; }
    set { _benefit = value; }
}
public int Salary
{
    get { return BaseSalary + Benefit; }
}
    }
}
