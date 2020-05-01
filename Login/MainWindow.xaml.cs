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
using System.IO;


namespace Login
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool r = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (!r)
            {
                string pname = email.Text;
                string pplus = @"C:\Logins\";

                if (Directory.Exists(pplus + pname))
                {

                    if ("i" == password.Text)
                    {
                        info.Text = "Signed in as " + email.Text;
                    }
                    else
                    {
                        info.Text = "Wrong password";
                    }
                }
                else
                {
                    info.Text = "This email is not registered";
                }
            }
            else
            {
                string pname = email.Text;
                string pplus = @"C:\Logins\";
                Directory.CreateDirectory(pname + pplus);
                File.WriteAllText(pname + pplus + @"\password.txt",password.Text);
            }

        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            reg.IsEnabled = false;
            reg.Content = "registrating";
            b.Content = "register";
            r = true;
        }
    }
}
