/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Обязательна проверка на ввод чисел больше/меньше 3-х знаков

456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length == 3)
{
    int result = (number%100)/10; 
    Console.WriteLine($"Вторая цифра {result}" );
}
else
{
    Console.WriteLine("Некорректное число, введите трехзначное число: ");
}



/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2){
  Console.WriteLine($"Исходное число: {number}, третья цифра -> " + numberText[2]);
}
else {
  Console.WriteLine($"Исходное число: {number}, -> третьей цифры нет");
}


/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
Обязательна проверка на ввод числа <1 и >7

6 -> да
7 -> да
1 -> нет*/


Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(Этот день выходной) -> Да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Некорректный ввод, введите цифру от 1 до 7");
  }
  else Console.WriteLine("(Этот день не является выходным) -> Нет");

