using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismNew.Lib
{
    public class Person
    {
        protected string _firstName, _lastName, _email;
        private readonly string _screenName;
        private int _age;
        private readonly bool _validAge = false, _isAdult = false, _isBirthday = false;
        protected DateTime _DOB, _currentDate = DateTime.Today;
        private readonly ChineseSign _chineseSign;

        public Person(string firstName, string lastName, string DOB)
        {
            _firstName = firstName;
            _lastName = lastName;
            _DOB = DateTime.Parse(DOB);
            _age = Age;
            if (_age >= 0)
                _validAge = true;
            if (_age >= 18)
                _isAdult = true;

            if (_currentDate.Month - _DOB.Month == 0 && _currentDate.Day - _DOB.Day == 0)
                _isBirthday = true;

            if (_validAge)
                _chineseSign = (ChineseSign)((8 + _DOB.Year % 12 )%12);  //+8 because 8 AC is a year of the rat

            _screenName = ScreenName;
        }

        public Person(string firstName, string lastName, string DOB, string email) : this(firstName, lastName, DOB)
        {
            _email = email;
        }
        /// <summary>
        /// returns the age of a person
        /// </summary>
        public int Age
        {
            get
            {
                TimeSpan elapsed = _currentDate - _DOB;
                return elapsed.Days / 365;
            }
        }

        /// <summary>
        /// gathers personal information and returns a suitable screen name.(virtual)
        /// </summary>
        public virtual string ScreenName  
        {
            get
            {
                return $"{_firstName}{_lastName[0]}{_DOB.Month}{_DOB.Day}";
            }
        }

        /// <summary>
        /// A non-virtual function which return a person's job
        /// </summary>
        public string Job
        {
            get
            {
                return "unknown";
            }
        }


    }
}
