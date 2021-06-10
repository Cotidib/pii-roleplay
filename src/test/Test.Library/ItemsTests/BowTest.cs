using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class BowTest
    {
        private Bow bow;

        [SetUp]
        public void SetUp()
        {
            bow = new Bow("Arco gigante", 75, "Tira fuego");
        }


        [Test]
        public void BowCorrectlyInstanced()
        //Se prueba que el arco se instanció correctamente.
        {
            //Assert
            Assert.IsNotNull(bow);
        }

        [Test]
        public void AttackValueCheck()
        //Se prueba que el valor del ataque del arco sea el esperado.
        {
            int expectedAttackValue = 75;

            //Assert
            Assert.AreEqual(expectedAttackValue, bow.Damage);
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre del arco no sea null.
        {
            Assert.IsNotNull(bow.Name);
        }
    }
}