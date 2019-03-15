using System.Windows.Controls;
using CSharpPractice2.Tools;
using CSharpPractice2.ViewModels;

namespace CSharpPractice2.Views
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
