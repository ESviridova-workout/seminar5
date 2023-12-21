// В этом документе вначале домашняя работа, потом семинар записан.
// _____________________________
// _____________________________
// Домашнее задание


// // Задача 1
// // Напишите программу, которая на  вход принимает позиции элемента в двумерном массиве, и возвращает
// //  значение этого элемента или же указание, что такого элемента нет.

// int[,] arr = new int [5,6];

// void CreateArr()
// {
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             arr[i,j]=new Random().Next(0,10);
//             Console.Write(arr[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// void FindNum ()
// {
//     bool isFind = false;
// // булевую переменную прописала, т.к. фраза, что элемента не существует выводилась много раз(по кол-ву всех 
// // элементов массива)
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             if (i==num1 && j==num2)
//             {
//                 isFind = true;
//                 Console.WriteLine("Элемент по заданным позицитям: " + arr[i,j]);
//             }
//         }
//     }
//     if(isFind==false)
//     {
//         Console.WriteLine("Элемента по таким позициям не существует");
//     }
// }

// Console.WriteLine();
// CreateArr();
// Console.WriteLine();
// FindNum ();
// Console.WriteLine();



// // Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую
// // и последнюю строку массива.

// int[,] arr = new int [5,8];

// void CreateArr()
// {
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             arr[i,j]=new Random().Next(0,10);
//         }
//     }
// }

// void PrintArr()
// {
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ReplaceNum()
// {
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             var a =arr[0,j];
// // ..var - ключевое слово, которое указывает, что компилятор должен вывести тип переменно из выражения справа.
// // ....локальную переменную можно объявлять без указания конкретного типа

//             arr[0,j]=arr[arr.GetLength(0)-1,j];
// //  ...... arr.GetLength(0)-1 - это обозначение последней строки
//             arr[arr.GetLength(0)-1,j]= a;
//         }
//     }   
// }

// CreateArr();
// PrintArr();
// ReplaceNum ();
// PrintArr();


// // Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// // строку с наименьшей суммой элементов.


// int[,] arr = new int [5,6];

// // задается и заполняется массив и сразу же считается и записывается сумма каждой строки (для облегчения проверки в дальнешем)

// for(int i=0; i<arr.GetLength(0); i++)
// {
//     int stringsum=0; 
//     for(int j=0; j<arr.GetLength(1); j++)
//     {
//         arr[i,j]=new Random().Next(0,10);
//         stringsum = stringsum+arr[i,j];
//         Console.Write(arr[i,j] + " ");
//     }
//     Console.WriteLine("сумма строки = " + stringsum);  
// }

// // находим сумму 1 строки для дальнейшего поиска строки сминимальной суммой
// // с 0 сравнивать нельзя, т.к. меньше нуля могут быть только отрицательные числа

// int minsum=0; 

// for(int i=0; i<1; i++)
// {
//     for(int j=0; j<arr.GetLength(1); j++)
//     {
//        minsum = minsum+arr[i,j];
//     }
// }
// Console.WriteLine("Ищем минимальную сумму строк сравнивая с суммой 1 строки  " + minsum); 

// int ind=0;

// for(int i=0; i<arr.GetLength(0); i++)
// {
//     int stringsum=0; 

//     for(int j=0; j<arr.GetLength(1); j++)
//     {
//         stringsum = stringsum+arr[i,j];
//     }

//     if(stringsum < minsum)
//     {
//         minsum=stringsum;
//         ind=i;
//     }
// }
// Console.WriteLine(ind + " - индекс строки с наименьшей суммой элементов (при наличии еще одной строки равной minsum, она не учитывается)");  


// // Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу,
// // которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// // Под удалением понимается создание нового двумерного массива без строки и столбца

// using System.Globalization;

// int[,] arr = new int [5,8];

// void CreateArr()
// {
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             arr[i,j]=new Random().Next(0,101);
//         }
//     }
// }

