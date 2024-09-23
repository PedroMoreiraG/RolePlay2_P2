using NUnit.Framework;
using Ucu.Poo.RoleplayGame;
namespace Library.Tests;

[TestFixture]
public class Test
{
    [Test]
    public void CheckAttack()
    {
        ICharacters gandalf = new Archer("Gandalf");
        ICharacters gimli = new Dwarf("Gimli");

        IItem espada = new Sword();
        IItem escudo = new Shield();
        IItem hacha = new Axe();
        IItem baculo = new Staff();
        IItem arco = new Bow();

        gandalf.AddItem(hacha);
        gandalf.AddItem(baculo);
        gandalf.AddItem(espada);
        gimli.AddItem(escudo);
        gimli.AddItem(arco);
    }
}
