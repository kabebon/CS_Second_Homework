//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

class geekHomeWork_Kabeba
{
    public static void Main()
    {
        while (true)
        {
            if(TryGetUserInput(out int input))
            {
                if (IsThreeDigits(input))
                {
                    int digit = GetThirdDigit(input);
                    Console.WriteLine("Third digit is " + digit);
                }
            }
            else
            {
                Console.WriteLine("It's not a number!");
            }
        
        }
    }
    
    private static int GetThirdDigit(int input) //получаем третью цифру введенного числа
    {
        int value = input;
        while (value/1000 != 0)
            {
                value=value/10;
            }
        return value %10;
    }
    
    private static bool IsThreeDigits(int input) // валидность числа. Есть ли там третья цифра или число <100
    {
        if (input<100)
            {
                Console.WriteLine("It's not three digits number!");
                return false;
            }
        return true;
    }

    private static bool IsString(string input) // метод проверки на string
    {
        return !int.TryParse(input, out _);
    }
    
    private static bool TryGetUserInput(out int value) // проверка введенного числа на string
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine()!;
            if (IsString(input))
            {
                value = 0;
                return false;
            }

            else
            {
                value = int.Parse(input);
                return true;
            }
    }
    
}
