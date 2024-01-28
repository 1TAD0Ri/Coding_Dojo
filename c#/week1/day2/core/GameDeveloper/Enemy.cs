public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }=100;
    public List<Attack> AttackList { get; set; }

    public Enemy(string name, List<Attack> attacks)
    {
        Name = name;
        AttackList = attacks;
    }
    static Random random = new Random();
    public virtual Attack RandomAttack()
    {
        return AttackList[random.Next(AttackList.Count())];
    }
    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }
    // Inside of the Enemy class
    public virtual void  PerformAttack(Enemy Target, Attack ChosenAttack)
    {

        Target.Health-=ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        if (Target.Health<=0)

        {
            System.Console.WriteLine($"{Target.Name} is dead");
        }
    }
}