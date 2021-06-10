using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    /* 
    • La clase Dragon cumple con el patron Expert ya que:
    - Es la clase experta en conocer el daño total de las instancias de la clase Dragon
     
    • La clase Dragon cumple con el principio SRP ya que su única razón de cambio sería
       cambiar algún atributo al momento de construir instancias de la clase.
    
    • Como es un personaje de tipo NormalEnemyCharacter, puede usar cualquier item subtipo de 
      INormalItem por el principio de sustitucion. */

    public class Dragon : NormalEnemyCharacter
    {

        public Dragon(string name, int damage, string role)
        {
            this.Name = name;
            this.Damage = damage;
            this.initialHealth = 200;
            this.Health = initialHealth;
            this.Role = role;
            this.Inventary = new List<INormalItem>();
            this.vP = 5;
        }
    }
}