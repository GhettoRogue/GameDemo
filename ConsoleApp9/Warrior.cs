namespace ConsoleApp9;

public class Warrior : Character
{
    public Warrior(string name, int health, int damage, int armor, int strength, int agility, int intellect)
        : base(name, health, damage, armor, strength, agility, intellect)
    {
    }

    public override void Ability()
    {
        BattleCry();
    }

    private void BattleCry()
    {
        Damage *= 1.5;
    }
}