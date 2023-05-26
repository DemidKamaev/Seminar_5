// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] FillArray(int size, int leftRange, int rightRange)
// {
//    int[] tempArray = new int[size];
//    Random rand = new Random();
// 
//    for (int i = 0; i < size; i++)
//    {
//        tempArray[i] = rand.Next(leftRange, rightRange + 1);
//    }
//
// return tempArray;
// } 

// void Cheng(int[] arrey){
//    for (int i=0; i<arrey.Length; i++)
// {
//     arrey[i] = -arrey[i];
//}
// }
// int[] arrey=FillArray(10, -9, 9);
// Console.WriteLine(string.Join( " ",arrey));
// Cheng(arrey);
// Console.WriteLine(string.Join( " ",arrey));



// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void SumNegativeAndPositive(int[] array, out int sumNegative, out int sumPositive)
{
    sumNegative = 0;
    sumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
}


int[] array = FillArray(12, -9, 9);

PrintArray(array);

SumNegativeAndPositive(array, out int sumN, out int sumP);

System.Console.WriteLine($"Сумма положительных: {sumP}");
System.Console.WriteLine($"Сумма отрицательных: {sumN}");

// int SumPositive(int[] array)
// {
//     int sumP = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sumP += array[i];
//         }
//     }
//     return sumP;
// }

// int SumNegative(int[] array)
// {
//     int sumN = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sumN += array[i];
//         }
//     }
//     return sumN;
// }

// int[] SumNegativeAndPositive(int[] array)
// {
//     int[] posAndNeg = new int[2];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             posAndNeg[0] += array[i];
//         }
//         else
//         {
//             posAndNeg[1] += array[i];
//         }
//     }
//     return posAndNeg;
// }