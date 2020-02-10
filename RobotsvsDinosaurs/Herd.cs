using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Herd
    {
        //Member Variables
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        //Constructor
        public Herd()
        {
            for(int index = 0; index < 3; index++)
            {
                Dinosaur dino = new Dinosaur();
                dinosaurs.Add(dino);
            }
            Console.WriteLine("-----------------------");
            PrintDinosaurHerd(dinosaurs);
        }

        //Methods
        public void PrintDinosaurHerd(List<Dinosaur> dinosaurNames)
        {
            foreach(Dinosaur dinosaur in dinosaurNames)
            {
                Console.WriteLine("\n\nYour Kaijus Name is: " + dinosaur.dinoName + " Here is his statistics: ");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("Your Kaijus Health is: " + dinosaur.dinoHealth);
                Console.WriteLine("Your Kaijus Type is: " + dinosaur.dinoType);
                Console.WriteLine("Your Kaijus Energy is: " + dinosaur.dinoEnergy);
                Console.WriteLine("Your Kaijus Weapon is: " + dinosaur.dinoWeapon);
                Console.WriteLine("Your Kaijus Weapon Power is: " + dinosaur.dinosaurWeapon.weaponPower + " and the type is " + dinosaur.dinosaurWeapon.weaponType);
            }
        }
    }
}