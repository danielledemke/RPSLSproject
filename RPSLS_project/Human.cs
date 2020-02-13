using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class Human : Player
    {
        //member variables


        //constructor
        public Human()
        {
            SetUserName();
        }

        //member methods
        public override void ChooseGesture()
        {
            Console.WriteLine(name + ", please choose gesture: \n");
            gesture = Console.ReadLine();

            switch (gesture)
            {
                case "Rock":
                case "rock":
                    gesture = "Rock";
                    break;
                case "Paper":
                case "paper":
                    gesture = "Paper";
                    break;
                case "scissors":
                case "Scissors":
                    gesture = "Scissors";
                    break;
                case "Lizard":
                case "lizard":
                    gesture = "Lizard";
                    break;
                case "Spock":
                case "spock":
                default:
                    Console.WriteLine("Not a valid entry");
                    break;
                    
            }

        }

        public override void SetUserName()
        {
            Console.WriteLine("Please enter name for this player: \n");
            name = Console.ReadLine();
        }

    }
}
