// int totalExercises = 1;
// for (int number = 8; number >= totalExercises; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }
// Console.WriteLine("Домашнее задание готово");


// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }


// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }

// int count = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         count++;
//         continue; // билет уже вытянут
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     break;
// }
// Console.WriteLine(count);


using System.Security.Cryptography;

// for (; ; )
// {
//     Console.Write("Введите код группы (для выхода - <выход>): ");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "exit")
//     {
//         break;
//     }
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");


// // Задача А
// int n = 7;
// for (int i = 1; i <= n; i++)
// {
//     if (i % 2 != 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// // Задача Б
// for ( int n = 100; n >= 0; n -= 10)
// {
//     Console.WriteLine(n);
// }


// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
//     Console.WriteLine("Фамилия не введена. Завершение работы."); 
//     return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
//     .OrderBy(_ => rnd.Next()) 
//     .Take(2) 
//     .OrderBy(x => x) 
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// // N2
// int m = -2;
// for (int n = 16; n >= 0; n += m)
// {
//     Console.WriteLine(n);
// }


// N6
for (int n = 1; n <= 30; n++)
{
    if (n % 4 == 0)
        continue;
    Console.WriteLine(n);
}