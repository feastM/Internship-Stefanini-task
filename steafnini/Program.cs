using System;
using System.Collections;
using System.Collections.Generic;

namespace Stef
{
    class Program
    {
        static void Main(string[] args)
        {

            Ingredient Chesse = new Ingredient(10, "Chesse");
            Ingredient Ham = new Ingredient(15, "Ham");
            Ingredient Tomato = new Ingredient(8, "Tomato");
            Ingredient Pickles = new Ingredient(5, "Pickles");
            Ingredient Bacon = new Ingredient(20, "Bacon");

            Dish Margherita = new Dish("Margherita", 30);
            Dish America = new Dish("America", 20);
            Dish Italiano = new Dish("Italiano", 40);

            Cook Eric = new Cook("Eric");
            Cook Alexandru = new Cook("Alexandru");
            Cook Ciprian = new Cook("Ciprian");
            
         


            Margherita.setDesc(Tomato.Name(), Chesse.Name(), Ham.Name());
            America.setDesc(Bacon.Name(), Chesse.Name(), Ham.Name());
            Italiano.setDesc(Tomato.Name(), Chesse.Name(), Pickles.Name());

            Margherita.setPrice(Tomato.cost(), Chesse.cost(), Ham.cost());
            America.setPrice(Bacon.cost(), Chesse.cost(), Ham.cost());
            Italiano.setPrice(Tomato.cost(), Chesse.cost(), Pickles.cost());

            string choice;

         
            do
            {
              
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Margherita");
                Console.WriteLine("2) America");
                Console.WriteLine("3) Italiano");
                Console.WriteLine("4) Close menu");
                Console.Write("\r\nSelect Something to order: ");
                 choice = Console.ReadLine();

                switch (choice)
                {
                    //case "Margherita":
                    case "1":
                        Console.WriteLine("Name of dish: " + Margherita.getName() + " | Prepare time: " + Margherita.getTime() + " | Dish's ingredients :" +
                                          Margherita.getDesc() + " | Price : " + Margherita.getPrice() + "$ |");
                        int x = Eric.assigncook(Margherita.getTime());
                        int y = Alexandru.assigncook(Margherita.getTime());
                        int z = Ciprian.assigncook(Margherita.getTime());
                        if (x > 10000 && y > 10000 && z > 10000)
                        {
                            Console.WriteLine((" All the cooks are busy"));
                            break;
                        }

                        if (x == 0)
                        {
                            Console.WriteLine(" Your cook is Eric");
                            Eric.addtime(Margherita.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Eric.getTime()));
                            Eric.incOrder();
                            break;
                        }

                      else   if (y == 0)
                        {
                            Console.WriteLine((" Your cook is Alexandru"));
                            Alexandru.addtime(Margherita.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Alexandru.getTime()));
                            Alexandru.incOrder();
                            break;
                        }

                      else   if (z == 0)
                        {
                            Console.WriteLine((" Your cook is Ciprian"));
                            Ciprian.addtime(Margherita.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Ciprian.getTime()));
                            Ciprian.incOrder();
                            break;
                        }

                        if (x <= y && x <= z)
                        {
                            Console.WriteLine((" Your cook is Eric"));
                            Eric.addtime(Margherita.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Eric.getTime()));
                            Eric.incOrder();
                            break;
                        }

