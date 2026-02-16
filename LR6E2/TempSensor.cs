namespace LR6E2;

internal class TempSensor : ISensor
{
    private Random rng = new Random();

    public double getValue()
    {
        double value = rng.NextDouble() * 100; // Simulate a temperature reading between 0 and 100
        return value;
    }
    public void printValue()
    {
        Console.WriteLine($"Temperature: { Math.Round( getValue(), 2 ) } °C");
    }
}
