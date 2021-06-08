using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    /*La clase Shield implementa la interfaz IProtectionItem y cumple con el patron Expert, 
    ya que es la clase experta en conocer el nombre y el poder de este item para poder 
    cumplir con la responsabilidad de construir una instancia de Shield.
    
    Cumple con el principio SRP ya que no hay más de una razón de cambio.*/

    public class DragonArmor : IProtectionItem
    {
        public string Name{get; private set;}

        public int Protection{get; private set;}

        public string Description{get; private set;}

        private bool isMagic = false;

        public bool IsMagic
        {
            get 
            { 
                return isMagic;
            }
        }

        public DragonArmor(string name, int protection, string description)
        {
            this.Name = name;
            this.Protection = protection;
            this.Description = description;
        }
    }
}