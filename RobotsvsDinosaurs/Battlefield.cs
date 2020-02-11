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


        //Lets player choose which object to attack
        public void RobotTurnChoice(Robot robot)
        {
            Console.WriteLine("\nPlease choose what Kaiju you would like to attack(Please type the Kaijus name): ");
            foreach (Dinosaur dinosaur in dinosaurHerd.dinosaurs)
            {
                Console.WriteLine(dinosaur.dinoName + "'s remaining hitpoints: " + dinosaur.dinoHealth +"\n");
            }
            string input = Console.ReadLine();
            foreach (Dinosaur dino in dinosaurHerd.dinosaurs.ToList())
            {
                if(dino.dinoName == input)
                {
                    Console.WriteLine("\n----------------------------");
                    Console.WriteLine("You have chosen " + input + " to attack!");
                    Console.WriteLine("----------------------------\n");
                    robot.RobotAttack(dino);
                    DinosaurKilled(dino);
                }
            }
        }
        public void DinosaursTurnChoice(Dinosaur dinosaur)
        {
            Console.WriteLine("\nPlease choose what Robot you would like to attack(Please type the Robots name): ");
            foreach(Robot robot in robotFleet.robots)
            {
                Console.WriteLine(robot.robotName + "'s remaining hitpoints: " + robot.robotHealth + "\n");
            }
            string input = Console.ReadLine();
            foreach (Robot robot in robotFleet.robots.ToList())
            {
                if(robot.robotName == input)
                {
                    Console.WriteLine("\n----------------------------");
                    Console.WriteLine("You have chosen " + input + " to attack!");
                    Console.WriteLine("----------------------------\n");
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


        //replay method
        public void WantToPlayAgain()
        {
            Console.WriteLine("\nWould you like to play again?(Type Y/N): ");
            string playAgain = Console.ReadLine();
            switch (playAgain)
            {
                case "Y":
                case "y":
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Welcome! to Kaijus vs Robots! Press Enter to Start the game...");
                    Console.WriteLine("--------------------------------------------------------------\n");
                    Console.ReadLine();
                    Battlefield newGame = new Battlefield();
                    newGame.SimulateProgram();
                    break;
                default:
                    Console.WriteLine("\nThankyou for playing!");
                    Console.ReadLine();
                    break;
            }

        }


        //This loops the game until a winner is declared
        public void SimulateProgram()
        {
            while (dinosaurHerd.dinosaurs.Count >= 1 && robotFleet.robots.Count >= 1)
            {
                if (dinoTurn == true)
                {
                    Console.WriteLine("          -----------------------");
                    Console.WriteLine("          |It's now Kaijus turn!|");
                    Console.WriteLine("          -----------------------");
                    DinosaursTurnChoice(dinosaurHerd.dinosaurs[0]);
                    dinoTurn = false;
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("          -----------------------");
                    Console.WriteLine("          |It's now Robots turn!|");
                    Console.WriteLine("          -----------------------");
                    RobotTurnChoice(robotFleet.robots[0]);
                    dinoTurn = true;
                    Console.ReadLine();
                    Console.Clear();
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
            WantToPlayAgain();
        }
    }
}
