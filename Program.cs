


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array= new int[rows, cols];
// FillArrayRandomNumbers(array);
// Console.WriteLine();
// Console.WriteLine("Массив до изменения");
// ShowArray(array);

// for (int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1) - 1; j++){
//         for (int z = 0; z < array.GetLength(1) - 1; z++){
//             if (array[i, z] < array[i, z + 1]){
//                 int temp = 0;
//                 temp = array[i, z];
//                 array[i, z] = array[i, z + 1];
//                 array[i, z + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив с упорядоченными значениями");
// ShowArray(array);

// void FillArrayRandomNumbers(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void ShowArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
        
//         for (int j = 0; j < array.GetLength(1); j++) {
//             Console.Write(array[i, j] + " ");
//         }
       
//         Console.WriteLine("");
//     }
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Console.Write("введите количество строк - ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите количество столбцов - ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите диапазон случайных значений: от 1 до  ");
// int range = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[x, y];
// CreateArray(array);
// ShowArray(array);

// int minSum = 0;
// int sum= SumElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++){
//   int tempSum = SumElements(array, i);
//   if (sum > tempSum){
//     sum = tempSum;
//     minSum = i;
//   }
// }

// Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой ={sum}  ");


// int SumElements(int[,] array, int i){
//   int sum = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)  {
//     sum += array[i,j];
//   }
//   return sum;
// }


// void CreateArray(int[,] array){
//   for (int i = 0; i < array.GetLength(0); i++) {
//     for (int j = 0; j < array.GetLength(1); j++) {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void ShowArray (int[,] array){
//   for (int i = 0; i < array.GetLength(0); i++) {
//     for (int j = 0; j < array.GetLength(1); j++) {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size){
//     array[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// ShowArray(array);

// void ShowArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++) {
       
//         for (int j = 0; j < array.GetLength(1); j++) {
//             Console.Write(array[i, j] + " ");
//         }
        
//         Console.WriteLine("");
//     }
// }
