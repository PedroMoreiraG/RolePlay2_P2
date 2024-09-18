namespace Ucu.Poo.RoleplayGame;

public interface ICharacters
{
    public string Name { get; }
    public int Health { get; }
    int AttackValue { get; }
    int DefenseValue { get; }
    void Cure();
}