using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    /* 
    • La clase Orc cumple con el patron Expert ya que:
    - Es la clase experta en conocer el daño total de las instancias de la clase Orc
     
    • La clase Orc cumple con el principio SRP ya que su única razón de cambio sería
       cambiar algún atributo al momento de construir instancias de la clase.
    
    • Al ser un personaje del tipo NormalEnemyCharacter, puede usar cualquier item subtipo de 
    INormalItem por el principio de sustitucion. */

    public class Orc : NormalEnemyCharacter
    {
        public Orc(string name, int damage, string role)
        {
            this.Name = name;
            this.Damage = damage;
            this.initialHealth = 200;
            this.Health = initialHealth;
            this.Role = role;
            this.Inventary = new List<INormalItem>();
            this.vP = 2;
        }
    }
}
