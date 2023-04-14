// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//  double[,] CreateRandom2dArray()
// {
//   Console.Write(" ВВедите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write(" ВВедите количество columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write(" ВВедите количество minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write(" ВВедите количество maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
//   double[,] array = new double[rows, columns];

//    for(int i = 0; i < rows; i++)
    
//       for(int j = 0; j < columns; j++)
     
//        array[i,j] = new Random().NextDouble();

//   return array;

// }
// void Show2dArray(Double[,] array)
// {
//   for(int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//      Console.Write(array[i,j] + "   ");

//      Console.WriteLine();
//   }
//   Console.WriteLine();
// }
// double[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Input a quantity of rows:"); 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a quantity of columns:");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a position rows:"); 
//    int posrows = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Input a position of columns:");
//    int poscolumns = Convert.ToInt32(Console.ReadLine());

//    int[,] array = new int[rows, columns];
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1,10);
//                Console.Write(array[i,j] + "   ");
//         }
//            Console.WriteLine();
//     }
//    if(posrows<=rows+1 || poscolumns <= columns+1)
//    Console.Write($"Значение элемента {array[posrows-1, poscolumns-1]}");
//    else 
//    Console.Write($"Такого элемента нет");
 
  

//   Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    // Console.WriteLine("Input a quantity of rows:"); 
    // int rows = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Input a quantity of columns:");
    // int columns = Convert.ToInt32(Console.ReadLine());

    // int[,] array = new int[rows, columns];
    
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         array[i, j] = new Random().Next(1,10);
    //            Console.Write(array[i,j] + "   ");
    //     }
    //        Console.WriteLine();
    //  }
    
    // for (int j = 0; j < array.GetLength(1); j++)
    // {
    //    double sum = 0;
    //    for (int i = 0; i < array.GetLength(0); i++)
    //     {
    //     sum += array[i,j];
    //     }
    
    //   Console.WriteLine($"{ sum / array.GetLength(0)} ");  
    // }
