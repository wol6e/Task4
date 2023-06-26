// Напишите программу, которая создаёт массив из 8 элементов
// и выводит их на экран
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6,1,33 -> [6,1,33]
int Prompt(string message)
{
System.Console.Write(message);
string ReadInput = System.Console.ReadLine();
int result = int.Parse(ReadInput);
return result;
}

int[] RandomBinaryArray(int Length,int minValue, int maxValue)
{

{
    int[] array = new int[Length];
    Random randomName = new Random();

    for(int i = 0; i < Length; i++)
    array[i] = randomName.Next(minValue, maxValue+1);
}
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0, i < array.Length -1; i++)
    {
      SystemConsole.Write($"{array[i]}");
    }
    System.Console.Write($"{array[array.Length-1]}");
    System.Console.Write("]");
}

int Length = Prompt("Введите длину массива: ");
int min = Prompt("Введите начальное значение, для диапазона случайного числа: ");
int max = Prompt("Введите конечное значение, для диапазона случайного числа: ");
int [] array = RandomBinaryArray(Length,min,max);
PrintArray(array);
