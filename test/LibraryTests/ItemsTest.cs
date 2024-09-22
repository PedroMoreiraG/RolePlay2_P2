using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class ItemTest
    {
        private Axe axe;

        [SetUp]
        public void SetUp()
        {
            axe = new Axe();
        }

        [Test]
        public void TestAxeAttackValue()
        {
            Assert.AreEqual(axe.AttackValue, 25); // Verifica que el valor de ataque del hacha sea 25
        }
    }
}
