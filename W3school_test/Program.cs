using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3school_test
{
    internal class Program
    {
		class Car
		{
			string strName = "kosalvireak";
			int intAge = 19;
			static void Main(string[] args)
			{
				Car myObj = new Car();
				Console.WriteLine(myObj.strName);
				Console.WriteLine(myObj.intAge);
			}
		}


	}
}
