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
using Puntentelling;

namespace BowlingGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Class1 pt;
        private bool isStrike = false;
        private bool isSpare = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            int frameNr = int.Parse(((Button)sender).Name.Substring(1));
            int score1 = Convert.ToInt32((TextBox)this.FindName($"txtScore{frameNr}a"));
            int score2 = Convert.ToInt32((TextBox)this.FindName($"txtScore{frameNr}b"));

            Frame huidigFrame;
            if(score1 == 10 && score2 == 0)
            {
                isStrike = true;
                huidigFrame = new Frame(score1, isStrike, pt);
            }
        }
    }
}
