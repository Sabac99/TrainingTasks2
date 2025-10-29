using TrainingTasks2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите Класс\n" +
                     "На выбор:\n " +
                     "Маг \n " +
                     "Воин \n" +
                     "В случае неудачи выбора вы станете крестянином \n");
        string playerClass = Console.ReadLine();
        Console.WriteLine();
        Battle battle = new Battle();
        Player player = new Player(playerClass);
        Boss boss = new Boss();
        Console.WriteLine($"Игрок: здоровье {player.hp}, Мана игрока {player.mana}, Атака {player.attack}, Класс {player.playerClass}\n" +
            $"Босс: Здоровье {boss.hp}, Атака {boss.attack} \n");

        while (boss.hp > 0 && player.hp > 0)
        {
            battle.Fight(ref boss, ref player);
        }
    }
}




//## 2. Игра “Битва с боссом”
//- Есть **игрок** и **босс**, у каждого — своё **HP**.
//- Игрок выбирает **тип атаки**, затем атакует.
//- После этого **босс наносит ответный удар**.
//- Раунд продолжается, пока один из участников не проиграет.
//- Можно добавить простые способности или разные типы атак.
//- Реализовать **меню выбора** и красиво оформить вывод.
//**Подсказка:**классы `Player`, `Boss`, `Battle`.