using System;
using CSharpPractice2.Models;
using CSharpPractice2.Tools;

namespace CSharpPractice2.ViewModels
{
    internal class OutputViewModel
    {
        #region Fields

        private Person _person;

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
                return $"Birthday: {_person.Birthday}";
            }
        }

        public String IsAdult
        {
            get
            {
                if (_person.IsAdult)
                    return "You are an adult";
                return "You are not an adult";
            }
        }

        public string IsBirthdayToday
        {
            get
            {
                if (_person.IsBirthdayToday)
                    return "Happy Birthday!";
                return "Sorry, it's not your birthday today:(";
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



        private RelayCommand<object> _returnCommand;

        public RelayCommand<object> ReturnCommand
        {
            get
            {
                return _returnCommand ?? (_returnCommand = new RelayCommand<object>(o =>
                           {
                               try
                               {
                                   NavigationManager.Instance.Navigate(ViewType.Input);
                               }
                               catch (Exception)
                               {
                                   //MessageBox.Show("Invalid input");
                               }
                           }
                       ));
            }
        }

        
    }
}
