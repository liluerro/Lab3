//Task 1

using System;

class Circle
{
    static void Main(string[] args)
    {
        Console.Write("Введiть значення х:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть значення y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть значення радiусу:");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(x, y, radius);
        circle.PrintInfo();
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }
    public Circle(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }
    public double S()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    public double length()
    {
        return 2 * Math.PI * Radius;
    }
    public double D()
    {
        return 2 * Radius;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Центр кола: ({X}, {Y})");
        Console.WriteLine($"Радiус: {Radius}");
        Console.WriteLine($"Дiаметр: {D()}");
        Console.WriteLine($"Площа: {S():F2}");
        Console.WriteLine($"Довжина кола: {length():F2}");
    }
}