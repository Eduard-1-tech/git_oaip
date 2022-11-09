namespace Confectionery
{
    internal class Menu
    {
        public static void MainMenu(int position, int amount, string order)
        {
            int point = 0;
            string[] mainMenu = new[] { "Форма", "Размер", "Кол-во коржей", "Глазурь", "Конец заказа" };

            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            foreach (string item in mainMenu)
            {
                Console.SetCursorPosition(3, point);
                Console.WriteLine(item);
                point++;
            }

            Console.WriteLine("-------------------");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine($"Сумма заказа: {amount}");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine($"Ваш заказ: {order}");
        }
        public static void ShowMenu()
        {
            int amount = 0;
            string order = "";
            int position = 0;
            int page = 0;
            Console.CursorVisible = false;

            PointsOfMenu Form = new PointsOfMenu()
            {
                Points = new[] { "Круглый", "Квадратный", "Треугольный" },
                Costs = new[] { 100, 150, 120 }
            };
            PointsOfMenu Size = new PointsOfMenu()
            {
                Points = new[] { "Маленький", "Средний", "Большой" },
                Costs = new[] { 100, 150, 200 }
            };
            PointsOfMenu NumOfCakes = new PointsOfMenu()
            {
                Points = new[] { "2 коржа", "3 коржа", "4 коржа" },
                Costs = new[] { 50, 120, 180 }
            };
            PointsOfMenu Glaze = new PointsOfMenu()
            {
                Points = new[] { "Классическая", "Черная", "Белая" },
                Costs = new[] { 50, 100, 110 }
            };

            MainMenu(position, amount, order);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch(key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (page == 0)
                        {
                            if (position > 0)
                            {
                                Console.Clear();
                                position--;
                                MainMenu(position, amount, order);
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (page == 0)
                        {
                            if (position < 4)
                            {
                                Console.Clear();
                                position++;
                                MainMenu(position, amount, order);
                            }
                        }
                        break;
                    case ConsoleKey.Enter:
                        while (key.Key != ConsoleKey.Escape)
                        {
                            if (page == 0)
                            {
                                switch (position)
                                {
                                    case 0:
                                        page = 1;
                                        Console.Clear();
                                        DopMenu(Form, position = 0);
                                        break;
                                    case 1:
                                        page = 2;
                                        Console.Clear();
                                        DopMenu(Size, position = 0);
                                        break;
                                    case 2:
                                        page = 3;
                                        Console.Clear();
                                        DopMenu(NumOfCakes, position = 0);
                                        break;
                                    case 3:
                                        page = 4;
                                        Console.Clear();
                                        DopMenu(Glaze, position = 0);
                                        break;
                                    case 4:
                                        position = 1;
                                        FileWrite(order, amount);
                                        Console.Clear();
                                        Console.SetCursorPosition(3, 0);
                                        Console.WriteLine("Хотите сделать еще один заказ?");
                                        Console.SetCursorPosition(3, 1);
                                        Console.WriteLine("Да");
                                        Console.SetCursorPosition(3, 2);
                                        Console.WriteLine("Нет");
                                        Console.SetCursorPosition(0, position);
                                        Console.WriteLine("->");
                                        while (true)
                                        {
                                            key = Console.ReadKey();
                                            switch (key.Key)
                                            {
                                                case ConsoleKey.DownArrow:
                                                    if (position < 2)
                                                    {
                                                        Console.Clear();
                                                        Console.SetCursorPosition(3, 0);
                                                        Console.WriteLine("Хотите сделать еще один заказ?");
                                                        Console.SetCursorPosition(3, 1);
                                                        Console.WriteLine("Да");
                                                        Console.SetCursorPosition(3, 2);
                                                        Console.WriteLine("Нет");
                                                        Console.SetCursorPosition(0, position);
                                                        position++;
                                                        Console.SetCursorPosition(0, position);
                                                        Console.WriteLine("->");
                                                    }
                                                    break;
                                                case ConsoleKey.UpArrow:
                                                    if (position > 1)
                                                    {
                                                        Console.Clear();
                                                        Console.SetCursorPosition(3, 0);
                                                        Console.WriteLine("Хотите сделать еще один заказ?");
                                                        Console.SetCursorPosition(3, 1);
                                                        Console.WriteLine("Да");
                                                        Console.SetCursorPosition(3, 2);
                                                        Console.WriteLine("Нет");
                                                        Console.SetCursorPosition(0, position);
                                                        position--;
                                                        Console.SetCursorPosition(0, position);
                                                        Console.WriteLine("->");
                                                    }
                                                    break;
                                                case ConsoleKey.Enter:
                                                    if (position == 1)
                                                    {
                                                        order = "";
                                                        amount = 0;
                                                        page = 0;
                                                        Console.Clear();
                                                        MainMenu(position, amount, order);
                                                    }
                                                    else
                                                    {
                                                        Environment.Exit(0);
                                                    }
                                                    break;

                                            }
                                        }
                                        break;
                                }
                            }
                            else if (page != 0 && page != 5)
                            {
                                PointsOfMenu x;
                                key = Console.ReadKey();
                                if (page == 1)
                                {
                                    x = Form;
                                }
                                else if (page == 2)
                                {
                                    x = Size;
                                }
                                else if (page == 3)
                                {
                                    x = NumOfCakes;
                                }
                                else if (page == 4)
                                {
                                    x = Glaze;
                                }
                                else
                                {
                                    x = Form;
                                }
                                switch (key.Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        if (position > 0)
                                        {
                                            Console.Clear();
                                            position--;
                                            DopMenu(x, position);
                                        }
                                        break;
                                    case ConsoleKey.DownArrow:
                                        if (position < 2)
                                        {
                                            Console.Clear();
                                            position++;
                                            DopMenu(x, position);
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                        if (position == 0)
                                        {
                                            Console.SetCursorPosition(3, 4);
                                            Console.WriteLine("Добавлено!");
                                            amount += x.Costs[0];
                                            order += x.Points[0] + ", ";
                                        }
                                        else if (position == 1)
                                        {
                                            Console.SetCursorPosition(3, 4);
                                            Console.WriteLine("Добавлено!");
                                            amount += x.Costs[1];
                                            order += x.Points[1] + ", ";
                                        }
                                        else if (position == 2)
                                        {
                                            Console.SetCursorPosition(3, 4);
                                            Console.WriteLine("Добавлено!");
                                            amount += x.Costs[2];
                                            order += x.Points[2] + ", ";
                                        }
                                        break;
                                }
                            }
                        }
                        Console.Clear();
                        page = 0;
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");
                        MainMenu(position, amount, order);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void DopMenu(PointsOfMenu menu, int position)
        {
            Console.SetCursorPosition(3, 0);
            Console.WriteLine(menu.Points[0]);
            Console.SetCursorPosition(3, 1);
            Console.WriteLine(menu.Points[1]);
            Console.SetCursorPosition(3, 2);
            Console.WriteLine(menu.Points[2]);
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        static void FileWrite(string order, int amount)
        {
            Console.Clear();
            Random random_num = new Random();
            int number = random_num.Next(0, 1000);
            string text_bill = $"\nВремя заказа: {DateTime.Now}\n" + $"Номер заказа: A-{number}\n\tЗаказ: {order}\n\tК оплате: {amount} Рублей";
            if (File.Exists("C:/Users/alexa/OneDrive/Рабочий стол/Заказ.txt"))
            {
                File.AppendAllText("C:/Users/alexa/OneDrive/Рабочий стол/Заказ.txt", text_bill);
            }
            else
            {
                var bill = File.Create("\"C:\\Users\\Эдуард\\Desktop\"");
                bill.Close();
                File.AppendAllText("\"C:\\Users\\Эдуард\\Desktop\"");
            };
        }
    }
}
