System.Console.WriteLine("Введите число: ");
int num = 0;

try
{
    num = int.Parse(Console.ReadLine());

    int numModul = Math.Abs(num);

    if (numModul<100)
    {
        System.Console.WriteLine("В введенном числе отсутствует третья цифра");
    }
    else
    {
        string numStr = Convert.ToString(numModul);

        System.Console.WriteLine(numStr[2]);

    }
}
catch
{
    System.Console.WriteLine("Вы ввели некорректные данные");
}

 






