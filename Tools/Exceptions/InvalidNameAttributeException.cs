using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractice2.Tools.Exceptions
{
    internal class InvalidNameAttributeException:Exception
    {
        public InvalidNameAttributeException(string nameAttribute):base($"Invalid characters in {nameAttribute}")
        {
            
        }
    }
}
