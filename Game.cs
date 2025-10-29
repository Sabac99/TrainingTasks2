using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrainingTasks2
{
    internal class Game
    {
        public void PlayGame(CoinsGenerator coinsGenerator, Player player)
        {
            bool exit = false;
            while (exit != true)
            {
                Coin coin = coinsGenerator.GenerateCoin();
                Console.WriteLine($"Была создана монетка номиналом {coin.nominal}");
                Console.WriteLine("Добавить, выкинуть или выйти? Введите ответ");
                bool inputCorrect = false;
                
                while (inputCorrect != true)
                {
                    if (inputCorrect == false)
                    {
                        string input = Console.ReadLine();
                        switch (input.ToLower())
                        {
                            case "добавить":
                                {
                                    Console.WriteLine($"Монетка номиналом {coin.nominal} была добавлена");
                                    player.coinsInWallet += coin.nominal;
                                    Console.WriteLine($"Текущий баланс {player.coinsInWallet}");
                                    inputCorrect = true;
                                    break;
                                }
                            case "выкинуть":
                                {
                                    Console.WriteLine($"Монетка номиналом {coin.nominal} была выкинута");
                                    Console.WriteLine($"Текущий баланс {player.coinsInWallet}");
                                    inputCorrect = true;
                                    break;
                                }
                            case "выйти":
                                {
                                    Console.WriteLine($"Ваш баланс на момент выхода {player.coinsInWallet}");
                                    Console.WriteLine("Спасибо за игру");
                                    inputCorrect = true;
                                    exit = true;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Ошибка ввода");
                                    inputCorrect = false;
                                    break;
                                }
                        }
                    }
                }
            }
        }
    }
}
