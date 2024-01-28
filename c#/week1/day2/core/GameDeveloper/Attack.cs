public class Attack
{
    public string Name { get; set; }
    public int DamageAmount { get; set; }

    public Attack(string name,int dmg)
    {
        Name=name;
        DamageAmount=dmg;
    }
}