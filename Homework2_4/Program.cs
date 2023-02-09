using System;
using System.Collections;
using System.Collections.Specialized;

namespace Homework2_4
{
    class Program
    {
        static void Main(string[] args)
        {
			var m1 = new OrderedDictionary
								  {
									  {"sbishop@contoso.com", "Bishop, Scott"},
									  {"chess@contoso.com", "Hell, Christian"},
									  {"djump@contoso.com", "Jump, Dan"}
								  };

			var m2 = new OrderedDictionary
								  {
									  {"sbishop@contoso.com", "Bishop, Scott"},
									  {"chess@contoso.com", "Hell, Christian"}
								  };

			

			Console.WriteLine(m1.Equals(m1));
			Console.WriteLine(m1.Equals(m2));



			// Delay
			Console.ReadKey();
		}
    }
}
