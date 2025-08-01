using System;
using System.Collections;

namespace C_ADV_02
{
    internal class Program
    {
        #region Q2
        public static bool IsPalindrome(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                    return false;
            }
            return true;
        }
        #endregion

        #region Q3
        public static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count > 0)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());
        }
        #endregion

        #region Q4
        public static bool isBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(str[i]);
                        break;
                    case ']':
                        if (!stack.TryPop(out char c1) || c1 != '[')
                            return false;
                        break;
                    case ')':
                        if (!stack.TryPop(out char c2) || c2 != '(')
                            return false;
                        break;
                    case '}':
                        if (!stack.TryPop(out char c3) || c3 != '{')
                            return false;
                        break;
                }
            }
            return stack.Count == 0;
        }
        #endregion

        #region Q5
        public static T[] RemoveDuplicate<T>(T[] arr)
        {
            return new HashSet<T>(arr).ToArray();
        }
        #endregion

        #region Q6
        public static void RemoveOdd(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] is int num)
                    if (num % 2 != 0)
                        arr.Remove(num);
            }
        }
        #endregion

        #region Q7
        public static void SeedStack(Stack<int> stack, params int[] values)
        {
            foreach (int i in values)
                stack.Push(i);
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            /*1. Given an array  consists of  numbers with size N and number
             * of queries, in each query you will be given an integer X,
             * and you should print how many numbers in array that is greater than  X.
                Ex:
                Input
                3 3                    //Size of array , number of queries
                11 5 3             //Array 
                1                      //Query1
                5                     //Query2
                13                  //Query 3
                Output
                3                   //11,5,3
                1                  //11
                0                   
                */

            //int size;
            //do
            //{
            //    Console.WriteLine("Enter Array Size: ");
            //} while (!int.TryParse(Console.ReadLine(), out size));

            //int q;
            //do
            //{
            //    Console.WriteLine("Enter Queries Number: ");
            //} while (!int.TryParse(Console.ReadLine(), out q));

            //Console.WriteLine("Enter Array Elements separated with space: ");
            //int[] arr = new int[size];
            //arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //while (q > 0)
            //{
            //    int count = 0;
            //    int n;
            //    do
            //    {
            //        Console.WriteLine("Enter A Number: ");
            //    } while (!int.TryParse(Console.ReadLine(), out n));

            //    for (int i = 0; i < size; i++)
            //    {
            //        if (arr[i] > n)
            //            ++count;
            //    }
            //    Console.WriteLine(count);
            //    q--;
            //}
            #endregion

            #region Q2
            /*2. Given a number N and an array of N numbers. Determine if it's
             * palindrome or not.
                    Ex:
                    Input:
                    5
                    1 3 2 3 1
                    Output:
                    YES
                    */

            //int size;
            //do
            //{
            //    Console.WriteLine("Enter Array Size: ");
            //} while (!int.TryParse(Console.ReadLine(), out size));

            //int[] arr = new int[size];

            //arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //if (IsPalindrome(arr))
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Q3
            /*3. Given a Queue, implement a function to reverse the elements
             * of a queue using a stack.*/

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //ReverseQueue(queue);

            //foreach (var item in queue)
            //    Console.Write($"{item} ");
            #endregion

            #region Q4
            /*4. Given a Stack, implement a function to check if a string of
                 parentheses is balanced using a stack.
                Ex:
                Input:
                [()]{}
                Output:
                Balanced
                */

            //Console.WriteLine("Enter Your String: ");
            //string s = Console.ReadLine();

            //if (isBalanced(s))
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced");
            #endregion

            #region Q5
            /*5. Given an array, implement a function to remove duplicate elements
             * from an array.*/

            //int[] arr = { 1, 2, 3, 4, 5, 6, 1, 2, 3 };

            //arr = RemoveDuplicate(arr);

            //foreach (var item in arr)
            //    Console.WriteLine($"{item} ");
            #endregion

            #region Q6
            /*6. Given an array list , implement a function to remove all odd numbers
             * from it.*/

            //ArrayList arr = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //RemoveOdd(arr);

            //foreach (var item in arr)
            //    Console.WriteLine($"{item} ");
            #endregion

            #region Q7
            /*7. Implement a queue that can hold different data types. 
                 And insert the following data:
                     queue.Enqueue(1)
                     queue.Enqueue(“Apple”)
                     queue.Enqueue(5.28)
                 */

            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //    Console.WriteLine(item);
            #endregion

            #region Q8
            /*8. Create a function that pushes a series of integers onto a stack.
                 Then, search for a target integer in the stack.
                 If the target is found, print a message indicating that the target
                 was found how many elements were checked before finding the target
                 (“Target was found successfully and the count = 5”). If the target
                 is not found, print a message indicating that the target
                 was not found(“Target was not found”).*/

            //Stack<int> stack = new Stack<int>();

            //SeedStack(stack, 1, 2, 3, 4, 5, 6);

            //int target;
            //do
            //{
            //    Console.WriteLine("Enter A Number to search: ");
            //} while (!int.TryParse(Console.ReadLine(), out target));

            //bool found = false;
            //int count = 1;

            //foreach (int i in stack)
            //{
            //    if (i == target)
            //    {
            //        found = true;
            //        break;
            //    }
            //    count++;
            //}

            //if (found)
            //    Console.WriteLine($"Target was found successfully and the count = {count}");
            //else
            //    Console.WriteLine("Target was not found");
            #endregion

            #region Q9
            /*9. Given two arrays, find their intersection. Each element in the
             * result should appear as many times as it shows in both arrays.
                    Ex : 
                    Input :
                    5 , 3
                    [1,2,3,4,4] , [10,4,4]
                    Output : 
                    [4,4]
                */

            //Console.WriteLine("Enter First Array Elements separated by space: ");
            //List<int> lst1 = new(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            //Console.WriteLine("Enter Second Array Elements separated by space: ");
            //List<int> lst2 = new(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            //Console.Write("[");
            //foreach (int num in lst1)
            //{
            //    if (lst2.Contains(num))
            //    {
            //        Console.Write($"{num}, ");
            //        lst2.Remove(num);
            //    }
            //}
            //Console.Write("]");
            #endregion

            #region Q10
            /*10. Given an ArrayList of integers and a target sum, find if there
                  is a contiguous sub list that sums up to the target.
                    Ex : 
                    Input : 
                    [1, 2, 3, 7, 5]
                    12
                    Output : 
                    [2, 3, 7]
                    */

            //Console.WriteLine("Enter Array Elements: ");
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //int targetSum;
            //do
            //{
            //    Console.WriteLine("Enter A target sum: ");
            //} while (!int.TryParse(Console.ReadLine(), out targetSum));

            //List<int> list = new List<int>();
            //bool found = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    list.Clear();
            //    int sum = 0;
            //    for (int j = i; j < arr.Length; j++)
            //    {
            //        list.Add(arr[j]);
            //        sum += arr[j];
            //        if (sum == targetSum)
            //        {
            //            found = true;
            //            break;
            //        }
            //        if (sum > targetSum)
            //            break;
            //    }
            //    if (found)
            //        break;
            //}

            //if (found)
            //{
            //    foreach (int i in list)
            //        Console.Write($"{i}, ");
            //}
            //else
            //{
            //    Console.WriteLine("No result found");
            //}
            #endregion

            #region Q11
            /*11. Given a queue reverse first K elements of a queue, keeping
             * the remaining elements in the same order 
                    Ex : 
                    Input : 
                    [1 , 2 , 3 , 4 ,5]
                    K = 3
                    Output :
                    [3 , 2 , 1 , 4 ,5]
                    */

            //Console.WriteLine("Enter Queue Elements: ");
            //Queue<int> queue = new(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            //int k;
            //do
            //{
            //    Console.WriteLine("Enter K elements to reverse: ");
            //} while (!int.TryParse(Console.ReadLine(), out k));

            //Stack<int> stack = new Stack<int>();
            //for (int i = 0; i < k; i++)
            //{
            //    stack.Push(queue.Dequeue());
            //}
            //while (stack.Count > 0)
            //    queue.Enqueue(stack.Pop());

            //for (int i = 0; i < queue.Count - k; i++)
            //    queue.Enqueue(queue.Dequeue());

            //foreach (int i in queue)
            //    Console.Write($"{i}, ");
            #endregion
        }
    }
}
