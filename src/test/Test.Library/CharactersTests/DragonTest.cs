using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DragonTest
    {
        private Dragon dragon;
        private SteelClaws steelClaws;
        private DragonArmor dragonArmor;
        private Dwarf dwarf;

        private Orc orc;

        private Axe axe;
        private Warhammer warhammer;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            steelClaws = new SteelClaws("Garras de juicio", 50, "Corte devastador");
            dragonArmor = new DragonArmor("Armadura alada", 70, "Blindaje total");
            dragon = new Dragon("Smaug", 70, "Tanque");

            orc = new Orc("Azog", 40, "Tanque");

            axe = new Axe("Executioner", 50, "Corte decisivo");
            warhammer = new Warhammer("Mjölnir", 60, "Ultimatum");
            dwarf = new Dwarf("Thorin", 70, "Luchador");

        }

        [Test]
        public void NameAndRoleCannotBeNull()
        //Se prueba que el nombre y el rol del dragón que no sea nulo
        {
            //Assert
            Assert.IsTrue(dragon.Name != null && dragon.Role != null);
        }

        [Test]
        public void DragonCorrectlyInstanced()
        //Se prueba que enano se instanció correctamente.
        {
            //Assert
            Assert.IsNotNull(dragon);
        }

        [Test]
        public void EquipItemCheck()
        //Se prueba que las garras de acero se hayan agregado al inventario del dragón.
        {   //Act
            dragon.Equip(steelClaws);

            //Assert
            Assert.IsNotNull(dragon.Inventary);
        }

        [Test]
        public void EquipTwoItemsCheck()
        //Se prueba que los dos items se agreguen correctamente al inventario del dragón.
        {
            //Act
            dragon.Equip(steelClaws);
            dragon.Equip(dragonArmor);
            int index = dragon.Inventary.IndexOf(dragonArmor);

            //Assert
            Assert.AreEqual(1, index);
        }

        [Test]
        public void RemoveItemCheck()
        //Se prueba que el item que se añada al inventario del dragón sea removido correctamente.
        {
            //Act
            dragon.Equip(dragonArmor);
            dragon.UnEquip(dragonArmor);
            int cantidadEsperadaItems = 0;
            //Assert
            Assert.AreEqual(cantidadEsperadaItems, dragon.Inventary.Count);
        }

        [Test]
        public void TotalDamageCheck()
        //Se prueba que el valor total del daño del dragón sea el esperado.
        {
            //Act
            dragon.Equip(steelClaws);
            int expectedTotalDamage = 70 + 50;

            int calcTotalDamage = dragon.TotalDamage();

            //Assert
            Assert.AreEqual(expectedTotalDamage, calcTotalDamage);
        }

        [Test]
        public void TotalProtectionCheck()
        //Se prueba que el valor total de la proteccion del dragón sea el esperado.
        {
            //Act
            dragon.Equip(dragonArmor);
            int expectedProtection = 70;

            int calcProtection = dragon.TotalProtection();

            //Assert
            Assert.AreEqual(expectedProtection, calcProtection);
        }

        [Test]
        public void CheckHeroHealthAfterBeingAttacked()
        /*Se prueba que el valor total de la vida del héroe atacado sea 
        el esperado despues de recibir un ataque por el dragón.*/
        {
            //Act
            dragon.Equip(steelClaws);
            dragon.Equip(dragonArmor);
            dragon.Attack(dwarf);

            //Assert
            Assert.AreEqual(0, dwarf.Health);
        }

        [Test]
        public void ReceiveAttackCheck()
        /*Se prueba que el valor total de la vida (más su protección) del dragón 
        sea el esperado despues de recibir un daño ataque en especifico.*/
        {
            //Act
            int expectedDragonHealth = 70;
            dragon.Equip(dragonArmor);
            dragon.RecieveAttack(200);

            //Assert
            Assert.AreEqual(expectedDragonHealth, dragon.Health);
        }

        [Test]
        public void HealOrcCheck()
        // Se comprueba que el el método para curar a un orco del dragón funcione correctamente. //

        {
            //Act
            dwarf.Attack(orc);
            dragon.HealCharacter(orc);
            int newHealth = orc.Health;
            //Assert
            Assert.AreEqual(200, newHealth);
        }

        [Test]
        public void EquipNormalItemsTest()
        // Se verifica que se añadan items al inventario del dragón correctamente.
        {
            dragon.Equip(steelClaws);
            dragon.Equip(dragonArmor);
            dragon.Equip(axe);
            dragon.Equip(warhammer);
            Assert.AreEqual(4, dragon.Inventary.Count);
        }
    }
}