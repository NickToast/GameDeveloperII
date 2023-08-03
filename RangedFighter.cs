public class RangedFighter : Enemy
{
    public int Distance {get; set;}

    public RangedFighter(string name) : base(name)
    {
        MaxHealth = 100;
        Distance = 5;
        Attack Arrow = new Attack("Arrow", 20);
        Attack ThrowingKnife = new Attack("Throw a Knife", 15);
        this.AddAttack(Arrow);
        this.AddAttack(ThrowingKnife);
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Target.Health <= 0)
        {
            Console.WriteLine($"{Target.Name} is already at 0 HP!");
        }
        if (this.Distance < 10)
        {
            Console.WriteLine($"{this.Name} is too close to the enemy and cannot attack!");
        } else {
            base.PerformAttack(Target, ChosenAttack);
        }
    }

    public void Dash()
    {
        this.Distance = 20;
        Console.WriteLine($"{this.Name} used Dash! They are now {this.Distance} units away!");
    }

}