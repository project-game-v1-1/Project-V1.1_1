using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

namespace Игра_V1._1
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

        private void Go_Click_1(object sender, RoutedEventArgs e)
        {
            Pb2.IsEnabled = true;
            P4.Opacity = 0;
            P3.Opacity = 100;
            Ba1.Opacity = 0;
            Ba2.Opacity = 0;
            Vs.Text = null;
            Vs.IsEnabled = false;
            BA1.IsEnabled = true;
            BA2.IsEnabled = true;
            BF1.IsEnabled = true;
            BF2.IsEnabled = true;
            Ba1.IsEnabled = false;
            Ba2.IsEnabled = false;
            Pb1.IsEnabled = true;
            Pb2.IsEnabled = true;
            Pb1.Value = Pb1.Value + 100;
            Pb2.Value = Pb2.Value + 100;
            Go.IsEnabled = false;
            Go.Opacity = 0;
            Panel.SetZIndex(BA2, 7);
            Panel.SetZIndex(Ba2, 7);
            Panel.SetZIndex(BF2, 7);
            Panel.SetZIndex(Pb2, 7);
            Panel.SetZIndex(BA3, 0);
            Panel.SetZIndex(BF3, 0);
            Panel.SetZIndex(Ba3, 0);
            Panel.SetZIndex(Pb3, 0);


        }

        private void BA1_Click_2(object sender, RoutedEventArgs e)
        {
            if (Text2.IsEnabled == true && Text1.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                Pb2.Value = Pb2.Value - 11;
                BF1.IsEnabled = false;
                BA1.IsEnabled = false;
                BA2.IsEnabled = true;
                BF2.IsEnabled = true;
            }
            if (Text3.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                Pb3.Value = Pb3.Value - 11;
                Ba1.IsEnabled = false;
                BF1.IsEnabled = false;
                BA1.IsEnabled = false;
                BA3.IsEnabled = true;
                BF3.IsEnabled = true;
            }

            if (Text1.Text == ("GOLD EXPERENICE RECVIEM") && Text2.IsEnabled==true)
            {
                Pb2.Value = Pb2.Value - 50;
            }
            if (Text1.Text == ("GOLD EXPERENICE RECVIEM") && Text3.IsEnabled == true)
            {
                Pb3.Value = Pb3.Value - 40;
            }
        }

        private void BA2_Click_2(object sender, RoutedEventArgs e)
        {
            if (Text1.IsEnabled == true && Text2.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                BF2.IsEnabled = false;
                BA2.IsEnabled = false;
                Ba2.IsEnabled = false;
                BF1.IsEnabled = true;
                BA1.IsEnabled = true;
                Pb1.Value = Pb1.Value - 13;
            }
            if (Text1.Text == ("GOLD EXPERENICE RECVIEM"))
            {
                Ba1.IsEnabled = false;
            }
        }

        private void BF1_Click_1(object sender, RoutedEventArgs e)
        {
            if (Text1.IsEnabled == true && Text2.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                BF1.IsEnabled = false;
                BA1.IsEnabled = false;
                BF2.IsEnabled = true;
                BA2.IsEnabled = true;
                if (Text1.Text == ("Gold Experince"))
                {
                    Pb1.Value = Pb1.Value + 5;
                }

                if (Text1.Text == ("GOLD EXPERENICE RECVIEM"))
                {
                    Pb1.Value = Pb1.Value + 50;
                }
            }
            if (Text1.IsEnabled == true && Text3.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                BF1.IsEnabled = false;
                BA1.IsEnabled = false;
                BF3.IsEnabled = true;
                BA3.IsEnabled = true;
                if (Text1.Text == ("Gold Experince"))
                {
                    Pb1.Value = Pb1.Value + 5;
                }

                if (Text1.Text == ("GOLD EXPERENICE RECVIEM"))
                {
                    Pb1.Value = Pb1.Value + 50;
                }
            }
        }

        private void BF2_Click(object sender, RoutedEventArgs e)
        {
            if (Text1.IsEnabled == true && Text2.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                BF2.IsEnabled = false;
                BA2.IsEnabled = false;
                Ba2.IsEnabled = false;
                BF1.IsEnabled = true;
                BA1.IsEnabled = true;
                if (Text2.Text == "KINGO KRIMSON EPITAFE")
                {
                    Ba2.IsEnabled = false;
                }

                if (Text2.Text == ("Kingo Krimson"))
                {
                    Pb2.Value = Pb2.Value + 3;
                }

                if (Text2.Text == ("KINGO KRIMSON EPITAFE"))
                {
                    Pb2.Value = Pb2.Value + 10;
                }
            }
        }

        private void Pb2_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Text1.IsEnabled == true && Text2.IsEnabled == true)
            {


                if (Pb2.Value == 0 && Text1.IsEnabled == true)
                {
                    MessageBox.Show("Good Grief");
                    Go.IsEnabled = true;
                    Ba1.IsEnabled = false;
                    BA1.IsEnabled = false;
                    BA2.IsEnabled = false;
                    BF1.IsEnabled = false;
                    BF2.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    Ba2.IsEnabled = false;
                    Pb1.IsEnabled = false;
                    Pb2.IsEnabled = false;
                    Go.Opacity = 100;
                }

                if (Pb2.Value <= 35)
                {
                    Ba2.Opacity = 100;
                    Ba2.IsEnabled = true;
                }
            }

        }

        private void Pb1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Text1.IsEnabled == true && Text2.IsEnabled == true)
            {
                if (Pb1.Value <= 0 && Text1.IsEnabled == true)
                {
                    MessageBox.Show("...");
                    Go.IsEnabled = true;
                    BA1.IsEnabled = false;
                    BA2.IsEnabled = false;
                    BF1.IsEnabled = false;
                    BF2.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    Ba2.IsEnabled = false;
                    Pb1.IsEnabled = false;
                    Pb2.IsEnabled = false;
                    Go.Opacity = 100;
                }

                if (Pb1.Value <= 40)
                {
                    Ba1.IsEnabled = true;
                    Ba1.Opacity = 100;
                }
            }

            if (Text1.IsEnabled == true && Text3.IsEnabled == true)
            {
                if (Pb1.Value <= 0 && Text1.IsEnabled == true)
                {
                    MessageBox.Show("YAV TOSU");
                    Go.IsEnabled = true;
                    BA1.IsEnabled = false;
                    BA3.IsEnabled = false;
                    BF1.IsEnabled = false;
                    BF3.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    Ba3.IsEnabled = false;
                    Pb1.IsEnabled = false;
                    Pb3.IsEnabled = false;
                    Go2.Opacity = 100;
                }
                if (Pb1.Value <= 0 && Text1.IsEnabled == true && Text3.Text=="WhiteSnake")
                {
                    MessageBox.Show("ARIVEDERCHI");
                    Go.IsEnabled = true;
                    BA1.IsEnabled = false;
                    BA3.IsEnabled = false;
                    BF1.IsEnabled = false;
                    BF3.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    Ba3.IsEnabled = false;
                    Pb1.IsEnabled = false;
                    Pb3.IsEnabled = false;
                    Go2.Opacity = 100;
                }
                if (Pb3.Value <= 0 && Text1.IsEnabled == true && Pb1.Value<=99)
                {
                    MessageBox.Show("Good Grief");
                    Go.IsEnabled = true;
                    BA1.IsEnabled = false;
                    BA3.IsEnabled = false;
                    BF1.IsEnabled = false;
                    BF3.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    Ba3.IsEnabled = false;
                    Pb1.IsEnabled = false;
                    Pb3.IsEnabled = false;
                    Go2.Opacity = 100;
                }
                if (Pb1.Value <= 40)
                {
                    Ba1.IsEnabled = true;
                    Ba1.Opacity = 100;
                }
            }
        }

        private void Ba1_Click(object sender, RoutedEventArgs e)
            {
                if (Text1.IsEnabled == true && Text2.IsEnabled == true)
                {
                    MessageBox.Show("GOLD EXPERENICE RECVIEM!");
                    Text1.Text = ("GOLD EXPERENICE RECVIEM");
                    P4.Opacity = 100;
                    P3.Opacity = 0;
                    BF1.IsEnabled = false;
                    BA1.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    BF2.IsEnabled = true;
                    BA2.IsEnabled = true;
                    if (Text1.Text == "GOLD EXPERENICE RECVIEM!")
                    {
                        Ba1.IsEnabled = false;
                    }
                }
                if (Text1.IsEnabled == true && Text3.IsEnabled == true)
                {
                    MessageBox.Show("GOLD EXPERENICE RECVIEM!");
                    Text1.Text = ("GOLD EXPERENICE RECVIEM");
                    P4.Opacity = 100;
                    P3.Opacity = 0;
                    BF1.IsEnabled = false;
                    BA1.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    BF3.IsEnabled = true;
                    BA3.IsEnabled = true;
                    if (Text1.Text == "GOLD EXPERENICE RECVIEM!")
                    {
                        Ba1.IsEnabled = false;
                    }
                }
        }
        

        private void Ba2_Click(object sender, RoutedEventArgs e)
        {
            if (Text1.IsEnabled == true && Text2.IsEnabled == true)
            {
                MessageBox.Show("WHAT?!");
                Text2.Text = ("KINGO KRIMSON EPITAFE");
                BF2.IsEnabled = false;
                BA2.IsEnabled = false;
                Ba2.IsEnabled = false;
                BF1.IsEnabled = true;
                BA1.IsEnabled = true;
                if (Text2.Text == "KINGO KRIMSON EPITAFE")
                {
                    Ba2.IsEnabled = false;
                }
            }
        }

        private void St_Click(object sender, RoutedEventArgs e)
        {
            St.IsEnabled = false;
            St.Opacity = 0;
            Sb1.IsEnabled = true;
            Sb2.IsEnabled = true;
            Sb1.Opacity = 100;
            Sb2.Opacity = 100;
            BA1.IsEnabled = false;
            BA2.IsEnabled = false;
            BF1.IsEnabled = false;
            BF2.IsEnabled = false;
            Ba1.IsEnabled = false;
            Ba2.IsEnabled = false;
            Pb1.IsEnabled = false;
            Pb2.IsEnabled = false;
            Go.IsEnabled = false;
            Vs.IsEnabled = false;
            Text1.IsEnabled = false;
            Text2.IsEnabled = false;
            P2.IsEnabled = false;
            P3.IsEnabled = false;
            P4.IsEnabled = false;
        }

        private void Sb1_Click(object sender, RoutedEventArgs e)
        {
            Sb2.IsEnabled = false;
            Sb2.Opacity = 0;
            Sb1.IsEnabled = false;
            Sb1.Opacity = 0;
            Go.IsEnabled = true;
            Vs.IsEnabled = true;
            Vs.Opacity = 100;
            Go.Opacity = 100;
            BA1.IsEnabled = false;
            BA2.IsEnabled = false;
            BF1.IsEnabled = false;
            BF2.IsEnabled = false;
            Ba1.IsEnabled = false;
            Ba2.IsEnabled = false;
            Pb1.IsEnabled = false;
            Pb2.IsEnabled = false;
            P2.Opacity = 100;
            P3.Opacity = 100;
            Text1.IsEnabled = true;
            Text2.IsEnabled = true;
            Text1.Opacity = 100;
            Text2.Opacity = 100;
            BA1.Opacity = 100;
            BA2.Opacity = 100;
            BF1.Opacity = 100;
            BF2.Opacity = 100;
            Pb1.Opacity = 100;
            Pb2.Opacity = 100;
            
        }

        private void Go2_Click(object sender, RoutedEventArgs e)
        {
            if (Text2.IsEnabled == false)
            {
                Pb3.IsEnabled = true;
                P4.Opacity = 0;
                P3.Opacity = 100;
                P7.Opacity = 0;
                P6.Opacity = 100;
                Ba1.Opacity = 0;
                Ba3.Opacity = 0;
                Vs.Text = null;
                Vs.IsEnabled = false;
                BA1.IsEnabled = true;
                BA3.IsEnabled = true;
                BF1.IsEnabled = true;
                BF3.IsEnabled = true;
                Ba1.IsEnabled = false;
                Ba3.IsEnabled = false;
                Pb1.IsEnabled = true;
                Pb3.IsEnabled = true;
                Pb1.Value = Pb1.Value + 100;
                Pb3.Value = Pb3.Value + 100;
                Go2.IsEnabled = false;
                Go2.Opacity = 0;
                Ba1.Opacity = 0;
                Ba1.IsEnabled = false;
                Panel.SetZIndex(BA2, 0);
                Panel.SetZIndex(Ba2, 0);
                Panel.SetZIndex(BF2, 0);
                Panel.SetZIndex(Pb2, 0);
                Panel.SetZIndex(BA3, 7);
                Panel.SetZIndex(BF3, 7);
                Panel.SetZIndex(Ba3, 7);
                Panel.SetZIndex(Pb3, 7);
            }
        }

        private void Sb2_Click(object sender, RoutedEventArgs e)
        {
            Sb2.IsEnabled = false;
            Sb2.Opacity = 0;
            Sb1.IsEnabled = false;
            Sb1.Opacity = 0;
            Go2.IsEnabled = true;
            Vs.IsEnabled = true;
            Vs.Opacity = 100;
            Go2.Opacity = 100;
            BA1.IsEnabled = false;
            BA3.IsEnabled = false;
            BF1.IsEnabled = false;
            BF3.IsEnabled = false;
            Ba1.IsEnabled = false;
            Ba3.IsEnabled = false;
            Pb1.IsEnabled = false;
            Pb3.IsEnabled = false;
            P3.Opacity = 100;
            P6.Opacity = 100;
            Text1.IsEnabled = true;
            Text3.IsEnabled = true;
            Text1.Opacity = 100;
            Text3.Opacity = 100;
            BA1.Opacity = 100;
            BA3.Opacity = 100;
            BF1.Opacity = 100;
            BF3.Opacity = 100;
            Pb1.Opacity = 100;
            Pb3.Opacity = 100;
            Go.IsEnabled = false;
            Go.Opacity = 0;
        }

        private void BA3_Click(object sender, RoutedEventArgs e)
        {
            if (Text1.IsEnabled == true && Text3.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                BF3.IsEnabled = false;
                BA3.IsEnabled = false;
                BF1.IsEnabled = true;
                BA1.IsEnabled = true;
                Pb1.Value = Pb1.Value - 10;
            }
        }

        private void BF3_Click(object sender, RoutedEventArgs e)
        {
            if (Text1.IsEnabled == true && Text3.IsEnabled == true)
            {
                Vs.IsEnabled = false;
                BF3.IsEnabled = false;
                BA3.IsEnabled = false;
                BF1.IsEnabled = true;
                BA1.IsEnabled = true;
                if (Text3.Text == "MADE IN HAVEN")
                {
                    Ba3.IsEnabled = false;
                }

                if (Text3.Text == ("WhiteSnake"))
                {
                    Pb3.Value = Pb3.Value + 5;
                }

                if (Text3.Text == ("MADE IN HAVEN"))
                {
                    Pb3.Value = Pb3.Value + 7;
                }
            }
        }

        private void Ba3_Click_1(object sender, RoutedEventArgs e)
        {
            if (Text1.IsEnabled == true && Text3.IsEnabled == true)
            {
                MessageBox.Show("YAV TOSU");
                Text3.Text = ("MADE IN HAVEN");
                P7.Opacity = 100;
                P6.Opacity = 0;
                BF3.IsEnabled = false;
                BA3.IsEnabled = false;
                Ba3.IsEnabled = false;
                BF1.IsEnabled = true;
                BA1.IsEnabled = true;
                if (Text3.Text == "MADE IN HAVEN")
                {
                    Ba3.IsEnabled = false;
                }

            }
        }

        private void Pb3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Text1.IsEnabled == true && Text3.IsEnabled == true)
            {
                if (Pb1.Value <= 0 && Text3.IsEnabled == true)
                {
                    MessageBox.Show("ARIVEDERCHI");
                    Go2.IsEnabled = true;
                    BA1.IsEnabled = false;
                    BA3.IsEnabled = false;
                    BF1.IsEnabled = false;
                    BF3.IsEnabled = false;
                    Ba1.IsEnabled = false;
                    Ba3.IsEnabled = false;
                    Pb1.IsEnabled = false;
                    Pb3.IsEnabled = false;
                    Go2.Opacity = 100;
                }
                if (Pb3.Value <= 10 && Text3.Text==("MADE IN HAVEN"))
                {
                    MessageBox.Show("MADE IN HAVEN БЛАГОДАРЯ УПРАВЛЕНИЮ СКОРОСТЬЮ И ГРАВИТАЦИИ СМОГ ПЕРЕСОЗДАТЬ ВСЕЛЕННУЮ С 0");
                    Close();
                }
                if (Pb3.Value <= 27 )
                { 
                    Ba3.IsEnabled = true;
                    Ba3.Opacity = 100;
                }
            }
        }
    }
}




