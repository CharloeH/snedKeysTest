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
using System.Windows.Threading;
using SendKeys = System.Windows.Forms.SendKeys;
namespace snedKeysTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isClicked = false;
        bool isFirst = true;
        int i = 0;
        DispatcherTimer WeeSnawTimer = new DispatcherTimer();
        DispatcherTimer SnawWeeTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            WeeSnawTimer.Tick += WeeSnawTimer_Tick;
            WeeSnawTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);//fps
            WeeSnawTimer.Start();
            SnawWeeTimer.Tick += SnawWeeTimer_Tick;
            SnawWeeTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);//fps
            SnawWeeTimer.Start();
        }
        private void WeeSnawTimer_Tick(object sender, EventArgs e)
        {
            if(isClicked == false)
            txtFOOL.Text += "WEE SNAW ";
            txtFOOL.Foreground = Brushes.Green;
            txtFOOL.FontWeight = FontWeights.UltraBold;
            txtFOOL.Background = Brushes.DarkGreen;
           
        }
        private void SnawWeeTimer_Tick(object sender, EventArgs e)
        {
            if (txtFOOL.Text.Contains("snaw wee"))
            {
                FOOOL();
            }
        }
        private void FOOOL()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("FOOL.txt");

                string foolish = sr.ReadToEnd();
                if (i < foolish.Length)
                    txtFOOL.Text += foolish[i];
                i++;
        }

        

        private void TxtFOOL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isClicked = true;
            txtFOOL.Text = "";
        }
    }
}
