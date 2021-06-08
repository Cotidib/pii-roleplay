using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class WizardTest
    {
        private Wizard wizard;
        private MagicStaff magicStaff;

        private SpellBook spellBook;
        private Spell spell;

        private Shield shield;

        private Sword sword;

        private Orc orc;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            magicStaff = new MagicStaff("Varita", 10, "Hace hechizos");
            spellBook = new SpellBook("Libro", "Tiene hechizos");
            spell = new FireSpell("Wingardium Leviosa", "Hace levitar objetos", 10, 10);
            wizard = new Wizard("Hermione", "Mago",spellBook);
            
            shield = new Shield ("GoldenShield", 30,"Escudo Protector");
            sword = new Sword ("Katana", 50, "Corte Fugaz");
            orc = new Orc ("Grom", 10, "Tanque");
            orc.Equip(shield);
            orc.Equip(sword);
             
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre del mago no sea null
        {
            Assert.IsNotNull(wizard.Name);
        }

        [Test]
        public void NameMustBeString()
        //Se prueba que el nombre del mago sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), wizard.Name);
        }

        [Test]
        public void RoleCannotBeNull()
        //Se prueba que el rol del mago no sea null
        {
            Assert.IsNotNull(wizard.Role);
        }

        [Test]
        public void RoleMustBeString()
        //Se prueba que el rol del mago sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), wizard.Role);
        }

        [Test]
        public void SpellBookMustBeSpellBookInstance()
        //Se prueba que el atributo spellBook del mago contenga una instancia de la clase SpellBook
        //y por tanto solamente se pueda equipar un item del tipo SpellBook
        {
            Assert.IsInstanceOf(typeof(SpellBook), wizard.SpellBook);
        }

        [Test]
        public void SpellBookCannotBeNull()
        //Se prueba que atributo spellBook no sea null
        {
            Assert.IsNotNull(wizard.SpellBook);
        }

        [Test]
        public void AttackTest()
        //Se prueba el metodo de ataque en un orco
        {
            //Act
            wizard.LearnSpell(spell);
            wizard.LearnSpell(spell);
            wizard.LearnSpell(spell);
            wizard.LearnSpell(spell);
            wizard.Attack(orc);

            //Assert
            Assert.AreEqual(190, orc.Health);

        } 

        [Test]
        public void ReceiveAttackTest()
        //Se prueba el metodo para recibir un ataque
        {
            //Act
            wizard.LearnSpell(spell);
            wizard.RecieveAttack(50);
            //Assert
            Assert.AreEqual(60, wizard.Health);
        } 


        [Test]
        public void InitialWizardDamageMustBeZero()
        //Se prueba que el daño propio del mago es 0 puntos
        {
            Assert.AreEqual(0, wizard.Damage);
        }

        [Test]
        public void CorrectTotalDamageCalculation()
        //Se prueba que el calculo del daño total sea correcto
        {
            //Act
            wizard.Equip(magicStaff);
            wizard.LearnSpell(spell);
            wizard.LearnSpell(spell);
            //Assert
            Assert.AreEqual(30, wizard.TotalDamage());
        }

        [Test]
        public void TotalDamageMustReturnInt()
        //Se prueba que el metodo TotalDamage devuelva un valor del tipo int
        {
            Assert.IsInstanceOf(typeof(int), wizard.TotalDamage());
        }

        [Test]
        public void CorrectTotalProtectionCalculation()
        //Se prueba que el calculo de la proteccion total sea correcto
        {
            //Act
            wizard.Equip(magicStaff);
            wizard.LearnSpell(spell);
            wizard.LearnSpell(spell);
            //Assert
            Assert.AreEqual(20, wizard.TotalProtection());
        }

        [Test]
        //Se prueba que el metodo TotalProtection devuelva un valor del tipo int
        public void TotalProtectionMustReturnInt()
        {
            Assert.IsInstanceOf(typeof(int), wizard.TotalProtection());
        }

        [Test]
        public void LearnSpellTest()
        //Se prueba que el hechizo aprendido se añada al libro
        {
            //Act
            wizard.LearnSpell(spell);
            //Assert
            Assert.True(spellBook.spells.Contains(spell));
        }

        [Test]
        public void inventaryMustStartEmpty()
        {
            Assert.AreEqual(0, wizard.Inventary.Count);
        }

        [Test]
        public void EquipItemsToInventary()
        {
            //Act
            wizard.Equip(magicStaff);
            wizard.Equip(sword);
            //Assert
            Assert.AreEqual(2, wizard.Inventary.Count);
        } 

    }
}