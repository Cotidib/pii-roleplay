using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    /*La clase Sword implementa la interfaz IAttackIem y cumple con el patron Expert, 
    ya que es la clase experta en conocer el nombre y el poder de este item para poder 
    cumplir con la responsabilidad de construir una instancia de Sword.
    
    Cumple con el principio SRP ya que no hay más de una razón de cambio. */

    public class Sword : IAttackItem
    {
        public string Name{get; private set;}

        public int Damage{get; private set;}

        public string Description{get; private set;}

        private bool isMagic = false;

        public bool IsMagic
        {
            get 
            { 
                return isMagic;
            }
        }
        
        public Sword(string name, int damage, string description)
        {
            this.Name = name;
            this.Damage = damage;
            this.Description = description;
        }
    }
}