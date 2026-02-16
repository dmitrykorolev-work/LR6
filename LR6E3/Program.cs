namespace LR6E3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<Artifact> inventory = new List<Artifact>(); // When upcasting, calling a method hidden via 'new' will call the base implementation

        inventory.Add(new MagicScroll(101));
        inventory.Add(new AncientSword(202));

        Console.WriteLine("--- Аналіз інвентарю ---");

        foreach (var item in inventory)
        {
            item.Identify();
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}