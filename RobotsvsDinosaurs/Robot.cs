using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Robot
    {
        //Member Variables
        public Weapon robotWeapon;
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;


        //Constructor
        public Robot()
        {
            RobotChoice();
            robotHealth = new Random().Next(70, 126);
            robotPowerLevel = new Random().Next(20, 41);
            RobotArsenal();
        }
        //Methods
        public void RobotChoice()
        {
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("What do you want your Robot name to be");
            Console.WriteLine("--------------------------------------\n");
            robotName = Console.ReadLine();
        }
        public void RobotAttack(Dinosaur dino)
        {
            dino.dinoHealth -= robotWeapon.weaponPower;
            Console.WriteLine("\n" + dino.dinoName + " has just taken " + robotWeapon.weaponPower + " points of damage");
            Console.WriteLine("\n" + dino.dinoName + " has " + dino.dinoHealth + " hitpoints remaining");
            robotPowerLevel -= 3;
        }

        public void RobotArsenal()
        {
            List<Weapon> weapons = new List<Weapon>() {new Weapon("Plasma Sword", "Slashing", 50), new Weapon("Lazer Gun", "Piercing", 75), new Weapon("Shoulder Launchers", "Explosive", 100)};
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Choose what weapon you would like to use:");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("The Plasma Sword, its power is 50, and its damage type is slashing.");
            Console.WriteLine("The Lazer Gun, its power is 75, and its damage type is piercing");
            Console.WriteLine("The Shoulder Launchers, its power is 100, and its damage type is explosive.\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Plasma Sword":
                case "plasma sword":
                case "1":
                    robotWeapon = weapons[0];
                    break;
                case "Lazer Gun":
                case "lazer gun":
                case "2":
                    robotWeapon = weapons[1];
                    break;
                case "Shoulder Launchers":
                case "shoulder launchers":
                case "3":
                    robotWeapon = weapons[2];
                    break;
                default:
                    Console.WriteLine("That was not a valid input, please try again...");
                    RobotArsenal();
                    break;
            }
        }
    }
}
