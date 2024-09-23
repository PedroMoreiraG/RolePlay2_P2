namespace Ucu.Poo.RoleplayGame;

public interface IMagicalCharacters:ICharacters
{
    void AddMagicalItem(IMagicalItem item);
    void RemoveMagicalItem(IMagicalItem item);
}