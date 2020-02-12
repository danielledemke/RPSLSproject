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
            Console.WriteLine("Please choose gesture: \n");
            gesture = Console.ReadLine();
        }

        public override void SetUserName()
        {
            Console.WriteLine("Please enter name for this player: \n");
            name = Console.ReadLine();
        }

    }
}
