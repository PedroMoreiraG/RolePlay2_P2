namespace Ucu.Poo.RoleplayGame;

public class Archer:ICharacters
{
    private int health = 100;
    private List<IItem> items = new List<IItem>();

    public Archer(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    
    public Bow Bow { get; set; }

    public Helmet Helmet { get; set; }

    public int AttackValue
    {
        get
        {
            return Bow.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return Helmet.DefenseValue;
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
