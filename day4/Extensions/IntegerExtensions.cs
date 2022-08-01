using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Extensions
{
    internal static class IntegerExtensions
    {
        internal static int KareAl(this int number)
        {
            return (int)Math.Pow((double)number,2);
        }
    }
}
