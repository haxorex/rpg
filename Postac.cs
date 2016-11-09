using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Postac
    {
        public static string player_name;
        public static string pick;
        public static int hp;
        public static int dmg;
        public int level;
        public static void MakeCharacter()
        {
            //Wprowadzanie nazwy postaci
            Console.WriteLine("Please write your character name");
            Console.Write("Name: ");
            player_name = Console.ReadLine();
            Console.Clear();
            ConfirmName();

        }
        

        public static void ConfirmName()
        {
            string choice;
            Console.WriteLine("Are sure u want to be named {0}?", player_name);
            Console.WriteLine("Yes or No.");
            choice = Console.ReadLine();
            if (choice == "yes" || choice == "Yes")
            {
                WyborKlasy();
            }
            else 
            {
                //Jesli się pomylil powtorz tworzenie postaci
                Console.Clear();
                MakeCharacter();
            }
        }
        public static void WyborKlasy()
        {
            Console.Clear();
            Console.WriteLine("Please choose class:");
            Console.WriteLine("Mage");
            Console.WriteLine("Warrior");
            Console.WriteLine("Ninja");
            pick = Console.ReadLine();
            switch (pick)
            {
                case "mage":
                    Console.Clear();
                    PotwierdzenieKlasy(pick);
                    Console.ReadLine();
                    break;
                case "warrior":
                    Console.Clear();
                    PotwierdzenieKlasy(pick);
                    Console.ReadLine();
                    break;
                case "ninja":
                    Console.Clear();
                    PotwierdzenieKlasy(pick);
                    Console.ReadLine();
                    break;
                case "Mage":
                    Console.Clear();
                    PotwierdzenieKlasy(pick);
                    Console.ReadLine();
                    break;
                case "Warrior":
                    Console.Clear();
                    PotwierdzenieKlasy(pick);
                    Console.ReadLine();
                    break;
                case "Ninja":
                    Console.Clear();
                    PotwierdzenieKlasy(pick);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You wanted to pick not existed class.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    WyborKlasy();
                    break;
           }

        }
        public static void KlasaMage(){
            hp = 170;
            dmg = 25;
        }
        public static void KlasaWarrior()
        {
            hp = 220;
            dmg = 20;
        }
        public static void KlasaNinja()
        {
            hp = 190;
            dmg = 22;
        }
        public static void PotwierdzenieKlasy(string wybrana_klasa)
        {
            string choice;
            Console.WriteLine("You picked {0}.", wybrana_klasa);
            Console.WriteLine("Are you sure? Yes or no.");
            choice = Console.ReadLine();
            if (choice == "yes" || choice == "Yes")
            {
                //ukonczenie tworzenia postaci
                FinishedCreatingChar();
            }
            else 
            {
                //Jesli się pomylil powtorz tworzenie postaci
                Console.Clear();
                WyborKlasy();
            }
        }
        public static void FinishedCreatingChar()
        {
            Console.Clear();
            Console.WriteLine("Good job, {0}!", player_name);
            Console.WriteLine("Your journey has already started.");
            Console.WriteLine("Remember, that you're a {0}.", pick);
            ShowDesc();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Town.TownInfo();
        }
        public static void Description()
        {
            Console.WriteLine("You've {0} health points.", hp);
            Console.WriteLine("And you deal {0} base damage to monsters.", dmg);
        }
        public static void ShowDesc()
        {
            if (pick == "mage" || pick == "Mage")
            {
                KlasaMage();
                Description();
            }
            else if (pick == "warrior" || pick == "Warrior")
            {
                KlasaWarrior();
                Description();
            }
            else if (pick == "ninja" || pick == "Ninja")
            {
                KlasaNinja();
                Description();
            }
        }
        public static void Stats()
        {
            if (pick == "mage" || pick == "Mage")
            {
                KlasaMage();

            }
            else if (pick == "warrior" || pick == "Warrior")
            {
                KlasaWarrior();
            }
            else if (pick == "ninja" || pick == "Ninja")
            {
                KlasaNinja();
            }
        }
    }

}
