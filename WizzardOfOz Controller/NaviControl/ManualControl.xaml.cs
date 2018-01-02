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
    /// Interaction logic for ManualControl.xaml
    /// </summary>
    public partial class ManualControl : UserControl, ISwitchable
    {
        public ManualControl()
        {
            this.InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void button_MainMenu_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("start");
        }

        private void button_ziel_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("goal");
        }

        private void button_dreieck_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("dreieck");
        }

        private void button_quadrat_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("quadrat");
        }

        private void button_kreis_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("kreis");
        }

        private void button_ar0_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_r_0");
        }

        private void button_ar1_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_r_1");
        }

        private void button_ar2_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_r_2");
        }

        private void button_ar3_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_r_3");
        }

        private void button_ar4_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_r_4");
        }

        private void button_al0_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_l_0");
        }

        private void button_al1_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_l_1");
        }

        private void button_al2_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_l_2");
        }

        private void button_al3_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_l_3");
        }

        private void button_al4_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_l_4");
        }

        private void button_ahr0_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hr_0");
        }

        private void button_ahr1_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hr_1");
        }

        private void button_ahr2_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hr_2");
        }

        private void button_ahr3_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hr_3");
        }

        private void button_ahr4_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hr_4");
        }

        private void button_ahl0_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hl_0");
        }

        private void button_ahl1_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hl_1");
        }

        private void button_ahl2_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hl_2");
        }

        private void button_ahl3_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hl_3");
        }

        private void button_ahl4_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_hl_4");
        }

        private void button_a0_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_0");
        }

        private void button_a1_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_1");
        }

        private void button_a2_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_2");
        }

        private void button_a3_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_3");
        }

        private void button_a4_Click(object sender, RoutedEventArgs e)
        {
            Sender.send("a_4");
        }
    }
}
