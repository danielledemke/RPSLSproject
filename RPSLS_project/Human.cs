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
            Console.ForegroundColor = ConsoleColor.Black;
            gesture = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            bool isValid = true;
            while (isValid)
            {
                switch (gesture)
                {
                    case "Rock":
                    case "rock":

                        gesture = "Rock";
                        isValid = false;
                        break;
                    case "Paper":
                    case "paper":
                        gesture = "Paper";
                        isValid = false;
                        break;
                    case "scissors":
                    case "Scissors":
                        gesture = "Scissors";
                        isValid = false;
                        break;
                    case "Lizard":
                    case "lizard":
                        gesture = "Lizard";
                        isValid = false;
                        break;
                    case "Spock":
                    case "spock":
                        gesture = "Spock";
                        isValid = false;
                        break;

                    default:
                        Console.WriteLine("Not a valid entry");
                        ChooseGesture();
                        break;

                }
                
            }

        }

        public override void SetUserName()
        {
            Console.WriteLine("Please enter name for this player: \n");
            name = Console.ReadLine();
        }

    }
}
