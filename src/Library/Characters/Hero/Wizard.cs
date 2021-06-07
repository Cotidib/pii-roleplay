using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    /*
    •La clase Wizard cumple con el patron Expert ya que:
    - Es la clase experta en conocer la información para crear instancias de la clase Wizard
     
    •La clase Wizard no cumple con el principio SRP ya que tiene más de una razón de cambio, las cuales por ejemplo, pueden ser:
    - Cambiar el cómo se calcula el daño total de un Wizard
    - Cambiar el cómo se calcula la proteccion total de un Wizard
    - Cambiar el modo en que se aprende un hechizo

    •Como es un personaje de tipo MagicCharacter, puede usar cualquier
     item subtipo de IItem por el principio de sustitucion. */

    public class Wizard : MagicCharacter
    {
        public SpellBook SpellBook {get; private set;}

        public Wizard(string name, string role, SpellBook spellBook)
        {
            this.Name = name;
            this.initialHealth = 100;
            this.Health = initialHealth;
            this.Role = role;
            this.Damage = 0;
            this.Inventary = new List<IItem>();
            this.SpellBook = spellBook;
            this.obtainedVP = 0;
        }

        public override int TotalDamage()
        {
            int totalDamage = 0;
            foreach(IItem item in this.Inventary)
            {
                if(typeof(IAttackItem).IsInstanceOfType(item))
                {
                    totalDamage += ((IAttackItem)item).Damage;
                }
                else if(typeof(IMagicAttackItem).IsInstanceOfType(item))
                {
                    totalDamage += ((IMagicAttackItem)item).Damage;
                }
            }
            return totalDamage + this.SpellBook.Damage + this.Damage;
        }

        public override int TotalProtection()
        {
            int totalProtection = 0;
            foreach(IItem item in this.Inventary)
            {
                if(typeof(IProtectionItem).IsInstanceOfType(item))
                {
                    totalProtection += ((IProtectionItem)item).Protection;
                }
                else if(typeof(IMagicProtectionItem).IsInstanceOfType(item))
                {
                    totalProtection += ((IMagicProtectionItem)item).Protection;
                }
            }
            return totalProtection + this.SpellBook.Protection;
        } 

        public void LearnSpell(Spell spell)
        {
            this.SpellBook.AddSpell(spell);

        }

    }

}