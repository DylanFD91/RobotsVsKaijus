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
            dinoHealth = new Random().Next(70, 126);
            dinoType = "Kaiju";
            dinoEnergy = new Random().Next(10,25);
            dinoWeapon = "Claws & Breath Attack";
            dinoWeaponType = "Slashing & Burning";
            dinosaurWeaponPower = 50;
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
            Console.WriteLine("If you are out of energy you can also choose to Wait to regain energy.\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Claw Attack":
                case "claw attack":
                case "1":
                    if (dinoEnergy >= 4)
                    {
                        dinosaurWeaponPower = 50;
                        robot.robotHealth -= dinosaurWeaponPower;
                        Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeaponPower + " points of damage.");
                        Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
                        dinoEnergy -= 4;
                        Console.WriteLine("You have used 4 Energy, " + dinoEnergy + " is your current energy.");
                    }
                    else
                    {
                        Console.WriteLine("\nYou do not have enough energy to do that. Please try again.");
                    }
                    break;
                case "Breath Attack":
                case "breath attack":
                case "2":
                    if (dinoEnergy >= 15)
                    {
                        dinosaurWeaponPower = 90;
                        robot.robotHealth -= dinosaurWeaponPower;
                        Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeaponPower + " points of damage.");
                        Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
                        dinoEnergy -= 15;
                        Console.WriteLine("You have used 15 Energy, " + dinoEnergy + " is your current energy.");
                    }
                    else
                    {
                        Console.WriteLine("\nYou do not have enough energy to do that. Please try again.");
                    }
                    break;
                case "Wait":
                case "wait":
                    dinoEnergy += 5;
                    Console.WriteLine("You have recharged 5 Energy, " + dinoEnergy + " is your current energy.");
                    break;
                default:
                    Console.WriteLine("Please input a valid response...");
                    DinoAttack(robot);
                    break;
            }

            /*robot.robotHealth -= dinosaurWeaponPower;
            Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeaponPower + " points of damage.");
            Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
            dinoEnergy -= 3;*/
        }
    }
}
