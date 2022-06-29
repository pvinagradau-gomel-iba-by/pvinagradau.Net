void startGame ()
{
    Console.Write(
    "Select language please: 1 - for English, 0 - for Russian\n"
);
    bool lang = true;
    string? isLang = Console.ReadLine();
    if (isLang == null)
    {
        lang = true;
    }
    if (isLang == "1")
    {
        lang = true;
    }
    if (isLang == "0")
    {
        lang = false;
    }
    if (lang == true)
    {
        bool validate = false;
        string secretWord;
        //Set secretWord
        do
        {
            Console.Write(
                "Enter secret word for players:"
            );
            secretWord = Console.ReadLine();
            if (secretWord.Length >= 8 && secretWord.Length <= 30)
            {
                validate = true;
                Console.WriteLine(
                    "Wow!\n" +
                    "The secret word was added!\n" +
                    "We can start!"
                );
            }
            else
            {
                Console.WriteLine(
                    "Hey!\n" +
                    "The length secret word should be more then 8 and less then 30 symbols!\n" +
                    "Try again!"
                );
            }
        }
        while (validate == false);
        //Add players
        Console.WriteLine(
            "-------------------------------------------------------------------------------------------------\n" +
            "Hi!\n" +
            "Welcome to the Words Game!\n" +
            "This game for 2 players.\n" +
            "You need to find out the secret word by knowing its length and the characters it consists of.\n" +
            "Good luck!\n" +
            "-------------------------------------------------------------------------------------------------"
        );
        Console.Write(
            "The first player, enter your name:"
        );
        string? name1 = Console.ReadLine();
        Console.WriteLine(
            $"Hi {name1}!"
        );
        Console.Write(
            "The second player, enter your name:"
        );
        string? name2 = Console.ReadLine();
        Console.WriteLine(
            $"Hi {name2}!"
        );
        //Start game
        Console.WriteLine(
            "-------------------------------------------------------------------------------------------------\n" +
            "\t\t\t\t\tGame Started!\n" +
            "-------------------------------------------------------------------------------------------------\n" +
            "The secret word consist off next symbols: "
        );
        char[] b = secretWord.ToCharArray();
        Array.Reverse(b, 1, secretWord.Length - 1);
        foreach (char x in b)
            Console.Write($"\t{x}");
        Console.WriteLine($"\nThe length of secret word should be {secretWord.Length} symbols!");
        //Set variables
        string variant1, variant2;
        bool res = false;
        string winner = "";
        //Check words
        do
        {
            Console.Write(
                $"{name1} enter your variant:"
            );
            variant1 = Console.ReadLine();
            if (variant1.Length != secretWord.Length)
            {
                Console.WriteLine($"{name1}, your variant is incorrect! Your variant must be {secretWord.Length} symbols!\n" +
                    $"You skip a step. Step goes to {name2}!"
                );
            }
            if (variant1 == secretWord && res != true)
            {
                res = true;
                winner = name1;
            }
            Console.Write(
                $"{name2} enter your variant:"
            );
            variant2 = Console.ReadLine();
            if (variant2.Length != secretWord.Length)
            {
                Console.WriteLine($"{name2}, your variant is incorrect! Your variant must be {secretWord.Length} symbols!\n" +
                    $"You skip a step. Step goes to {name1}!"
                );
            }
            if (variant2 == secretWord && res != true)
            {
                res = true;
                winner = name2;
            }
            if (res == true)
            {
                Console.WriteLine(
                    $"Congratulate {winner}! You are win!\n" +
                    "-------------------------------------------------------------------------------------------------\n" +
                    "\t\t\t\t\tGame Over!\n" +
                    "-------------------------------------------------------------------------------------------------\n"
                );
            }
            else
            {
                Console.WriteLine(
                    $"We don't have right answer. Try again!"
                );
            }
        }
        while (res == false);
    }
    // For russian
    if (lang == false)
    {
        bool validate = false;
        string secretWord;
        //Set secretWord
        do
        {
            Console.Write(
                "Введите секретное слово для участников:"
            );
            secretWord = Console.ReadLine();
            if (secretWord.Length >= 8 && secretWord.Length <= 30)
            {
                validate = true;
                Console.WriteLine(
                    "Ого!\n" +
                    "Секретное слово было задано!\n" +
                    "Мы можем начинать!"
                );
            }
            else
            {
                Console.WriteLine(
                    "Эй!\n" +
                    "Длина секретного слова должна быть больше 8 и меньше 30 символов!\n" +
                    "Попробуй ещё раз!"
                );
            }
        }
        while (validate == false);
        Console.WriteLine(
            "-------------------------------------------------------------------------------------------------\n" +
            "Привет!\n" +
            "Добро пожаловать в игру Игра в Слова!\n" +
            "Эта игра рассчитана для двоих игроков.\n" +
            "Вам нужно узнать секретное слово, зная его длинну и символы из которых оно состоит.\n" +
            "Удачи!\n" +
            "-------------------------------------------------------------------------------------------------"
        );
        //Add players
        Console.Write(
            "Первый игрок, введи своё имя:"
        );
        string? name1 = Console.ReadLine();
        Console.WriteLine(
            $"Привет {name1}!"
        );
        Console.Write(
            "Второй игрок, введи своё имя:"
        );
        string? name2 = Console.ReadLine();
        Console.WriteLine(
            $"Привет {name2}!"
        );
        //Start game
        Console.WriteLine(
            "-------------------------------------------------------------------------------------------------\n" +
            "\t\t\t\t\tИгра началась!\n" +
            "-------------------------------------------------------------------------------------------------\n" +
            "Секретное слово состоит из следующих символов: "
        );
        char[] b = secretWord.ToCharArray();
        Array.Reverse(b, 1, secretWord.Length - 1);
        foreach (char x in b)
            Console.Write($"\t{x}");
        Console.WriteLine($"\nДлина секретного слова должна быть {secretWord.Length} символов!");
        //Set variables
        string variant1, variant2;
        bool res = false;
        string winner = "";
        //Check words
        do
        {
            Console.Write(
                $"{name1} введи свой вариант:"
            );
            variant1 = Console.ReadLine();
            if (variant1.Length != secretWord.Length)
            {
                Console.WriteLine($"{name1}, твой вариант некорректный! Твой вариант должен быть {secretWord.Length} символов!\n" +
                    $"Ты пропускаешь свой ход. Ход переходит к {name2}!"
                );
            }
            if (variant1 == secretWord && res != true)
            {
                res = true;
                winner = name1;
            }
            Console.Write(
                $"{name2} введи свой вориант:"
            );
            variant2 = Console.ReadLine();
            if (variant2.Length != secretWord.Length)
            {
                Console.WriteLine($"{name2}, твой вариант некорректный! Твой вариант должен быть {secretWord.Length} символов!\n" +
                    $"Ты пропускаешь свой ход. Ход переходит к {name1}!"
                );
            }
            if (variant2 == secretWord && res != true)
            {
                res = true;
                winner = name2;
            }
            if (res == true)
            {
                Console.WriteLine(
                    $"Поздравляю {winner}! Ты победил!\n" +
                    "-------------------------------------------------------------------------------------------------\n" +
                    "\t\t\t\t\tКонец игры!\n" +
                    "-------------------------------------------------------------------------------------------------\n"
                );
            }
            else
            {
                Console.WriteLine(
                    $"Правильных ответов нет. Продолжаем!"
                );
            }
        }
        while (res == false);
    };
}
startGame();

