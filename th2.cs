using System.Data.Common;
using System.Dynamic;

public abstract class Animal
{
    protected string Weight { get; set; }
    protected string Height { get; set; }

    public Animal(string Weight, string Height)
    {
        this.Weight = Weight;
        this.Height = Height;
    }
    public abstract void PrintInfo();

}

class Cat : Animal
{
    private string Name { get; set; }
    public Cat(string weight, string height, string name)
    : base(weight, height)
    {
        this.Name = name;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
    }
    static void Main(string[] args)
    {
        Cat cat = new Cat("20kg", "1.5", "kitty");
        cat.PrintInfo();
    }
}


