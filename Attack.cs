public class Attack
{
    public string Name {get; set;}
    public int DamageAmount {get; set;}

    public Attack (string name, int damageAmount)
    {
        Name = name;
        DamageAmount = damageAmount;
        Console.WriteLine($"The attack move, {Name}, has been created! It deals {DamageAmount} damage!");
    }

}