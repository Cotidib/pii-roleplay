using System;

namespace RoleplayGame
{
    /* 
       La clase FireSpell hereda de la clase abstracta Spell.

       La clase FireSpell cumple con el patron Expert ya que es la clase experta en conocer 
       la información necesaria para crear una instancia de FireSpell.

       Cumple con el principio SRP, ya que no tiene más de una razón de cambio.
    */
    public class FireSpell : Spell
    {
        public FireSpell(string name, string description, int damage, int protection) 
        {
            this.Name = name;
            this.Description = description;
            this.Damage = damage;
            this.Protection = protection;
        }

    }

}