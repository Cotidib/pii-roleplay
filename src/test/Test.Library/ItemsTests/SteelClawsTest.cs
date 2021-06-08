using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class SteelClawsTest
    {
        private SteelClaws steelClaws;

        [SetUp]
        public void SetUp()
        {
            steelClaws = new SteelClaws("Garras de juicio", 50, "Corte devastador");
        }

        [Test]
        public void SteelClawsCorrectlyInstanced()
        //Se prueba que las garras de acero se instanciaron correctamente.
        {   
            //Assert
            Assert.IsNotNull(steelClaws);
        }

        [Test]
        public void AttackValueCheck()
        //Se prueba que el valor del ataque de las garras sea el esperado.
        {  
            //Act
            int expectedAttackValue = 50;

            //Assert
            Assert.AreEqual(expectedAttackValue, steelClaws.Damage);
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre de las garras no sea nulo.
        {
            Assert.IsNotNull(steelClaws.Name);
        }
    }
}