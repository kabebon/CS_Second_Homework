Console.WriteLine("Input number: ");
while(true)
{
    int day = int.Parse(Console.ReadLine()!);
    switch(day)
    {
    case 6: Console.WriteLine("It's Saturday"); break;
    case 7: Console.WriteLine("It's Sunday"); break;
    default: Console.WriteLine("It's not a week day");break;
    }
}


