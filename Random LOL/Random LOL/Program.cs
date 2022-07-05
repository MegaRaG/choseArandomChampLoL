using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Random_LOL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Chapions> lesChampions = Program.ChargeChampions();
            int nb = 0;
            bool encore = true;
            while (encore)
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine("0.Quitter");
                Console.WriteLine("1.Voir tous les Champions");
                Console.WriteLine("2.Random parmis tous les champions");
                Console.WriteLine("3.Random parmis tous les tanks");
                Console.WriteLine("4.Tous les champions tank");
                Console.WriteLine("5.Tous les champions assassin");
                Console.WriteLine("6.Tous les champions support");
                Console.WriteLine("7.Tous les champions tireur");
                Console.WriteLine("8.Tous les champions combattant");
                Console.WriteLine("9.Tous les champions mage");
                Console.WriteLine("10.Generation code");
                Console.WriteLine("11.Generation code");
                Console.WriteLine("12.Generation code");
                Console.WriteLine("13.Generation code");
                Console.WriteLine("14.Generation code");
                Console.WriteLine("---------------------");
                String rep = Console.ReadLine();
                switch (rep)
                {
                    case "0": encore = false; break;
                    case "1":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES CHAMPIONS");
                            Console.WriteLine("---------------------");
                            AfficheListe(lesChampions);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("RANDOM TOUS LES CHAMPIONS");
                            Console.WriteLine("---------------------");
                            double numeroChampionRandom = Chapions.RandomTous();
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.NumeroChampion == numeroChampionRandom)
                                    Console.WriteLine(unChampion);
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("RANDOM LES CHAMPIONS TANKS");
                            Console.WriteLine("---------------------");
                            double numeroChampionRandom = Chapions.RandomTous();
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.NumeroChampion == numeroChampionRandom && unChampion.Categorie == CategorieChampion.Tank)
                                    Console.WriteLine(unChampion);
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES CHAMPIONS TANKS");
                            Console.WriteLine("---------------------");
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.Categorie == CategorieChampion.Tank)
                                    Console.WriteLine("--------------------\n" + unChampion);
                            }
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES CHAMPIONS ASSASSINS");
                            Console.WriteLine("---------------------");
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.Categorie == CategorieChampion.Assassin)
                                    Console.WriteLine("--------------------\n" + unChampion);
                            }
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES CHAMPIONS SUPPORTS");
                            Console.WriteLine("---------------------");
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.Categorie == CategorieChampion.Support)
                                    Console.WriteLine("--------------------\n" + unChampion);
                            }
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES CHAMPIONS TIREUR");
                            Console.WriteLine("---------------------");
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.Categorie == CategorieChampion.Tireur)
                                    Console.WriteLine("--------------------\n" + unChampion);
                            }
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES CHAMPIONS COMBATTANTS");
                            Console.WriteLine("---------------------");
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.Categorie == CategorieChampion.Combattant)
                                    Console.WriteLine("--------------------\n" + unChampion);
                            }
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES CHAMPIONS MAGES");
                            Console.WriteLine("---------------------");
                            foreach (Chapions unChampion in lesChampions)
                            {
                                if (unChampion.Categorie == CategorieChampion.Mage)
                                    Console.WriteLine("--------------------\n" + unChampion);
                            }

                            break;
                        }
                    case "10":
                        {
                            foreach (Chapions unChampion in lesChampions)
                            {
                                nb = unChampion.NumeroChampion;
                                Console.WriteLine("case" + "\"" + nb + "\":"+ "\n" +"{" + "\n" +"this.reponseNom = " + "\"" + unChampion.Nom +"\";" + "\n"+
                                    "if (this.BoxNom.Text == reponseNom || this.BoxNom.Text == reponseNom.ToUpper())" + "\n" + "{" + "\n" + "this.LabelFaire.Content = "+ "\"" + "Bravo c'est juste" + "\";" + "\n" +
                                    "Brush couleur1 = (Brush)bc.ConvertFrom(" + "\"" + "#FF0FFF00" + "\");" + "\n" + "this.LabelFaire.Foreground = couleur1;" + "\n" + "points += 1;" + "\n" + "}" + "\n" + "else"+ "\n" + "{" + "\n" +
                                    "this.LabelFaire.Content = " + "\"" + "Faux !" + "\";" + "\n" +
                                    "Brush couleur1 = (Brush)bc.ConvertFrom(" + "\"" + "#f00020" + "\");" + "\n" + "this.LabelFaire.Foreground = couleur1;" + "\n" + "points -= 1;" + "\n" + "}" + "\n" + "pointsEnString = points.ToString();" + "\n" + 
                                    "pointsEnObject = pointsEnString;" + "\n" + "LaPoints.Content = pointsEnObject;" + "\n" + "Button_Click(sender, e);"+ "\n" + "}" + "\n" + "break;");
                            }

                        }
                        break;
                    case "11":
                        {
                            foreach (Chapions unChampion in lesChampions)
                            {
                                Console.WriteLine("else if (this.Immage" + unChampion.NumeroChampion + ".Visibility == Visibility.Visible) { nbPage = " + "\"" + unChampion.NumeroChampion +"\"" + " ; }");
                            }
                            
                        }
                        break;
                    case "12":
                        {
                            foreach (Chapions unChampion in lesChampions)
                            {
                                Console.WriteLine("< Image x:Name = " + "\"" +"Immage" + unChampion.NumeroChampion + "\"" + " VerticalAlignment=" + "\"" + "Top" + "\"" + " Height=" + "\"" + 282 + "\"" + " Margin=" + "\"" + "0,56,101.2,0" + "\"" + " Source=" + "\"" + "ImagesChamps/Champion" + unChampion.NumeroChampion +".jpg"+ "\"" + " HorizontalAlignment = " + "\"" + "Right" + "\"" + " Width=" + "\"" + 250 + "\"" + " Visibility=" + "\"" + "Hidden" + "\"" + " />");
                            }
                            
                        }
                        break;
                    case "13":
                        {
                            foreach (Chapions unChampion in lesChampions)
                            {
                                Console.WriteLine("this.Immage"+unChampion.NumeroChampion+".Visibility = Visibility.Hidden;");

                            }
                                
                        }
                        break;
                    case "14":
                        {
                            foreach (Chapions unChampion in lesChampions)
                            {
                                Console.WriteLine("case" + "\"" + unChampion.NumeroChampion + "\":" + "\n" + "{" + "\n" + "Immage" + unChampion.NumeroChampion + ".Visibility = Visibility.Visible;" + "\n" + "}" + "\n" + "break;");
                            }
                        }
                        break;
                }
                Console.ReadLine();
            }
        }

            public static List<Chapions> ChargeChampions()
            {
                List<Chapions> lesStocks = null;
                try
                {
                    String contenuFichier = File.ReadAllText("Championsse.json");
                    lesStocks = JsonConvert.DeserializeObject<List<Chapions>>(contenuFichier);
                }
                catch (Exception e) { throw e; }
                return lesStocks;
            }
            public static void AfficheListe(List<Chapions> liste)
            {
                foreach (Chapions unChampion in liste)
                    Console.WriteLine(unChampion);
            }
        }
    }

