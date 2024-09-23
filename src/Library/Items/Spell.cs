namespace Ucu.Poo.RoleplayGame;

public class Spell:ISpell
{
    public int AttackValue{get;}
    public int DefenseValue{get;}

    public Spell(string name, int attack)
    {
        this.AttackValue = attack;
    }
}
