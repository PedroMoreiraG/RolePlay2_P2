using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace Ucu.Poo.RoleplayGame.Tests
{
    [TestFixture]
    public class CharacterTest
    {
        private Archer archer;

        [SetUp]
        public void SetUp()
        {
            archer = new Archer("Legolas");
        }

        [Test]
        public void TestArcherHealth()
        {
            Assert.AreEqual(archer.Health, 100); // verifico que la salud inicial ya sea 100 
        }

        [Test]
        public void TestArcherCure()
        {
            archer.Health = 50; //Cambio la salud 
            archer.Cure(); // Curo al arquero 
            Assert.AreEqual(archer.Health, 100); // Verifico que la salud sea 100 
        }
    }
}
