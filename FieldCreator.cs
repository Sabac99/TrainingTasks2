using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class FieldCreator
    {
        public string[,] array;
        public int size;
        public FieldCreator(int size)
        {
            array = new string[size,size];
            this.size = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = "o";
                }
            }
        }
        public void PrintField()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    Console.Write(this.array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
