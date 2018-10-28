﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using FluentAssertions;

namespace Tests
{
    /*
        Tic-tac-toe 
            (also known as noughts and crosses or Xs and Os) 
            
        is a paper-and-pencil game for two players, X and O, who 
        take turns marking the spaces in a 3×3 grid. 
    
        The player who succeeds in placing three of their marks in a 
        horizontal, vertical, or diagonal row wins the game.
    */

    public class TicTackToeTests
    {
        [Fact]
        public void ValidMarks()
        {
            IsValid(0).Should().BeTrue();
            IsValid(-1).Should().BeFalse();
            IsValid(9).Should().BeFalse();
            IsValid(1).Should().BeTrue();
            IsValid(8).Should().BeTrue();
        }

        [Fact]
        public void CanScoreGame()
        {
            GameCanBeScored(0).Should().BeFalse();
            GameCanBeScored(5).Should().BeTrue();
        }

        public bool GameCanBeScored(int plays)
        {
            return plays >= 5;
        }

        public bool IsValid(int position)
        {
            return position >= 0 && position <= 8;
        }
    }
}
