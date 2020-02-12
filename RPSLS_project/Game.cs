using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class Game
    {
        //member variables
       public Player playerOne;
       public Player playerTwo;
       public List<string> gestures;


        //constructor



        //member methods
        public void RunGame()
        {
            DisplayGameRules();
            GetNumberOfPlayers();
            string numberPlayers = GetNumberOfPlayers();
            SetPlayers(numberPlayers);
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
        }

        public string GetNumberOfPlayers()
        {
            Console.WriteLine("Please choose the number of human players in the game: \n");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
            
        }
        public void SetPlayers(string numberPlayers)
        {
            if (numberPlayers == "1")
            {
                playerOne = new Human();
                playerTwo = new AI();
            }
            else if(numberPlayers == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else if(numberPlayers == "0")
            {
                playerOne = new AI();
                playerTwo = new AI();
            }
            else
            {
                Console.WriteLine("Invalid number of players");
                GetNumberOfPlayers();
            }
        }
        public void DisplayGestureList()
        {
            Console.WriteLine("The list of possible gesture choices is as follows:");
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
        public void DisplayGameRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! \n The game is played just like a standard game of Rock, Paper, Scissors except with additional gesture choices.");
            Console.WriteLine("To win the game, you must win the best of 3 rounds");
            Console.WriteLine("Rock crushes Scissors, and crushes Lizard");
            Console.WriteLine("Scissors cuts Paper, and decapitates Lizard");
            Console.WriteLine("Paper covers Rock, and disproves Spock");
            Console.WriteLine("Lizard poisons Spock, and eats Paper");
            Console.WriteLine("Spock vaporizes Rock, and smashes Scissors");
            Console.ReadLine();
        }
        public void CompareGestures()
        {
            Console.WriteLine(playerOne.name + " uses " + playerOne.gesture);
            Console.WriteLine(playerTwo.name + "uses " + playerTwo.gesture);

            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Players have tied! Please redo round");
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
            }
            else if (playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Paper" && playerTwo.gesture == "Spock")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Spock" && playerTwo.gesture == "Rock")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else if (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissors")
            {
                Console.WriteLine(playerOne.name + " wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine(playerTwo.name + " wins the round!");
                playerTwo.score++;
            }
        }
        
    }
}
