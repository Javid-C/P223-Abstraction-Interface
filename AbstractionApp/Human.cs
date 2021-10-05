using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionApp
{
	abstract class Human
	{
		public string Firstname;
		public string Surname;

		public Human(string firstname, string surname)
		{
			Firstname = firstname;
			Surname = surname;
		}

		//public  void GetInfo()
		//{
		//	Console.WriteLine("Human");
		//}

	}
}
