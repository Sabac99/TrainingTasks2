using TrainingTasks2;
class Program
{
    static void Main(string[] args)
    {
        
        Checker checker = new Checker();
        CreateCell cellCreator = new CreateCell();
        Console.WriteLine("Введите размер поля, минимальный размер : 2");
        int size = checker.checkAnswer(Console.ReadLine());
        FieldCreator field = new FieldCreator(size);
        int attemptsLeft = size * 2;
        int score = 0;
        var compCells = cellCreator.getCellFromComp(size, checker.usedCells);
        while (attemptsLeft > 0 || score < size)
        {
            checker.CellsEquals(size, compCells, ref checker.usedCells, out bool equals, out (int, int) answer);
            if (equals == true)
            {
                
                field.array[answer.Item1, answer.Item2] = "x";
                score++;
                Console.WriteLine($"Ваш счет {score}, осталось попыток {attemptsLeft}");
                compCells = cellCreator.getCellFromComp(size, checker.usedCells);
                field.PrintField();
            }
            else
            {

                Console.WriteLine("Неверно");
                attemptsLeft--;
                Console.WriteLine($"Ваш счет {score}, осталось попыток {attemptsLeft}");
            }
        }
        if(score == size)
        {
            Console.WriteLine("Вы победили");
        }
        else
        {
            Console.WriteLine("Вы проиграли");
        }
        
    }
    
}




//Модернизировать задачу из прошлой версии (игра 3×3):
//-Теперь игрок** сам выбирает размер поля** (например, 2×2, 3×3 и т.д.).
//- Минимальный размер — **2×2**.
//- Программа случайно загадывает клетки, а пользователь пытается их угадать.
//- Разделить код на **классы** и **методы**, использовать **коллекции**.
//- Обеспечить удобную и понятную структуру кода.
//**Подсказка:**выделите отдельные классы для поля, логики игры и ввода пользователя.