using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Player
    {
        private Inventory inventory = new Inventory();
        private const string commandOpenInventory = "открыть инвентарь";
        private const string commandRemoveItemFromInventory = "удалить предмет";
        private const string commandAddItemToInventory = "добавить предмет";
        private const string commandExit = "выйти";
        public Player()
        {
        
        }
        private int GetItemWeight()
        {
            bool isInputCorrect = false;
            while (!isInputCorrect)
            {
                Console.WriteLine("Введите вес предмета");
                if (int.TryParse(Console.ReadLine(), out int weight))
                {
                    isInputCorrect = true;
                    return weight;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return 0;
        }
        private string GetItemName()
        {
            bool isInputCorrect = false;
            while (!isInputCorrect)
            {
                Console.WriteLine("Введите название предмета");
                string itemNameInput = Console.ReadLine();
                if (itemNameInput != null)
                {
                    isInputCorrect = true;
                    return itemNameInput;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return "0";
            
        }
        public void CommandList()
        {
            Console.WriteLine("Список доступных команд");
            Console.WriteLine($"{commandOpenInventory}, {commandRemoveItemFromInventory}, {commandAddItemToInventory}, {commandExit}");
        }
        public void CheckCommand(string command, ref bool exit)
        {

            switch(command.ToLower())
            {
                case commandOpenInventory:
                    inventory.ShowInvetory();
                    break;
                case commandAddItemToInventory:
                    inventory.AddItemToInventory(GetItemName(),  GetItemWeight());
                    break;
                case commandRemoveItemFromInventory:
                    inventory.RemoveItemFromInventory(GetItemName());
                    break;
                case commandExit:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Комманда не найдена");
                    break;
            }
        }
    }
}
