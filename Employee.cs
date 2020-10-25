using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        #region Member
        protected double _totalHoursWorked;
        protected double _totalWage;
        #endregion

        #region Constructor
        public Employee()
        {
        }
        public Employee(string fname, string lname, double wage)
        {
            FirstName = fname;
            LastName = lname;
            HourlyWage = wage;
        }
        #endregion

        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double HourlyWage { get; set; }
        #endregion

        #region Methods
        public virtual void BookWorkDay(double time)
        {
            _totalHoursWorked += time;
        }
        public virtual void PrintMonthSalary()
        {
            _totalWage = HourlyWage * _totalHoursWorked;
            Console.WriteLine($"The total workhours: {_totalHoursWorked}{Environment.NewLine}Monthly Wage: {_totalWage}");
        }
        #endregion
    }
}
