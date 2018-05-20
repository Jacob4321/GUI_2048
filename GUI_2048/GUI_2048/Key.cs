using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_2048
{
    class Key
    {

        public bool check_move = false;
        public bool board_clear = false;
        public int falsee = 0;

        public int check_y = 0;                  // check after the variable y 
        public int check_x = 0;                  // check after the variable x

        public int check_next_y = 0;            // variable helpful
        public int check_next_x = 0;            // variable helpful
        public int check_priev_x = 0;            // variable helpful
        public int check_priev_y = 0;            // variable helpful


        User User = new User();

        public bool Checkclear(int _sizeBoard)
        {
            board_clear = false;

            // Checking if there are empty fields
            for (int i = 0; i <= _sizeBoard; i++)
            {
                for (int j = 0; j <= _sizeBoard; j++)
                {
                    if (User.board[i, j] == User.emptyy)
                    {
                        return board_clear = true;
                    }
                }
            }
            return board_clear = false;
        }




        public void CheckKey(int _sizeBoard, KeyEventArgs _key1)
        {
            check_move = false;

            if (_key1.Key == System.Windows.Input.Key.W || _key1.Key == System.Windows.Input.Key.Up)
            {
                for (check_x = 0; check_x <= _sizeBoard; check_x++)
                {
                    for (check_y = 0; check_y <= _sizeBoard; check_y++)
                    {
                        check_next_y = check_y + 1;

                        // we check the rows from first to last
                        for (int max = check_next_y; max <= _sizeBoard; max++)
                        {
                            falsee = 0;
                            // if the first and last lines are the same and if the last one is not zero
                            if (User.board[check_y, check_x] == User.board[max, check_x] && User.board[max, check_x] != User.emptyy)
                            {
                                // we check the elements between the second and last line
                                for (int i = check_next_y; i < max; i++)
                                {
                                    // if it is not empty
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle rows are empty
                                if (falsee == User.emptyy)
                                {
                                    // adding the first and last row cell
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    // we fill the last cell of the line with zero
                                    User.board[max, check_x] = User.emptyy;
                                    // confirmation that the move was made
                                    check_move = true;
                                }
                            }
                            // if the last line is not zero and the first is empty
                            else if (User.board[max, check_x] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // we check the elements of the array between the second and the last row
                                for (int i = check_next_y; i < max; i++)
                                {
                                    // if it is not empty
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle rows are empty
                                if (falsee == User.emptyy)
                                {
                                    // insert the contents of the last row to the first row
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    // fill the last line with zero
                                    User.board[max, check_x] = User.emptyy;
                                    // confirmation that the move was made
                                    check_move = true;
                                }
                            }
                            // if the first row and the next row are the same and if the next one is not zero
                            else if (User.board[check_y, check_x] == User.board[check_next_y, check_x] && User.board[check_next_y, check_x] != User.emptyy)
                            {
                                // add first and next line
                                User.board[check_y, check_x] += User.board[check_next_y, check_x];
                                // fill the next line with zero
                                User.board[check_next_y, check_x] = User.emptyy;
                                // confirmation that the move was made
                                check_move = true;
                            }
                            // if the first row is empty and the next is not
                            else if (User.board[check_y, check_x] == 0 && User.board[check_next_y, check_x] != User.emptyy)
                            {
                                // insert the content of the next row in place of the first one
                                User.board[check_y, check_x] += User.board[check_next_y, check_x];
                                // the next row will fill with zero
                                User.board[check_next_y, check_x] = User.emptyy;
                                // confirmation that the move was made
                                check_move = true;
                            }
                        }
                    }
                }
            }

            if (_key1.Key == System.Windows.Input.Key.A || _key1.Key == System.Windows.Input.Key.Left)
            {
                for (check_x = 0; check_x <= _sizeBoard; check_x++)
                {
                    for (check_y = 0; check_y <= _sizeBoard; check_y++)
                    {
                        check_next_x = check_x + 1;

                        // we check the columns from first to last
                        for (int max = check_next_x; max <= _sizeBoard; max++)
                        {
                            falsee = 0;
                            // if the first and last column is the same and if the last one is not zero
                            if (User.board[check_y, check_x] == User.board[check_y, max] && User.board[check_y, max] != User.emptyy)
                            {
                                // we check the elements of the array between the second and last column
                                for (int i = check_next_x; i < max; i++)
                                {
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle columns are empty
                                if (falsee == User.emptyy)
                                {
                                    // adding the cell of the first and last columns
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    User.board[check_y, max] = User.emptyy;
                                    check_move = true;
                                }
                            }
                            // if the last column is not zero and the first column is empty
                            else if (User.board[check_y, max] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // we check the elements of the array between the second and last column
                                for (int i = check_next_x; i < max; i++)
                                {
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle columns are empty
                                if (falsee == User.emptyy)
                                {
                                    // insert the contents of the last column into the first column
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    User.board[check_y, max] = User.emptyy;
                                    check_move = true;
                                }
                            }
                            // if the first column and the next column are the same and if the next one is not zero
                            else if (User.board[check_y, check_x] == User.board[check_y, check_next_x] && User.board[check_y, check_next_x] != User.emptyy)
                            {
                                // add first and next columns
                                User.board[check_y, check_x] += User.board[check_y, check_next_x];
                                User.board[check_y, check_next_x] = User.emptyy;
                                check_move = true;
                            }
                            // if the first column is empty and the next column is not
                            else if (User.board[check_y, check_x] == 0 && User.board[check_y, check_next_x] != User.emptyy)
                            {
                                // insert the contents of the next column in place of the first one
                                User.board[check_y, check_x] += User.board[check_y, check_next_x];
                                User.board[check_y, check_next_x] = User.emptyy;
                                check_move = true;
                            }
                        }
                    }
                }
            }



            if (_key1.Key == System.Windows.Input.Key.D || _key1.Key == System.Windows.Input.Key.Right)
            {
                for (check_x = _sizeBoard; check_x >= 0; check_x--)
                {
                    for (check_y = _sizeBoard; check_y >= 0; check_y--)
                    {
                        check_priev_x = check_x - 1;

                        // we check the columns from last to first
                        for (int max = check_priev_x; max >= 0; max--)
                        {
                            falsee = 0;
                            // if the last and first column is the same and if the first one is not zero
                            if (User.board[check_y, check_x] == User.board[check_y, max] && User.board[check_y, max] != User.emptyy)
                            {
                                // we check the elements of the array between the second and last column
                                for (int i = check_priev_x; i < max; i--)
                                {
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle columns are empty
                                if (falsee == User.emptyy)
                                {
                                    // adding the last and first column cell
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    User.board[check_y, max] = User.emptyy;
                                    check_move = true;
                                }
                            }
                            // if the first column is not zero and the last column is empty
                            else if (User.board[check_y, max] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // we check the elements of the table between the second and the last column
                                for (int i = check_priev_x; i < max; i--)
                                {
                                    if (User.board[check_y, i] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle columns are empty
                                if (falsee == User.emptyy)
                                {
                                    // insert the contents of the first column into the last column
                                    User.board[check_y, check_x] += User.board[check_y, max];
                                    User.board[check_y, max] = User.emptyy;
                                    check_move = true;
                                }
                            }
                            // if the last column and the previous one are the same and if the previous one is not zero
                            else if (User.board[check_y, check_x] == User.board[check_y, check_priev_x] && User.board[check_y, check_priev_x] != User.emptyy)
                            {
                                // add the last and previous columns
                                User.board[check_y, check_x] += User.board[check_y, check_priev_x];
                                User.board[check_y, check_priev_x] = User.emptyy;
                                check_move = true;
                            }
                            // if the last column is empty and the previous column is not
                            else if (User.board[check_y, check_x] == 0 && User.board[check_y, check_priev_x] != User.emptyy)
                            {
                                // insert the contents of the previous column in place of the last one
                                User.board[check_y, check_x] += User.board[check_y, check_priev_x];
                                User.board[check_y, check_priev_x] = User.emptyy;
                                check_move = true;
                            }
                        }
                    }
                }
            }



            if (_key1.Key == System.Windows.Input.Key.S || _key1.Key == System.Windows.Input.Key.Down)
            {
                for (check_x = _sizeBoard; check_x >= 0; check_x--)
                {
                    for (check_y = _sizeBoard; check_y >= 0; check_y--)
                    {
                        check_priev_y = check_y - 1;

                        // we check the rows from last to first
                        for (int max = check_priev_y; max >= 0; max--)
                        {
                            falsee = 0;
                            // if the last and first row is the same and if the first is not zero
                            if (User.board[check_y, check_x] == User.board[max, check_x] && User.board[max, check_x] != User.emptyy)
                            {
                                // we check the elements of the array between the last and the second row
                                for (int i = check_priev_y; i < max; i--)
                                {
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle rows are empty
                                if (falsee == User.emptyy)
                                {
                                    // adding the last and first row of cells
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    User.board[max, check_x] = User.emptyy;
                                    check_move = true;
                                }
                            }
                            // if the first row is not zero and the last row is empty
                            else if (User.board[max, check_x] != User.emptyy && User.board[check_y, check_x] == User.emptyy)
                            {
                                // we check the elements of the array between the second and the last row
                                for (int i = check_priev_y; i < max; i--)
                                {
                                    if (User.board[i, check_x] != User.emptyy)
                                    {
                                        falsee = 1;
                                    }
                                }
                                // if the middle rows are empty
                                if (falsee == User.emptyy)
                                {
                                    // insert the contents of the first row to the last row
                                    User.board[check_y, check_x] += User.board[max, check_x];
                                    User.board[max, check_x] = User.emptyy;
                                    check_move = true;
                                }
                            }
                            // if the last row and the previous row are the same and if the previous one is not zero
                            else if (User.board[check_y, check_x] == User.board[check_priev_y, check_x] && User.board[check_priev_y, check_x] != User.emptyy)
                            {
                                // add the last and previous row
                                User.board[check_y, check_x] += User.board[check_priev_y, check_x];
                                User.board[check_priev_y, check_x] = User.emptyy;
                                check_move = true;
                            }
                            // if the last row is empty and the previous one is not
                            else if (User.board[check_y, check_x] == 0 && User.board[check_priev_y, check_x] != User.emptyy)
                            {
                                // insert the content of the previous line in place of the last one
                                User.board[check_y, check_x] += User.board[check_priev_y, check_x];
                                User.board[check_priev_y, check_x] = User.emptyy;
                                check_move = true;
                            }
                        }
                    }
                }
            }





        }


    }
}
