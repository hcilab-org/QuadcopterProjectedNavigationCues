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

namespace NaviControl
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl, ISwitchable
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void b_route1_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Route(1));
        }

        private void b_route2_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Route(2));
        }

        private void b_manual_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ManualControl());
        }

        private void b_settings_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Settings());
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #region Touchinput
        private void b_route1_TouchDown(object sender, TouchEventArgs e)
        {
            b_route1_Click(sender, e);
        }

        private void b_route2_TouchDown(object sender, TouchEventArgs e)
        {
            b_route2_Click(sender, e);
        }

        private void b_manual_TouchDown(object sender, TouchEventArgs e)
        {
            b_manual_Click(sender, e);
        }

        private void b_settings_TouchDown(object sender, TouchEventArgs e)
        {
            b_settings_Click(sender, e);
        }
        #endregion
    }
}
