using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    /*
    •La clase Demon cumple con el patron Expert ya que:
    - Es la clase experta en conocer la información necesaria para crear instancias de Demon
     
    •La clase Demon cumple con el principio SRP ya que no tiene más de una razón de cambio 
    
    •Como es un personaje de tipo MagicEnemyCharacter, puede usar cualquier
     item subtipo de IItem por el principio de sustitucion. */

    public class Demon : MagicEnemyCharacter
    {
        public Demon(string name, string role)
        {
            this.Name = name;
            this.initialHealth = 100;
            this.Health = initialHealth;
            this.Role = role;
            this.Inventary = new List<IItem>();
            this.vP = 2;
         
        }

    }

}