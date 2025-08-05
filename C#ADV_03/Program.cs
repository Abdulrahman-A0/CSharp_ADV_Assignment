

using System.Collections;
using System.Data.Common;

namespace C_ADV_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable
            //Hashtable hashtable = new Hashtable(new StringEqualComparer());

            //hashtable.Add("Ali", 123);
            //hashtable.Add("Ahmed", 456);

            //if (!hashtable.ContainsKey("ali"))
            //    hashtable.Add("ali", 789);
            //else
            //    Console.WriteLine("Key Already Exists");

            //foreach (var item in hashtable)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary
            //Dictionary<string, int> phoneBook =
            //    new Dictionary<string, int>(new StringEqualityComparerGeneric())
            //    {
            //        { "Ali", 123 },
            //        { "Ahmed", 456 }
            //    };

            //phoneBook["karim"] = 123456;

            //if (!phoneBook.ContainsKey("ali"))
            //    phoneBook.Add("ali", 789);
            //else
            //    Console.WriteLine("Key Already Exists");

            //foreach (var item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SortedDictianry
            //SortedDictionary<string, int> phoneBookSorted =
            //    new SortedDictionary<string, int>(new StringEqualityComparerGeneric())
            //    {
            //        { "Ali", 123 },
            //        { "Ahmed", 456 }
            //    };

            //phoneBookSorted["karim"] = 123456;

            //if (!phoneBookSorted.ContainsKey("ali"))
            //    phoneBookSorted.Add("ali", 789);
            //else
            //    Console.WriteLine("Key Already Exists");

            //foreach (var item in phoneBookSorted)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SortedList
            //SortedList<string, int> phoneBookSlist =
            //    new SortedList<string, int>(new StringEqualityComparerGeneric())
            //    {
            //        { "Ali", 123 },
            //        { "Ahmed", 456 }
            //    };

            //phoneBookSlist["karim"] = 123456;

            //if (!phoneBookSlist.ContainsKey("ali"))
            //    phoneBookSlist.Add("ali", 789);
            //else
            //    Console.WriteLine("Key Already Exists");

            //foreach (var item in phoneBookSlist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
