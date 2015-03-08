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

            long resultSum = 0;//The end result

            //Set's the starting row and col 
            int startRow = row - 1;
            int startCol = 0;

            int amountOfMoves = int.Parse(Console.ReadLine());
            string[] playCommands = new string[amountOfMoves];//String array that contains all the commands(RU 10, LD 5....)

            for (int i = 0; i < amountOfMoves; i++)
            {
                playCommands[i] = Console.ReadLine();
            }//commands taken

            //Fills the matrix with the correct numbers
            int[,] playField = new int[row, col];
            int number = (row - 1) * 3;//Top left number in the matrix
            for (int rowW = 0; rowW < sizeOfMatrix[0]; rowW++)
            {
                int finalNum = number;
                for (int colL = 0; colL < sizeOfMatrix[1]; colL++)
                {

                    playField[rowW, colL] = finalNum;
                    finalNum += 3;//Adding 3 for each next col
                }
                number -= 3;
            }//filling complete

            int tempRow = startRow;
            int tempCol = startCol;
            for (int i = 0; i < amountOfMoves; i++)//Game on
            {
                string resultString = Regex.Match(playCommands[i], @"\d+").Value;//A regex that takes the number (amount of moves)
                int amountOfSteps = int.Parse(resultString);
                string move = playCommands[i].Substring(0, 2);//Extracts the first two letters (direction)
                //Gives the abillity to work with only 4 string commands
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
                switch (move)//A simple switch case that makes the correct movements
                {
                    case "RU": //Moving right up
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            //Initally the move is made
                            tempRow--;
                            tempCol++;
                            if (tempRow >= row || tempRow < 0 || tempCol >= col || tempCol < 0)//Then the move is checked (if it exits the matrix its invalid)
                            {
                                tempRow++;//Before breaking the switch-case the row and col are set back to the previous location
                                tempCol--;
                                break;
                            }
                            resultSum += playField[tempRow, tempCol];//Adds the number to the final result
                            playField[tempRow, tempCol] = 0;// sets the number at [row,col] to 0
                        }
                        break;
                    case "LU": //Moving left up
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
                        break;
                    case "RD": //Moving right down                                    
                        for (int j = 0; j < amountOfSteps - 1; j++)
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
                        break;
                    case "LD": //Moving left down 
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
                        break;
                }
            }
            Console.WriteLine(resultSum); // After the for loop runs thru all the moves the result is printed
        }
    }
}
