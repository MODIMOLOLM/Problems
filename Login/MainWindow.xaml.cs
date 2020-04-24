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

namespace Login
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[,] gcloud= { { "m@gmail.com", "lolfunnypassword" }, { "sanis@gmail.com","oMMgH" } };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            bool k = false;
            for (int i = 0; i < 2; i++)
            {
                if (email.Text == gcloud[i, 0])
                {
                    b.Content = "done!";
                    k = true;
                }
            }
            for (int i=0;i<2;i++)
            {
                if(email.Text==gcloud[i,0]&&password.Text==gcloud[i,1])
                {
                    b.Content = "done!";
                    k=true;
                }
            }
            if (!k) b.Content = "wrong email or password";
        }
    }
}
