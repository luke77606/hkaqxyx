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
    /// cabin.xaml 的交互逻辑
    /// </summary>
    public partial class cabin : Page
    {
        public cabin()
        {
            InitializeComponent();
        }
        private MainWindow parentWin;
        public MainWindow ParentWindow
        {
            get { return parentWin; }
            set { parentWin = value; }
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            door.Source = (new BitmapImage(new Uri("/航空安全小游戏;component/photo/安全门2.png", UriKind.RelativeOrAbsolute)));
            //door.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            door.Source = (new BitmapImage(new Uri("/航空安全小游戏;component/photo/white.png", UriKind.RelativeOrAbsolute)));
        }

        private void door_MouseDown(object sender, MouseButtonEventArgs e)
        {
            cab.Source = (new BitmapImage(new Uri("/航空安全小游戏;component/photo/安全门1.jpg", UriKind.RelativeOrAbsolute)));
            door.Visibility = Visibility.Hidden;
            text1.Visibility = Visibility.Visible;
            text2.Visibility = Visibility.Hidden;
            canvas.Visibility = Visibility.Hidden;

        }
    }
}
