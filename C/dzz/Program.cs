// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// using System;
// namespace Lesson
// {
//   class Program
//  {
//    static void Main(string[] args)
//    {
//     Console.Write("Введите числа через запятую: ");
//     int[] numbers = StringToNum(Console.ReadLine());
//     PrintArray(numbers);
//     int sum = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//       if (numbers[i] > 0)
//       sum++;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"количество значений больше 0 = {sum}");


//     int[] StringToNum(string input)
//     {
//       int count = 1;
//       for (int i = 0; i < input.Length; i++)
//     {
//       if (input[i] == ',')
//       {
//         count++;
//       }
//     }
//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//      {
//         Console.Write(array[i] + " ");
//      }
//     }
//    } 
//  }
// } 
   




//Задача 43: Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

// using System;
// namespace Lesson
// {
//   class Program
//  {
//    static void Main(string[] args)
//    {
//     float k1,b1;
//     float k2,b2;
//     float x,y;

//     if ((k1 == k2) && (b1 == b2))
//     {
//       Console.WriteLine("Прямые совпадают");
//     }
//     else 
//     if (k1==k2)
//     {
//       Console.WriteLine("Прямые параллельны");
//     }
//     else

//     x=(b2-b1)/(k1-k2);

//     y=(k1*(b2-b1))/(k1-k2)+b1;
//     {
//       Console.WriteLine($"x=" << x << "y=" << y);
//     }
//     return 0;
//     }
//   }
// }

