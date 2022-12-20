// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//===============================================
//1. Метод > Ввод трехназначного цисла
int GetNumberFromUser()
{
    Console.Write("Input number from 100 to 999: ");
    int temp = int.Parse (Console.ReadLine()!);
    return temp;
}
//2. Метод > Валидность числа
bool IsValid(int number)
{
    return number >= 100 && number <= 999; 
}
//3. Метод > Выдираем вторую цифру
int GetNumber(int value)
{
    int a = value / 100;
    int b = (value/ 10) % 10;
    int c = value % 10;
    
    return b;
}

//4. Метод > Вывод результата
string GetText (int input, int output)
{
    return "The second number of " + input + " is " + output;
}
int value = GetNumberFromUser();
if (IsValid(value))
{
    int result = GetNumber (value);
    System.Console.WriteLine(GetText(value, result));
}
else 
{
    System.Console.WriteLine("Number is incorrect!");
} 
