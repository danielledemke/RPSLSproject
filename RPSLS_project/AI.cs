using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class AI : Player
    {
        //member variables
        int nameNumber;
        Random randomNumber;
        
        
        //constructor
        public AI()
        {
            randomNumber = new Random();
            nameNumber++;
            SetUserName();
        }

        //member methods
        public override void ChooseGesture()
        {
           int gestureNumber = GetRandomNumber();
            
            if(gestureNumber == 1)
            {
                gesture = "Rock";
            }
            if(gestureNumber == 2)
            {
                gesture = "Paper";
            }
            if(gestureNumber == 3)
            {
                gesture = "Scissors";
            }
            if(gestureNumber == 4)
            {
                gesture = "Lizard";
            }
            if(gestureNumber == 5)
            {
                gesture = "Spock";
            }
        }

        public override void SetUserName()
        {
            name = "Computer " + nameNumber;
        }
        public int GetRandomNumber()
        {

            int result = randomNumber.Next(1, 6);
            return result;
        }
    }
}
