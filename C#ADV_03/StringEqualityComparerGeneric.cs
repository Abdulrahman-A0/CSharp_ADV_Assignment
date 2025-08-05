using System.Diagnostics.CodeAnalysis;

namespace C_ADV_03
{
    public class StringEqualityComparerGeneric : IEqualityComparer<string>, IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x?.ToLower().CompareTo(y?.ToLower()) ?? -1;
        }

        public bool Equals(string? x, string? y)
        {
            return x?.ToLower().Equals(y?.ToLower()) ?? false;
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj.ToLower().GetHashCode();
        }
    }
}
