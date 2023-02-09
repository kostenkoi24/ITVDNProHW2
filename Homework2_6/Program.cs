using System;
using System.Collections;

namespace Homework2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new SortedList(new DescendingComparer());

            sort[1] = "1st";
            sort[2] = "2nd";
            sort[3] = "3rd";
            sort[4] = "4th";
            

            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            

            sort = new SortedList(sort,new AscendingComparer());
            
            
            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            // Delay.
            Console.ReadKey();
        }



    }


    public class DescendingComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            int result = comparer.Compare(y, x);
            return result;
        }
    }

    public class AscendingComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            int result = comparer.Compare(x, y);
            return result;
        }
    }


}
