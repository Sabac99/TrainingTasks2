using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class CreateCell
    {
        Random random = new Random();
        public int cellX;
        public int cellY;
        public (int, int) getCellFromComp(int size, List<(int,int)> usedCells)
        {
            do
            {
                cellX = random.Next(1, size + 1);
                cellY = random.Next(1, size + 1);
            }
            while (usedCells.Contains((cellX, cellY)));

            return (cellX, cellY);
        }
        public (int, int) createCellsFromPlayer(int size, List<(int, int)> usedCells)
        {
            bool inputCorrect = false;
            while (inputCorrect != true)
            {
                Console.WriteLine("Введите строку начиная с 1");
                if (int.TryParse(Console.ReadLine(), out int playerCellX) && playerCellX >= 1 && playerCellX <= size)
                {
                    Console.WriteLine("Введите столбец начиная с 1");
                    if (int.TryParse(Console.ReadLine(), out int playerCellY) && playerCellY >= 1 && playerCellY <= size)
                    {
                        if (!usedCells.Contains((playerCellX, playerCellY)))
                        {
                            inputCorrect = true;
                            return (playerCellX, playerCellY);
                        }
                        else
                        {
                            Console.WriteLine("Ячейка уже была введена");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return (0, 0);

        }
    }
}
