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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Click(object sender, MouseButtonEventArgs e)
        {
            Button button = new Button();
            button.Content = "Кнопка";
            button.Width = 100;
            button.Height = 50;
            Canvas.SetLeft(button, e.GetPosition(canvas).X);            
            Canvas.SetTop(button, e.GetPosition(canvas).Y);
            canvas.Children.Add(button);
        }
    }
}
