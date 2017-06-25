using System;
using System.Collections;
using System.Collections.Generic;

namespace ListShuffle
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                myList.Add(i);
            }

            foreach (int num in myList)
            {
                Console.WriteLine(num.ToString());
            }

            myList.Shuffle();

            Console.WriteLine("****************");
            foreach(int num in myList)
            {
                Console.WriteLine(num.ToString());
            }
        }
    }

    static class MyExtensions
    {
		public static void Shuffle<T>(this IList<T> list)
		{
			int n = list.Count;
            Random myRand = new Random();
			while (n > 1)
			{
				n--;
				int k = myRand.Next(n + 1);
				T value = list[k];
				list[k] = list[n];  // n'th element's value is now being stored
                                    // at the k'th element
				list[n] = value;
			}
		}

	}
}
