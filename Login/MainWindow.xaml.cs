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
        bool IsEmailEmpty=true;
        bool IsPasswordEmpty=true;

        private bool r = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string pname = email.Text;
            string pplus = @"C:\Logins\";
            if (!r)
            {

                if (Directory.Exists(pplus + pname))
                {

                    using (StreamReader sr = new StreamReader(pplus+pname+@"\password.txt", System.Text.Encoding.Default))
                    {
                        string line;
                        line = sr.ReadLine();
                        {
                            Console.WriteLine(line);
                        }
                        if (line == password.Text)
                        {
                            Window1 w = new Window1(email.Text);
                            w.Show();
                            this.Close();
                        }
                        else
                        {
                            info.Text = "Wrong password";
                        }
                    }
                }
                else
                {
                    info.Text = "This email is not registered";
                }
            }
            else
            {
                if(Directory.Exists(pplus + pname))
                {
                    info.Text = "This email is already registered";
                }
                else
                {
                    bool condition = false;
                    try 
                    {
                        condition = email.Text.Remove(0, email.Text.Length - 10) == "@gmail.com";
                    }

                    catch (Exception ex)
                    {
                    MessageBox.Show("email lenth can not be less than 11 symbols");
                    }
                    if (condition && email.Text.Length>10)
                    {
                        Directory.CreateDirectory(pplus + pname);
                        File.WriteAllText(pplus + pname + @"\password.txt", password.Text);
                        Window1 w = new Window1(email.Text);
                        w.Show();
                        this.Close();
                    }
                    else info.Text = "This is wrong email point";
                }
            }

        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            reg.IsEnabled = false;
            reg.Content = "registrating";
            b.Content = "register";
            r = true;
            info.Text = "";
        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (email.Text.Length > 0) IsEmailEmpty = false;
            else IsEmailEmpty = true;
            if (IsEmailEmpty == false && IsPasswordEmpty == false) b.IsEnabled = true;
            else b.IsEnabled = false;
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (password.Text.Length > 0) IsPasswordEmpty = false;
            else IsPasswordEmpty = true;
            if (IsEmailEmpty == false && IsPasswordEmpty == false) b.IsEnabled = true;
            else b.IsEnabled = false;
        }
    }
}
