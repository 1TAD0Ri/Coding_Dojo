public class MagicCaster : Enemy
{
    static private Attack FireBall = new("FireBall", 20);
    static private Attack Lightining = new("Lightning", 20);
    static private Attack StaffStrike = new("Staff Strike", 10);
    static private List<Attack> Attacks = [FireBall, Lightining, StaffStrike];
    public MagicCaster(string name) : base(name, Attacks)
    {
        Health = 80;
    }

    private void Heal(Enemy target)
    {
        target.Health += 40;
        System.Console.WriteLine($"{Name} healed {target.Name} \n{target.Name} health became {target.Health}");
    }


}