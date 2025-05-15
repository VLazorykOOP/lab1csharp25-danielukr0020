// See https://aka.ms/new-console-template for more information

static void task1()
{
    Console.WriteLine("Task1");
    Console.WriteLine("Введiть 2 точки з координатами a, b i с, d");

    Console.Write("a: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c: ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.Write("d: ");
    double d = Convert.ToDouble(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2));

    Console.WriteLine($"Вiдстань {distance:F2}");
}

static void task2()
{
    Console.WriteLine("Task2");
    Console.Write("Введiть цiле число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 != 0)
    {
        Console.WriteLine("число непарне");
    }
    else
    {
        Console.WriteLine("число парне");
    }
}

static void task3()
{
    Console.WriteLine("Task3");
    Console.WriteLine("Введiть точку з координатами x i y:");

    Console.Write("x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    double distance = x * x + y * y;

    if(y<0 || distance > 100 || distance < 25)
    {
        Console.WriteLine("Нi");
    }
    else if (distance == 100 || distance == 25)
    {
        Console.WriteLine("На межi");
    } else
    {
        Console.WriteLine("Так");
    }
}

static void task4()
{
    Console.WriteLine("Task4");
    Console.Write("Введіть номер масті: ");
    int m = Convert.ToInt32(Console.ReadLine());

    string mast = m switch
    {
        1 => "піки",
        2 => "трефи",
        3 => "бубни",
        4 => "черви",
        _ => "Невірний номер масті"
    };

    Console.WriteLine(mast);
}

static void task5()
{
    Console.WriteLine("Task5");
    Console.Write("Введіть перше число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введіть друге число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Добуток чисел {num1 * num2}");
}

static void task6()
{
    Console.WriteLine("Task6");
    Console.Write("m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if ((n * n + m * m + 1) == 0 || ((m + 1) * (n + 1)) == 0)
    {
        Console.WriteLine($"Не можливо подiлити на 0");
    }
    else
    {
        double result = ((n + 1) / (double)(n * n + m * m + 1)) - (1 / (double)((m + 1) * (n + 1)));
        Console.WriteLine(result);
    }
}



Console.WriteLine("Lab 1");
//task1();
//task2();
//task3();
//task4();
//task5();
task6();

Console.ReadKey();

