using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
 /* La clase Bow cumple con el patron Expert, ya que es la clase experta en conocer el nombre 
    y poder de este item para poder cumplir con la responsabilidad de construir un nuevo arco.
    Cumple con el principio SRP ya que no hay más de una razón de cambio. */
    
    public class Bow : IAttackItem
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

        public Bow(string name, int damage, string description)
        {
            this.Name = name;
            this.Damage = damage;
            this.Description = description;
        }
    }
}