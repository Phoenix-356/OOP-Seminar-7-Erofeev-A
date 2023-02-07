namespace MazeCs;

public class Maze 
{
    // В рамках данной задачи работаем с лабиринтом 11 на 11.
    // Значение можно менять, но лабиринт работает только с нечетными матрицами. 
    public string[,] matrix = new string [11, 11];

    public void CreateMaze(string[,] maze) 
    {
        for (int i = 0; i < maze.GetLength(0); i++) 
        {
            for (int j = 0; j < maze.GetLength(1); j++) 
            {
                maze[i, j] = "#####";
            }
        }
    }   
    public void PrintMaze(string[,] maze) 
    {
        for (int i = 0; i < maze.GetLength(0); i++) 
        {
            for (int j = 0; j < maze.GetLength(1); j++) 
            {
                Console.Write($"{maze[i, j]}" + "\t");
            }
        Console.WriteLine();
        }
    }
}