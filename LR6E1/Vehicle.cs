namespace LR6E1;
internal abstract class Vehicle
{
    private protected string brand;
    private protected float speed;

    internal Vehicle(string brand, float speed)
    {
        this.brand = brand;
        this.speed = speed;
    }

    internal abstract void move();
}
