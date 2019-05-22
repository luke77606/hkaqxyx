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

namespace 航空安全小游戏.page
{
    /// <summary>
    /// information.xaml 的交互逻辑
    /// </summary>
    public partial class information : Page
    {
        public information()
        {
            InitializeComponent();
        }
        private MainWindow parentWin;
        public MainWindow ParentWindow
        {
            get { return parentWin; }
            set { parentWin = value; }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            player.name = this.name.Text;
            player.money = 10000;
            player.start= this.start.Text;
            player.destination = this.destination.Text;
            player.date=date.Text;
            parentWin.name0.Content = "姓名：";
            parentWin.name.Content = player.name;
            parentWin.money0.Content = "金钱:";
            parentWin.money.Content = player.money;
            luggage i = new luggage();
            i.ParentWindow = parentWin;
            parentWin.frame.Content = i;
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (name.Text != "" && start.Text != "" && destination.Text != "" && date.Text != "" && (adult.IsChecked == true || child.IsChecked == true))
            {
                button.IsEnabled = true;
            }
            else { button.IsEnabled = false; }
        }

        private void date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (name.Text != "" && start.Text != "" && destination.Text != "" && date.Text != "" && (adult.IsChecked == true || child.IsChecked == true))
            {
                button.IsEnabled = true;
            }
            else { button.IsEnabled = false; }
        }

        private void adult_Checked(object sender, RoutedEventArgs e)
        {
            if (name.Text != "" && start.Text != "" && destination.Text != "" && date.Text != "" && (adult.IsChecked == true || child.IsChecked == true))
            {
                button.IsEnabled = true;
            }
            else { button.IsEnabled = false; }
        }
    }
}
