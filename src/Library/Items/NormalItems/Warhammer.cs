using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    /*La clase Warhammer cumple con el patron Expert ya que es la clase experta 
    en conocer la información necesaria para crear una instancia de Warhammer.
    
    Cumple con el principio SRP ya que no hay más de una razón de cambio.*/

    public class Warhammer : IAttackItem
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
        
        public Warhammer(string name, int damage, string description)
        {
            this.Name = name;
            this.Damage = damage;
            this.Description = description;
        }
    }
}