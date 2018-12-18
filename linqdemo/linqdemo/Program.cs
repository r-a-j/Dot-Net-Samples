using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
	class Program
	{
		static void Main(string[] args)
		{
			employee[] obj1 =
			{
				new employee{name="Raj", age=23},
				new employee{name="Yogesh", age=56},
				new employee{name="Urvesh", age=13},
				new employee{name="Pankaj", age=44},
			};


			//By Query Syntax method
			//IEnumerable<string> empobj = from i in obj1 where i.age > 25 orderby i.age select i.name;

			IEnumerable<string> empobj = obj1.Where(x => x.age > 25).OrderBy(x => x.age).Select(x => x.name);

			foreach(string output in empobj)
			{
				Console.WriteLine(output);
			}
			Console.ReadLine();

		}
			class employee
			{
				public string name;
				public int age;
			}
	}
}

