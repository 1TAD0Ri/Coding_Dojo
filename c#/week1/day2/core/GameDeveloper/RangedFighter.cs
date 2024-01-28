public class RangedFighter : Enemy
{
    public int Distance { get; set; }
    static private Attack ShootArrow = new("Shoot an Arrow",20);
    static private Attack ThrowKnife = new("Throw a Knife",15);
    static private List<Attack> Attacks = [ShootArrow,ThrowKnife];
    public RangedFighter(string name):base(name,Attacks)
    {
        Distance=15;
    }
public override Attack RandomAttack()
{
    if (Distance < 10)
    {
        Console.WriteLine($"{Name} can't attack because the distance is less than 10.");
        return null; 
    }
    return base.RandomAttack();
}
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance < 10)
        {
            Console.WriteLine($"{Name} can't attack because the distance is less than 10.");
        }
        else
        {
            base.PerformAttack(Target, ChosenAttack);
        }
    }
}