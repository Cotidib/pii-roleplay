using System;
using System.Collections;
using System.Collections.Generic;

namespace RoleplayGame
{
    /* 
    • La clase Orc cumple con el patron Expert ya que:
    - Es la clase experta en conocer el daño total de las instancias de la clase Orc
     
    • La clase Orc cumple con el principio SRP ya que su única razón de cambio sería
       cambiar algún atributo al momento de construir instancias de la clase.
    
    • Al ser un personaje del tipo NormalEnemyCharacter, puede usar cualquier item subtipo de 
    INormalItem por el principio de sustitucion. */

    public class Battlefield
    {
        private List<Hero> heroesTeam = new List<Hero>();
        private List<Enemy> enemiesTeam = new List<Enemy>();

        public void RecruitHero(Hero hero)
        {
            heroesTeam.Add(hero);
        }

        public void RecruitEnemy(Enemy enemy)
        {
            enemiesTeam.Add(enemy);
        }
        public void TeamEnemyAttacks()
        {
            if (heroesTeam.Count == enemiesTeam.Count)
            {
                for (int i = 0; i < heroesTeam.Count; i++)
                {
                    enemiesTeam[i].Attack(heroesTeam[i]);
                }
            }
            else if (heroesTeam.Count == 1)
            {
                foreach (Enemy enemy in enemiesTeam)
                {
                    enemy.Attack(heroesTeam[0]);
                }
            }
            else if (heroesTeam.Count < enemiesTeam.Count)
            {
                int contador = 0;
                foreach (Enemy enemy in enemiesTeam)
                {
                    if (contador == heroesTeam.Count)
                    {
                        enemy.Attack(heroesTeam[contador]);
                        contador = 0;
                    }
                    else
                    {
                        enemy.Attack(heroesTeam[contador]);
                        contador += 1;
                    }
                }
            }
            else if (heroesTeam.Count > enemiesTeam.Count)
            {
                int contador2 = 0;
                foreach (Enemy enemy in enemiesTeam)
                {
                    if (contador2 == heroesTeam.Count)
                    {
                        enemy.Attack(heroesTeam[contador2]);
                        contador2 = 0;
                    }
                    else
                    {
                        enemy.Attack(heroesTeam[contador2]);
                        contador2 += 1;
                    }
                }

            }
        }
        public void TeamHeroAttacks()
        {
            int contador = 0;
            foreach(Hero hero in heroesTeam)
            {
                if (hero.Health>0)
                {
                    if (contador == enemiesTeam.Count)
                    {
                        hero.Attack(enemiesTeam[contador]);
                        contador = 0;
                    }
                    else
                    {
                        hero.Attack(enemiesTeam[contador]);
                        contador += 1;
                    }
                }
            }
        }
        public void RemoveHeroFromField()
        {
            foreach (Hero hero in heroesTeam)
            {
                if (hero.Health <= 0)
                {
                    heroesTeam.Remove(hero);
                }
            }
        }
        public void RemoveEnemyFromField()
        {
            foreach (Enemy enemy in enemiesTeam)
            {
                if (enemy.Health <= 0)
                {
                    enemiesTeam.Remove(enemy);
                }
            }
        }
        
        public void DoEncounter()
        {
            while (heroesTeam.Count != 0 && enemiesTeam.Count != 0)
            {
                TeamEnemyAttacks();
                RemoveHeroFromField();
                TeamHeroAttacks();
                RemoveEnemyFromField();
            }
        }

        

    }
}
