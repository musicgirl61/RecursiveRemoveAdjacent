using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveRemoveAdjacent
{
	class Program
	{
		// iterative version
		//static string removeIterative(string s)
		//{
		//	StringBuilder sb = new StringBuilder();
		//	bool repeat = false;

		//	for (int i = 1; i < s.Length; ++i)
		//	{
		//		if (s[i - 1] != s[i])
		//		{
		//			if (!repeat)
		//			{
		//				sb.Append(s[i - 1]);
		//			}
		//			repeat = false;
		//		}
		//		else
		//		{
		//			repeat = true;
		//		}

		//	}

		//	return sb.ToString();
		//}

		//recursive version
		static void remove(string s, int i, StringBuilder sb, bool repeat)
		{
			if (i == s.Length) return;

			if (s[i - 1] != s[i])
			{
				if (!repeat)
				{
					sb.Append(s[i - 1]);
				}
				repeat = false;
			}
			else
			{
				repeat = true;
			}
			remove(s, i + 1, sb, repeat);
		}


		// iterative version
		static string removeAdjacent(string s)
		{
			StringBuilder sb = new StringBuilder();
			bool repeat = false;
			remove(s, 1, sb, repeat);
			return sb.ToString();
		}

		static void Main(string[] args)
		{
			Console.WriteLine(removeAdjacent("geeksforgeek"));
			Console.WriteLine(removeAdjacent("acaaabbbacdddd"));

			Console.ReadKey();

		}
	}
}
