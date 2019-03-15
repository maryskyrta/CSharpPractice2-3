using System;
using System.Globalization;

namespace CSharpPractice2.Tools.Exceptions
{
    internal class PersonTooOldException: Exception
    {
        public PersonTooOldException(DateTime date): base($"Entered date of birth {date.ToShortDateString()} was too long ago.")
        {
            
        }
    }
}
