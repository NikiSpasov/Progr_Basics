﻿using System;

class SquareN_NumbersInSpiralMatrix
{
    static void Main()
    {
        string numberStr = Console.ReadLine();
        uint numN = uint.Parse(numberStr);
        if (numN < 1 || numN > 20)
        {
            Console.WriteLine("Error - The Number is Out of Range !!!");
        }
        else
        {
            int[,] spiralMatrix = new int[numN, numN];
            int row = 0;
            int col = 0;
            string direction = "right";
            uint maxValue = numN * numN;

            for (int i = 1; i <= maxValue; i++)
            {
                if (direction == "right" && (col > (numN - 1) || spiralMatrix[row, col] != 0))
                {
                    direction = "down";
                    row++;
                    col--;
                }
                if (direction == "down" && (row > (numN - 1) || spiralMatrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || spiralMatrix[row, col] != 0))
                {
                    direction = "up";
                    row--;
                    col++;
                }
                if (direction == "up" && (row < 0 || spiralMatrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                spiralMatrix[row, col] = i;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            for (int r = 0; r < numN; r++)
            {
                for (int c = 0; c < numN; c++)
                {
                    Console.Write("{0,2}", spiralMatrix[r, c]);
                }
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}