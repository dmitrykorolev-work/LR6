namespace LR6E1;

internal class Airplane : Vehicle, IRefuelable
{
    internal Airplane(string brand, float speed) : base(brand, speed) { }

    internal override void move()
    {
        Console.WriteLine($"The airplane {brand} is flying at a speed of {speed} km/h.");
    }

    public void refill()
    {
        Console.WriteLine($"The airplane {brand} is refueling.");
    }
}
