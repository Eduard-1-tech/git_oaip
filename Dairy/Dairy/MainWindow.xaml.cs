using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace Dairy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {

            InitializeComponent();
            BindingList<zametki> zametki;
            zametki = ster.get();
            //zametki zametki = new zametki();
            zametki = ster.get();

            calendar.SelectedDate = DateTime.Now;
            showzametki();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        
        public void showzametki()
        {
            BindingList<zametki> zametki;
            BindingList<zametki> zapis = new BindingList<zametki>();
            foreach (zametki note in zametki)
            {
                if (note.date == calendar.SelectedDate)
                {
                    zapis.Add(note);
                }
                z1.Content = zapis;
                
            }
            ster.save(zametki);
        }




        private void dobavl_Click_1(object sender, RoutedEventArgs e)
        {
zametki zametki = new zametki();

List<zametki> zametka = new List<zametki>();
   if (name.Text!="")
   {
       zametki.name= name.Text;
       zametki.opisanie= opisanie.Text;
       zametki.date = calendar.DisplayDate;

   }
   
   zametka.Add(zametki);
            ster.save(zametka);
   

   name.Text = string.Empty;
   opisanie.Text = string.Empty;
        }

        private void re_Click(object sender, RoutedEventArgs e)
        {
            zametki zametki = new zametki();
            List<zametki> zametka = new List<zametki>();


        }

        private void dalete_Click(object sender, RoutedEventArgs e)
        {
            BindingList<zametki> zametki;
            foreach (zametki note in zametki)
            {
                if (note == z1.Content)
                {
                    zametki.Remove(note);
                    break;
                }
            }
            showzametki();

        }
    }
}
