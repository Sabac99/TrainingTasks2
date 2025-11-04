using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Inventory
    {
        private static int inventoryCapacity = 10;
        Dictionary<string, int> inventory = new Dictionary<string, int>(inventoryCapacity);

        public Inventory()
        {

        }
        public void ShowInvetory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
            }
            foreach (var item in inventory)
            {
                Console.WriteLine($"Предмет: {item.Key}, Вес: {item.Value}");
            }
        } //дописать пустой инвентарь
        public void AddItemToInventory(string name, int weight)
        {
            if (inventory.Count() <= inventoryCapacity-1)
            {
                if(!inventory.TryAdd(name, weight))
                {
                    Console.WriteLine("Предмет уже существует в инвентаре");
                }
                else
                {
                    Console.WriteLine($"Предмет {name} успешно добавлен");
                }
            }
            else
            {
                Console.WriteLine("Превышено количество вещей");
            }
                
        }
        public void RemoveItemFromInventory(string name)
        {
            if (inventory.ContainsKey(name))
            {
                inventory.Remove(name);
                Console.WriteLine($"{name} удален");
            }
            else
            {
                Console.WriteLine("Предмет в инвентаре не найден");
            }
        }
    }
}
