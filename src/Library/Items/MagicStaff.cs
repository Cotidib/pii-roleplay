using System;

namespace RoleplayGame
{
    /*La clase MagicStaff cumple con el patron Expert ya que es la clase experta en conocer 
    la información necesaria para crear una instancia de MagicStaff
    Cumple con el principio SRP ya que no hay más de una razón de cambio.*/
    
    public class MagicStaff : IMagicAttackItem
    {
        public string Name{get; private set;}

        public int Damage{get; private set;}

        public string Description{get; private set;}

        public MagicStaff(string name, int damage, string description)
        {
            this.Name = name;
            this.Damage = damage;
            this.Description = description;
        }
    }
}