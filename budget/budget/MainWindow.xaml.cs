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
using budget.model;

namespace budget
{
    
    public partial class MainWindow : Window
    {
        

        public int summa = 0;
        public DateTime Date { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            
            List<string> types = ster.Read2();
            listtypes.ItemsSource = types;

            
            List<dannie> dannies = ster.Read();
            datagrid.ItemsSource = dannies;

            sum.Text = summa.ToString();


        }
        

        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {/*
            _comedata = new BindingList<datagrid>()
            {
                new datagrid() { Name="test",Type="12",Money=1,isDone=true},
                new datagrid() { Name = "fdg" }

            };
            datagrid.ItemsSource = _comedata;
        */}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void dob_type_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow window = new SecondWindow();
            window.ShowDialog();

            if (window.DialogResult == true)
            {
                ster.Save2(window.zapis2);
                List<string> types = ster.Read2();
                listtypes.ItemsSource = types;
            }



        }



        private void dobavl_Click(object sender, RoutedEventArgs e)
        {
            List < dannie > dannies=ster.Read();
            dannie dannie = new dannie();
            if (name.Text != "" && (listtypes.SelectedValue).ToString() != "")
            {
                dannie.Name = name.Text;
                dannie.Type = listtypes.SelectedValue.ToString();
                if (int.Parse(mon.Text) < 0)
                {
                    dannie.Money = Math.Abs(int.Parse(mon.Text));
                    dannie.isDone = false;

                }
                else
                {
                    dannie.Money = int.Parse(mon.Text);
                    dannie.isDone = true;
                }
                
                dannie.Date = calendar.DisplayDate;
                summa += int.Parse(mon.Text);
                sum.Text = summa.ToString();
                dannies.Add(dannie);
                ster.save(dannies);

                name.Text = "";
                mon.Text = "";

                List<string> types = ster.Read2();
                listtypes.ItemsSource = types;
                datagrid.ItemsSource = dannies;
                
            }
            else
            {
                MessageBox.Show("Нет имени или типа записи");
            }

            

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            List<dannie> dannies = ster.Read();
            dannie zamdel=dannies.FirstOrDefault(u=>u.Name == name.Text);  
            if (zamdel != null)
            {
                dannies.Remove(zamdel);
                ster.save(dannies);
            }
            summa -= int.Parse(mon.Text);
            sum.Text = summa.ToString();
            name.Text = "";
            mon.Text = "";
            List<string> types = ster.Read2();
            listtypes.ItemsSource = types;
            datagrid.ItemsSource = dannies;

        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dannie selected = datagrid.SelectedItem as dannie;
            if (selected != null)
            {
                name.Text = selected.Name;
                listtypes.ItemsSource = selected.Type;
                mon.Text = selected.Money.ToString();
            }
            List<string> types = ster.Read2();
            listtypes.ItemsSource = types;
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {

            List<dannie> dannies = ster.Read();
            dannie dannie = new dannie();
            if (name.Text != "" && (listtypes.SelectedValue).ToString() != "")
            {
                dannie.Name = name.Text;
                dannie.Type = listtypes.SelectedValue.ToString();
                if (int.Parse(mon.Text) < 0)
                {
                    dannie.Money = Math.Abs(int.Parse(mon.Text));
                    dannie.isDone = false;

                }
                else
                {
                    dannie.Money = int.Parse(mon.Text);
                    dannie.isDone = true;
                }

                dannie.Date = calendar.DisplayDate;
                
                dannies.Add(dannie);
                ster.save(dannies);
                datagrid.ItemsSource = dannies;

            }
            else
            {
                MessageBox.Show("Нет имени или типа записи");
            }

            List<dannie> dannies2 = ster.Read();
            dannie zamdel = dannies2.FirstOrDefault(u => u.Name == name.Text);
            if (zamdel != null)
            {
                dannies2.Remove(zamdel);
                ster.save(dannies2);
            }
            
            name.Text = "";
            mon.Text = "";
            List<string> types = ster.Read2();
            listtypes.ItemsSource = types;
            datagrid.ItemsSource = dannies;
        }
       
        
    }
}
