using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{

    public abstract class Hero : Character
    {
        public int obtainedVP{get; protected set;}
        public abstract void Attack(Enemy character);

        public void HealCharacter(Hero character)
        {
            character.Heal();
            Console.WriteLine($"{character.Name} ahora tiene {character.Health} de vida ❤");
        }
    }

}