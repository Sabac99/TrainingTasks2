using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingTasks2
{

    internal class Player
    {
        
        private const string commandOpenStorage = "открыть склад";
        private const string commandSpendResources = "потратить ресурсы";
        private const string commandAddResources = "добавить ресурсы";
        private const string commandExit = "выйти";
        private const string errorInputMessage = "Ошибка ввода";
        Storage storage;
        public Player()
        {
            Resource stone = new Resource(100, "Камень");
            Resource wood = new Resource(100, "Дерево");
            Resource iron = new Resource(100, "Железо");
            storage = new Storage(wood, stone, iron);
        }
        private int GetResourcesCount()
        {
            bool isInputCorrect = false;
            while (!isInputCorrect)
            {
                Console.WriteLine("Введите количество ресурсов");
                if (int.TryParse(Console.ReadLine(), out int weight))
                {
                    isInputCorrect = true;
                    return weight;
                }
                else
                {
                    Console.WriteLine(errorInputMessage);
                }
            }
            return 0;
        }
        private string GetResourceType()
        {
            bool isInputCorrect = false;
            while (!isInputCorrect)
            {
                Console.WriteLine("Введите название ресурса");
                string itemNameInput = Console.ReadLine();
                if (itemNameInput != null)
                {
                    isInputCorrect = true;
                    return itemNameInput;
                }
                else
                {
                    Console.WriteLine(errorInputMessage);
                }
            }
            return "0";

        }
        public void CommandList()
        {
            Console.WriteLine("Список доступных команд");
            Console.WriteLine($"{commandOpenStorage}, {commandAddResources}, {commandSpendResources}, {commandExit}");
        }
        public void CheckCommand(string command, ref bool exit)
        {

            switch (command.ToLower())
            {
                case commandOpenStorage:
                    storage.ShowStorage();
                    break;
                case commandAddResources:
                    storage.AddResource(GetResourceType(), GetResourcesCount());
                    break;
                case commandSpendResources:
                    storage.SpendResource(GetResourceType(), GetResourcesCount());
                    break;
                case commandExit:
                    exit = true;
                    break;
                default:
                    Console.WriteLine(errorInputMessage);
                    break;
            }
        }
    }
}
