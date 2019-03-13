﻿
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CSharpPractice2.Tools;
using CSharpPractice2.ViewModels;

namespace CSharpPractice2
{
    /// <summary>
    /// Логика взаимодействия для InputView.xaml
    /// </summary>
    public partial class InputView : UserControl, INavigatable
    {
        public InputView()
        {
            InitializeComponent();
            DataContext = new InputViewModel();
        }
    }
}
