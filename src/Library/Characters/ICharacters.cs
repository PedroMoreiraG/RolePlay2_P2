namespace Ucu.Poo.RoleplayGame;

//Interface para albergar los characters, con sus propiedades
public interface ICharacters
{
    public string Name { get; }
    public int Health { get; }
    int AttackValue { get; }
    int DefenseValue { get; }
    void Cure();
    void AddItem(IItem item);
    void RemoveItem(IItem item);
    void ReceiveAttack(ICharacters attacker);
}