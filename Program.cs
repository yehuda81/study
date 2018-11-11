using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1=add");
			Console.WriteLine("2=sub");
			Console.WriteLine("3=mul");
			Console.WriteLine("4=div");
			Console.WriteLine("5=exit");
			Console.WriteLine("choose option");
			int opt = Convert.ToInt32(Console.ReadLine());
			if (opt>0)
			{
				while (opt < 5)
				{
					Console.WriteLine("enter nomber1");
					int a = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("enter nomber2");
					int b = Convert.ToInt32(Console.ReadLine());
					if (opt == 1)
					{
						int ans = a + b;
						Console.WriteLine(ans);
					}

					else if (opt == 2)
					{
						int ans = a - b;
						Console.WriteLine(ans);
					}
					else if (opt == 3)
					{
						int ans = a * b;
						Console.WriteLine(ans);
					}
					else if (opt == 4)
					{
						int ans = a / b;
						Console.WriteLine(ans);
					}
					else
					{
						Console.WriteLine("wrong option");
					}
					Console.WriteLine("choose option");
					opt = Convert.ToInt32(Console.ReadLine());
				}
				Console.WriteLine("wrong option");

			}


		}
	}
}
