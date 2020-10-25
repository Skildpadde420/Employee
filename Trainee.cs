using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Trainee : Employee
    {
        #region Member
        private double _totalSchoolHours;
        #endregion

        #region Constructor
        public Trainee()
        {
        }
        public Trainee(string fname, string lname, double wage) : base(fname, lname, wage)
        {
        }
        #endregion

        #region Property
        #endregion

        #region Methods
        public virtual void BookWorkDay()
        {
            _totalSchoolHours += 7.75;
        }
        public override void PrintMonthSalary()
        {
            _totalWage = HourlyWage * (_totalSchoolHours + _totalHoursWorked);
            Console.WriteLine($"Total hours worked: {_totalHoursWorked}{Environment.NewLine}Total hours attended school: {_totalSchoolHours}{Environment.NewLine}Monthly Wage: {_totalWage}");
        }
        #endregion
    }
}
