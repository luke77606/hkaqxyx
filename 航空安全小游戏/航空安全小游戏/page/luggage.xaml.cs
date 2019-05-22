using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// luggage.xaml 的交互逻辑
    /// </summary>
    public partial class luggage : Page
    {
        public luggage()
        {
            InitializeComponent();

           
        }
        private MainWindow parentWin;

        private int tasknum=0;
        public MainWindow ParentWindow
        {
            get { return parentWin; }
            set { parentWin = value; }
        }

        private async void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Thread t = new Thread(moveit);
            //t.Start(sender);
            await Dispatcher.InvokeAsync(() => Moveit1(sender));   //p91,调度器隐式创建执行任务
            //Task a = method1(sender);
            //a.RunSynchronously();
            //Task b = method1(lgm);
            //Task.Run(() => moveit(sender));
        }
       
        private async Task Moveit1(object sender)
        {
            tasknum += 1;
            button.IsEnabled = false;
            Image im = (Image)sender;
            //im.Dispatcher.Invoke(() =>
            //{
                im.IsEnabled = false;
                Thickness m = new Thickness(im.Margin.Left, im.Margin.Top, im.Margin.Right, im.Margin.Bottom);
                int led = (int)m.Left;
                if (m.Left <= 370)
                {
                    do
                    {
                        m.Left += 3;
                        im.Margin = m;
                        App.DoEvents();
                        System.Threading.Thread.Sleep(3);
                    await Task.Delay(1);
                    } while (int.Parse(im.Margin.Left.ToString()) <= led + 480);
                }
                else
                {
                    do
                    {
                        m.Left -= 3;
                        im.Margin = m;
                        App.DoEvents();
                        System.Threading.Thread.Sleep(3);
                    await Task.Delay(1);
                } while (int.Parse(im.Margin.Left.ToString()) >= led - 480);
                }
                im.IsEnabled = true;
            //}
            //    );
            if (tasknum==1)
            {
              button.IsEnabled = true;
            }
            tasknum -= 1;
        }


        //private async Task method1(object sender)
        //{
        //    Image im = (Image)sender;
        //    im.Dispatcher.Invoke(() =>
        //    {
        //        im.IsEnabled = false;
        //        Thickness m = new Thickness(im.Margin.Left, im.Margin.Top, im.Margin.Right, im.Margin.Bottom);
        //        int led = (int)m.Left;
        //        if (m.Left <= 370)
        //        {
        //            do
        //            {
        //                m.Left += 2;
        //                im.Margin = m;
        //                App.DoEvents();
        //                System.Threading.Thread.Sleep(3);
        //            } while (int.Parse(im.Margin.Left.ToString()) <= led + 480);
        //        }
        //        else
        //        {
        //            do
        //            {
        //                m.Left -= 2;
        //                im.Margin = m;
        //                App.DoEvents();
        //                System.Threading.Thread.Sleep(3);
        //            } while (int.Parse(im.Margin.Left.ToString()) >= led - 480);
        //        }
        //        im.IsEnabled = true;
        //    }
        //        );

        //}
        //private  void moveit(object sender)
        //{
        //    Image im = (Image)sender;
        //    im.Dispatcher.Invoke(() =>
        //    {
        //    im.IsEnabled = false;
        //    Thickness m = new Thickness(im.Margin.Left, im.Margin.Top, im.Margin.Right, im.Margin.Bottom);
        //    int led = (int)m.Left;
        //    if (m.Left <= 370)
        //    {
        //        do
        //        {
        //            m.Left += 2;
        //            im.Margin = m;
        //            App.DoEvents();
        //            System.Threading.Thread.Sleep(3);
        //        } while (int.Parse(im.Margin.Left.ToString()) <= led + 480);
        //    }
        //    else
        //    {
        //        do
        //        {
        //            m.Left -= 2;
        //            im.Margin = m;
        //            App.DoEvents();
        //            System.Threading.Thread.Sleep(3);
        //        } while (int.Parse(im.Margin.Left.ToString()) >= led - 480);
        //    }
        //    im.IsEnabled = true;
        //    }
        //        );
            
        //}

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
