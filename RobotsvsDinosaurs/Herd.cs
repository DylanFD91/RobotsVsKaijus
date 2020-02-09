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
        //Constructor
        //Methods

        public List<Dinosaur> dinosaurs = new List<Dinosaur>();
        public Herd()
        {
            for(int index = 0; index < 3; index++)
            {
                Dinosaur dino = new Dinosaur();
                dinosaurs.Add(dino);
            }
            PrintDinosaurHerd(dinosaurs);
        }
        public void PrintDinosaurHerd(List<Dinosaur> dinosaurNames)
        {
            foreach(Dinosaur dinosaur in dinosaurNames)
            {
                Console.WriteLine("\nYour Dinosaurs Name is: " + dinosaur.dinoName);
                Console.WriteLine("Your Dinosaurs Health is: " + dinosaur.dinoHealth);
                Console.WriteLine("Your Dinosaurs Type is: " + dinosaur.dinoType);
                Console.WriteLine("Your Dinosaurs Energy is: " + dinosaur.dinoEnergy);
                Console.WriteLine("Your Dinosaurs Weapon is: " + dinosaur.dinoWeapon);
                Console.WriteLine("Your Dinosaurs Weapon Power is: " + dinosaur.dinosaurWeapon.weaponPower + " and the type is " + dinosaur.dinosaurWeapon.weaponType);
            }
        }
    }
}
