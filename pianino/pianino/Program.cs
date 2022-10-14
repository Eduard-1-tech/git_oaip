

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Чтобы выбрать октаву нажмите клавишы от F4 до F7\n");
            Console.WriteLine("можно играть клавишами q-u,s-h");
            Sound();
        }
        private static ConsoleKeyInfo GetPianoKey() { return Console.ReadKey(true); }
        private static int[] GetOctav(int Noctav)
        {
            switch (Noctav)
            {

                case 0:
                    Console.WriteLine("Октава 4");
                    return new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                case 1:
                    Console.WriteLine("Октава 5");
                    return new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                case 2:
                    Console.WriteLine("Октава 6");
                    return new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                case 3:
                    Console.WriteLine("Октава 7");
                    return new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                default: return new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            }
        }
        private static void Sound()
        {
            int[] hz = GetOctav(4);
            ConsoleKeyInfo inf = GetPianoKey();
            while (true)
            {

                switch (inf.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(hz[0], 500);
                        Console.WriteLine(hz[0]);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(hz[1], 500);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(hz[2], 500);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(hz[3], 500);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(hz[4], 500);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(hz[5], 500);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(hz[6], 500);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(hz[7], 500);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(hz[8], 500);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(hz[9], 500);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(hz[10], 500);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(hz[11], 500);
                        break;
                    case ConsoleKey.F4:
                        hz = GetOctav(0);
                        break;
                    case ConsoleKey.F5:
                        hz = GetOctav(1);
                        break;
                    case ConsoleKey.F6:
                        hz = GetOctav(2);
                        break;
                    case ConsoleKey.F7:
                        hz = GetOctav(3);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
                inf = GetPianoKey();
            }
        }
    }
}