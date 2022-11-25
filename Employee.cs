using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managertask
{
    internal class Employee
    {
        private string _name;
        private bool _isSuccessfull;
        private decimal _salary;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set 
            { 
                if(value > 250)
                {
                    _salary = value;
                }
            }
        }

        public bool IsSuccessfull
        {
            get { return _isSuccessfull; }
            set { _isSuccessfull = value; }
        }

        public Employee(string name,decimal salary,bool isSuccessful)
        {
            Name = name;
            Salary = salary;
            IsSuccessfull = isSuccessful;
        }
    }
}
