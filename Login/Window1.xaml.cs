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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(string email)
        {
            InitializeComponent();
            EmailLabel.Content = email;
            if (Directory.Exists(@"C:\Logins\" + EmailLabel.Content + @"\description.txt"))
            {

                using (StreamReader sr = new StreamReader(@"C:\Logins\" + EmailLabel.Content + @"\description.txt", System.Text.Encoding.Default))
                {
                    string line;
                    line = sr.ReadLine();
                    {
                        Console.WriteLine(line);
                    }
                    description.Text = line;
                }
            }

        }
        private string email;

        private void DeskChange(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(@"C:\Logins\" + EmailLabel.Content + @"\description.txt", description.Text);
        }
    }
}
