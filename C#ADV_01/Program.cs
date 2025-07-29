namespace C_ADV_01
{
    internal class Program
    {

        #region Q1
        /*1-The Bubble Sort algorithm has a time complexity of O(n^2) in its worst
         * and average cases, which makes it inefficient for large datasets.
         * How we can optimize the Bubble Sort algorithm 
           And implement the code of this optimized bubble sort algorithm*/


        // answer : During each pass, if no elements are swapped, it means the array
        // is already sorted. So, we can stop early by adding a "swapped" flag
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSort<T>(T[] arr) where T : IComparable
        {
            bool swapped;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1 Test
            int[] numbers = { 5, 2, 9, 1, 5, 6 };

            BubbleSort(numbers);

            Console.WriteLine("Sorted array:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            #endregion


            //Range<int> range = new Range<int>(1, 5);
            //Console.WriteLine(range.IsInRange(1));
            //Console.WriteLine(range.IsInRange(0));
            //Console.WriteLine(range.IsInRange(5));
            //Console.WriteLine(range.Length());

            //Range<double> rng = new Range<double>(1.2, 5.7);
            //Console.WriteLine(rng.Length());

        }
    }
}
