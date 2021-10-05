using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionApp
{
	class Shark : Animal,IAnimal,IAlive
	{
		public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void Breathe()
		{
			Console.WriteLine("");
		}

		public override void Eat()
		{
			Console.WriteLine("fish");
		}

		public void makeSound()
		{
			Console.WriteLine("blop blop");
		}
	}



}
