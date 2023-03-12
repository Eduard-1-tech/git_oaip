using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace budget
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public string zapis2;
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void dobavl2_Click(object sender, RoutedEventArgs e)
        {

            //MainWindow(zapisi2.Text);
            if (zapisi2.Text != "")
            {
                zapis2 = zapisi2.Text;
                DialogResult = true;
            }
            Close();

            //MessageBox.Show(zapis2);
        }
    }
}
