using PointCs;
using MazeCs;
using MoleCs;
Main();

void Main() 
{
    Maze mazeNew = new Maze(); // Класс содержит в себе заранее заданную пустую матрицу 21 на 21.
    mazeNew.CreateMaze(mazeNew.matrix); // Заполняет матрицу "#"
    int count = 100000;
    while (count > 0) 
    {
        Mole digger = new Mole(); // Класс для создания тоннелей в массиве из "#". 
        digger.MoleDigg(digger, mazeNew.matrix);
        count--;
    }
    Point point1 = new Point(3, 3, 1); // "Магические числа" в конструкторе для обозначения точки входа в лабиринт.
    point1.WaveAlgoritm(mazeNew.matrix, point1); // Запускает волновой алгоритм в массив
    mazeNew.PrintMaze(mazeNew.matrix); // Выводим в консоль результат
}