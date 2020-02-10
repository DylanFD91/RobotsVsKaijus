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
        public string dinoName;
        public int dinoHealth;
        public string dinoType;
        public int dinoEnergy;
        public string dinoWeapon;

        //Constructor
        public Dinosaur()
        {
            DinoNamer();
            dinoHealth = rnd.Next(70, 126);
            dinoType = "Kaiju";
            dinoEnergy = rnd.Next(20,41);
            dinoWeapon = "Claws";
            dinosaurWeapon = new Weapon();
        }

        //Methods
        public void DinoNamer()
        {
            Console.WriteLine("\nWhat do you want your Kaiju name to be?");
            dinoName = Console.ReadLine();
        }
        public void DinoAttack(Robot robot)
        {
            robot.robotHealth -= dinosaurWeapon.weaponPower;
            Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeapon.weaponPower + " points of damage.");
            Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
            dinoEnergy -= 3;
        }
    }
}
