// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


void CheckDayIndex (int index)
{
    if (index > 0 & index < 6)
    {
        Console.WriteLine ("Этот день - будний");
    }
    else if (index > 5 & index < 8)
    {
        Console.WriteLine ("Этот день - выходной");
    }
    else
    {
        Console.WriteLine ("Введите число от 1 до 7!");
    }
}



try
{
    Console.WriteLine("Введите порядковый номер дня недели");
    int index = Convert.ToInt32(Console.ReadLine());
    CheckDayIndex (index);
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}