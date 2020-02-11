using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Dinosaur
    {
        //Member Variables
        Random rnd = new Random();
        public Weapon dinosaurWeapon;
        public int dinosaurWeaponPower;
        public string dinoName;
        public int dinoHealth;
        public string dinoType;
        public int dinoEnergy;
        public string dinoWeapon;
        public string dinoWeaponType;

        //Constructor
        public Dinosaur()
        {
            KaijuNamer();
            dinoHealth = rnd.Next(70, 126);
            dinoType = "Kaiju";
            dinoEnergy = rnd.Next(20,41);
            dinoWeapon = "Claws & Breath Attack";
            dinoWeaponType = "Slashing & Burning";
            dinosaurWeaponPower = 0;
        }

        //Methods
        public void KaijuNamer()
        {
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("What do you want your Kaiju name to be?");
            Console.WriteLine("---------------------------------------\n");
            dinoName = Console.ReadLine();
        }
        public void DinoAttack(Robot robot)
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Choose what attack you would like to use:");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("The Claw Attack is slashing, it does 50 points of damage and uses low energy.");
            Console.WriteLine("The Breath Attack is burning, it does 90 points of damage and uses alot of energy.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Claw Attack":
                case "claw attack":
                case "1":
                    dinosaurWeaponPower = 50;
                    robot.robotHealth -= dinosaurWeaponPower;
                    Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeaponPower + " points of damage.");
                    Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
                    dinoEnergy -= 4;
                    break;
                case "Breath Attack":
                case "breath attack":
                case "2":
                    dinosaurWeaponPower = 90;
                    robot.robotHealth -= dinosaurWeaponPower;
                    Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeaponPower + " points of damage.");
                    Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
                    dinoEnergy -= 15;
                    break;
                default:
                    Console.WriteLine("Please input a valid response next time, your turn is skipped...");
                    break;
            }

            /*robot.robotHealth -= dinosaurWeaponPower;
            Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeaponPower + " points of damage.");
            Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
            dinoEnergy -= 3;*/
        }
    }
}
