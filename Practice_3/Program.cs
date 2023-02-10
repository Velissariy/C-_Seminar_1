//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница




Console.WriteLine("Input number");
int a = Convert.ToInt32(System.Console.ReadLine());
int c = 5;
switch (a) 
{
      case 1:
           Console.WriteLine("Monday");
           break;
      case 2:
           Console.WriteLine("Tuesday");
           break;
      case 3:
           Console.WriteLine("Wednesday");
           break;
      case 4:
           Console.WriteLine("Thursday");
           break;
      case 5:
           Console.WriteLine("Friday");
           break;
      case 6:
           Console.WriteLine("Saturday");
           break;
      case 7:
           Console.WriteLine("Sunday");
           break;
      default:
           Console.WriteLine("There is no such a weekday");
           break;
}






//System.Console.WriteLine("Введите день недели");
//int a = Convert.ToInt32(System.Console.ReadLine());

//if (a ==1)
//System.Console.WriteLine("День недели:понедельник");
//else if (a ==2)
//System.Console.WriteLine("День недели:вторник");
//else if (a ==3)
//System.Console.WriteLine("День недели:среда");
//else if (a ==4)
//System.Console.WriteLine("День недели:четверг");
//else if (a ==5)
//System.Console.WriteLine("День недели:пятница");
//else if (a ==6)
//System.Console.WriteLine("День недели:суббота");
//else if (a ==7)
//System.Console.WriteLine("День недели:воскресенье");