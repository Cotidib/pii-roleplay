using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CloakTest
    {
        private Cloak cloak;

        [SetUp]
        public void SetUp()
        {
            cloak = new Cloak("Capa maxima", 85, "Agilidad");
        }

        [Test]
        public void CloakCorrectlyInstanced()
        //Se prueba que la capa se instanció correctamente.
        {   
            //Assert
            Assert.IsNotNull(cloak);
        }

        [Test]
        public void DefenseValueCheck()
        //Se prueba que el valor de la defensa de la capa sea el esperado.
        {   
            int expectedDefenseValue = 85;

            //Assert
            Assert.AreEqual(expectedDefenseValue,cloak.Protection);
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre de la capa no sea null.
        {
            Assert.IsNotNull(cloak.Name);
        }
    }
}