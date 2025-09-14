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
	public virtual void MakeSound()
	{
		Console.WriteLine($"{name} makes a sound");
	}

	public void DisplayInfo()
	{
		Console.WriteLine($"Name: {name}, Age: {age}, Species: {species}");
	}
}
