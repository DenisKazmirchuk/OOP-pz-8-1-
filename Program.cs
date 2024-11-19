using System;

class Program
{
    // Делегат для обчислення площі
    delegate double AreaDelegate();

    // Метод для обчислення площі кола
    static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Метод для обчислення площі квадрату
    static double SquareArea(double side)
    {
        return side * side;
    }

    static void Main(string[] args)
    {
        // Введення радіуса кола
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        // Введення сторони квадрату
        Console.Write("Enter the side of the square: ");
        double side = double.Parse(Console.ReadLine());

        // Створення делегатів для кожної фігури
        AreaDelegate circleDelegate = () => CircleArea(radius);
        AreaDelegate squareDelegate = () => SquareArea(side);

        // Виклик делегатів
        double circleArea = circleDelegate();
        double squareArea = squareDelegate();

        // Виведення площ фігур
        Console.WriteLine($"\nCircle Area: {circleArea:F2}");
        Console.WriteLine($"Square Area: {squareArea:F2}");

        // Порівняння площ
        if (circleArea > squareArea)
        {
            Console.WriteLine("\nThe circle has a larger area.");
        }
        else if (squareArea > circleArea)
        {
            Console.WriteLine("\nThe square has a larger area.");
        }
        else
        {
            Console.WriteLine("\nThe areas are equal.");
        }

        Console.ReadKey();
    }
}

