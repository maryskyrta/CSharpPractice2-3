using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice2.Tools
{
    internal enum ViewType
    {
        Input,
        Output,
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
