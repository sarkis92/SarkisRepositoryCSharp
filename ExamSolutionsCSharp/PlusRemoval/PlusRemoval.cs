using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlusRemoval
{
    class PlusRemoval
    {
        static void Main()
        {

            char[][] jagged;
            List<string> strings = new List<string>();
            
            string letters = Console.ReadLine();
            while (letters != "END")
            {
                strings.Add(letters);
                letters = Console.ReadLine();
            }

            jagged = new char[strings.Count][];

            int row = strings.Count - 1;
            while (row >= 0)
            {
                jagged[row] = strings[row].ToArray();
                row--;
            }


            var pntsToRemove = new List<Point>();
            for (int i = 1; i <= strings.Count - 2; i++)
            {
                for (int j = 1; j <= jagged[i].Length - 2; j++)
                {
                    if (jagged[i - 1].Length - 1 < j || jagged[i + 1].Length - 1 < j)
                    {
                        break;
                    }

                    if (string.Equals(jagged[i][j].ToString(), jagged[i - 1][j].ToString(), StringComparison.OrdinalIgnoreCase) &&
                       string.Equals(jagged[i - 1][j].ToString(), jagged[i + 1][j].ToString(), StringComparison.OrdinalIgnoreCase) &&
                       string.Equals(jagged[i + 1][j].ToString(), jagged[i][j - 1].ToString(), StringComparison.OrdinalIgnoreCase) &&
                       string.Equals(jagged[i][j - 1].ToString(), jagged[i][j + 1].ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        pntsToRemove.Add(new Point(i, j));
                    }
                }
            }


            int count = pntsToRemove.Count;
            while (count > 0)
            {
                jagged[pntsToRemove[count - 1].X][pntsToRemove[count - 1].Y] =
                    jagged[pntsToRemove[count - 1].X - 1][pntsToRemove[count - 1].Y] =
                    jagged[pntsToRemove[count - 1].X + 1][pntsToRemove[count - 1].Y] =
                    jagged[pntsToRemove[count - 1].X][pntsToRemove[count - 1].Y - 1] =
                    jagged[pntsToRemove[count - 1].X][pntsToRemove[count - 1].Y + 1] = ' ';
                count--;
            }

           
            for (int i = 0; i < strings.Count; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if (jagged[i][j] != ' ')
                    {
                        Console.Write(jagged[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
