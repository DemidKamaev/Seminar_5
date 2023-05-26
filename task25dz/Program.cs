// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

int result = Math.Row(int numA, int numB)
{
    int array = 1;
    for (int i = 0; i <= numB; i++)
    {
        array = array * numA;
    }
    return array;
}


int exponent = Math.Pow(numA, numB);
Console.WriteLine("Ответ: " + exponent);