namespace ConsoleApp9;

public class Priest : Character
{
    public Priest(string name, int health, int damage, int armor, int strength, int agility, int intellect)
        : base(name, health, damage, armor, strength, agility, intellect)
    {
    }

    public override void Ability()
    {
        LastStand();
    }

    private void LastStand()
    {
        Health *= 1.5;
    }
}