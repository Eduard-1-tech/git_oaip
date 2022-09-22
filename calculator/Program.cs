Console.WriteLine("выберите операцию: \n" +
    "1.сложить 2 числа\n" +
    "2.вычесть первое из второго\n" +
    "3.перемножить 2 числа\n"+
    "4.разделить первое на второе\n" +
    "5.возвести в степень n первое число\n"+
    "6.найти квадратный корень числа\n"+
    "7.найти 1% от числа\n"+
    "8.найти факториал числа\n"+
    "9.выйти из программы");

bool Tr = true;

while (Tr)
{
    int input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        Console.WriteLine("введите первое число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("результат: " + sum + "\nвведите операцию ещё раз");
    }
    else if (input == 2)
    {
        Console.WriteLine("введите первое число");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int d = Convert.ToInt32(Console.ReadLine());
        int raz = d - c;
        Console.WriteLine("результат: " + raz + "\nвведите операцию ещё раз");
    }
    else if (input == 3)
    {
        Console.WriteLine("введите первое число");
        int e = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int g = Convert.ToInt32(Console.ReadLine());
        int umn = e - g;
        Console.WriteLine("результат: " + umn + "\nвведите операцию ещё раз");
    }
    else if (input == 4)
    {
        Console.WriteLine("введите первое число");
        float f = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        float h = Convert.ToInt32(Console.ReadLine());
        if (h == 0)
        {
            Console.WriteLine("на ноль делить нельзя!Введите второе число ещё раз");
            float h1 = Convert.ToInt32(Console.ReadLine());
            float del = f / h1;
            Console.WriteLine("результат: " + del + "\nвведите операцию ещё раз");
        }
        else if (h != 0)
        {
            float del = f / h;
            Console.WriteLine("результат: " + del + "\nвведите операцию ещё раз");
        }
    }

    else if (input == 5)
    {
        Console.WriteLine("введите число");
        double j = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите cтепень");
        double k = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("результат: " + Math.Pow(j, k) + "\nвведите операцию ещё раз");
    }
    else if (input == 6)
    {
        Console.WriteLine("введите число");
        double l = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("квадратный корень равен: " + Math.Sqrt(l) + "\nвведите операцию ещё раз");
    }

    else if (input == 7)
    {
        Console.WriteLine("введите число");
        double m = Convert.ToDouble (Console.ReadLine());
        double proz = (m/100);
        Console.WriteLine("1% от числа {0} равен:" + proz+ "\nвведите операцию ещё раз", m);
    }

    else if (input == 8)
    {
        Console.WriteLine("введите число");
         int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("факториал {0} равен: "+factorial+ "\nвведите операцию ещё раз",n );
    }
    else if (input == 9)
    {
        Tr=false;
    }
}