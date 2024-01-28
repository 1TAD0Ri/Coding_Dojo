public class MeleeFighter : Enemy
{
    static public Attack Punch=new("Punch",20);
    static private Attack Kick = new("Kick",15);
    static private Attack Tackle =new("Tackle",25);
    static private List<Attack> Attacks =[Kick,Tackle,Punch];
    static Random random = new Random();
    public MeleeFighter(string name): base(name,Attacks)
    {
        Name=name;
        Health=120;
    }
    public void Rage()
    {
        foreach (Attack item in AttackList)
        {
            item.DamageAmount+=10;
        }
    }
}