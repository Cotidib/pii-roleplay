using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DragonArmorTest
    {
        private DragonArmor dragonArmor;

        [SetUp]
        public void SetUp()
        {
            dragonArmor = new DragonArmor("Armadura alada", 70, "Blindaje impenetrable");
        }

        [Test]
        public void DragonArmorCorrectlyInstanced()
        //Se prueba que la armadura del dragón se instanció correctamente.
        {   
            //Assert
            Assert.IsNotNull(dragonArmor);
        }

        [Test]
        public void DefenseValueCheck()
        //Se prueba que el valor de la defensa de la armadura sea el esperado.
        {   
            int expectedDefenseValue = 70;

            //Assert
            Assert.AreEqual(expectedDefenseValue, dragonArmor.Protection);
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre de la armadura no sea nulo.
        {
            Assert.IsNotNull(dragonArmor.Name);
        }
    }
}