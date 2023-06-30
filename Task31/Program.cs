// Задайте массив из 12 элементов, заполненный
// случайными чмслами из промежутка [-9,9]. Найдите сумму
// отрицательных и положительных элементов массива
 
int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальный диапазон чисел в массиве: ");
int maxValue = Prompt("Введите максимальный диапазон чисел в массиве: ");
int[] array = GetArray(size,minValue,maxValue); // вызов метода
PrintArray(array); // вызов метода печати
GetSum(array);

int Prompt(string message)  // метод для работы с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()); // считываем число с консоли
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
    //for (int i = 0; i < arr.Length; i++)
    //{
    //    Console.Write($"{arr[i]} ");
    //}
    foreach(int el in arr)
    {
        Console.Write($"{el} ");
    }
}

void GetSum(int[] array)
{
int positiveSum = 0;
int negativeSum = 0;

foreach(int el in array) // работает с элементами массива
{
    if(el>0) positiveSum +=el;
    if(el<0) negativeSum +=el;
} 
Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательных чисел = {negativeSum}");
}