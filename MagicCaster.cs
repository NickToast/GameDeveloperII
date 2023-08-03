public class MagicCaster : Enemy
{
    public MagicCaster(string name) : base(name)
    {
        Health = 80;
        MaxHealth = 80;
        Attack Fireball = new Attack("Fireball", 25);
        Attack LightningBolt = new Attack("Lightning Bolt", 20);
        Attack StaffStrike = new Attack("Staff Strike", 10);
        this.AddAttack(Fireball);
        this.AddAttack(LightningBolt);
        this.AddAttack(StaffStrike);
    }

    public void Heal(Enemy Target)
    {
        int healAmount = 40;
        if (Target.Health <= 0)
        {
            Console.WriteLine("Cannot heal an enemy that has already died.");
        }
        if ((healAmount + Target.Health) > Target.MaxHealth)
        {
            Target.Health = Target.MaxHealth;
        }
        else
        {
            Target.Health += healAmount;
        }
        Console.WriteLine($"{Target.Name} was healed for {healAmount} by {this.Name}. {Target.Name}'s health is now {Target.Health}.");
    }

}