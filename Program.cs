using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secret
{
	class Program
	{
		static void Main(string[] args)
		{
			int secret = (new Random()).Next(1, 100);
			int GUESS = Convert.ToInt32(Console.ReadLine());
			while(GUESS != secret)
			{
				if (GUESS < secret) 
					Console.WriteLine("too small");
				else Console.WriteLine("too big");
				GUESS = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine("Bingo");

		}
	}
}
