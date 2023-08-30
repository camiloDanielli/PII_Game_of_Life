using System;

namespace PII_Game_Of_Life
{
    public class Logica
    {
        public bool[,] ApplyRules(bool[,] gameBoard)
        {
            int boardWidth = gameBoard.GetLength(0);
            int boardHeight = gameBoard.GetLength(1);

            bool[,] newBoard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if (gameBoard[x, y])
                    {
                        aliveNeighbors--;
                    }
                    if (gameBoard[x, y] && aliveNeighbors < 2)
                    {
                        // Celula muere por baja población
                        newBoard[x, y] = false;
                    }
                    else if (gameBoard[x, y] && aliveNeighbors > 3)
                    {
                        // Celula muere por sobrepoblación
                        newBoard[x, y] = false;
                    }
                    else if (!gameBoard[x, y] && aliveNeighbors == 3)
                    {
                        // Celula nace por reproducción
                        newBoard[x, y] = true;
                    }
                    else
                    {
                        // Celula mantiene el estado que tenía
                        newBoard[x, y] = gameBoard[x, y];
                    }
                }
            }
            return newBoard;
        }
    }
}