namespace LR6E1;

internal class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car("Toyota", 120),
            new Bicycle("Giant", 25),
            new Airplane("Boeing", 900)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.move();

            if (vehicle is IRefuelable refuelable)
            {
                refuelable.refill();
            }
        }
    }
}
