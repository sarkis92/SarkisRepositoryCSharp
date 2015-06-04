using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombArray
{
    class BombArray
    {
        static void Main()
        {

            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] arr = new char[dimensions[0], dimensions[1]];

            bool direction = false;
            int snakeCounter = 0;

            //fill matrix
            for (int i = dimensions[0] - 1; i >= 0; i--)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    if (!direction)
                    {
                        if (snakeCounter < snake.Length)
                        {
                            arr[i, dimensions[1] - 1 - j] = snake[snakeCounter++];
                        }
                        else
                        {
                            snakeCounter = 0;
                            arr[i, dimensions[1] - 1 - j] = snake[snakeCounter++];
                        }

                    }
                    else
                    {
                        if (snakeCounter < snake.Length)
                        {
                            arr[i, j] = snake[snakeCounter++];
                        }
                        else
                        {
                            snakeCounter = 0;
                            arr[i, j] = snake[snakeCounter++];
                        }

                    }

                }
                direction = !direction;
            }


            //bomb cells

            int startRow = bomb[0] - bomb[2];
            int endRow = bomb[0] + bomb[2];
            int startCol = bomb[1];
            int endCol = bomb[1];
            int centerBombRow = bomb[0];
            //if (startRow > endRow)
            {
                //endRow = startRow + 1;
            }

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    if (i >= 0 && i < dimensions[0] && j >= 0 && j < dimensions[1])
                    {
                        arr[i, j] = ' ';
                    }
                }
                if (i < centerBombRow)
                {
                    startCol--;
                    endCol++;
                }
                else
                {
                    startCol++;
                    endCol--;
                }
            }
            //Console.WriteLine();
            //for (int i = 0; i < dimensions[0]; i++)
            //{
            //    for (int j = 0; j < dimensions[1]; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            // drop down characters
            int numEmpty = 0;
            int lastEmptyCellIndex = 0;
            for (int i = 0; i < dimensions[1]; i++)
            {
                numEmpty = 0;
                lastEmptyCellIndex = 0;
                for (int j = 0; j < dimensions[0]; j++)
                {
                    if (arr[j, i] == ' ')
                    {
                        numEmpty++;
                        lastEmptyCellIndex = j;
                    }
                }

                if (numEmpty > 0 && arr[0, i] != ' ')
                {
                    int counter = 0;
                    int iterations = lastEmptyCellIndex + 1 - numEmpty;
                    while (iterations > 0)
                    {
                        arr[lastEmptyCellIndex - counter, i] = arr[lastEmptyCellIndex - counter - numEmpty, i];
                        arr[lastEmptyCellIndex - numEmpty - counter, i] = ' ';
                        counter++;
                        iterations--;
                    }
                }
            }

            //print matrix
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}