// void PrintArr()
// {
//     for(int i=0; i<arr.GetLength(0); i++)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "  ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// CreateArr();
// PrintArr();
// Console.WriteLine();


// int min = arr[0,0];
// int str = 0;
// // строка
// int col = 0;
// // столбец

// for(int i=0; i<arr.GetLength(0); i++)
// {
//     for(int j=0; j<arr.GetLength(1); j++)
//     {
//         if (arr[i,j]<min)
//         {
//             min = arr[i,j];
//             str=i;
//             col=j;
//         }
//     }
// }

// Console.WriteLine(min + " - самый первый наименьший элемент массива");
// Console.WriteLine("\n Минимальный элемент находится на пересечении" + " \n строки с индексом " + str + " \n и столбца с индексом " + col);

// int[,] arr2 = new int [arr.GetLength(0)-1, arr.GetLength(1)-1];
// int m = 0;
// int n = 0;

// for(int i=0; i<arr.GetLength(0); i++)
// {
//     if (i!=str)
//     {
//         for(int j=0; j<arr.GetLength(1); j++)
//         {  
//             if (j!=col)
//             {
//                 arr2[m,n]=arr[i,j];
//                 n++;                
//             }
//         }
//         m++;
//         n=0;
//     } 
// }

// for(int i=0; i<arr2.GetLength(0); i++)
// {
//     for(int j=0; j<arr2.GetLength(1); j++)
//     {
//         Console.Write(arr2[i,j] + "  ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();



// _________________________________________________-
// ________________________________________________
// ________________________________________________


// // 3 задача из д.з.5 от преподавателя
// // За// Задача 3: Задайте прямоугольный двумерный массив.
// // Напишите программу, которая будет находить строку с
// // наибольшей суммой элементов.

// int[,] array = new int[3,4];

// int sumInMax=0;
// int indexMax=0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum=0;

//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      array[i,j] = new Random().Next(0,10);
//      System.Console.Write(array[i,j]+ " ");

//      sum += array[i,j];
//    }
//     System.Console.WriteLine("сумма "+sum);

//    if(sum>sumInMax)
//    {
//      sumInMax= sum;
//      indexMax= i;
//    }
//    System.Console.WriteLine();
// }
// System.Console.WriteLine("\nИндекс макимальной = "+indexMax);


// __________________________________________________
//                 Семинар 5
// __________________________________________________

// ________________________________________________


// // 1.
// // Задайте двумерный массив. Найдите элементы, у которых оба
// // индекса чётные, и замените эти элементы на их квадраты.
// // Пример
// // 2 3 4 3
// //  4 3 4 1 =>
// //  2 9 5 4
// // Обсудить этапы решения задачи
// // Оформить этапы в виде функций
// // 4 3 4 3
// // 4 3 4 1
// // 2 9 25 4

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i %2 ==0 && j%2==0)
//             {
//                 array[i,j]= array[i,j] * array[i,j];
//             }
//         }
//     }
// }

// CreateArray();
// PrintArray();
// FindElementsArray();
// PrintArray();


// 2.
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray()
// {
//     int sumElement=0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i ==j)
//             {
//                sumElement+= array[i,j];
//             //    sumElement= sumElement+ array[i,j];

//             }
//         }
//     }
//     System.Console.WriteLine("Сумма = " + sumElement);
// }

// CreateArray();
// PrintArray();
// FindElementsArray();


// 3. 
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

// int[,] array = new int[3,4];
// double [] array2 = new double[array.GetLength(0)];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         double sumElement=0;

//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//                sumElement += array[i,j];
//             // sumElement= sumElement+ array[i,j];


//         }
//         array2[i] = sumElement/array.GetLength(1);
//     }
// }

// void PrintArray2()
// {
//     for (int i = 0; i < array2.Length; i++)
//     {

//             System.Console.Write(array2[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// CreateArray();
// PrintArray();
// FindElementsArray();
// PrintArray2();



