using System;
using Dio_RPG.src.Entities;

namespace Rpg_POO
{
    class Program
    {
        static void Main(string []args)
        {

            Console.WriteLine("Dados do personagem: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: ");
            int level = int.Parse(Console.ReadLine());
            Console.Write("HP: ");
            int hp = int.Parse(Console.ReadLine());
            Console.Write("MP: ");
            int mp = int.Parse(Console.ReadLine());
            Console.WriteLine("Hero Type: ");
            Console.WriteLine("1 - Knight | 2 - Wizard | 3 - Ninja | 4 - Black Wizard");
            int heroType = int.Parse(Console.ReadLine());
           
            
            if (heroType == 1){
                Knight knight = new Knight (name,hp,mp,level,"Knight");
                Console.WriteLine("Name: "+ knight.Name +
                                  " Level: "+knight.Level+
                                  " HP: "+knight.Hp+
                                  " MP: "+knight.Mp+
                                  " Hero Type: "+knight.HeroType);
                                  Combate(name,heroType);
                                  
            }
            else if (heroType == 2){
                Wizard wizard  = new Wizard (name,hp,mp,level,"Wizard");
                Console.WriteLine("Name: "+ wizard.Name +
                                  " Level: "+wizard.Level+
                                  " HP: "+wizard.Hp+
                                  " MP: "+wizard.Mp+
                                  " Hero Type: "+wizard.HeroType);
                                  Combate(name,heroType);
            }
            else if(heroType == 3){
                Ninja ninja = new Ninja (name,hp,mp,level,"Ninja");
                Console.WriteLine("Name: "+ ninja.Name +
                                  " Level: "+ninja.Level+
                                  " HP: "+ninja.Hp+
                                  " MP: "+ninja.Mp+
                                  " Hero Type: "+ninja.HeroType);
                                  Combate(name,heroType);
            }
            else if(heroType == 4){
                BlackWizard blackWizard = new BlackWizard(name,hp,mp,level,"Black Wizard");
                Console.WriteLine("Name: "+ blackWizard.Name +
                                  " Level: "+blackWizard.Level+
                                  " HP: "+blackWizard.Hp+
                                  " MP: "+blackWizard.Mp+
                                  " Hero Type: "+blackWizard.HeroType);
                                  Combate(name,heroType);
            }else{
                Console.WriteLine("Escolha uma das 4 opções: ");
            }

           


        } 
        static void Combate(string name,int heroType){
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");

            Console.WriteLine($"{name} foi jogado em uma masmorra, onde seu primeiro desafio é matar um esqueleto !");
            Skeleton skeleton = new Skeleton();
            Console.WriteLine($"{skeleton.Name} aparece ! ");
            int opcao;
            Console.WriteLine("Escolha: ");
            Console.WriteLine("1 - Lutar");
            Console.WriteLine("2 - Fugir");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Attack(heroType);

                }else{
                Console.WriteLine("Game Over");
                }

        }
    
        static void Attack(int heroType){
            if (heroType == 1){
                Skeleton skeleton = new Skeleton();
                Console.WriteLine("Escolha seu ataque: ");
                Console.WriteLine("1 - Ataque com espada");
                Console.WriteLine("2 - Bater escudo");
                int opcaoDamge = int.Parse(Console.ReadLine());
                int lifeSkeleton = skeleton.HP;
                int damage = 1;
                while(lifeSkeleton != 0){
                                                          
                    if (opcaoDamge == 1){
                        damage = lifeSkeleton - 23;
                        lifeSkeleton = damage;
                        Console.WriteLine($"{skeleton.Name} levou 23 de dano");
                        if (lifeSkeleton < 0){
                            lifeSkeleton = 0;
                        }
                        
                    }else{
                         damage = lifeSkeleton - 13;
                         lifeSkeleton = damage;
                         Console.WriteLine($"{skeleton.Name} levou 13 de dano");
                        if (lifeSkeleton < 0){
                            lifeSkeleton = 0;
                        }
                    }
                Console.WriteLine(lifeSkeleton);
                Console.WriteLine("Escolha seu ataque: ");
                Console.WriteLine("1 - Ataque com espada");
                Console.WriteLine("2 - Bater escudo");
                opcaoDamge = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine($"{skeleton.Name} foi derrotado");
            }else if(heroType == 2){
                Skeleton skeleton = new Skeleton();
                Console.WriteLine("Escolha seu ataque: ");
                Console.WriteLine("1 - Lançou Magia de Raio");
                Console.WriteLine("2 - Lançou Magia de Vento");
                int opcaoDamge = int.Parse(Console.ReadLine());
                int lifeSkeleton = skeleton.HP;
                int damage = 1;
                while(lifeSkeleton != 0){
                                                          
                    if (opcaoDamge == 1){
                        damage = lifeSkeleton - 23;
                        lifeSkeleton = damage;
                        Console.WriteLine($"{skeleton.Name} levou 23 de dano de magia de raio");
                        if (lifeSkeleton < 0){
                            lifeSkeleton = 0;
                        }
                        
                    }else{
                         damage = lifeSkeleton - 13;
                         lifeSkeleton = damage;
                         Console.WriteLine($"{skeleton.Name} levou 13 de dano de magia de vento");
                        if (lifeSkeleton < 0){
                            lifeSkeleton = 0;
                        }
                    }
                Console.WriteLine(lifeSkeleton);
                Console.WriteLine("Escolha seu ataque: ");
                Console.WriteLine("1 - Lançou Magia de Raio");
                Console.WriteLine("2 - Lançou Magia de Vento");
                opcaoDamge = int.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine($"{skeleton.Name} foi derrotado");
            }
            }

            
            
        
    
    }  
}