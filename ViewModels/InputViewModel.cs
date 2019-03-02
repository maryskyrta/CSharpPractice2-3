using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice2
{
    internal class InputViewModel
    {
        #region Fields
        private Person person;
        private string _name;
        private string _surname;
        private string _email;
        private DateTime _birthday;
        #endregion

        #region Properties

        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public string Surname
        {
            set
            {
                _surname = value;
            }
            get
            {
                return _surname;
            }
        }

        public string Email
        {
            set
            {
                _email = value;
            }
            get
            {
                return _email;
            }
        }

        public DateTime Birthday
        {
            set
            {
                _birthday = value;
            }
            get
            {
                return _birthday;
            }
        }

        #endregion


    }
}
