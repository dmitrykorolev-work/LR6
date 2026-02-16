namespace LR6E1;

internal class Car : Vehicle, IRefuelable
{
    internal Car(string brand, float speed) : base(brand, speed) { }

    internal override void move()
    {
        Console.WriteLine($"The car {brand} is driving at a speed of {speed} km/h.");
    }

    public void refill()
    {
        Console.WriteLine($"The car {brand} is refueling.");
    }
}
