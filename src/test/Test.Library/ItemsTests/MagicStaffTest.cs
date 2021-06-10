using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


    public class MagicStaffTest
    {
        private MagicStaff magicStaff;

        [SetUp]
        public void SetUp()
        {

            magicStaff = new MagicStaff("Accio", 10, "Atrae un objeto");

        }


        [Test]
        public void MagicStaffNameCannotBeNull()
        //Se prueba que el atributo nombre de la instancia de MagicStaff no sea null 
        {
            Assert.IsNotNull(magicStaff.Name);
        }

        [Test]
        public void MagicStaffNameMustBeAString()
        //Se prueba que el atributo name sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), magicStaff.Name);
        }

        [Test]
        public void MagicStaffDescriptionCannotBeNull()
        //Se prueba que el atributo description de la instancia de MagicStaff no sea null 
        {
            Assert.IsNotNull(magicStaff.Description);
        }

        [Test]
        public void MagicStaffPowerMustBeAString()
        //Se prueba que el atributo description sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), magicStaff.Description);
        }

        [Test]
        public void MagicStaffDamageTest()
        //Se prueba que el magicStaff tenga un daño fijo de 50 puntos en todas sus instancias
        {
            Assert.AreEqual(10, magicStaff.Damage);
        }
    }
}