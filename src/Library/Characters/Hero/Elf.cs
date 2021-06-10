using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    /* 
    • La clase Elf cumple con el patron Expert ya que:
    - Es la clase experta en conocer el daño total de las instancias de la clase Elf
     
    • La clase Elf cumple con el principio SRP ya que su única razón de cambio sería
       cambiar algún atributo al momento de construir instancias de la clase.
    
    • Al ser un personaje del tipo NormalCharacter, puede usar cualquier item subtipo de 
    INormalItem por el principio de sustitucion. */

    public class Elf : NormalCharacter
    {
        public Elf(string name, int damage, string role)
        {
            this.Name = name;
            this.Damage = damage;
            this.initialHealth = 100;
            this.Health = initialHealth;
            this.Role = role;
            this.Inventary = new List<INormalItem>();
            this.obtainedVP = 0;
        }
    }

}

