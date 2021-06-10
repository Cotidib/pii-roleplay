using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class SwordTest
    {
        private Sword sword;

        [SetUp]
        public void SetUp()
        {
            sword = new Sword("Espadon", 50, "Corte Fugaz");
        }


        [Test]
        public void SwordCorrectlyInstanced()
        //Se prueba que la espada se instanció correctamente.
        {
            //Assert
            Assert.IsNotNull(sword);
        }

        [Test]
        public void AttackValueCheck()
        //Se prueba que el valor del ataque de la espada sea el esperado.
        {
            int expectedAttackValue = 50;

            //Assert
            Assert.AreEqual(expectedAttackValue, sword.Damage);
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre de la espada no sea null.
        {
            Assert.IsNotNull(sword.Name);
        }
    }
}