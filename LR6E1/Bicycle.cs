namespace LR6E1;

internal class Bicycle : Vehicle
{
    internal Bicycle(string brand, float speed) : base(brand, speed) { }

    internal override void move()
    {
        Console.WriteLine($"The bicycle {brand} is driving at a speed of {speed} km/h.");
    }
}
