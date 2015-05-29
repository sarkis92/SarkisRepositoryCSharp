using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatrixRotation
{
    class MatrixRotation
    {
        static void Main()
        {

            string command = Console.ReadLine();
            string pattern = @"[0-9]+";

            Regex reg = new Regex(pattern);
            Match match = reg.Match(command);

            List<string> text = new List<string>();

            int longestLine = -1;
            string lines = Console.ReadLine();
            while (lines != "END")
            {
                if (longestLine < lines.Length)
                {
                    longestLine = lines.Length;
                }
                text.Add(lines);
                lines = Console.ReadLine();
            }

            char[,] arr = new char[text.Count, longestLine];

            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < longestLine; j++)
                {
                    if (j > text[i].Length - 1)
                        arr[i, j] = ' ';
                    else
                        arr[i, j] = text[i][j];
                }
            }

            int degrees = int.Parse(match.Value);

            while (degrees > 360)
                degrees -= 360;

            switch (degrees)
            {


                case 90:

                    for (int i = 0; i < longestLine; i++)
                    {
                        for (int j = 0; j < text.Count; j++)
                        {
                            Console.Write(arr[text.Count - 1 - j, i]);
                        }
                        Console.WriteLine();
                    }
                    break;


                case 180:

                    for (int i = 0; i < text.Count; i++)
                    {
                        for (int j = 0; j < longestLine; j++)
                        {
                            Console.Write(arr[text.Count - 1 - i, longestLine - 1 - j]);
                        }
                        Console.WriteLine();
                    }
                    break;


                case 270:

                    for (int i = 0; i < longestLine; i++)
                    {
                        for (int j = 0; j < text.Count; j++)
                        {
                            Console.Write(arr[j, longestLine - 1 - i]);
                        }
                        Console.WriteLine();
                    }
                    break;


                default:
                    for (int i = 0; i < text.Count; i++)
                    {
                        for (int j = 0; j < longestLine; j++)
                        {
                            Console.Write(arr[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
