namespace Ucu.Poo.RoleplayGame;

//Creamos Interface para contener los items de Ataque
public interface IAttackItems:IItem
{
    int AttackValue { get; }
}