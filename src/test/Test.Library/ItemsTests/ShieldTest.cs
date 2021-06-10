using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ShieldTest
    {
        private Shield shield;

        [SetUp]
        public void SetUp()
        {
            shield = new Shield("Escudo Dorado", 25, "Escudazo");
        }

        [Test]
        public void GoldenShieldCorrectlyInstanced()
        //Se prueba que el escudo se instanció correctamente.
        {
            //Assert
            Assert.IsNotNull(shield);
        }

        [Test]
        public void DefenseValueCheck()
        //Se prueba que el valor de la defensa del escudo sea el esperado.
        {
            int expectedDefenseValue = 25;

            //Assert
            Assert.AreEqual(expectedDefenseValue, shield.Protection);
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre del escudo no sea null.
        {
            Assert.IsNotNull(shield.Name);
        }
    }
}