namespace Ucu.Poo.RoleplayGame;

public class SpellsBook:IMagicalAttackItems
{
    public List<ISpell> Spells= new List<ISpell>();
        
    
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
            int attack = 0;
            foreach (ISpell spell in Spells)
            {
                attack += spell.AttackValue;
            }
            return attack;
        }
    }

    
    public int DefenseValue
    {
        get
        {
            int defense = 0;
            foreach (ISpell spell in Spells)
            {
                defense += spell.DefenseValue;
            }
            return defense;
        }
    }
}
