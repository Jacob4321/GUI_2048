using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_2048
{
    class User 
    {
        public int emptyy = 0; // empty field

        public static int[,] board = new int[9, 9];

        
        public void CreateBoard(int _sizeBoard)
        {

            // we give the value 0000 (empty field) of the "field" array

            for (int i = 0; i <= _sizeBoard; i++)
            {
                for (int j = 0; j <= _sizeBoard; j++)
                {
                    board[i, j] = emptyy;
                }
            }
        }

    }
}
