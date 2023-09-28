namespace ConsoleApp9;

public class Rogue : Character
{
    public Rogue(string name, int health, int damage, int armor, int strength, int agility, int intellect)
        : base(name, health, damage, armor, strength, agility, intellect)
    {
    }


    public override void Ability()
    {
        ShadowStrike();
    }

    private void ShadowStrike()
    {
        Damage *= 1.5;
    }
}