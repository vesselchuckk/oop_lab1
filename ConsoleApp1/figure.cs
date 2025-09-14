public class Figure
{
	private double _square;

	public double Square
	{
		get { return _square; }
	}

	public Figure(double side)
	{
		_square = side * side;
	}

	/// <summary>
	/// Конструктор для круга
	/// </summary>
	/// <param name="radius"></param>
	/// <param name="isCircle"></param>
	public Figure(double radius, bool isCircle)
	{
		if (isCircle)
			_square = Math.PI * radius * radius;
		else
			_square = radius * radius; // если не круг - то квадрат
	}

	/// <summary>
	/// Конструктор для круга
	/// </summary>
	/// <param name="radius"></param>
	/// <param name="isCircle"></param>
	public Figure(double basis, double height, bool isTriangle)
	{
		if (isTriangle)
			_square = 0.5 * basis * height;
		else
			_square = basis * height; // если не треугольник - то квадрат
	}
}