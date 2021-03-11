using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismNew.Lib
{
    public class Teacher : Person
    {
        private string _subject;
        public Teacher(string firstName, string lastName, string DOB, string subject) : base(firstName, lastName, DOB)
        {
            _subject = subject;
        }

        public override string ScreenName
        {
            get
            {
                return $"{_firstName}{_lastName[0]}{_DOB.Month}{_DOB.Day}Teach{_subject}";
            }
        }

    }
}
