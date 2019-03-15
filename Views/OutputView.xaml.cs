using System.Windows.Controls;
using CSharpPractice2.Tools;
using CSharpPractice2.ViewModels;

namespace CSharpPractice2.Views
{
    /// <summary>
    /// Логика взаимодействия для OutputView.xaml
    /// </summary>
    public partial class OutputView : UserControl, INavigatable
    {
        public OutputView()
        {
            InitializeComponent();
            DataContext = new OutputViewModel();
        }
    }
}
