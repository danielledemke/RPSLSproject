using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public abstract class Player
    {
        //member variables
        public string name = "";
        public int score;
        public string gesture;


        //constructor



        //member methods
        public abstract void ChooseGesture();

        public abstract void SetUserName();
        

       
    }
}
