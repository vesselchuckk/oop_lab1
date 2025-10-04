using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");

		Animal lion = new Animal(
			"Leo",
			5,
			"Lion",
			4,
			AnimalType.Carnivore,
			AnimalHabitat.Grassland,
			Continent.Africa,
			190,
			true
		);

		Animal crocodile = new Animal("World Destoryer",
			120,
			"Reptile",
			4,
			AnimalType.Carnivore,
			AnimalHabitat.Aquatic,
			Continent.NorthAmerica,
			190,
			true
		);

		Figure square = new Figure(4); // квадрат со стороной 4
		Figure circle = new Figure(3, true); // круг с радиусом

		lion.GetSound(lion.Type);
		crocodile.ExistingTail();

		crocodile.DisplayInfo();
		lion.DisplayInfo();
	}
}