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
        Herd dinosaurHerd = new Herd();
        Fleet robotFleet = new Fleet();
        Robot robot = new Robot();
        Dinosaur dinosaur = new Dinosaur();
        //keeps track of player turns
        public bool dinoTurn = false;
        public bool robotTurn = false;
        //keeps track of player scores
        public int robotPlayerScore = 0;
        public int dinoPlayerScore = 0;



        //Constructor
        // text



        //Methods
        /*public void Destroyed()//will destroy dinos or robots when health reaches 0
        {
            if (List < Dinosaur > dinosaurHerd.dinosaurs.dinoHealth || List < Robot > robotFleet.robots.robotHealth <= 0)
            {

            }
        }*/

        //something that tracks rounds
        // do while loop?


        //something that can hold each of the constructed objects robots and dinos
        //this must also hold there values and allow them to be targeted
        //switch case statement? with maybe a nested if or loop statement

        // something that when all robots or dinos are dead will declare a player to be the winner and increase there score.



        //this is the method that calls the turn choice methods
        /*public void ChoiceForAttack(List<Dinosaur> dinosaurNames)
        {
            if (dinoTurn == true)
            {
                DinosaursTurnChoice();
            }
            else if(robotTurn == true)
            {
                RobotsTurnChoice();
            }
        }*/


        //this lets the player decide which dinosaur they want to attack with
        /*public void DinosaursTurnChoice()
        {
            do
            {
                Console.WriteLine("\nPlease choose what Dinosaur you would like to attack with(Please type your dinosaurs name): ");
                foreach (List<Dinosaur> dinosaurNames )
                {
                    Console.WriteLine(dinosaur.dinoName);
                }
                string whichDinoChoice = Console.ReadLine();
                switch (whichDinoChoice)
                {
                    case:
                        break;
                    default:
                        Console.WriteLine("Please try again, it is case sensitive.");
                        break;
                }
            } while (dinoTurn == true);

        }*/


        //this lets the player decide which robot they want to attack with
        /*public void RobotsTurnChoice()
        {
            do
            {
                Console.WriteLine("\nPlease choose what Dinosaur you would like to attack with(Please type your dinosaurs name): ");
                foreach (Robot robots in robotNames)
                {
                    Console.WriteLine(robot.robotName);
                }
                string whichRobotChoice = Console.ReadLine();
                switch (whichRobotChoice)
                {
                    case:
                        break;
                    default:
                        Console.WriteLine("Please try again, it is case sensitive.");
                        break;
                }
            } while (robotTurn == true);
        }*/


        //replay method(Complete)
        public void WantToPlayAgain()//will rerun the program after winner is declared
        {
            Console.WriteLine("Would you like to play again?(Type Y/N): ");
            string playAgain = Console.ReadLine();
            switch (playAgain)
            {
                case "Y":
                case "y":
                    InitializeProgram();
                    break;
                default:
                    Console.WriteLine("Thankyou for playing");
                    Console.ReadLine();
                    break;
            }

        }


        //Runs the program
        public void InitializeProgram()
        {




            
            WantToPlayAgain();
        }
    }
}
