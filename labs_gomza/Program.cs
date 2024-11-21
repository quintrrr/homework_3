using System;
 
 class Program
 {
     static void Task1()
     {
         Console.WriteLine("Введите номер дня в году");
         if (int.TryParse(Console.ReadLine(), out int inputDay))
         {
             int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
             string[] nameOfMonth =
             {
                 "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября",
                 "Ноября", "Декабря"
             };
             int month = 0;
             while (inputDay > daysInMonth[month])
             {
                 inputDay -= daysInMonth[month];
                 month++;
             }

             Console.WriteLine($"Название месяца {nameOfMonth[month]}, День {inputDay}");
         }
         else
         {
             Console.WriteLine("Ошибка ввода");
         }
     }

     static void Task2()
     {
         Console.WriteLine("Введите номер дня в году");
         if (int.TryParse(Console.ReadLine(), out int inputDay) && inputDay >= 1 && inputDay <= 365)
         {
             int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
             string[] nameOfMonth =
             {
                 "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября",
                 "Ноября", "Декабря"
             };
             int month = 0;
             while (inputDay > daysInMonth[month])
             {
                 inputDay -= daysInMonth[month];
                 month++;
             }

             Console.WriteLine($"Название месяца {nameOfMonth[month]}, День {inputDay}");
         }
         else
         {
             Console.WriteLine("Ошибка ввода");
         }

     }

     static void Task3()
     {
         Console.WriteLine("Введите год:");
         if (int.TryParse(Console.ReadLine(), out int year))
         {
             bool leapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
             Console.WriteLine("Введите номер дня в году");

             if (int.TryParse(Console.ReadLine(), out int inputDay) && inputDay >= 1 &&
                 inputDay <= (leapYear ? 366 : 365))
             {
                 int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                 if (leapYear)
                 {
                     daysInMonth[1] = 29;
                 }

                 string[] nameOfMonth =
                 {
                     "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня",
                     "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря"
                 };

                 int month = 0;
                 while (inputDay > daysInMonth[month])
                 {
                     inputDay -= daysInMonth[month];
                     month++;
                 }

                 Console.WriteLine($"Дата: {inputDay} {nameOfMonth[month]} {year} года.");
             }
             else
             {
                 Console.WriteLine("Ошибка ввода");
             }
         }
         else
         {
             Console.WriteLine("Ошибка ввода");
         }
     }
     
     static void Main()
     {
         // Написать программу, которая читает с экрана число от 1 до 365 (номер дня
         // в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
         // февраля (високосный год не учитывать).
         Console.WriteLine("Упражнение 4.1\n"); 
         Task1();
         // Добавить к задаче из предыдущего упражнения проверку числа введенного
         // пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
         // исключение, и выдавать на экран сообщение.
         Console.WriteLine("\nУпражнение 4.2\n");
         Task2();

         // Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
         // учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
         // делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
         // год. Однако, если он делится без остатка на 400, это високосный год.)
         Console.WriteLine("Домашнее задание 3.1");
         Task3();
     }
 }
 

