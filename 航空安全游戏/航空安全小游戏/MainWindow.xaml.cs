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
using 航空安全小游戏.page;

namespace 航空安全小游戏
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //frame.Source = new Uri("/page/Welcome.xaml", UriKind.Relative);
            //frame.Navigate(new Uri("/page/Welcome.xaml", UriKind.Relative));
            //Welcome a = new Welcome();
            cabin a = new cabin();
            frame.Content = a;
            a.ParentWindow = this;
            
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {


            button.Visibility = Visibility.Hidden;
            mediaElement.Pause();
            button1.Visibility = Visibility.Visible;


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Visible;
            mediaElement.Play();
            button1.Visibility = Visibility.Hidden;
        }
    }
}
