public class Rectangle
{
    double width, height;

    public Rectangle() { }

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double getArea()
    {
        return width * height;
    }

    public double getPerimeter()
    {
        return 2 * width + 2 * height;
    }

    public string display()
    {
        return "width: " + width + " height: " + height;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the width: ");
        double width = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the height: ");
        double height = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);

        System.Console.WriteLine("Your rectangle is: " + rectangle.display());
        System.Console.WriteLine("Perimeter: " + rectangle.getPerimeter());
        System.Console.WriteLine("Area of the rectangle: " + rectangle.getArea());
    }
}