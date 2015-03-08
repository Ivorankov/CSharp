using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int row = sizeOfMatrix[0];
            int col = sizeOfMatrix[1];

            long resultSum = 0;

            int startRow = row - 1;
            int startCol = 0;

            int amountOfMoves = int.Parse(Console.ReadLine());
            string[] playCommands = new string[amountOfMoves];

            for (int i = 0; i < amountOfMoves; i++)
            {
                playCommands[i] = Console.ReadLine();
            }//commands taken

            int[,] playField = new int[row, col];
            int number = (row -1) *3;
            for (int rowW = 0; rowW < sizeOfMatrix[0]; rowW++)
            {
                int finalNum = number;
                for (int colL = 0; colL < sizeOfMatrix[1]; colL++)
                {

                    playField[rowW, colL] = finalNum;
                    finalNum += 3;
                }
                number -= 3;
            }//filling complete

            int tempRow = startRow;
            int tempCol = startCol;
            for (int i = 0; i < amountOfMoves; i++)//Game on
            {
                string resultString = Regex.Match(playCommands[i], @"\d+").Value;

                string move = playCommands[i].Substring(0, 2);
                int amountOfSteps = int.Parse(resultString);
                if (move == "UR")
                {
                    move = "RU";
                }
                else if (move == "UL")
                {
                    move = "LU";
                }
                else if (move == "DR")
                {
                    move = "RD";
                }
                 else if (move == "DL")
                {
                    move = "LD";
                }
                switch (move)
                {
                    case "RU":
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            tempRow--;
                            tempCol++;
                            if (tempRow >= row || tempRow < 0 || tempCol >= col || tempCol < 0)
                            {
                                tempRow++;
                                tempCol--;
                                break;
                            }
                            resultSum += playField[tempRow, tempCol];
                            playField[tempRow, tempCol] = 0;

                        }
                        if (tempRow >= row)
                        {
                            tempRow--;

                        }
                        if (tempCol >= col)
                        {
                            tempCol--;

                        }
                        if (tempCol < 0)
                        {
                            tempCol++;

                        }
                        if (tempRow < 0)
                        {
                            tempRow++;
                        }
                        break;
                    case "LU":
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            tempRow--;
                            tempCol--;
                            if (tempRow >= row || tempRow < 0 || tempCol >= col || tempCol < 0)
                            {
                                tempRow++;
                                tempCol++;
                                break;
                            }
                            resultSum += playField[tempRow, tempCol];
                            playField[tempRow, tempCol] = 0;
 
                        }
                        if (tempRow >= row)
                        {
                            tempRow--;

                        }
                        if (tempCol >= col)
                        {
                            tempCol--;

                        }
                        if (tempCol < 0)
                        {
                            tempCol++;

                        }
                        if (tempRow < 0)
                        {
                            tempRow++;
                        }
                        break;
                    case "RD":                                       // RIGHT DOWN row ++ col --
                        for (int j = 0; j < amountOfSteps-1; j++)
                        {
                            tempRow++;
                            tempCol++;
                            if (tempRow >= row || tempRow < 0 || tempCol >= col || tempCol < 0)
                            {
                                tempRow--;
                                tempCol--;
                                break;
                            }
                            resultSum += playField[tempRow, tempCol];
                            playField[tempRow, tempCol] = 0;

                        }
                        if (tempRow >= row)
                        {
                            tempRow--;

                        }
                        if (tempCol >= col)
                        {
                            tempCol--;

                        }
                        if (tempCol < 0)
                        {
                            tempCol++;

                        }
                        if (tempRow < 0)
                        {
                            tempRow++;
                        }
                        break;
                    case "LD":
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            tempRow++;
                            tempCol--;
                            if (tempRow >= row || tempRow < 0 || tempCol >= col || tempCol < 0)
                            {
                                tempRow--;
                                tempCol++;
                                break;
                            }
                            resultSum += playField[tempRow, tempCol];
                            playField[tempRow, tempCol] = 0;

                        }
                        if (tempRow >= row)
                        {
                            tempRow--;

                        }
                        if (tempCol >= col)
                        {
                            tempCol--;

                        }
                        if (tempCol < 0)
                        {
                            tempCol++;

                        }
                        if (tempRow < 0)
                        {
                            tempRow++;
                        }
                        break;
                }
            }
            Console.WriteLine(resultSum);
        }
    }
}
