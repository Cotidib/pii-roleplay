using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    /*La clase SpellBook cumple con el patron Expert ya que es la clase experta 
    en conocer el contenido de cada libro para poder cumplir con la responsabilidad 
    de agregar o sacar hechizos.
    Cumple con el principio SRP ya que la única razón de cambio seria cambiar la forma 
    en la que se agregan o sacan hechizos.*/

    public class SpellBook : IMagicAttackItem, IMagicProtectionItem
    {
        public string Name{get; private set;}

        public int Damage{get; private set;}

        public int Protection{get; private set;}

        public string Description{get; private set;}
        
        public List<Spell> spells;


        public SpellBook(string name, string description)
        {
            this.Name = name;            
            this.Description = description;
            this.spells = new List<Spell>();
        }

        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
            UpdateBookSpellDamage();
            UpdateBookSpellProtection();
            
        }

        private void UpdateBookSpellDamage()
        {
            int totalDamage = 0;
            foreach(Spell spell in spells)
            {
                totalDamage += spell.Damage;
            }

            this.Damage = totalDamage;
        }

        private void UpdateBookSpellProtection()
        {
            int totalProtection = 0;
            foreach(Spell spell in spells)
            {
                totalProtection += spell.Protection;
            }

            this.Protection = totalProtection;
        }
        

    }
}