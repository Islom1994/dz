// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// using System;
// namespace lesson
// { 
//  class Program
//  { 
//   public static void Main()
//   { 
//    Console.WriteLine("Задайте количество строк двумерного массива:");
//    int m = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Задайте количество столбцов двумерного массива:");
//    int n = Convert.ToInt32(Console.ReadLine());
//    double[,] twoDimArray = new double[m, n];
//    Random rnd = new Random();
//    void PrintArray(double[,] matr)
//    { for (int i = 0; i < m; i++)
//    { for (int j = 0; j < n; j++)
//    { 
//     Console.Write($"{matr[i, j]} ");
//    }
//     Console.WriteLine();}}

//   void FillArray(double[,] matr)
//   { 
//     for (int i = 0; i < m; i++)
//   { 
//     for (int j = 0; j < n; j++)
//   { 
//     matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
//     FillArray(twoDimArray);
//     Console.WriteLine();
//     PrintArray(twoDimArray);
//   }
//  }
// }


// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// using System;
// namespace lesson
// { 
//  class Program
//  { 
//   public static void Main()
//   { 
//    Console.WriteLine("Введите размеры массива");
//    int m = Convert.ToInt32(Console.ReadLine());
//    int n = Convert.ToInt32(Console.ReadLine());
//    int[,] array = new int[m, n];
 
//    for (int i = 0; i < array.GetLength(0); i++) 
//    {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
//    }
 
//    for (int i = 0; i < array.GetLength(0); i++) 
//    {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t  ");
//         Console.WriteLine();
//    }
 
//   Console.WriteLine("Введите координаты");
//   int a = Convert.ToInt32(Console.ReadLine());
//   int b = Convert.ToInt32(Console.ReadLine());
//   if (a>m && b>n)
//   Console.WriteLine("такого числа нет");
//   else
//   {
//    object c = array.GetValue(a,b);
//    Console.WriteLine(c);
//   }
//   }
//  }
// }


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Array
// {
//     static class Program
//     {
//         static void Main()
//         {
//             var array = GenerateArray( 10, 20 );
//             WriteToConsole( array );
//             Console.WriteLine( "All averages" );
//             PrintColumnsAverage( array, indexColumn => true );
//             Console.WriteLine( "All averages with indexColumn % 2 == 0" );
//             PrintColumnsAverage( array, indexColumn => indexColumn % 2 == 0 );
//             Console.ReadKey();
//         }

//         private static void PrintColumnsAverage( IEnumerable< int[] > array, Func< int, bool > columnSelector )
//         {
//             if ( array == null )
//                 throw new ArgumentNullException( "array" );
//             if ( columnSelector == null )
//                 throw new ArgumentNullException( "columnSelector" );

//             foreach ( var val in
//                 array.SelectMany( row => row.Select( ( colValue, index ) => new { Value = colValue, Index = index + 1 } ) ).
//                     GroupBy( item => item.Index ).
//                     Where( item => columnSelector( item.Key ) ).
//                     Select( item => new { Average = item.Average( col => col.Value ), Index = item.Key } ) )
//                 Console.WriteLine( "Col= {0}, Average={1}", val.Index, val.Average );
//         }

//         private static void WriteToConsole( IEnumerable< int[] > array )
//         {
//             if ( array == null )
//                 throw new ArgumentNullException( "array" );
//             foreach ( var row in array )
//                 Console.WriteLine( string.Join( " ", row ) );
//         }

//         private static int[][] GenerateArray( int rowsCount, int columnsCount )
//         {
//             if ( rowsCount <= 0 )
//                 throw new ArgumentException( "rowsCount" );
//             if ( columnsCount <= 0 )
//                 throw new ArgumentException( "columnsCount" );
//             var counter = 0;
//             return Enumerable.Range( 0, rowsCount ).Select( i => Enumerable.Range( 0, columnsCount ).Select( j => counter++ ).ToArray() ).ToArray();
//         }
//     }
// }

