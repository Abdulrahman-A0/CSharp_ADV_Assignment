using System.Numerics;

namespace C_ADV_01
{
    public class Range<T> where T : IComparable<T>, INumber<T>
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        public Range(T minValue, T maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
        }

        public T Length()
        {
            return MaxValue - MinValue;
        }
    }
}
