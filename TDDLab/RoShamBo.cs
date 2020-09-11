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
            else if ((playerOne == "Scissors" && playerTwo == "Paper") ||
                playerTwo == "Paper" && playerOne == "Scissors")
            {
                return "Scissors beats Paper";
            }
            else if ((playerOne == "Paper" && playerTwo == "Rock") ||
               playerTwo == "Rock" && playerOne == "Paper")
            {
                return "Paper beats Rock";
            }
            else
            {
                return "Both players played the same. It's a tie.";
            }            
        }
    }
}
