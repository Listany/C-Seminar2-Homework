System.Console.WriteLine("Введите трехзначное число: ");

int num=0;

try
{
    num = int.Parse(Console.ReadLine());
    

    if (num<100 | num>999)
    {
        System.Console.WriteLine("Вы ввели не трехзначное число, попробуйте снова");
    }
    else
    {
        int result = num / 10 % 10;
        System.Console.WriteLine($"Вторая цифра заданного числа = {result}");
    }
}
catch
{
    System.Console.WriteLine("Вы ввели недопустимое значение!");
}

