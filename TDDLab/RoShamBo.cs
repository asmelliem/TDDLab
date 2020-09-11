using System;
using System.Collections.Generic;
using System.Text;

namespace ROSHAMBO
{
    public class RoShamBo
    {
        public string Play(string playerOne, string playerTwo)
        {
            var result = "";
            if((playerOne == "Rock" && playerTwo == "Scissors") || 
                playerTwo == "Rock" && playerOne == "Scissors")
            {
                result =  "Rock beats Scissors";
            }
            else if ((playerOne == "Scissors" && playerTwo == "Paper") ||
                playerTwo == "Paper" && playerOne == "Scissors")
            {
                result = "Scissors beats Paper";
            }
            else if ((playerOne == "Paper" && playerTwo == "Rock") ||
               playerTwo == "Rock" && playerOne == "Paper")
            {
                result = "Paper beats Rock";
            }
            else
            {
                result = "Both players played the same. It's a tie.";
            }

            return result;
        }
    }
}
