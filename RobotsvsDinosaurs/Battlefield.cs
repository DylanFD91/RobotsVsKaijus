using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Battlefield
    {
        //Member Variables
        public Herd dinosaurHerd = new Herd();
        public Fleet robotFleet = new Fleet();
        //keeps track of player turns
        public bool dinoTurn = false;


        //Methods


        //These destroy the objects in the list when they reach 0 hitpoints
        public void RobotDestroyed(Robot robot)
        {
            if (robot.robotHealth <= 0)
            {
                robotFleet.robots.Remove(robot);
                Console.WriteLine(robot.robotName + " has just died!\n");
            }
        }
        public void DinosaurKilled(Dinosaur dinosaur)
        {
            if (dinosaur.dinoHealth <= 0)
            {
                dinosaurHerd.dinosaurs.Remove(dinosaur);
                Console.WriteLine(dinosaur.dinoName + " has just died!\n");
            }
        }


        //Lets player choose which dino to attack
        public void RobotTurnChoice(Robot robot)
        {
            Console.WriteLine("\nPlease choose what Kaiju you would like to attack(Please type the dinosaurs name): ");
            foreach (Dinosaur dinosaur in dinosaurHerd.dinosaurs)
            {
                Console.WriteLine(dinosaur.dinoName + "\n");
            }
            string input = Console.ReadLine();
            foreach (Dinosaur dino in dinosaurHerd.dinosaurs.ToList())
            {
                    if(dino.dinoName == input)
                    {
                        robot.RobotAttack(dino);
                        DinosaurKilled(dino);
                    }
            }
        }


        //lets player choose which robot to attack
        public void DinosaursTurnChoice(Dinosaur dinosaur)
        {
            Console.WriteLine("\nPlease choose what Robot you would like to attack(Please type the Robots name): ");
            foreach(Robot robot in robotFleet.robots)
            {
                Console.WriteLine(robot.robotName + "\n");
            }
            string input = Console.ReadLine();
            foreach (Robot robot in robotFleet.robots.ToList())
            {
                if(robot.robotName == input)
                {
                    
                    dinosaur.DinoAttack(robot);
                    RobotDestroyed(robot);
                }
            }
        }


        //These Declare the winner of the game
        public void DinosaurWinner()
        {
            Console.WriteLine("\nThe Kaiju Player has won!");
        }
        public void RobotWinner()
        {
            Console.WriteLine("\nThe Robot Player has won!");
        }


        //replay method(Complete)
        public void WantToPlayAgain()//will rerun the program after winner is declared
        {
            Console.WriteLine("\nWould you like to play again?(Type Y/N): ");
            string playAgain = Console.ReadLine();
            switch (playAgain)
            {
                case "Y":
                case "y":
                    SimulateProgram();
                    break;
                default:
                    Console.WriteLine("\nThankyou for playing!");
                    Console.ReadLine();
                    break;
            }

        }


        //this provides logic for checking turns and runs the attack methods
        public void SimulateProgram()
        {
            while (dinosaurHerd.dinosaurs.Count >= 1 && robotFleet.robots.Count >= 1)
            {
                if (dinoTurn == true)
                {
                    Console.WriteLine("\nIt's now Kaijus turn!");
                    DinosaursTurnChoice(dinosaurHerd.dinosaurs[0]);
                    dinoTurn = false;
                }
                else
                {
                    Console.WriteLine("\nIt's now Robots turn!");
                    RobotTurnChoice(robotFleet.robots[0]);
                    dinoTurn = true;
                }
            }
            if (dinosaurHerd.dinosaurs.Count <= 0)
            {
                Console.WriteLine("\n");
                RobotWinner();
            }
            else
            {
                Console.WriteLine("\n");
                DinosaurWinner();
            }
        }
    }
}
