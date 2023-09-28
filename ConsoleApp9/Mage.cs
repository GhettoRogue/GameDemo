namespace ConsoleApp9;

public class Mage : Character
{
    public Mage(string name, int health, int damage, int armor, int strength, int agility, int intellect)
        : base(name, health, damage, armor, strength, agility, intellect)
    {
    }

    public override void Ability()
    {
        MagicShield();
    }

    private void MagicShield()
    {
        Armor *= 2.5;
    }
}