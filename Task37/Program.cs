// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний...
// Результат запишите в новом массиве
// [1,2,3,4,5] -> 5,8,3
// [6,7,3,6] -> 36,21

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальный диапазон чисел в массиве: ");
int maxValue = Prompt("Введите максимальный диапазон чисел в массиве: ");
int[] array = GetArray(size,minValue,maxValue); // вызов метода
PrintArray(array); // вызов метода печати
Console.Write($" -> ");
GetSum(array);
PrintArray(GetSum(array));

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

int[] GetSum(int[] arr)
{       
   int[] resArray = new int[(arr.Length+1)/2]; 
   for(int i=0;i<arr.Length/2;i++)
       {
        resArray[i] = arr[i]*arr[arr.Length -i-1];
       }
       if(arr.Length % 2==1)
       {
        resArray[(arr.Length-1)/2] = arr[(arr.Length-1)/2];
       } 
       return resArray;
}

