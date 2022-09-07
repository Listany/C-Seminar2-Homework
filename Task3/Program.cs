int numWeek=0;

try
{
    System.Console.WriteLine("Введите день недели - от 1 до 7");

    numWeek=int.Parse(Console.ReadLine());

    switch(numWeek)
    {
        case 6:
        case 7:
            System.Console.WriteLine("Сегодня выходной!");
            break;
        default:
            System.Console.WriteLine("Сегодня будний день...");
            break;
    }
}
catch
{
    System.Console.WriteLine("Вы ввели некорректные данные");
}