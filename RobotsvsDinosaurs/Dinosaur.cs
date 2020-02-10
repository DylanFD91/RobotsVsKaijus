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
        Random rnd = new Random();//declare the random variable
        public Weapon dinosaurWeapon; //declares weapon variable
        public string dinoName;
        public int dinoHealth;
        public string dinoType;
        public int dinoEnergy;
        public string dinoWeapon;

        //Constructor
        public Dinosaur()//dinosaur constructor(Complete)
        {
            DinoNamer();//calls the dino name method
            dinoHealth = rnd.Next(70, 126);//allows there to be a randomized number for health/energy
            dinoType = "Kaiju";
            dinoEnergy = rnd.Next(20,41);
            dinoWeapon = "Claws";
            dinosaurWeapon = new Weapon();//calls the weapon class and creates a weapon object
        }



        //Methods
        public void DinoNamer()//Names your dinosaur(Complete)
        {
            Console.WriteLine("\nWhat do you want your Kaiju name to be?");
            dinoName = Console.ReadLine();
        }
        public void DinoAttack(Robot robot)//Attack method()
        {
            robot.robotHealth -= dinosaurWeapon.weaponPower;
            Console.WriteLine("\n" + robot.robotName + " has just taken " + dinosaurWeapon.weaponPower + " points of damage.");
            Console.WriteLine("\n" + robot.robotName + " has " + robot.robotHealth + " hitpoints remaining.");
            dinoEnergy -= 3;
        }
    }
}
