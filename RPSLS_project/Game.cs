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
        public Random randomNumber;
        public string numberPlayers;

        //constructor
        public Game()
        {
            randomNumber = new Random();
        }


        //member methods
        public void RunGame()
        {
            DisplayGameRules();
            numberPlayers = GetNumberOfPlayers();
            SetPlayers(numberPlayers);

            while (playerOne.score < 2 && playerTwo.score < 2)
            { RunFullGameRound(); }
            CheckGameWinner();
            AskPlayAgain();
        }

        public void RunFullGameRound()
        {
            Console.ReadLine();
            DisplayGestureList();
            playerOne.ChooseGesture();
            Console.ReadLine();
            DisplayGestureList();
            playerTwo.ChooseGesture();

            CompareGestures();
        }
        public string GetNumberOfPlayers()
        {
            Console.WriteLine("Please choose the number of human players in the game: \n");
            string userInput = Console.ReadLine();
            return userInput;

        }
        public void SetPlayers(string numberPlayers)
        {

            bool isValid = true;
            while (isValid)
            {
                if (numberPlayers == "1")
                {
                    playerOne = new Human();
                    playerTwo = new AI(randomNumber);
                    Console.WriteLine(playerOne.name + ", you are now playing against the computer!");
                    isValid = false;
                }
                else if (numberPlayers == "2")
                {
                    playerOne = new Human();
                    playerTwo = new Human();
                    isValid = false;
                }
                else if (numberPlayers == "0")
                {
                    playerOne = new AI(randomNumber);
                    playerTwo = new AI(randomNumber);
                    Console.WriteLine("You can now watch the computer players!");
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid number of players");
                    numberPlayers = GetNumberOfPlayers();
                }
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
            Console.WriteLine("To win the game, you must win the best of 3 rounds. The gesture results are:");
            Console.WriteLine(" * Rock crushes Scissors, and crushes Lizard");
            Console.WriteLine(" * Scissors cuts Paper, and decapitates Lizard");
            Console.WriteLine(" * Paper covers Rock, and disproves Spock");
            Console.WriteLine(" * Lizard poisons Spock, and eats Paper");
            Console.WriteLine(" * Spock vaporizes Rock, and smashes Scissors");
            Console.WriteLine("Press ENTER key when ready to begin!");
            Console.ReadLine();
        }
        public void CompareGestures()
        {
            Console.WriteLine(playerOne.name + " uses " + playerOne.gesture);
            Console.WriteLine(playerTwo.name + " uses " + playerTwo.gesture);
            Console.ReadLine();

            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Players have tied! Please redo round");
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
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
        public void CheckGameWinner()
        {
            if (playerOne.score >= 2)
            {
                Console.WriteLine(playerOne.name + " has a total score of " + playerOne.score + " round wins and wins the game!");
            }
            else if (playerTwo.score >= 2)
            {
                Console.WriteLine(playerTwo.name + " has a total score of " + playerTwo.score + " round wins and wins the game!");
            }

        }

        public void AskPlayAgain()
        {
            Console.WriteLine("Would you like to play another game?");
            string userResponse = Console.ReadLine();

            if (userResponse == "yes" || userResponse == "Yes" || userResponse == "Y")
            {
                RunGame();
            }
            
        }

        
    }
}
