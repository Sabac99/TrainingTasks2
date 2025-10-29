using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Checker
    {
        public List<(int, int)> usedCells;
        public int checkAnswer(string answer)
        {
            bool inputCorrect = false;
            int size = 0;
            while (inputCorrect != true)
            {
                if (int.TryParse(answer, out size) && size >= 2)
                {
                    inputCorrect = true;
                    return size;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return size;
        }

        public void CellsEquals(int size, ref List<(int,int)> usedCells, out bool equals, out (int,int) answer)
        {
            CreateCell creator = new CreateCell();
            var compCells = creator.getCellFromComp(size, usedCells);
            var playerCells = creator.createCellsFromPlayer(size, usedCells);
            if (compCells == playerCells)
            {
                equals = true;
                answer = (compCells.Item1 - 1, compCells.Item2 - 1);
                usedCells.Add(compCells);
            }
            else
            {
                Console.WriteLine("Ячейки не совпадают");
                equals = false;
                answer = (0, 0);
                
            }
        }
    }
}
