using System.Windows;
using System.Windows.Controls;

using CSharpPractice2.Tools;

namespace CSharpPractice2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.Input);
        }

        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }
    }
}
