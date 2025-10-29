using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Battle
    {
        Random random = new Random();
        public void Fight(ref Boss boss, ref Player player)
        {
            bool attackSelectCorrect = false;

            while (attackSelectCorrect != true)
            {
                int attackType = random.Next(1, 3);
                Console.WriteLine("Введите тип атаки\n" +
                    "На выбор: \n" +
                    "Обычная атака \n" +
                    "Магическая атака \n");
                string attackSelect = Console.ReadLine().ToLower();
                Console.WriteLine();
                switch (attackSelect)
                {
                    case "обычная атака":
                        {
                            attackSelectCorrect = true;
                            boss.hp -= player.Attack(boss);
                            player.hp -= boss.SelectAttack(attackType, ref player);
                            break;
                        }
                    case "магическая атака":
                        {
                            attackSelectCorrect = true;
                            boss.hp -= player.MagicAttack(boss);
                            player.hp -= boss.SelectAttack(attackType, ref player);
                            break;
                        }
                    default:
                        {
                            attackSelectCorrect = false;
                            Console.WriteLine("Попробуйте еще раз \n");
                            break;
                        }
                }
            }
            if (player.hp > 0 && boss.hp > 0)
            {
                Console.WriteLine($"Здоровье Игрока {player.hp}, Мана Игрока {player.mana}, Здоровье босса {boss.hp}\n");

            }
            else if (player.hp <= 0)
            {
                Console.WriteLine("Босс победил");
                Console.WriteLine($"Оставшееся здоровье босса {boss.hp}");
            }
            else
            {
                Console.WriteLine("Игрок победил");
                Console.WriteLine($"Оставшееся здоровье игрока {player.hp}");
            }
        }
    }

    
}
