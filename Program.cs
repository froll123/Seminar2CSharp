/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

void Main()
    {
        var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));
        while (n >= 100)
        {
            n /= 10;
        }
        var r = n % 10;
        System.Console.WriteLine(r);
    }
    Main();


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите трехзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (ThirdNumber(number1) == -1)
{
Console.WriteLine("третьей цифры нет");
}
else
{
Console.WriteLine($"третье число это: {ThirdNumber(number1)}");
}
int ThirdNumber(int number1)
        {
            int result = -1;
            if (number1 >= 100)
            {
                while (number1 > 999)
                {
                    number1 = number1 / 10;
                }
                result = number1 % 10;
            }
            return result; 
}


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine ("Введите день недели...");
int dayofweek = Convert.ToInt32(Console.ReadLine());
      if (dayofweek == 6 || dayofweek == 7) 
      {
        Console.WriteLine ("Ответ: Выходной день.");
      }
      else if (dayofweek <= 5) 
      {
        Console.WriteLine ("Ответ: Будний день.");
        }
      else if (dayofweek > 7) 
      {
        Console.WriteLine ("Ошибка: В неделе всего 7 дней!");
      }
      