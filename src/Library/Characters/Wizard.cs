namespace Ucu.Poo.RoleplayGame;

public class Wizard:IMagicalCharacters
{
    private int health;
    private string name;
    private List<IItem> Items= new List<IItem>();
    private List<IMagicalItem> MagicalItems= new List<IMagicalItem>();

    public Wizard(string name)
    {
        this.name = name;
    }
    
    public string Name
    {
        get { return this.name; }
    }
    
    public int Health
    {
        get{ return this.health; }
        set{ this.health=value; }
    }


    public int AttackValue
    {   
        get
        {
            int attack = 0;
            foreach (IItem item in Items)
                //Recorre la lista de items y si este es un item de defensa, lo suma a la variable defense
            {
                if (item is IAttackItems attackItem)
                {
                    attack += attackItem.AttackValue;
                }
            }

            foreach (IMagicalItem item in MagicalItems)
            {
                if (item is SpellsBook spellsbook)
                {
                    attack += spellsbook.AttackValue;
                }
            }
            return attack;
        }
    }
    
    
    public int DefenseValue
    {   
        get
        {
            int defense = 0;
            foreach (IItem item in Items)
                //Recorre la lista de items y si este es un item de defensa, lo suma a la variable defense
            {
                if (item is IDefenseItems defenseItem)
                {
                    defense += defenseItem.DefenseValue;
                }
            }

            foreach (IMagicalItem item in MagicalItems)
            {
                if (item is SpellsBook spellsBook)
                {
                    defense += spellsBook.DefenseValue;
                }
            }
            return defense;
        }
    }


    public void AddItem(IItem item)
    {
        this.Items.Add(item);
    }
    
    
    public void RemoveItem(IItem item)
    {
        this.Items.Remove(item);

    }
    
    
    public void AddMagicalItem(IMagicalItem item)
    {
        this.MagicalItems.Add(item);

    }
    
    
    public void RemoveMagicalItem(IMagicalItem item)
    {
        this.MagicalItems.Remove(item);

    }
    
    
    public void Cure()
    {
        this.Health=100;
    }
    
    
    public void ReceiveAttack(ICharacters attacker)
    {
        if (attacker.Name != this.name) //Para que no se ataque a si mismo
        {
            if (this.health > 0) //Para saber si esta vivo
            {
                if (attacker.AttackValue > this.DefenseValue) 
                    //Si el ataque es mas alto que la defensa, resta la defensa al ataque y baja sus puntos de vida
                {
                    int damage = attacker.AttackValue - this.DefenseValue;
                    this.health -= damage;
                    Console.WriteLine($"El ataque ha vencido las defensas de {this.name}.\nVida restante: {this.health}");
                }
                else
                {
                    //Si no lo es, no le resta puntos de vida
                    Console.WriteLine($"Los escudos de {this.name} resistieron el ataque.\nEscudo restante: {this.DefenseValue}");
                }
            }
            else
            {
                Console.WriteLine($"{this.name}, no tiene puntos de vida, necesita curación.");
            }
        }
        else
        {
            Console.WriteLine($"{this.name}, no te puedes atacar a ti mismo");
        }
    }
}
