using CSharpPractice2.Models;
using CSharpPractice2.Tools;

namespace CSharpPractice2.ViewModels
{
    internal class OutputViewModel
    {
        #region Fields

        private readonly Person _person;
        private RelayCommand<object> _returnCommand;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return $"Name: {_person.Name}";
            }
        }

        public string Surname
        {
            get
            {
                return $"Surname: {_person.Surname}";
            }
        }

        public string Email
        {
            get
            {
                return $"Email: {_person.Email}";
            }
        }

        public string Birthday
        {
            get
            {
                return $"Birthday: {_person.Birthday.ToShortDateString()}";
            }
        }

        public string IsAdult
        {
            get
            {
                return _person.IsAdult ? "You are an adult" : "You are not an adult";
            }
        }

        public string IsBirthdayToday
        {
            get
            {
                return _person.IsBirthdayToday ? "Happy Birthday!" : "Sorry, it's not your birthday today:(";
            }
        }

        public string ChineseSign
        {
            get
            {
                return $"Chinese sign: {_person.ChineseSign}";
            }
        }

        public string WesternSign
        {
            get
            {
                return $"Western sign: {_person.WesternSign}";
            }
        }



        #endregion

        internal OutputViewModel()
        {
            _person = PersonManager.Person;
        }


        public RelayCommand<object> ReturnCommand
        {
            get
            {
                return _returnCommand ?? (_returnCommand = new RelayCommand<object>(o =>
                           {
                               NavigationManager.Instance.Navigate(ViewType.Input);
                           }
                       ));
            }
        }

        
    }
}
