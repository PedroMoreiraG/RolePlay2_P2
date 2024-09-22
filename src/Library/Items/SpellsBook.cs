namespace Ucu.Poo.RoleplayGame;

public class SpellsBook:IMagicalItem
{
    private List<ISpell> Spells= new List<ISpell>();
        
    public  void  AddSpell(ISpell spell )   
    {
        Spells.Add(spell);
    }
    
    // Para sacar hechizos
    public void RemoveSpell (ISpell spell )
    {
        Spells.Remove(spell);
    }
    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (ISpell spell in Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (ISpell spell in Spells)
            {
                value += spell.DefenseValue;
            }
            return value;
        }
    }
}
