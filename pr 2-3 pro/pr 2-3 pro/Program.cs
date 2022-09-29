Console.WriteLine("выберите операцию: \n" +
    "1.Угадай число\n" +
    "2.Таблица умножения\n" +
    "3.Найти делитель числа\n" );

bool Tr = true;
while (Tr)
{ 
short input=Convert.ToInt16(Console.ReadLine());

    switch (input)
    {
        case 1:
            {

                Console.WriteLine("Угадайте число");
                Random rnd = new Random();
                int value = rnd.Next(0, 100);

                int a;


                do
                {

                    a=Convert.ToInt32(Console.ReadLine());

                    if (a < value)
                        Console.WriteLine(" число больше");
                    if (a > value)
                        Console.WriteLine(" число меньше");

                }
                while (a != value);

                Console.WriteLine("Вы угадали!!!");

                Console.WriteLine("выберете операцию ещё раз");
                break;
            }
        case 2:
            int[,] tabl = new int[10, 10];

            for (short i = 1; i < 10; i += 1)
            {
                for (short j = 1; j < 10; j += 1)
                {
                    tabl[i, j] = i * j;
                    Console.Write(" {0}\t", tabl[i, j], "");
                }
                Console.WriteLine();
            }
            break;
        case 3:
            {
                Console.WriteLine("введите число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("делители числа {0}",b);
                for(int i = 1; i <= b; i++)
                {
                    if (b%i ==0)
                        Console.Write(" {0} ", i);
                }
                Console.Write("\nВыберете операцию ещё раз ");
                break;
            }
        default:
            Tr = false;
            break;
    }
}