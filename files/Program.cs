using System;

enum DaysOfWeek
{
    Понедельник = 1,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Воскресенье
}

class Program
{
    static void Ex1()
    {
        Console.WriteLine("Введите 10 чисел через пробел:");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (!int.TryParse(input[i], out numbers[i]))
            {
                Console.WriteLine("Ошибка ввода");
                break;
            }
        }
        bool flag = true;
        int breaking = -1;
        for (int i = 0; i < numbers.Length-1; i++)
        {
            if (numbers[i] >= numbers[i + 1])
            {
                flag = false;
                breaking = i;
                break;
            }
        }
        if (flag)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию");
        }
        else
        {
            Console.WriteLine($"Последовательность нарушена на {breaking+2}-м элементе");
        }
    }

    static void Ex2()
    {
        try
        {
            Console.Write("Введите номер карты (от 6 до 14): ");
            int k = int.Parse(Console.ReadLine());
            
            if (k < 6 || k > 14)
            {
                throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
            }
            
            string card;
            switch (k)
            {
                case 11:
                    card = "Валет";
                    break;
                case 12:
                    card = "Дама";
                    break;
                case 13:
                    card = "Король";
                    break;
                case 14:
                    card = "Туз";
                    break;
                default:
                    card = k.ToString();
                    break;
            }
            
            Console.WriteLine($"Достоинство карты: {card}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Программа завершена.");
        }
    }

    static void Ex3()
    {
        Console.WriteLine("Введите строку:");
        string input1 = Console.ReadLine();
        string lowerInput = input1.ToLower();
        string output = lowerInput switch
        {
            "jabroni" => "Patron Tequila",
            "school counselor" => "Anything with Alcohol",
            "programmer" => "Hipster Craft Beer",
            "bike gang member" => "Moonshine",
            "politician" => "Your tax dollars",
            "rapper" => "Cristal",
            _ => "Beer" // Любое другое значение
        };
        Console.WriteLine($"Выходные данные: {output}");
    }

    static void Ex4()
    {
        Console.WriteLine("Введите число от 1 до 7");
        try
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 7)
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            DaysOfWeek day = (DaysOfWeek)num;
            Console.WriteLine($"День недели: {day}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Введите корректное число");
        }
    }

    static void Ex5()
    {
        string[] items = { "Hello Kitty", "Barbie doll", "Pen", "Ball", "Book", "Phone" };
        int count = 0;
        foreach (string item in items)
        {
            if (item == "Hello Kitty" || item == "Barbie doll")
            {
                count++;
            }
        }

        Console.WriteLine($"Количество кукол в сумке: {count}");
    }
    
    static void Main()
    {
        // Дана последовательность из 10 чисел. Определить, является ли эта последовательность
        // упорядоченной по возрастанию. В случае отрицательного ответа определить
        // порядковый номер первого числа, которое нарушает данную последовательность.
        // Использовать break.
        Console.WriteLine("Упражнение 1");
        Ex1();

        // Игральным картам условно присвоены следующие порядковые номера в зависимости от
        // их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
        // Порядковые номера остальных карт соответствуют их названиям («шестерка»,
        // «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
        // соответствующей карты. Использовать try-catch-finally.
        Console.WriteLine("\nУпражнение 2");
        Ex2();
        
        //Напишите программу, которая принимает на входе строку и производит выходные
        // данные в соответствии со следующей таблицей:
        Console.WriteLine("\nУпражнение 3");
        Ex3();
        
        // Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
        // ...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
        // Использовать enum.
        Console.WriteLine("\nУпражнение 4\n");
        Ex4();
        
        //Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
        // "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
        // результату. Вывести на экран сколько кукол в “сумке”.
        Console.WriteLine("\nУпражнение 5");
        Ex5();
    }
}