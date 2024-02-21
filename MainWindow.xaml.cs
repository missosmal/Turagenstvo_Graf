using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Turagenstvo_Graf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public static Connection connect;
        public static Pages.Main main;
        public static Login_win login;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            connect = new Connection();
            main = new Pages.Main();
            login = new Login_win();
            OpenPageLogin();
        }


        public void OpenPageLogin()
        {
            DoubleAnimation opgridAnimation = new DoubleAnimation();
            opgridAnimation.From = 1;
            opgridAnimation.To = 0;
            opgridAnimation.Duration = TimeSpan.FromSeconds(0.6);
            opgridAnimation.Completed += delegate
            {
                frame.Navigate(login);

                DoubleAnimation opgtisdAnimation = new DoubleAnimation();
                opgtisdAnimation.From = 0;
                opgtisdAnimation.To = 1;
                opgtisdAnimation.Duration = TimeSpan.FromSeconds(1.2);

                frame.BeginAnimation(Frame.OpacityProperty, opgtisdAnimation);
            };

            frame.BeginAnimation(Frame.OpacityProperty, opgridAnimation);
        }

        public void OpenPageMain()
        {
            DoubleAnimation opgridAnimation = new DoubleAnimation();
            opgridAnimation.From = 1;
            opgridAnimation.To = 0;
            opgridAnimation.Duration = TimeSpan.FromSeconds(0.6);
            opgridAnimation.Completed += delegate
            {
                frame.Navigate(main);

                DoubleAnimation opgtisdAnimation = new DoubleAnimation();
                opgtisdAnimation.From = 0;
                opgtisdAnimation.To = 1;
                opgtisdAnimation.Duration = TimeSpan.FromSeconds(1.2);

                frame.BeginAnimation(Frame.OpacityProperty, opgtisdAnimation);
            };

            frame.BeginAnimation(Frame.OpacityProperty, opgridAnimation);
        }
    }
}
