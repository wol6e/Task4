// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот
// [-4,-8,8,2] -> [4,8,-8,-2]

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
    Console.Write(" -> [");
for(int i=0;i<array.Length-1;i++) 
{
   Console.Write($"{array[i] * (-1)},");
} 
Console.Write($"{array[array.Length-1]*(-1)}");
Console.Write("]");
}