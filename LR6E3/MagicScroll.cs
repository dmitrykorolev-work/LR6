namespace LR6E3;

internal class MagicScroll : Artifact
{
    internal MagicScroll(int id) : base(id)
    {
    }

    internal override void Identify() // Using the 'new' operator here will hide the base class method, but will not override it.
    {
        Console.WriteLine("[Magic Scroll] Це сувій з закляттям вогню.");
    }
}
