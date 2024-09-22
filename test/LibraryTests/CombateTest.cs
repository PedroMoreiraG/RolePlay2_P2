using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class CombateTest
    {
        private Wizard wizard;
        private Dwarf dwarf;

        [SetUp]
        public void SetUp()
        {
            wizard = new Wizard("Gandalf");
            dwarf = new Dwarf("Gimli");
        }

        [Test]
        public void TestWizardAttack()
        {
            wizard.AddItem(new Staff()); // Agrego un item 
            Assert.AreEqual(wizard.AttackValue, 100); // Verifico que su ataque sea 100 
        }
    }
}
