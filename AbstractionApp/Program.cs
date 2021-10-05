using System;

namespace AbstractionApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//Human human = new Human();
			//human.GetInfo();
			//Human teacher = new Teacher();
			//teacher.GetInfo();
			//Human student = new Student();
			//student.GetInfo();

			//Teacher teacher = new Teacher("Javid","Asadullayev");
			//Console.WriteLine(teacher.Firstname);

			//Student student = new Student("Niyazi","Abbasov");

			//Console.WriteLine(student.Surname);


			Shark shark = new Shark();
			//shark.Eat();

			Dog dog = new Dog();
			//dog.Eat();

			shark.makeSound();
			dog.makeSound();

		}
		
	}
}
