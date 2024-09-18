namespace Ucu.Poo.RoleplayGame;

public class Wizard:ICharacters
{
    private int health = 100;
    private List<IItem> items = new List<IItem>();

    public Wizard(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public SpellsBook SpellsBook { get; set; }

    public Staff Staff { get; set; }

    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return SpellsBook.DefenseValue + Staff.DefenseValue;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }
    
    public void AddItem(IItem item)
    {
        this.items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        this.items.Remove(item);
    }
}
