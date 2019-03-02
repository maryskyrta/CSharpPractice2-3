using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice2
{
    internal class Person
    {
        private static readonly string[] WesternSigns = { "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn" };
        private static readonly string[] ChineseSigns = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };


        #region Fields
        private string _name;
        private string _surname;
        private string _email;
        private DateTime _birthday;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        public string Surname
        {
            get { return _surname; }
        }

        public string Email
        {
            get { return _email; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
        }

        public bool IsAdult
        {
            get
            {
                return ((DateTime.Today.Year - _birthday.Year) > 18) || (((DateTime.Today.Year - _birthday.Year) == 18) && (DateTime.Today.DayOfYear >= _birthday.DayOfYear));
            }
        }

        public bool IsBirthday
        {
            get
            {
                return DateTime.Today.DayOfYear == _birthday.DayOfYear;
            }
        }

        public string WesternSign
        {
            get
            {
                int day = _birthday.Day;
                int month = _birthday.Month;
                if (month == 1)
                    return day < 20 ? WesternSigns[WesternSigns.Length - 1] : WesternSigns[month - 1];
                if (month == 2)
                    return day < 19 ? WesternSigns[month - 2] : WesternSigns[month - 1];
                if (month > 2 && month < 7)
                    return day < 21 ? WesternSigns[month - 2] : WesternSigns[month - 1];
                if (month > 6 && month < 11)
                    return day < 23 ? WesternSigns[month - 2] : WesternSigns[month - 1];
                return day < 22 ? WesternSigns[month - 2] : WesternSigns[month - 1];
            }
        }

        public string ChineseSign
        {
            get
            {
                return ChineseSigns[_birthday.Year % 12];
            }
        }





        #endregion

        #region Constructors

        internal Person(string name, string surname, string email, DateTime birthday)
        {
            _name = name;
            _surname = surname;
            _email = email;
            _birthday = birthday;
        }

        internal Person(string name, string surname, string email) : this(name, surname, email, DateTime.Today)
        {

        }

        internal Person(string name, string surname, DateTime birthday) : this(name, surname, "No email", birthday)
        {

        }

        #endregion



    }
}
