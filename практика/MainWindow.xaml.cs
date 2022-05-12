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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace практика
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Пароль.IsEnabled = false;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Номер.Text = string.Empty;
            Пароль.Text = string.Empty;
            Код.Text = string.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Номер.Text==string.Empty||Пароль.Text==string.Empty)
            {
                MessageBox.Show("Введите данные");
                return;
            }
            using(praktikaEntities context=new praktikaEntities())
            {
               var parol=  context.Работники.FirstOrDefault(ak => ak.Номер == Номер.Text);
                if(parol!=null)
            }
        }
    }
}