                       else  if (y <= x && y <= z)
                        {
                            Console.WriteLine((" Your cook is Alexandru"));
                            Alexandru.addtime(Margherita.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Alexandru.getTime()));
                            Alexandru.incOrder();
                            break;
                        }

                       else if (z <= x && z <= y)
                        {
                            Console.WriteLine((" Your cook is Ciprian"));
                            Ciprian.addtime(Margherita.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Ciprian.getTime()));
                            Ciprian.incOrder();
                            break;
                        }

                        break;
                    //case "America":
                    case "2" :
                        Console.WriteLine("Name of dish: " + America.getName() + " | Prepare time: " + America.getTime() + " | Dish's ingredients :" +
                                          America.getDesc() + " | Price : " + America.getPrice() + "$ |");
                         x = Eric.assigncook(America.getTime());
                         y = Alexandru.assigncook(America.getTime());
                         z = Ciprian.assigncook(America.getTime());
                        if (x > 10000 && y > 10000 && z > 10000)
                        {
                            Console.WriteLine((" All the cooks are busy"));
                            break;
                        }

                        if (x == 0)
                        {
                            Console.WriteLine((" Your cook is Eric"));
                            Eric.addtime(America.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Eric.getTime()));
                            Eric.incOrder();
                            break;
                        }

                      else   if (y == 0)
                        {
                            Console.WriteLine((" Your cook is Alexandru"));
                            Alexandru.addtime(America.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Alexandru.getTime()));
                            Alexandru.incOrder();
                            break;
                        }

                      else   if (z == 0)
                        {
                            Console.WriteLine((" Your cook is Ciprian"));
                            Ciprian.addtime(America.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Ciprian.getTime()));
                            Ciprian.incOrder();
                            break;
                        }

                        if (x <= y && x <= z)
                        {
                            Console.WriteLine((" Your cook is Eric"));
                            Eric.addtime(America.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Eric.getTime()));
                            Eric.incOrder();
                            break;
                        }

                       else  if (y <= x && y <= z)
                        {
                            Console.WriteLine((" Your cook is Alexandru"));
                            Alexandru.addtime(America.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Alexandru.getTime()));
                            Alexandru.incOrder();
                            break;
                        }

                       else if (z <= x && z <= y)
                        {
                            Console.WriteLine((" Your cook is Ciprian"));
                            Ciprian.addtime(America.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Ciprian.getTime()));
                            Ciprian.incOrder();
                            break;
                        }
                        
                        break;
                    //case "Italiano :
                    case "3" :
                        Console.WriteLine("Name of dish: " + Italiano.getName() + " | Prepare time: " + Italiano.getTime() + " | Dish's ingredients :" +
                                          Italiano.getDesc() + " | Price : " + Italiano.getPrice() + "$ |");
                         x = Eric.assigncook(Italiano.getTime());
                         y = Alexandru.assigncook(Italiano.getTime());
                         z = Ciprian.assigncook(Italiano.getTime());
                        if (x > 10000 && y > 10000 && z > 10000)
                        {
                            Console.WriteLine((" All the cooks are busy"));
                            break;
                        }

                        if (x == 0)
                        {
                            Console.WriteLine((" Your cook is Eric"));
                            Eric.addtime(Italiano.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Eric.getTime()));
                            Eric.incOrder();
                            break;
                        }

                      else   if (y == 0)
                        {
                            Console.WriteLine((" Your cook is Alexandru"));
                            Alexandru.addtime(Italiano.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Alexandru.getTime()));
                            Alexandru.incOrder();
                            break;
                        }

                      else   if (z == 0)
                        {
                            Console.WriteLine((" Your cook is Ciprian"));
                            Ciprian.addtime(Italiano.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Ciprian.getTime()));
                            Ciprian.incOrder();
                            break;
                        }

                        if (x <= y && x <= z)
                        {
                            Console.WriteLine((" Your cook is Eric"));
                            Eric.addtime(Italiano.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Eric.getTime()));
                            Eric.incOrder();
                            break;
                        }

                       else  if (y <= x && y <= z)
                        {
                            Console.WriteLine((" Your cook is Alexandru"));
                            Alexandru.addtime(Italiano.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Alexandru.getTime()));
                            Alexandru.incOrder();
                            break;
                        }

                       else if (z <= x && z <= y)
                        {
                            Console.WriteLine((" Your cook is Ciprian"));
                            Ciprian.addtime(Italiano.getTime());
                            Console.WriteLine(("Dish will be ready in aprox : " + Ciprian.getTime()));
                            Ciprian.incOrder();
                            break;
                        }
                        break;
                     
                         

                    default:

                        break;
                }

            } while (choice != "4");
        }public static void PrintValues( IEnumerable myList )  {
            foreach ( Object obj in myList )
                Console.Write( "   {0}", obj );
            Console.WriteLine();
        }
    }

    }
    
