namespace Ucu.Poo.RoleplayGame;

public interface IMagicalCharacters:ICharacters
{
    void AddItem(IMagicalItem item);
    void RemoveItem(IMagicalItem item);
}