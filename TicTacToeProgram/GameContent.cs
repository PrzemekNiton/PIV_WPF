using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameContent
    {
        public string actualPlayer { get; set; }

        private const string X = "X";
        private const string O = "O";

        public void SetNextUser()
        {
            if (actualPlayer == X)
            {
                actualPlayer = O;
                
            }
            else
            {
                actualPlayer = X;
            }

        }

      

    }
}
