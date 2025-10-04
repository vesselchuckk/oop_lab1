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

		lion.GetSound(lion.Type);
		crocodile.ExistingTail();

		crocodile.DisplayInfo();
		lion.DisplayInfo();
	}
}