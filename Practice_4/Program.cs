//Console.WriteLine("Введите число"); //Вывод в консоль
//string example = Console.ReadLine(); //Создаем переменную example, в которую записываем строковое значение из консоли
//int a = Convert.ToInt32(example); //Создаем переменную а, в которую конвентируем из строкового в числовое значение

//Console.WriteLine("Вывод:"); //Вывод в консоль
//int result = a * a;  //Квадрат числа
//Console.WriteLine(result); //Вывод результата


// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите первое число");
string example1 = Console.ReadLine();
int a = Convert.ToInt32(example1);
Console.WriteLine("Введите второе число");
string example2 = Console.ReadLine();
int b = Convert.ToInt32(example2);

int i = a - 1;
while (i < b);
{
  i += 1;
  Console.Write(i);
}








// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8