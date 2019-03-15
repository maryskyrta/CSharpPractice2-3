using System;

namespace CSharpPractice2.Tools.Exceptions
{
    internal class InvalidEmailException: Exception
    {
        public InvalidEmailException(string email): base($"Invalid email {email}")
        {
            
        }
    }
}
