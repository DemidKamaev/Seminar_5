// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 // 82 -> 10 // 9012 -> 12



Console.WriteLine("$Ввести сумму цифр в числе");
Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int numS(int numN)
{
    int count = Convert.ToString(numN).Length;
    int array = 0;
    int result = 0;


  for (int i = 0; i < count; i++)
    {
       array = numN - numN % 10;
       result = result + (numN - array);
       numN = numN / 10;
    }
    return result;
}

int numS = numS(numN);
Console.WriteLine("Сумма цифр в цисле:" + numS);




//int sum = 0;  // создадим переменную
//int result = 0;
//int number = ReadInt("Insert number: ");





//System.Console.WriteLine(sum);