using NUnit.Framework;
using Ucu.Poo.RoleplayGame;
namespace Library.Tests;

[TestFixture]
public class CharacterTests
{
    ICharacters gandalf = new Archer("Gandalf");
    ICharacters gimli = new Dwarf("Gimli");
    IItem espada = new Sword();
    IItem escudo = new Shield();
    IItem hacha = new Axe();
    IItem baculo = new Staff();
    IItem arco = new Bow();
    
    
    [Test]
    public void CheckAttack()
    {
        gandalf.AddItem(hacha);
        gandalf.AddItem(baculo);
        gandalf.AddItem(espada);
        gimli.AddItem(escudo);
        gimli.AddItem(arco);
        
        gimli.ReceiveAttack(gandalf);
        gimli.Cure();
        gimli.ReceiveAttack(gandalf);
        gimli.ReceiveAttack(gandalf);
        //Comprobamos que funcione bien el ataque y la cura
    }
    
    
    [Test]
    public void CheckSelfAttack()
    {
        gandalf.AddItem(hacha);
        gandalf.AddItem(baculo);
        gandalf.AddItem(espada);
        gimli.AddItem(escudo);
        gimli.AddItem(arco);
        
        gimli.ReceiveAttack(gimli); 
        //Comprobamos que se podia a atacar a si mismo y por esta misma razon agregamos un if para que esto no suceda
    }
    
    
    [Test]
    public void CheckRemoveItem()
    {
        gandalf.AddItem(hacha);
        gandalf.AddItem(baculo);
        gandalf.AddItem(espada);
        gimli.AddItem(escudo);
        gimli.AddItem(arco);
        gandalf.RemoveItem(hacha);
        gandalf.RemoveItem(baculo);
        gandalf.RemoveItem(espada); 
        //Comprobamos que funcione bien el poder remover los objetos
        
        gimli.ReceiveAttack(gandalf);
    }
}