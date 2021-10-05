using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionApp
{
	interface IAnimal
	{
		public int MyProperty { get; set; }
		void makeSound();
	}

	interface IAlive
	{
		void Breathe();
	}
	
}
