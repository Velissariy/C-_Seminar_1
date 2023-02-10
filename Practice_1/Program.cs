//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
//на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

string example = Console.ReadLine(); 
int a = Convert.ToInt32(example);                                 //Convert.ToInt32(string)   string example = Console.ReadLine()  int a = Convert.ToInt32(example)
                                                
//int result = 1;

int result = a * a;
Console.WriteLine(result);

//Console.WriteLine("Введите число"); //Вывод в консоль
//string example = Console.ReadLine(); //Создаем переменную example, в которую записываем строковое значение из консоли
//int a = Convert.ToInt32(example); //Создаем переменную а, в которую конвентируем из строкового в числовое значение

//Console.WriteLine("Вывод:"); //Вывод в консоль
//int result = a * a;  //Квадрат числа
//Console.WriteLine(result); //Вывод результата
