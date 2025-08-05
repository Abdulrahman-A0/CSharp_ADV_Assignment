using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ADV_03
{
    internal class StringEqualComparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
            string? X = x as string;
            string? Y = y as string;
            return X?.ToLower().Equals(Y?.ToLower()) ?? false;
        }

        public int GetHashCode(object obj)
        {
            string? str = obj as string;
            return str?.ToLower().GetHashCode() ?? throw new ArgumentException();
        }
    }
}
