namespace Diary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Page();
        }
        static void Page()
        {
            int page = 0;
            int arrowPosition = 1;
            
            Page firstPage = new Page()
            {
                date = new DateTime(2022, 10, 19),
                notes = new string[] { "Позавтракать", "Написать философию" }
            };
            Page secondPage = new Page()
            {
                date = new DateTime(2022, 10, 20),
                notes = new string[] { "Сделать практическую ", "Посмотреть аниме", "Лечь спать до 23:00" }
            };
            Page thirdPage = new Page()
            {
                date = new DateTime(2022, 10, 21),
                notes = new string[] { "Поиграть в компьютер", "Сделать дз" }
            };

            Console.SetCursorPosition(0, arrowPosition);
            showPage(firstPage);
            
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        arrowPosition = 1;

                        if (page == 0)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(secondPage);
                            page++;
                        }
                        else if (page == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(thirdPage);
                            page++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        arrowPosition = 1;

                        if (page == 2)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(secondPage);
                            page--;
                        }
                        else if (page == 1)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(firstPage);
                            page--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (key.Key == ConsoleKey.DownArrow && page == 0)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(firstPage);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && page == 1)
                        {
                            arrowPosition++;
                            if (arrowPosition > 5)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(secondPage);
                        }
                        else if (key.Key == ConsoleKey.DownArrow && page == 2)
                        {
                            arrowPosition++;
                            if (arrowPosition > 4)
                            {
                                arrowPosition--;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(thirdPage);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (key.Key == ConsoleKey.UpArrow && page == 0)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(firstPage);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && page == 1)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(secondPage);
                        }
                        else if (key.Key == ConsoleKey.UpArrow && page == 2)
                        {
                            arrowPosition--;
                            if (arrowPosition < 1)
                            {
                                arrowPosition++;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(0, arrowPosition);
                            showPage(thirdPage);
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (page)
                        {
                            case 0:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {firstPage.date}");
                                    Console.WriteLine("<------------описание дела------------->");
                                    Console.WriteLine("Сделать чай и бутерброды с колбасой.");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {firstPage.date}");
                                    Console.WriteLine("<------------описание дела------------->");
                                    Console.WriteLine("Написать практическую ");
                                }
                                break;
                            case 1:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {secondPage.date}");
                                    Console.WriteLine("<------------описание дела------------->");
                                    Console.WriteLine("Нужно доделать два задания и сделать отчет по практической Python.");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {secondPage.date}");
                                    Console.WriteLine("<------------описание дела------------->");
                                    Console.WriteLine("Найти какой-нибудь интересный фильм на часа 2 и посмотреть его.");
                                }
                                else if (arrowPosition == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {secondPage.date}");
                                    Console.WriteLine("<------------описание дела------------->");
                                    Console.WriteLine("Необходимо лечь до 23:00");
                                }
                                break;
                            case 2:
                                if (arrowPosition == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {thirdPage.date}");
                                    Console.WriteLine("<------------описание дела------------->");
                                    Console.WriteLine("Поиграть во что-нибудь");
                                }
                                else if (arrowPosition == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Выбарана дата: {thirdPage.date}");
                                    Console.WriteLine("<------------описание дела------------->");
                                    Console.WriteLine("Сделать дз по ИТ");
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void showPage(Page currentPage)
        {
            Console.WriteLine("-->");
            Console.SetCursorPosition(3, 0);
            Console.WriteLine(currentPage.date);
            Console.CursorVisible = false;

            int i = 1;
            foreach (string n in currentPage.notes)
            {
                i++;
                Console.SetCursorPosition(3, i);
                Console.WriteLine(n);
            }
        }
    }
}
 namespace Diary
{
    internal class Page
    {
        public DateTime date;
        public string[] notes;
    }
}