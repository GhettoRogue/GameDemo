namespace ConsoleApp9;

public abstract class Character : IStats
{
    public string Name { get; set; }
    public double Health { get; set; }
    public double Damage { get; set; }
    public double Armor { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intellect { get; set; }


    protected Character(string name, int health, int damage, int armor, int strength, int agility, int intellect)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Armor = armor;
        Strength = strength;
        Agility = agility;
        Intellect = intellect;
    }

    public abstract void Ability();
}