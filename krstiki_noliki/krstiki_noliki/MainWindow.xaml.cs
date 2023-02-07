using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace krstiki_noliki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random random = new Random();
        int rand;
        bool xz = true;
        int korn = 0;
        List<string> spisok1 = new List<string>() { "", "", "",
                                                    "", "", "", 
                                                    "", "", "" };
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in main_window.Children)
            {
                if (el is Button && el != start_game)
                {
                    ((Button)el).Click += Button_click;
                }
            }   
        }
        public void Button_click(object sender, RoutedEventArgs e)
        {
            string sym = "X";
            if (korn % 2 == 0)
            {
                sym = "O";
            }
            else
            {
                sym = "X";
            }
            ((Button)e.OriginalSource).Content = sym;
            ((Button)e.OriginalSource).IsEnabled= false;
            bool proverka =spisok1.Contains("");

            win(((Button)e.OriginalSource).Content.ToString());

            if (proverka==false)
            {
                Enablefalse();
            }
            else {Robot(); }   
        }
        private void win(string btnContent)
        {
            if ((b1.Content == btnContent & b2.Content == btnContent &
b3.Content == btnContent)
| (b1.Content == btnContent & b4.Content == btnContent &
b7.Content == btnContent)
| (b1.Content == btnContent & b5.Content == btnContent &
b9.Content == btnContent)
| (b2.Content == btnContent & b5.Content == btnContent &
b8.Content == btnContent)
| (b3.Content == btnContent & b6.Content == btnContent &
b9.Content == btnContent)
| (b4.Content == btnContent & b5.Content == btnContent &
b6.Content == btnContent)
| (b7.Content == btnContent & b8.Content == btnContent &
b9.Content == btnContent)
| (b3.Content == btnContent & b5.Content == btnContent &
b7.Content == btnContent))
            {
                if (btnContent == "O")
                {
                    textblock.Text = "нолики победили";
                }
                else if (btnContent == "X")
                {
                    textblock.Text = "крестики победили";
                }
                Enablefalse();
            }
            else
            {
                foreach (Button btn in main_window.Children)
                {
                    if (btn.IsEnabled == true)
                        return;
                }
                textblock.Text = "ничья";
            }
        }
        public void Robot()
        {
            string sym = "X";
            if (korn % 2 == 0)
            {
                sym = "X";
            }
            else
            {
                sym = "O";
            }
            bool tr = true;
            while (tr)
            {
                int rand = random.Next(1, 9);
                if (spisok1[rand - 1] != "O" && spisok1[rand - 1] != "X")
                {
                    switch (rand)
                    {
                        case 1:
                            b1.Content = sym;
                            b1.IsEnabled = false;
                            spisok1[0] = sym;
                            break;
                        case 2:
                            b2.Content = sym;
                            b2.IsEnabled = false;
                            spisok1[1] = sym;
                            break;
                        case 3:
                            b3.Content = sym;
                            b3.IsEnabled = false;
                            spisok1[2] = sym;
                            break;
                        case 4:
                            b4.Content = sym;
                            b4.IsEnabled = false;
                            spisok1[3] = sym;
                            break;
                        case 5:
                            b5.Content = sym;
                            b5.IsEnabled = false;
                            spisok1[4] = sym;
                            break;
                        case 6:
                            b6.Content = sym;
                            b6.IsEnabled = false;
                            spisok1[5] = sym;
                            break;
                        case 7:
                            b7.Content = sym;
                            b7.IsEnabled = false;
                            spisok1[6] = sym;
                            break;
                        case 8:
                            b8.Content = sym;
                            b8.IsEnabled = false;
                            spisok1[7] = sym;
                            break;
                        case 9:
                            b9.Content = sym;
                            b9.IsEnabled = false;
                            spisok1[8] = sym;
                            break;
                        default: break;

                    }
                    tr = false;   
                }
            }
        }
        public void Enabletrue()
        {

            foreach (UIElement el in main_window.Children)
            {
                if (el is Button )
                {
                    el.IsEnabled = true;

                }
            }
        }
        public void Enablefalse()
        {
            b1.IsEnabled= false;
            b2.IsEnabled= false;
            b3.IsEnabled= false;
            b4.IsEnabled= false;
            b5.IsEnabled= false;
            b6.IsEnabled= false;
            b7.IsEnabled= false;
            b8.IsEnabled= false;
            b9.IsEnabled= false;
        }
        public void Ochistka()
        {
            b1.Content = " ";
            b2.Content = " ";
            b3.Content = " ";
            b4.Content = " ";
            b5.Content = " ";
            b6.Content = " ";
            b7.Content = " ";
            b8.Content = " ";
            b9.Content = " ";
            textblock.Text= " ";
        }
        private void start_game_Click(object sender, RoutedEventArgs e)
        {
            Ochistka();
            for (int i = 0; i < 9; i++)
            {
                spisok1[i] = "";
            }
            korn += 1;
            Enabletrue();
        }

        public string sym()
        {
            string symb = "X";
            if (korn % 2 == 0)
            {
                symb = "O";
            }
            else
            {
                symb = "X";
            }
            return symb;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[0] = symb;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[1] = symb;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[2] = symb;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[3] = symb;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[4] = symb;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[5] = symb;
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[6] = symb;
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[7] = symb;
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            string symb = sym();
            spisok1[8] = symb;
        }
    }
}
