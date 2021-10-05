using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionApp
{
	abstract class Animal
	{
		public void Type()
		{
			Console.WriteLine("type");
		}

		public abstract void Eat();
	}
}
