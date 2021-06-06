using System;

namespace RoleplayGame
{

    /*La clase Spell cumple con el patron Expert, ya que es la clase experta en conocer 
    el nombre y el poder de cada hechizo para poder cumplir con la responsabilidad de 
    construir un hechizo nuevo.
    
    Cumple con el principio SRP ya que no hay más de una razón de cambio. */

    public abstract class Spell 
    {
        public string Name{get; protected set;}

        public int Damage{get; protected set;}

        public int Protection{get; protected set;}

        public string Description{get; protected set;}

    }

}