using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{

    public abstract class MagicCharacter : Hero
    {
        public List<IItem> Inventary{get; protected set;}

        public void Equip(IItem item)
        {   
            this.Inventary.Add((IItem)item);  
        }

        public void UnEquip(IItem item)
        {   
            if(this.Inventary.Contains(item))
            {
                this.Inventary.Remove(item);
                Console.WriteLine($"Se ha removido el item {item.Name} del personaje {this.Name}.");
            }
            else
            {
                Console.WriteLine($"El item {item.Name} no se puede remover ya que no se encuentra añadido al personaje.");
            } 
        
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
            return totalDamage + this.Damage;
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
            return totalProtection;
        } 

        public override void Attack(Character character)
        {
            if(character.Health > 0)
            {
                Console.WriteLine($"{this.Name} ⚔ ataca a {character.Name}");
                character.RecieveAttack(this.TotalDamage());

                if(character.Health <= 0)
                {
                    Console.WriteLine($" {character.Name} fue asesinado 💔");
                }
                else
                {
                    Console.WriteLine($"{character.Name} tiene {character.Health} de vida ❤");
                }
            }
            else
                {
                    Console.WriteLine($"No se puede atacar a {character.Name} ya que se encuentra muerto 💔");
                }
        }

        public override void RecieveAttack(int damage)
        {
            if(damage <= (this.Health + this.TotalProtection()))
            {
                this.Health -= (damage - this.TotalProtection());
            }
            else
            {
                this.Health = 0;
            }  
        }
    }

}