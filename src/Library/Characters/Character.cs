using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{

    public abstract class Character 
    {
        public string Name{get; protected set;}
        public int Damage{get; protected set;}
        public int Health{get; protected set;}
        public string Role{get; protected set;}
        
        protected int initialHealth;

        public abstract int TotalDamage();
        public abstract int TotalProtection();
        public abstract void RecieveAttack(int damage);
        

        public void HealCharacter(Character character)
        {
            character.Heal();
            Console.WriteLine($"{character.Name} ahora tiene {character.Health} de vida ❤");
        }

        public void Heal()
        {   
            if(this.Health > 0)
            {
                this.Health = this.initialHealth;
            }
            else
                Console.WriteLine($"{this.Name} esta muerto. No se puede curar 💔");
        }

        public void Respawn()
        {
            if(this.Health <= 0)
            {
                this.Health = initialHealth;
            }
            else
            {
                this.Health = this.Health;
            }
        }

        
    }
    
}
