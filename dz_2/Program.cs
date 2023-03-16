int ThirdRank(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}




bool CheckNum(int number)
{
    if (number < 100)
    {
        Console.WriteLine ("Третья цифра отсутствует");
        return false;
    }
    return true;
}




try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());   
    if (CheckNum(num))
    {
        Console.WriteLine(ThirdRank(num));
    }
}
catch
{
Console.WriteLine("Введено неверное значение");
}