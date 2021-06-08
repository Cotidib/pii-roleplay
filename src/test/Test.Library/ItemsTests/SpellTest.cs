using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


    public class SpellTest
    {
        private Spell spell;

        [SetUp]
        public void SetUp()
        {
            
            spell = new FireSpell("Accio", "Atrae un objeto",10,20);
            
        }


        [Test]
        public void SpellNameCannotBeNull()
        //Se prueba que el atributo nombre de la instancia de Spell no sea null 
        {
            Assert.IsNotNull(spell.Name);
        }

        [Test]
        public void SpellNameMustBeAString()
        //Se prueba que el atributo name sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), spell.Name);
        }

        [Test]
        public void SpellPowerCannotBeNull()
        //Se prueba que el atributo description de la instancia de Spell no sea null 
        {
            Assert.IsNotNull(spell.Description);
        }

        [Test]
        public void SpellDescriptionMustBeAString()
        //Se prueba que el atributo description sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), spell.Description);
        }

        [Test]
        public void GetCorrectDamage()
        {
            Assert.AreEqual(10, spell.Damage);
        }

        [Test]
        public void GetCorrectProtection()
        {
            Assert.AreEqual(20, spell.Protection);
        }
    }
}