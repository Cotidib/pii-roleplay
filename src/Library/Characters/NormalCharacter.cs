using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{

    public abstract class NormalCharacter : Hero
    {
        public List<INormalItem> Inventary { get; protected set; }

        public void Equip(INormalItem item)
        {
            this.Inventary.Add((INormalItem)item);
        }

        public void UnEquip(INormalItem item)
        {
            if (Inventary.Contains(item))
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
            foreach (INormalItem item in this.Inventary)
            {
                if (typeof(IAttackItem).IsInstanceOfType(item))
                {
                    totalDamage += ((IAttackItem)item).Damage;
                }

            }
            totalDamage += this.Damage;

            return totalDamage;
        }

        public override int TotalProtection()
        {
            int totalProtection = 0;
            foreach (INormalItem item in this.Inventary)
            {
                if (typeof(IProtectionItem).IsInstanceOfType(item))
                {
                    totalProtection += ((IProtectionItem)item).Protection;
                }
            }
            return totalProtection;
        }

        public override void Attack(Enemy character)
        {
            if (character.Health > 0)
            {
                Console.WriteLine($"{this.Name} ⚔ ataca a {character.Name}");
                character.RecieveAttack(this.TotalDamage());

                if (character.Health <= 0)
                {
                    Console.WriteLine($"{character.Name} fue asesinado 💔");
                    this.obtainedVP += character.vP;
                    Console.WriteLine($"El campeón {this.Name} ha acumulado {this.obtainedVP} puntos de victoria.");
                    if (this.obtainedVP >= 5)
                    {
                        this.Heal();
                        Console.WriteLine($"El campeón {this.Name} ha acumulado 5 puntos de victoria, por lo tanto se ha restablecido su vida.");
                        this.obtainedVP = 0;
                    }
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
            if (damage <= (this.TotalProtection()))
            {
                this.Health -= 0;
            }
            else
            {
                this.Health -= (damage - this.TotalProtection());

                if (this.Health < 0)
                {
                    this.Health = 0;
                }
            }
        }
    }

}