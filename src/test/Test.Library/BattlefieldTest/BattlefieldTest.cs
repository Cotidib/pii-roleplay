using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class BattlefieldTest
    {
        private Axe axe;
        private Bow bow;
        private Cloak cloak;
        private DragonArmor dragonArmor;
        private Shield shield;
        private SteelClaws steelClaws;
        private Sword sword;
        private Warhammer warhammer;
        private Demon demon;
        private Dragon dragon;
        private Dwarf dwarf;
        private Elf elf;
        private Orc orc;
        private Battlefield battlefield;


        [SetUp]
        public void SetUp()
        {
            axe = new Axe("Verdugo", 60, "Juicio final");
            bow = new Bow("Arco gigante", 45, "Tira fuego");
            cloak = new Cloak("Capa maxima", 20, "Invisibilidad");
            dragonArmor = new DragonArmor("Armadura alada", 40, "Blindaje total");
            shield = new Shield("Golden Shield", 30, "Escudo Protector");
            steelClaws = new SteelClaws("Garras de juicio", 75, "Corte devastador");
            sword = new Sword("Katana", 90, "Corte Fugaz");
            warhammer = new Warhammer("Mjölnir", 95, "Aplastar y machacar");

            demon = new Demon("Demonio", 15, "Asesino");
            dragon = new Dragon("dragon", 10, "Tanque");
            dwarf = new Dwarf("enano", 5, "Luchador");
            elf = new Elf("elfo", 5, "Escurridizo");
            orc = new Orc("orco", 15, "Tanque");

            battlefield = new Battlefield();
        }

        [Test]
        public void RecruitEnemyCheck()
        //
        {   
            //Act
            battlefield.RecruitEnemy(demon);
            battlefield.RecruitEnemy(dragon);
            battlefield.RecruitEnemy(orc);

            //Assert
            Assert.AreEqual(3,battlefield.EnemiesTeam.Count);
        }

        [Test]
        public void RecruitHeroCheck()
        //
        {   
            //Act
            battlefield.RecruitHero(dwarf);
            battlefield.RecruitHero(elf);

            //Assert
            Assert.AreEqual(2,battlefield.HeroesTeam.Count);
        }

        [Test]
        public void EnemyAttackCheck()
        {
            //Act
            battlefield.RecruitEnemy(demon);
            demon.Equip(sword);

            battlefield.RecruitHero(dwarf);

            battlefield.TeamEnemyAttacks();

            //Assert
            Assert.AreEqual(0,dwarf.Health);
        }

        [Test]
        public void HeroAttackCheck()
        {
            //Act
            battlefield.RecruitEnemy(demon);
            battlefield.RecruitHero(dwarf);
            dwarf.Equip(warhammer);


            battlefield.TeamHeroAttacks();

            //Assert
            Assert.AreEqual(0,demon.Health);
        }

        [Test]
        public void DoEncounterCheckRemoveHero()
        {
            //Act
            battlefield.RecruitEnemy(demon);
            battlefield.RecruitHero(dwarf);
            demon.Equip(sword);


            battlefield.DoEncounter();

            //Assert
            Assert.AreEqual(0,battlefield.HeroesTeam.Count);
        }

        [Test]
        public void DoEncounterCheckRemoveEnemy()
        {
            //Act
            battlefield.RecruitEnemy(demon);
            battlefield.RecruitHero(dwarf);
            dwarf.Equip(warhammer);


            battlefield.DoEncounter();

            //Assert
            Assert.AreEqual(0,battlefield.EnemiesTeam.Count);
        }
        
    }
}