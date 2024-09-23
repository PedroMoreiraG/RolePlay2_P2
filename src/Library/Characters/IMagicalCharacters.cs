namespace Ucu.Poo.RoleplayGame;

//Creamos Interface para contener los characters magicos.
public interface IMagicalCharacters:ICharacters
{
    void AddItem(IMagicalItem item);
    void RemoveItem(IMagicalItem item);
}