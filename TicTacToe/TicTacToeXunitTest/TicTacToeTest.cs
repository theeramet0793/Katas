using TicTacToeNamespace;
using Xunit;

namespace TicTacToeXunitTest
{
    public class TicTacToeTest
    {
        [Fact]
        public void IsFullTable_return_true()
        {
            var ttt = new TicTacToe();
            ttt.table = new string[3, 3] { { "X", "X", "X" }, { "X", "X", "X" }, { "X", "X", "X" } };
            

            var result = ttt.IsFullTable();

            Assert.True(result);
        }

        [Fact]
        public void IsFullTable_return_False()
        {
            var ttt = new TicTacToe();
            ttt.table = new string[3, 3] { { "1", "2", "3" }, { "X", "X", "X" }, { "X", "X", "X" } };

            var result = ttt.IsFullTable();

            Assert.False(result);
        }
        
        [Fact]
        public void CheckWinner_return_X()
        {
            var ttt = new TicTacToe();
            ttt.table = new string[3, 3] { { "1", "2", "3" }, { "X", "X", "X" }, { "7", "8", "9" } };

            var result = ttt.CheckWinner();

            Assert.Equal("X",result);
        }

        [Fact]
        public void CheckWinner_return_O()
        {
            var ttt = new TicTacToe();
            ttt.table = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "O", "O", "O" } };

            var result = ttt.CheckWinner();

            Assert.Equal("O", result);
        }

        [Fact]
        public void CheckWinner_return_null()
        {
            var ttt = new TicTacToe();
            ttt.table = new string[3, 3] { { "1", "2", "3" }, { "4", "X", "X" }, { "7", "8", "9" } };

            var result = ttt.CheckWinner();

            Assert.Null(result);
        }
    }
}