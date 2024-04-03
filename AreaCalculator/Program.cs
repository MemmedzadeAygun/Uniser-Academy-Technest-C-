
using AreaCalculator.Class;

Console.WriteLine("Area Calculator");
Console.WriteLine("1.Calculate The area of Triangle");
Console.WriteLine("2.Calculate The area of circle");
Console.WriteLine("2.Calculate The area of Rectangle");
Console.Write("Please enter your choice: ");

int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        {
            Console.WriteLine("Enter the first side of triangle: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second side of triangle: ");
            int side2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third side of triangle: ");
            int side3 = Convert.ToInt32(Console.ReadLine());


            Triangle triangle = new Triangle();
            triangle.Side1 = side1;
            triangle.Side2 = side2;
            triangle.Side3 = side3;

            Console.WriteLine(triangle.CalcAreaOfTriangle());
        }
         break;

    case 2:
        Console.Write("Enter the radius of Circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        Circle circle = new Circle();
        circle.Radius = radius;

       Console.WriteLine(circle.CalcAreaOfCircle());
        break;

    case 3:
        Console.Write("Enter the rectangle of side1: ");
        int rside1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the reactangle of side2: ");
        int rside2 = Convert.ToInt32(Console.ReadLine());

        Rectangle rectangle = new Rectangle();
        rectangle.Side1 = rside1;
        rectangle.Side2 = rside2;

        Console.WriteLine(rectangle.CalcAreaOfRectangle());
        break;

    default:
        Console.WriteLine("This Type of operation does not exist.");
        break;
}
