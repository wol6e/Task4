// Напишите цикл, который принимает на вход 2 числа А и В и возводит число А\
// в натуральную степень В
// 3, 5 -> 243
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase,int exponent)
{
  int power = 1;
  for(int i = 0; i < exponent; i++)
 {
    power*=powerBase;
 }
return power;
}

bool ValidateExponent(int exponent)
{
 if (exponent <0)
 {
    System.Console.WriteLine("Введено некорректное число В, введите натуальное число В: ");
    return false;
 }
return true;
}

int powerBase = Prompt("Введите число А: ");
int exponent= Prompt("Введите число В: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase,exponent)}");
}
