
using CSharpPractice2.Models;

namespace CSharpPractice2.Tools
{
    internal static class PersonManager
    {
        private static Person CurrentPerson;

        internal static Person Person
        {
            get => CurrentPerson;
            set => CurrentPerson = value;
        }
    }
}
