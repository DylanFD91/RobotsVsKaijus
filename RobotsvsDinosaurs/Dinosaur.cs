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
        Weapon dinosaurWeapon; //declares weapon variable
        public string dinoName;
        public int dinoHealth;
        public string dinoType;
        public int dinoEnergy;

        //Constructor
        public Dinosaur()
        {
            DinoNamer();//calls the dino name method
            dinoHealth = rnd.Next(70, 125);//allows there to be a randomized number for health/energy
            dinoType = "Kaiju";
            dinoEnergy = rnd.Next(20,41);
            dinosaurWeapon = new Weapon();//calls the weapon class and creates a weapon object

        }
        //Methods
        public void DinoNamer()//Names your dinosaur
        {
            Console.WriteLine("What do you want your dinosaur name to be");
            dinoName = Console.ReadLine();
        }
    }
}
