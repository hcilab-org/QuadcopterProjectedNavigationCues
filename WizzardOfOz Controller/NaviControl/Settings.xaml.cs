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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl, ISwitchable
    {
        public Settings()
        {
            this.InitializeComponent();
            tb_phone.Text = Variables.PhoneIP;
            tb_beamer.Text = Variables.BeamerIP;
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void b_return_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void b_setPhone_Click(object sender, RoutedEventArgs e)
        {
            Variables.PhoneIP = tb_phone.Text; 
        }

        private void b_setBeamer_Click(object sender, RoutedEventArgs e)
        {
            Variables.BeamerIP = tb_beamer.Text;
        }

        #region TouchInput
        private void b_setBeamer_TouchDown(object sender, TouchEventArgs e)
        {
            b_setBeamer_Click(sender, e);
        }

        private void b_setPhone_TouchDown(object sender, TouchEventArgs e)
        {
            b_setPhone_Click(sender, e);
        }

        private void b_return_TouchDown(object sender, TouchEventArgs e)
        {
            b_return_Click(sender, e);
        }
        #endregion
    }
}
