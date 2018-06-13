using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblems{

	public class Program { 

		static int Add(string nbrs)		{
			var strArray = nbrs.Split(',');
			List<int> ints = new List<int>();
			foreach(var str in strArray) {
				int i;
				int.TryParse(str, out i);
				ints.Add(i);
			}
			var sum = ints.Sum();
			return sum;


		}			
	
		static void Main(string[] args)		{

			Console.WriteLine($"Enter the numbers you would like to add shit pirate:");
			string response = Console.ReadLine();
			var answer = Add(response);
			Console.WriteLine($"{response} is {answer}");
			





		}
	}
}
