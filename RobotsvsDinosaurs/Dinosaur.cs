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
        //public Weapon dinosaurWeapon;
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
            dinoWeapon = "Claws";
            dinoWeaponType = "Slashing";
            dinosaurWeaponPower = 75;
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
            robot.robotHealth -= dinosaurWeaponPower;
            Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeaponPower + " points of damage.");
            Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
            dinoEnergy -= 3;
        }
    }
}
