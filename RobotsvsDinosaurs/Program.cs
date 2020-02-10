using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Welcome! to Kaijus vs Robots! Press Enter to Start the game...");
            Console.WriteLine("--------------------------------------------------------------\n");
            Console.ReadLine();
            Battlefield battlefield = new Battlefield();
            battlefield.SimulateProgram();
            Console.ReadLine();
        }
    }
}
