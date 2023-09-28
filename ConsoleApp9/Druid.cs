namespace ConsoleApp9;

public class Druid : Character
{
    public Druid(string name, int health, int damage, int armor, int strength, int agility, int intellect)
        : base(name, health, damage, armor, strength, agility, intellect)
    {
    }

    public override void Ability()
    {
        BearForm();
    }

    private void BearForm()
    {
        Health *= 2.5;
    }
}