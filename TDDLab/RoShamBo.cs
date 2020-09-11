using System;
using System.Collections.Generic;
using System.Text;

namespace ROSHAMBO
{
    public class RoShamBo
    {
        public string DetermineWinner(string playerOne, string playerTwo)
        {
            if((playerOne == "Rock" && playerTwo == "Scissors") || 
                playerTwo == "Rock" && playerOne == "Scissors")
            {
                return "Rock beats Scissors";
            }
            else
            {
                return "Scissors beats Paper";
            }
            
        }
    }
}
