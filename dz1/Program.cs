void SecondNum (int num)
{
    if (num > -1000 & num < 1000)
    {
    num = (num / 10) % 10;
    Console.WriteLine("Вторая цифра введенного числа " + num);
    }
    else
    {
       Console.WriteLine("Введите трехзначное число!!!"); 
    }
}



try
{
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
SecondNum (num);
}
catch
{
   Console.WriteLine("Введено некорректное значение"); 
}