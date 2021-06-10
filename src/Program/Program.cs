using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Items

            Axe axe = new Axe("Verdugo", 60, "Juicio final");
            Bow bow = new Bow("Arco gigante", 45, "Tira fuego");
            Cloak cloak = new Cloak("Capa maxima", 20, "Invisibilidad");
            DragonArmor dragonArmor = new DragonArmor("Armadura alada", 40, "Blindaje total");
            Shield shield = new Shield("Golden Shield", 30, "Escudo Protector");
            SteelClaws steelClaws = new SteelClaws("Garras de juicio", 75, "Corte devastador");
            Sword sword = new Sword("Katana", 90, "Corte Fugaz");
            Warhammer warhammer = new Warhammer("Mjölnir", 95, "Aplastar y machacar");

            FireSpell fireSpell = new FireSpell("Lumos", "La varita enciende luz", 70, 0);
            SpellBook spellBook = new SpellBook("Libro de Hechizos Oscuros", "Hechizos oscuros");
            MagicStaff magicStaff = new MagicStaff("Baculo Oscuro", 85, "Baculo perdido de Toran");

            //Characters
            Demon demon = new Demon("Azael", 15, "Asesino");
            Dragon dragon = new Dragon("Smaug", 10, "Tanque");
            Dwarf dwarf = new Dwarf("Thorin", 5, "Luchador");
            Elf elf = new Elf("Galardiel", 5, "Escurridizo");
            Orc orc = new Orc("Shrek", 15, "Tanque");
            Wizard wizard = new Wizard("Hermione", "Mago", spellBook);

            //Equipo a los characters

            orc.Equip(sword);
            orc.Equip(shield);

            dwarf.Equip(shield);
            dwarf.Equip(warhammer);

            elf.Equip(bow);
            elf.Equip(cloak);

            demon.Equip(sword);
            demon.Equip(axe);

            dragon.Equip(dragonArmor);
            dragon.Equip(steelClaws);

            wizard.LearnSpell(fireSpell);

            //Campo de batalla
            Battlefield battlefield = new Battlefield();

            //Agrego campeones al equipo de heroes
            battlefield.RecruitHero(dwarf);
            battlefield.RecruitHero(wizard);
            battlefield.RecruitHero(elf);
            //Agrego campeones al equipo de enemigos
            battlefield.RecruitEnemy(orc);
            battlefield.RecruitEnemy(demon);
            battlefield.RecruitEnemy(dragon);
            //La pelea
            battlefield.DoEncounter();
        }
    }
}
