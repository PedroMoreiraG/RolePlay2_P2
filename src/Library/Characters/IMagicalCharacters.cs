namespace Ucu.Poo.RoleplayGame;

//Creamos Interface para contener los characters magicos.
public interface IMagicalCharacters:ICharacters
{
    void AddMagicalItem(IMagicalItem item);
    void RemoveMagicalItem(IMagicalItem item);
}