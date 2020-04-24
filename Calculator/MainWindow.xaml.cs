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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double number1;
        private double number2;
        private bool q = false;
        private bool qq = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DefaultButtonClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            t.Text += b.Content;
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            t.Text = "";
            q = false;
        }

        private void DotButtonClick(object sender, RoutedEventArgs e)
        {
            if (!q && t.Text != "")
            {
                t.Text += ".";
                q = true;
            }

        }

        private void Task(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            number1 = Convert.ToDouble(t.Text);
            tt.Text = t.Text + " " + b.Content;
            t.Text = "";
            q = false;
            qq = false;
        }

        private void Equals(object sender, RoutedEventArgs e)
        {
            if (qq) return;
            number2 = Convert.ToDouble(t.Text);
            switch(tt.Text[tt.Text.Length - 1])
            {
                case '+':
                    t.Text = (number1 + number2).ToString();
                    break;
                case '-':
                    t.Text = (number1 - number2).ToString();
                    break;
                case '*':
                    t.Text = (number1 * number2).ToString();
                    break;
                case '/':
                    t.Text = (number1 / number2).ToString();
                    break;


            }
            tt.Text += " " + number2 + " =";
            qq = true;
        }
    }
}
