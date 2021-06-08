using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DemonTest
    {
        private Wizard wizard;
        private MagicStaff magicStaff;

        private SpellBook spellBook;
        private Spell spell;

        private Demon demon;
        private Sword sword;
        private MagicStaff blackMagicStaff;       

        [SetUp]
        public void SetUp()
        {
            //Arrange
            magicStaff = new MagicStaff("Varita", 10, "Hace hechizos");
            spellBook = new SpellBook("Libro", "Tiene hechizos");
            spell = new FireSpell("Wingardium Leviosa", "Hace levitar objetos", 10, 10);
            wizard = new Wizard("Hermione", "Mago",spellBook);
            wizard.Equip(magicStaff);
            
            demon = new Demon("Demon", 0, "Asesino");
            sword = new Sword ("Espada corta", 50, "Corte Fugaz");
            blackMagicStaff = new MagicStaff("Varita", 10, "Invoca magia negra");         
             
        }

        [Test]
        public void NameCannotBeNull()
        //Se prueba que el nombre del demonio no sea null
        {
            Assert.IsNotNull(demon.Name);
        }

        [Test]
        public void NameMustBeString()
        //Se prueba que el nombre del demonio sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), demon.Name);
        }

        [Test]
        public void RoleCannotBeNull()
        //Se prueba que el rol del demonio no sea null
        {
            Assert.IsNotNull(demon.Role);
        }

        [Test]
        public void RoleMustBeString()
        //Se prueba que el rol del demonio sea del tipo string
        {
            Assert.IsInstanceOf(typeof(string), demon.Role);
        }

        [Test]
        public void AttackTest()
        //Se prueba el metodo de ataque
        {
            //Act
            wizard.LearnSpell(spell);
            demon.Equip(blackMagicStaff);
            demon.Equip(sword);
            demon.Attack(wizard);

            //Assert
            Assert.AreEqual(50, wizard.Health);

        } 

        [Test]
        public void ReceiveAttackTest()
        //Se prueba el metodo para recibir un ataque
        {
            //Act
            demon.RecieveAttack(40);
            //Assert
            Assert.AreEqual(60, demon.Health);
        } 

        [Test]
        public void CorrectTotalDamageCalculation()
        //Se prueba que el calculo del daño total sea correcto
        {
            //Act
            demon.Equip(blackMagicStaff);
            demon.Equip(sword);
            demon.Equip(sword);
            //Assert
            Assert.AreEqual(110, demon.TotalDamage());
        }

        [Test]
        public void TotalDamageMustReturnInt()
        //Se prueba que el metodo TotalDamage devuelva un valor del tipo int
        {
            Assert.IsInstanceOf(typeof(int), demon.TotalDamage());
        }

        [Test]
        public void CorrectTotalProtectionCalculation()
        //Se prueba que el calculo de la proteccion total sea correcto
        {
            //Act
            wizard.Equip(blackMagicStaff);
            //Assert
            Assert.AreEqual(0, demon.TotalProtection());
        }

        [Test]
        //Se prueba que el metodo TotalProtection devuelva un valor del tipo int
        public void TotalProtectionMustReturnInt()
        {
            Assert.IsInstanceOf(typeof(int), demon.TotalProtection());
        }

        [Test]
        public void inventaryMustStartEmpty()
        //Se prueba que el inventario comience vacio
        {
            Assert.AreEqual(0, demon.Inventary.Count);
        }

        [Test]
        public void EquipItemsToInventary()
        //Se prueba que se puedan equipar items magicos e items normales
        {
            //Act
            demon.Equip(magicStaff);
            demon.Equip(sword);
            //Assert
            Assert.AreEqual(2, demon.Inventary.Count);
        } 

    }
}