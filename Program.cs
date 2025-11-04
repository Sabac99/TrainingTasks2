using System.Numerics;
using TrainingTasks2;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        Player player = new Player();
        bool exit = false;
        while (exit != true)
        {
            player.CommandList();
            player.CheckCommand(Console.ReadLine(), ref exit);
        }
    }

}
