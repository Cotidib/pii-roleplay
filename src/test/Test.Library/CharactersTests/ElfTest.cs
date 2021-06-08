using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ElfTest
    {
        private Elf elf;
        private Bow bow;
        private Cloak cloak;
        private Orc orc;
        private Sword sword;
        private Shield shield;
        private Axe axe;
        private Warhammer warhammer;
        private Dwarf dwarf;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            bow = new Bow("Arco gigante", 75, "Tira fuego");
            cloak = new Cloak("Capa maxima", 80, "Agilidad");
            elf = new Elf("Frank",15, "Escurridizo");

            sword = new Sword("Espadon", 50, "Corte Fugaz");
            shield = new Shield("Escudo Dorado", 30, "Escudazo");
            orc = new Orc("Thor", 25, "Tanque");

            axe = new Axe("Executioner",50, "Corte decisivo");
            warhammer = new Warhammer("Mjölnir", 60, "Ultimatum");
            dwarf = new Dwarf("Thorin", 70, "Luchador"); 

        }

        [Test]
        public void NameAndRoleCannotBeNull()
        //Se prueba que el nombre y el rol del elfo que no sea nulo
        {   
            //Assert
            Assert.IsTrue(elf.Name!=null && elf.Role!=null);
        }

        [Test]
        public void ElfCorrectlyInstanced()
        //Se prueba que elfo se instanció correctamente.
        {   
            //Assert
            Assert.IsNotNull(elf);
        }

        [Test]
        public void EquipItemCheck()
        //Se prueba que el hacha se haya agregado al inventario del elfo.
        {   //Act
            elf.Equip(bow);
            
            //Assert
            Assert.IsNotNull(elf.Inventary);
        }

        [Test]
        public void EquipTwoItemsCheck()
        //Se prueba que los dos items se agreguen correctamente al inventario del elfo.
        {   
            //Act
            elf.Equip(bow);
            elf.Equip(cloak);
            int index = elf.Inventary.IndexOf(cloak);

            //Assert
            Assert.AreEqual(1,index);
        }

        [Test]
        public void RemoveItemCheck()
        //Se prueba que el item que se añada al inventario del elfo sea removido correctamente.
        {   
            //Act
            elf.Equip(bow);
            elf.UnEquip(bow);
            int cantidadEsperadaItems = 0;
            //Assert
            Assert.AreEqual(cantidadEsperadaItems, elf.Inventary.Count);
        }

        [Test]
        public void TotalDamageCheck()
        //Se prueba que el valor total del damage del elfo sea el esperado.
        {   
            //Act
            elf.Equip(bow);
            int expectedTotalDamage = 75 + 15;

            int calcTotalDamage = elf.TotalDamage();

            //Assert
            Assert.AreEqual(expectedTotalDamage, calcTotalDamage);
        }

        [Test]
        public void TotalProtectionCheck()
        //Se prueba que el valor total de la proteccion del elfo sea el esperado.
        {
            //Act
            elf.Equip(cloak);
            int expectedProtection = 80;
            int calcProtection = elf.TotalProtection();

            //Assert
            Assert.AreEqual(expectedProtection, calcProtection);
        }

        [Test]
        public void CheckHeroHealthAfterBeingAttacked()
        /*Se prueba que el valor total de la vida del enemigo sea el esperado después 
        de recibir un ataque por el elfo.*/
        {  
            //Act
            int expectedHealthLeftEnemy = 230 - 90;
            orc.Equip(shield);

            elf.Equip(bow);
            elf.Attack(orc);

            //Assert
            Assert.AreEqual(expectedHealthLeftEnemy, orc.Health);
        } 

        [Test]
        public void ReceiveAttackCheck()
        /*Se prueba que el valor total de la vida (con su protección) del elfo sea 
        el esperado despues de recibir un daño ataque en especifico.*/
        {   
            //Act
            int expectedElfHealth = 100 - 25;
            orc.Equip(sword);
            elf.RecieveAttack(25);
        
            //Assert
            Assert.AreEqual(expectedElfHealth, elf.Health);
        }

       [Test]
        public void HealAllyCheck()
        // Se comprueba que el el método para curar a un aliado del elfo funcione correctamente. //

        {
            //Act
            orc.Attack(dwarf);
            elf.HealCharacter(dwarf);
            int newHealth = dwarf.Health;
            //Assert
            Assert.AreEqual(100, newHealth);
        }

        [Test]
        public void EquipNormalItemsTest()
        // Se verifica que se añadan items al inventario del enano correctamente.
        {
            elf.Equip(bow);
            Assert.AreEqual(1, elf.Inventary.Count); 
        }
    }
}