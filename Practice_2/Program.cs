//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет


//Console.WriteLine("Введите число"); //Вывод в консоль
//string example = Console.ReadLine(); //Создаем переменную example, в которую записываем строковое значение из консоли
//int a = Convert.ToInt32(example); //Создаем переменную а, в которую конвентируем из строкового в числовое значение

//Console.WriteLine("Вывод:"); //Вывод в консоль
//int result = a * a;  //Квадрат числа
//Console.WriteLine(result); //Вывод результата


static void Example()
{
System.Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(System.Console.ReadLine());

numberB *= numberB;

if ( numberA == numberB)
{
  System.Console.WriteLine("Квадрат второго числа равен первому числу");
}
else
{
  System.Console.WriteLine("Нет");
}
System.Console.ReadLine();

}


//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

System.Console.WriteLine("Введите день недели");
int a = Convert.ToInt32(System.Console.ReadLine());

if (a ==1)
System.Console.WriteLine("День недели:понедельник");
else if (a ==2)
System.Console.WriteLine("День недели:вторник");



int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a*a==b)
{Console.WriteLine("True");}
else
Console.WriteLine("False");