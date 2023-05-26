// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array1 = new int[5];
Random rand = new Random();
int[] array2 = new int[3];
Random random = new Random();

for(int i = 0; i < array1.Length; i++)
{
    array1[i] = rand.Next(1,100);
}

for(int i = 0; i < array2.Length; i++)
{
    array2[i] = rand.Next(1,100);
}

System.Console.WriteLine(string.Join(" ", array1));
System.Console.WriteLine(string.Join(" ", array2));