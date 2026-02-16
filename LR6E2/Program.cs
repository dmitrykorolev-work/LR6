namespace LR6E2;

internal class Program
{
    static void Main(string[] args)
    {
        ISensor tempSensor = new TempSensor();
        ISensor pressureSensor = new PressureSensor();

        tempSensor.printValue();
        pressureSensor.printValue();
    }
}
