using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpPractice2.Models;
using CSharpPractice2.Tools;
using CSharpPractice2.Tools.Exceptions;

namespace CSharpPractice2.ViewModels
{
    internal class InputViewModel
    {

        #region Fields

        private RelayCommand<object> _proceedCommand;

        #endregion

        #region Properties

        public string Name { set; get; }

        public string Surname { set; get; }

        public string Email { set; get; }

        public DateTime Birthday { set; get; }

        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceedCommand?? (_proceedCommand = new RelayCommand<object>(ProceedInput, CanProceedExecute));
            }
        }

        private bool CanProceedExecute(object obj)
        {

            return !String.IsNullOrWhiteSpace(Name) && !String.IsNullOrWhiteSpace(Surname) && !String.IsNullOrWhiteSpace(Email) && !(Birthday == default(DateTime));
        }


        #endregion




        #region Validation

        private static void ValidateNameAttribute(string name)
        {
            if(!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
               throw new InvalidNameAttributeException(name);

        }

        private void ValidateEmail()
        {
            if (!Regex.IsMatch(Email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase))
            throw new InvalidEmailException(Email);
        }

        private void ValidateDate()
        {
            if(Birthday>DateTime.Today)
                throw new PersonNotBornException(Birthday);
            if(Birthday.Year<(DateTime.Today.Year-135))
                throw new PersonTooOldException(Birthday);
        }

        #endregion

        private async void ProceedInput(object obj)
        {
            var result = await Task.Run(() =>
            {
                try
                {
                    ValidateNameAttribute(Name);
                }
                catch (InvalidNameAttributeException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                try
                {
                    ValidateNameAttribute(Surname);
                }
                catch (InvalidNameAttributeException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                try
                {
                    ValidateEmail();
                }
                catch (InvalidEmailException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                try
                {
                    ValidateDate();
                }
                catch (PersonNotBornException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                catch (PersonTooOldException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }

                return true;
            });
            if (!result) return;
            PersonManager.Person = new Person(Name, Surname, Email, Birthday);
            NavigationManager.Instance.Navigate(ViewType.Output);
        }

        
    }
}
