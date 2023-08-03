public class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name)
    {
        Health = 120;
        MaxHealth = 120;
        Attack Punch = new Attack("Punch", 20);
        Attack Kick = new Attack("Kick", 15);
        Attack Tackle = new Attack("Tackle", 25);
        this.AddAttack(Punch);
        this.AddAttack(Kick);
        this.AddAttack(Tackle);
    }

    public void Rage(Enemy Target)
    {
        Attack Rage = this.RandomAttack();
        Rage.DamageAmount += 10;
        Console.WriteLine("Building rage");
        this.PerformAttack(Target, Rage);
    }

}