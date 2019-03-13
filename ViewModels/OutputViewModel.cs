using System;
using System.Windows;

namespace CSharpPractice2.ViewModels
{
    internal class OutputViewModel
    {
        public OutputViewModel()
        {
            MessageBox.Show("Invalid input");
        }

        private RelayCommand<object> _returnCommand;

        public RelayCommand<object> ReturnCommand
        {
            get
            {
                return _returnCommand ?? (_returnCommand = new RelayCommand<object>(o =>
                           {
                               try
                               {
                                   //ProceedInput();
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
