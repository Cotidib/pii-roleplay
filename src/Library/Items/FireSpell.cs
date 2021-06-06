using System;

namespace RoleplayGame
{
    public abstract class FireSpell : Spell
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