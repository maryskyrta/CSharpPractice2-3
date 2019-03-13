using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using CSharpPractice2.Models;
using CSharpPractice2.Tools;

namespace CSharpPractice2.ViewModels
{
    internal class InputViewModel: INotifyPropertyChanged
    {
        #region Fields
        private Person person;
        private string _name;
        private string _surname;
        private string _email;
        private DateTime _birthday;
        private RelayCommand<object> _proceedCommand;
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

        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceedCommand?? (_proceedCommand = new RelayCommand<object>(o =>
                           {
                               try
                               {
                                   ProceedInput();
                               }
                               catch(Exception)
                               {
                                   MessageBox.Show("Invalid input");
                               }
                           }
                       ))
                    

                ;
            }
        }

        #endregion

        private void ProceedInput()
        {
            NavigationManager.Instance.Navigate(ViewType.Output);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
