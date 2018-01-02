using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NaviControl
{
    /// <summary>
    /// Interaction logic for Route.xaml
    /// </summary>
    public partial class Route : UserControl, ISwitchable
    {
        private static int routenumber;
        private int routeItem;
        private int maxRouteItems;

        public Route(int rnumber)
        {
            this.InitializeComponent();
            routenumber = rnumber;
            routeItem = 0;
            Variables.BeamerActive = true;
            if(routenumber == 1)
            {
                maxRouteItems = Variables.Route1Items.Length;
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("Images/"+Variables.Route1Items[0]+".png", UriKind.Relative)); //Ändern auf Variables.Route1Item[0]
                b_next.Background = brush;
                l_desc.Content = Variables.Route1Descriptions[0];
            }
            else if(routenumber == 2)
            {
                maxRouteItems = Variables.Route2Items.Length;
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route2Items[0] + ".png", UriKind.Relative)); //Ändern auf Variables.Route2Item[0]
                b_next.Background = brush;
                l_desc.Content = Variables.Route2Descriptions[0];
            }

            if (Variables.BeamerActive)
            {
                greenC.Fill = Brushes.Gray;
                redC.Fill = Brushes.Red;
                b_m_down.IsEnabled = false;
                b_m_up.IsEnabled = false;
            }
            else if (!Variables.BeamerActive)
            {
                greenC.Fill = Brushes.Green;
                redC.Fill = Brushes.Gray;
                b_m_down.IsEnabled = true;
                b_m_up.IsEnabled = true;
            }
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void b_drone_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if(Variables.BeamerActive)
            {
                Variables.BeamerActive = false;
                greenC.Fill = Brushes.Gray;
                redC.Fill = Brushes.Red;
                b_m_down.IsEnabled = false;
                b_m_up.IsEnabled = false;
            }
            else if(!Variables.BeamerActive)
            {
                Variables.BeamerActive = true;
                greenC.Fill = Brushes.Green;
                redC.Fill = Brushes.Gray;
                b_m_down.IsEnabled = true;
                b_m_up.IsEnabled = true;
            }
        }


        private void b_next_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            routeItem++;
            if (maxRouteItems - routeItem > 0)
            {
                if (routenumber == 1)
                {
                    var brushN = new ImageBrush();
                    var brushP = new ImageBrush();
                    brushP.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route1Items[routeItem-1] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route1Items[routeItem-1]
                    b_prev.Background = brushP;
                    brushN.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route1Items[routeItem] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route1Items[routeItem]
                    b_next.Background = brushN;
                    //Sender.send(Variables.Route1Items[routeItem-1]);
                    l_desc.Content = Variables.Route1Descriptions[routeItem];
                }
                else if (routenumber == 2)
                {
                    var brushN = new ImageBrush();
                    var brushP = new ImageBrush();
                    brushP.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route2Items[routeItem - 1] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route1Items[routeItem-1]
                    b_prev.Background = brushP;
                    brushN.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route2Items[routeItem] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route2Items[routeItem]
                    b_next.Background = brushN;
                    //Sender.send(Variables.Route2Items[routeItem - 1]);
                    l_desc.Content = Variables.Route2Descriptions[routeItem];
                }
            }
            else if(maxRouteItems  - routeItem == 0)
            {
                if (routenumber == 1)
                {
                    var brushN = new ImageBrush();
                    var brushP = new ImageBrush();
                    brushP.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route1Items[routeItem - 1] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route1Items[routeItem-1]
                    b_prev.Background = brushP;
                    brushN.ImageSource = new BitmapImage(new Uri("Images/" + "goal" + ".png", UriKind.Relative)); //TODO: Ändern auf Finished
                    b_next.Background = brushN;
                    //Sender.send(Variables.Route1Items[routeItem - 1]);
                    l_desc.Content = Variables.Route1Descriptions[routeItem];
                }
                else if (routenumber == 2)
                {
                    var brushN = new ImageBrush();
                    var brushP = new ImageBrush();
                    brushN.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route2Items[routeItem - 1] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route2Items[routeItem-1]
                    b_prev.Background = brushP;
                    brushN.ImageSource = new BitmapImage(new Uri("Images/" + "goal" + ".png", UriKind.Relative)); //TODO: Ändern auf Finished
                    b_next.Background = brushN;
                    //Sender.send(Variables.Route2Items[routeItem - 1]);
                    l_desc.Content = Variables.Route2Descriptions[routeItem];
                }
            }
            else
            {
                Switcher.Switch(new MainMenu());
            }

        }

        private void b_prev_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            routeItem--;
            if (routenumber == 1)
            {
                var brushN = new ImageBrush();
                var brushP = new ImageBrush();
                if (routeItem != 0)
                {
                    brushP.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route1Items[routeItem - 1] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route1Item[routeItem-1]
                    b_prev.Background = brushP;
                }
                brushN.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route1Items[routeItem] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route1Item[routeItem]
                b_next.Background = brushN;
               // Sender.send(Variables.Route1Items[routeItem - 1]);
                l_desc.Content = Variables.Route1Descriptions[routeItem];
            }
            else if (routenumber == 2)
            {
                var brushN = new ImageBrush();
                var brushP = new ImageBrush();
                if (routeItem != 0)
                {
                    brushP.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route2Items[routeItem - 1] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route2Item[routeItem-1]
                    b_prev.Background = brushP;
                }
                brushN.ImageSource = new BitmapImage(new Uri("Images/" + Variables.Route2Items[routeItem] + ".png", UriKind.Relative)); //TODO: Ändern auf Variables.Route2Item[routeItem]
                b_next.Background = brushN;
               // Sender.send(Variables.Route2Items[routeItem - 1]);
                l_desc.Content = Variables.Route2Descriptions[routeItem];
            }
        }

        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
