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
    /// Welcome.xaml 的交互逻辑
    /// </summary>
    public partial class Welcome : Page
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private MainWindow parentWin;
        public MainWindow ParentWindow
        {
            get { return parentWin; }
            set { parentWin = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //information i = new information();
            luggage i = new luggage();             //应该是information
            i.ParentWindow = parentWin;
            parentWin.frame.Content = i;
            
        }
    }
}
