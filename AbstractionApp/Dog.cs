using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionApp
{
	class Dog : Animal,IAnimal,IAlive
	{
		public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Breathe()
		{
			Console.WriteLine("fs fs");
		}

		public override void Eat()
		{
			throw new NotImplementedException();
		}

		public void makeSound()
		{
			Console.WriteLine("hav hav");
		}
	}
}
