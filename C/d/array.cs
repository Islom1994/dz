// Задача 62: Заполнить спирально массив 4 на 4.// 1 2 3 4// 12 13 14 5// 11 16 15 6// 10 9 8 7 Консоль.Очистить();Console.WriteLine($"Задача 62: Заполнить спирально массив 4 на 4."); инт п = 4;int[,] sqareMatrix = new int[n, n]; инт темп = 1;интервал я = 0;интервал j = 0; в то время как (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1)){ sqareMatrix[i, j] = temp; темп++; если (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1) j++; иначе, если (i < j && i + j >= sqareMatrix.GetLength(0) - 1) я++; иначе, если (i >= j && i + j > sqareMatrix.GetLength(1) - 1) ж--; еще я--;} ЗаписатьМассив(КвадратнаяМатрица); void WriteArray (массив int[,]){ for (int i = 0; i < array.GetLength(0); i++) { for (int j = 0; j < array.GetLength(1); j++) { если (массив[i,j]/10 <= 0) Console.Write($"{массив[i,j]}"); еще Console.Write($"{массив [i,j]} "); } Консоль.ЗаписьЛинии(); }}

namespace Lesson
{
  internal class array
  {
  }
}