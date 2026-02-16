namespace LR6E2;

internal class PressureSensor : ISensor
{
    private Random rng = new Random();

    public double getValue()
    {
        double value = rng.NextDouble() * 200; // Simulate a pressure reading between 0 and 200
        return value;
    }
    public void printValue()
    {
        Console.WriteLine($"Pressure: { Math.Round( getValue(), 2 ) } kPa");
    }
}
