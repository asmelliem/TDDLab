using ROSHAMBO;
using System;
using Xunit;

namespace ROSHAMBOTests
{
    public class UnitTest1
    {
        [Fact]
        public void RockBeatsScissorsTest()
        {
            //Arrange
            RoShamBo roShamBo = new RoShamBo();
            var playerOne = "Rock";
            var playerTwo = "Scissors";
            var expected = "Rock beats Scissors";

            //Act
            var actual = roShamBo.DetermineWinner(playerOne, playerTwo);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
