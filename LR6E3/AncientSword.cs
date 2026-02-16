namespace LR6E3;

internal class AncientSword: Artifact
{
    internal AncientSword(int id) : base(id)
    {
    }

    internal override void Identify() // Using the 'new' operator here will hide the base class method, but will not override it.
    {
        Console.WriteLine("[Ancient Sword] Це заіржавілий меч короля.");
    }
}
