// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task19()
{
    Console.WriteLine("Первая задача");
    int nom = Input("Введите исходное число:");
    int nom_1 = nom % 10;
    Console.WriteLine(nom_1);
    int a = nom / 10;
    int nom_2 = a % 10;
    Console.WriteLine(nom_2);
    int b = a / 10;
    int nom_3 = b % 10;
    Console.WriteLine(nom_3);
    int c = b / 10;
    int nom_4 = c % 10;
    Console.WriteLine(nom_4);
    int d = c / 10;
    int nom_5 = d % 10;
    Console.WriteLine(nom_5);
    if (nom_1 == nom_5 && nom_2 == nom_4)
    {
        Console.Write($"число {nom} является палиндромом ");
    }
    else 
    {
        Console.Write($"{nom} - обычное число");
    }
}

void Task21()
{
    int x_1 = Input("Координата Х1:");
    int y_1 = Input("Координата Y1:");
    int z_1 = Input("Координата Z1:");
    int x_2 = Input("Координата Х2:");
    int y_2 = Input("Координата Y2:");
    int z_2 = Input("Координата Z2:");
    double dr = Math.Sqrt(Math.Pow((x_1 - x_2),2) + Math.Pow((y_1 - y_2),2) + Math.Pow((z_1 - z_2),2));
    Console.WriteLine(dr);
}

void Task23()
{
    int N = Input("Введите число:");
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }
}
int task = Input("Введите номер задачи: ");
switch(task)
{
    case 19:
        Task19();
        break;
     case 21:
        Task21();
        break;
     case 23:
        Task23();
        break;
    default:
        Console.WriteLine("Ошибка ввода");
        break;
}