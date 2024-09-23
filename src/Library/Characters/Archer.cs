namespace Ucu.Poo.RoleplayGame;

public class Archer:ICharacters
{
    private int health;
    private string name;
    private List<IItem> Items= new List<IItem>();
    
    public Archer(string name)
    {
        this.name = name;
    }
    
    public string Name
    {
        get { return this.name; }
    }
    
    public int Health
    {
        get { return this.Health; }
        set { this.Health=value; }
    }
    
    
    public int DefenseValue
    {
        get
        {
            int defense = 0; //Lo defino y tambien reseteo
            foreach (IItem item in Items)
                //Recorre la lista de items y si este es un item de defensa, lo suma a la variable defense
            {
                if (item is IDefenseItems defenseItem)
                {
                    defense += defenseItem.DefenseValue;
                }
            }
            return defense;
        }
    }

    
    public int AttackValue
    {
        get
        {
            int attack = 0; //Lo defino y tambien reseteo
            foreach (IItem item in Items)
                //Recorre la lista de items y si este es un item de ataque, lo suma a la variable attack
            {
                if (item is IAttackItems attackItem)
                {
                    attack += attackItem.AttackValue;
                }
            }
            return attack;
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
    
    
    public void Cure()
    {
        this.Health = 100;
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
