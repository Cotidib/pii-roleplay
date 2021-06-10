using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace RoleplayGame
{

    public class Battlefield
    {
        private List<Hero> heroesTeam = new List<Hero>();
        public List<Hero> HeroesTeam
        {
            get { return heroesTeam; }
        }
        private List<Enemy> enemiesTeam = new List<Enemy>();
        public List<Enemy> EnemiesTeam 
        {
            get { return enemiesTeam; }
        }

        public void RecruitHero(Hero hero)
        {
            heroesTeam.Add(hero);

            Console.WriteLine($"El campeón {hero.Name} se ha unido al equipo de heroes en el campo de batalla!");
        }

        public void RecruitEnemy(Enemy enemy)
        {
            enemiesTeam.Add(enemy);

            Console.WriteLine($"El campeón {enemy.Name} se ha unido al equipo de enemigos en el campo de batalla!");
        }


        public void TeamEnemyAttacks()
        {
            //Misma cantidad de integrantes
            if (enemiesTeam.Count == heroesTeam.Count)
            {
                int i = 0;
                foreach (Enemy enemy in enemiesTeam)
                {
                    if (heroesTeam[i].Health > 0)
                    {
                        enemy.Attack(heroesTeam[i]);
                        i += 1;
                    }
                }
            }

            //Enemigos sean mayor numero que los heroe
            else if (enemiesTeam.Count > heroesTeam.Count)
            {
                if (heroesTeam.Count == 1)
                {
                    foreach (Enemy enemy in enemiesTeam)
                    {
                        enemy.Attack(heroesTeam[0]);
                    }

                }
                else
                {
                    int contador = 0;
                    foreach (Enemy enemy in enemiesTeam)
                    {
                         if (contador == heroesTeam.Count)
                    {
                        if (heroesTeam[contador].Health > 0)
                        {
                            enemy.Attack(heroesTeam[contador]);
                            contador = 0;
                        }
                    }
                    else
                    {
                        if (heroesTeam[contador].Health > 0)
                        {
                            enemy.Attack(heroesTeam[contador]);
                            contador += 1;
                        }
                    }
                }
            }
        }


            //Enemigos sean menor numero que los heroe
            if (enemiesTeam.Count < heroesTeam.Count)
            {
                int contador2 = 0;
                foreach (Enemy enemy in enemiesTeam)
                {
                    if (contador2 == heroesTeam.Count)
                    {
                        if (heroesTeam[contador2].Health > 0)
                        {
                            enemy.Attack(heroesTeam[contador2]);
                            contador2 = 0;
                        }
                    }
                    else
                    {
                        if (heroesTeam[contador2].Health > 0)
                        {
                            enemy.Attack(heroesTeam[contador2]);
                            contador2 += 1;
                        }
                    }
                }
            }
        }
        public void TeamHeroAttacks()
        {
            foreach (Hero hero in heroesTeam)
            {
                foreach (Enemy enemy in enemiesTeam)
                {
                    if (enemy.Health > 0 && hero.Health > 0)
                    {
                        hero.Attack(enemy);
                    }
                }
            }
        }

        public void DoEncounter()
        {
            int contador = 1;
            while (heroesTeam.Count != 0 && enemiesTeam.Count != 0)
            {
                Console.WriteLine("Ronda: " + contador);

                TeamEnemyAttacks();
                TeamHeroAttacks();

                heroesTeam = heroesTeam.Where(hero => hero.Health > 0).ToList();
                enemiesTeam = enemiesTeam.Where(enemy => enemy.Health > 0).ToList();

                Console.WriteLine("");

                contador += 1;
            }

            if (heroesTeam.Count > enemiesTeam.Count)
            {   
                Console.WriteLine("");
                Console.WriteLine("La batalla entre equipos ha finalizado!");
                Console.WriteLine("");
                Console.WriteLine("El equipo de GoodGuys ha ganado el encuentro.");
            }
            else if (heroesTeam.Count < enemiesTeam.Count)
            {
                Console.WriteLine("");
                Console.WriteLine("La batalla entre equipos ha finalizado!");
                Console.WriteLine("");
                Console.WriteLine("El equipo de BadGuys ha ganado el encuentro.");
            }
        }
    }
}