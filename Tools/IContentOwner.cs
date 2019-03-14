using System.Windows.Controls;

namespace CSharpPractice2.Tools
{
    internal interface IContentOwner
    {
        ContentControl ContentControl { get; }
    }
}
