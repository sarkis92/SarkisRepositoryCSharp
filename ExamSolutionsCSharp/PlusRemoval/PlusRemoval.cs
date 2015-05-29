using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Globalization.CultureInfo;
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
                //sumChars += letters.Length;
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
                        //jagged[i][j] = jagged[i - 1][j] = jagged[i + 1][j] = jagged[i][j - 1] = jagged[i][j + 1] = ' ';
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

            //char[][] outputArr = new char[strings.Count][];
            //int elemPosition;
            for (int i = 0; i < strings.Count; i++)
            {
                //elemPosition = 0;
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if (jagged[i][j] != ' ')
                    {
                        Console.Write(jagged[i][j]);
                        //outputArr[i][elemPosition] = jagged[i][j];
                        //elemPosition++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
