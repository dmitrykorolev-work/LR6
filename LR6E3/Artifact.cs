namespace LR6E3;

internal class Artifact
{
    private int id;

    internal Artifact(int id)
    {
        this.id = id;
    }

    internal virtual void Identify()
    {
        Console.WriteLine($"[Artifact ID: {id}] Це невідомий стародавній предмет.");
    }
}