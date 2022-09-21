﻿// //Задача 48

// int m = 3;
// int n = 4;
// int[,] array = new int [m , n];
// FillArray ( array);
// PrintArray ( array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i , j] = i + j;
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i , j] + " "); 
//         }
//         System.Console.WriteLine();
//     }
// }

// //End



// //Задача 49

// int[,] array = new int[,] {
//        { 3, 5, 8, 2} ,
//        { 5, 7, 9, 2} ,
//        {10, 4, 2, 7}
// };
// PrintArray ( array);
// System.Console.WriteLine();
// FindEven ( array);
// PrintArray ( array);

// void FindEven(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < array.GetLength(1); j+=2)
//         {
//             array[i , j] = (int)Math.Pow(array[i , j] , 2) ;// возвести в квадрат 
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i , j] + " "); 
//         }
//         System.Console.WriteLine();
//     }
// }

// //End

// //Задача 51

// int[,] array = new int[,] {
//        { 1, 4, 7, 2} ,
//        { 5, 9, 2, 3} ,
//        { 8, 4, 2, 4}
// };

// System.Console.WriteLine(FindSumm(array));


// int FindSumm(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
//     {
//             result += array[i,i];
//     }
//     return result;
// }

// //End


// // Задача . Найти сумму элементов нах по краям матрици .

// int[,] array = new int[,] {
//        { 1, 4, 7, 2} ,
//        { 5, 9, 2, 3} ,
//        { 8, 4, 2, 4}
// };

// System.Console.WriteLine(FindSumm(array));

// int FindSumm(int[,] array)
// {
//     return  array[0 , 0] + array[0 , array.GetLength(1)-1] + 
//     array[ array.GetLength(0)-1 , 0]+ 
//     array[ array.GetLength(0)-1 , array.GetLength(1)-1];  
// }

// //End


// // Задача . Найти сумму элементов нах на периметре матрици .

// int[,] array = new int[,] {
//        { 1, 4, 7, 2} ,
//        { 5, 9, 2, 3} ,
//        { 8, 4, 2, 4} ,
//        { 8, 4, 2, 4} ,
//        { 8, 4, 2, 4}
// };

// System.Console.WriteLine(FindSumm(array));

// int FindSumm(int[,] array)
// {
//    int result = 0 ;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == 0 || i == array.GetLength(0) - 1  ) 
//             result +=  array [i , j ];
//             else 
//             {
//                 result +=  array [i , 0 ];
//                 result +=  array [i , array.GetLength (1) - 1];
//                 break;
//             }
//         }
//     }
//     return result ;
// }


// //End

// //Задача . найти сумму элементов ниже главной диагонали 

// int[,] array = new int[,] {
//        { 1, 4, 7, 2} ,
//        { 5, 9, 2, 3} ,
//        { 8, 4, 2, 4} ,
//        { 8, 4, 2, 4} ,
//        { 8, 4, 2, 4}
// };
// System.Console.WriteLine(FindSumm( array));

// int FindSumm(int[,] array)
//     {
//         int result = 0 ;
//         for (int i = 1; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                result += array [i , j];
//             }
//         }
//         return result ;
//     }

// // End    

// //Задача . найти сумму элементов выше главной диагонали 

// int[,] array = new int[,] {
//        { 1, 4, 7, 2} ,
//        { 5, 9, 2, 3} ,
//        { 8, 4, 2, 4} ,
//        { 8, 4, 2, 4} ,
//        { 8, 4, 2, 4}
// };
// System.Console.WriteLine(FindSumm( array));

// int FindSumm(int[,] array)
//     {
//         int result = 0 ;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                result += array [i , j];
//             }
//         }
//         return result ;
//     }

//  // End   

// Задача . Вывести  элементов нах на периметре матрици .

int[,] array = new int[,] {
       { 1, 4, 7, 2} ,
       { 5, 9, 2, 3} ,
       { 8, 4, 2, 4} ,
       { 8, 4, 2, 4} ,
       { 8, 4, 2, 4}
};
PrintArray( array) ;

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int k = 0; k < length; k++)
    {
        
    
        for (int j = 0; j < columns; j++)
        {
            System.Console.Write(array[0 , j] + " "); 
        }
        for (int i = 1; i < rows; i++)
        {
            System.Console.Write(array[i , columns - 1] + " "); 
        }
        for (int j = columns-2 ; j >= 0; j--)
        {
            System.Console.Write(array[rows-1 , j] + " "); 
        }
        for (int i =rows - 2; i > 0; i--)
        {
            System.Console.Write(array[i , 0] + " "); 
        }
    }
}
