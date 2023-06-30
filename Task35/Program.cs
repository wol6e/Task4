// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10,99]
// [5,18.123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,14] -> 5

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальный диапазон чисел в массиве: ");
int maxValue = Prompt("Введите максимальный диапазон чисел в массиве: ");
int[] array = GetArray(size,minValue,maxValue); // вызов метода
PrintArray(array); // вызов метода печати
GetSum(array);

int Prompt(string message)  // метод для работы с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!); // считываем число с консоли
    return number; // возвращаем число
}

int[] GetArray(int size,int minValue,int maxValue) // метод работы с массивом
{
    int[] result = new int[size];
    for(int i = 0;i<result.Length;i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
        // Console.Write($"{result[i]} ");
    }
    return result;
}

void PrintArray(int[] arr) // метод печати
{
    Console.Write("[");
    for(int i=0;i<arr.Length-1;i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[arr.Length-1]}");
    Console.Write("]");
}

void GetSum(int[] array)
{
int count=0;    
foreach(int el in array) 
{
    if (el>=10 && el<=99)
    count ++;
} 
Console.Write($" -> {count}");
}

