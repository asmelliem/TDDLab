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
            var actual = roShamBo.Play(playerOne, playerTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ScissorsBeatsPaperTest()
        {
            //Arrange
            RoShamBo roShamBo = new RoShamBo();
            var playerOne = "Scissors";
            var playerTwo = "Paper";
            var expected = "Scissors beats Paper";

            //Act
            var actual = roShamBo.Play(playerOne, playerTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PaperBeatsRockTest()
        {
            //Arrange
            RoShamBo roShamBo = new RoShamBo();
            var playerOne = "Paper";
            var playerTwo = "Rock";
            var expected = "Paper beats Rock";

            //Act
            var actual = roShamBo.Play(playerOne, playerTwo);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsATieTest()
        {
            //Arrange
            RoShamBo roShamBo = new RoShamBo();
            var playerOne = "Paper";
            var playerTwo = "Paper";
            var expected = "Both players played the same. It's a tie.";

            //Act
            var actual = roShamBo.Play(playerOne, playerTwo);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
