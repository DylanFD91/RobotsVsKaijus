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
        }
        public void PrintDinosaurHerd(List<Dinosaur> dinosaurNames)
        {
            foreach(Dinosaur dinosaur in dinosaurNames)
            {
                Console.WriteLine(dinosaur.dinoName);
                Console.WriteLine(dinosaur.dinoHealth);
                Console.WriteLine(dinosaur.dinoType);
                Console.WriteLine(dinosaur.dinoEnergy);
            }
        }
    }
}
