using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismNew.Lib
{
    public class Student : Person
    {
        private int _schoolYear;
        public Student(string firstName, string lastName, string DOB, int schoolYear) : base(firstName, lastName, DOB)
        {
            _schoolYear = schoolYear;
        }

        public Student(string firstName, string lastName, string DOB) : base(firstName, lastName, DOB)
        {
            _schoolYear = Age - 4;
        }

        public override string ScreenName
        {
            get
            {
                return $"{_firstName}{_lastName[0]}{_DOB.Month}{_DOB.Day}Y{_schoolYear}";
            }
        }

        public new string Job
        {
            get
            {
                return "student";
            }
        }


    }
}
