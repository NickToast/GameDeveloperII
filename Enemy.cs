public class Enemy
{
    public string Name {get; set;}
    public int Health {get; set;}
    public int MaxHealth {get; set;}

    //Make Enemy's Health attribute private and add a Public version that lets us just see the value of private health

    public List<Attack> AttackList {get; set;}

    public Enemy (string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
        Console.WriteLine($"A new enemy, {Name}, has arrived!");
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public Attack RandomAttack()
    {
        Random rand = new Random();
        Attack randomAttack = AttackList[rand.Next(0, AttackList.Count)];
        Console.WriteLine(randomAttack.Name);
        return randomAttack;
    }

    //Inside Enemy class
    public virtual void PerformAttack (Enemy Target, Attack ChosenAttack)
    {
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        if (Target.Health <= 0)
        {
            Console.WriteLine("Cannot attack an enemy with no health!");
        } else {
            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }
    }

}