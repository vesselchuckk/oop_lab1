public class Animal
{
	private string name { get; set; }
	private int age { get; set; }
	private string species { get; set; }
	private int limbCount;
	private AnimalType type;
	private AnimalHabitat habitat;
	private Continent continent;
	private int weight;
	private bool hasTail;

	public int WeightProperty
	{
		set { weight = value; }
	}

	public int Age
	{
		get { return age; }
	}

	public AnimalType Type
	{
		get { return type; }
	}

	public Animal() {
		name = "Unknown";
		age = 0;
		limbCount = 0;
		type = AnimalType.Herbivore;
		habitat = AnimalHabitat.Forest;
		continent = Continent.Africa;
		weight = 0;
		hasTail = false;
	}

	public Animal(string name, int age, string species, int limbCount, AnimalType type, AnimalHabitat habitat, Continent continent, int weight, bool hasTail)
	{
		this.name = name;
		this.age = age;
		this.species = species;
		this.limbCount = limbCount;
		this.type = type;
		this.habitat = habitat;
		this.continent = continent;
		this.weight = weight;
		this.hasTail = hasTail;
	}
	
	// Methods
		public bool ExistingTail()
	{
		return hasTail;
	}

	public static bool operator !=(Animal a, Animal b)
	{
		return !(a == b);
	}

	public static bool operator ==(Animal a, Animal b)
	{
		return a.name == b.name &&
						a.age == b.age &&
						a.limbCount == b.limbCount &&
						a.type == b.type &&
						a.habitat == b.habitat &&
						a.continent == b.continent &&
						a.weight == b.weight;
	}

	public string GetSound(AnimalType type)
	{
		return type switch
		{
			AnimalType.Herbivore => "Bleat",
			AnimalType.Omnivore => "Growl",
			AnimalType.Carnivore => "Roar",
			_ => "Unknown sound"
		};
	}

	public static string Movement(AnimalHabitat habitat)
	{
		return habitat switch
		{
			AnimalHabitat.Forest => "Walk",
			AnimalHabitat.Desert => "Crawl",
			AnimalHabitat.Aquatic => "Swim",
			AnimalHabitat.Mountain => "Climb",
			AnimalHabitat.Air => "Fly",
			_ => "Unknown movement"
		};
	}

	public static string CanFly(AnimalHabitat habitat)
	{
		return habitat == AnimalHabitat.Air ? "Can fly" : "Cannot fly";
	}

	public static string CanSwim(AnimalHabitat habitat)
	{
		return habitat == AnimalHabitat.Aquatic ? "Can swim" : "Cannot swim";
	}



	public void DisplayInfo()
	{
		Console.WriteLine($"Name: {name}, Age: {age}, Species: {species}");
	}
}
