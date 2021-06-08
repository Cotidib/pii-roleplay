using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{


    public class SpellBookTest
    {
        private SpellBook spellBook;
        private Spell spell;

        [SetUp]
        public void SetUp()
        {
            spellBook = new SpellBook("Libro", "Libro con hechizos");
            spell = new FireSpell("Expecto patronum", "Invoca un Patronus", 20, 40);
        }

        [Test]
        public void SpellBookNameCannotBeNull()
        //Se prueba que el atributo name de la instancia de spellBook no sea null
        {
            Assert.IsNotNull(spellBook.Name);
        }

        [Test]
        public void SpellBookDescriptionCannotBeNull()
        //Se prueba que el atributo description de la instancia de spellBook no sea null 
        {
            Assert.IsNotNull(spellBook.Description);
        }

        [Test]
        public void SpellBookNameMustBeAString()
        //Se prueba que el atributo name sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), spellBook.Name);
        }

        [Test]
        public void SpellBookDescriptionMustBeString()
        //Se prueba que el atributo description sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), spellBook.Description);
        }

        [Test]
        public void SpellBookMustStartEmpty()
        //Se prueba que el libro de hechizos se instancie inicialmente sin contener hechizos
        {
            Assert.AreEqual(0,spellBook.spells.Count);
        }

        [Test]
        public void CorrectSpellBookDamageCalculation()
        //Se prueba que el daño de un spellbook sea igual al total de hechizos que contiene
        {
            //Act
            spellBook.AddSpell(spell);
            spellBook.AddSpell(spell);
            spellBook.AddSpell(spell);
            spellBook.AddSpell(spell);
            //Assert
            Assert.AreEqual(80, spellBook.Damage);
        }

        [Test]
        public void CorrectSpellBookProtectionCalculation()
        //Se prueba que el spellbook sea un elemento puramente ofensivo
        {
            //Act
            spellBook.AddSpell(spell);
            spellBook.AddSpell(spell);
            spellBook.AddSpell(spell);
            //Assert
            Assert.AreEqual(120, spellBook.Protection);
        }

        [Test]
        public void AddSpellTest()
        //Se prueba que el metodo AddSpell agregue hechizos al spellbook
        {
            //Act
            spellBook.AddSpell(spell);
            spellBook.AddSpell(spell);
            //Assert
            Assert.AreEqual(2, spellBook.spells.Count);
        }
    }
}