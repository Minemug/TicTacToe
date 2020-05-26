using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {            
            InitializeComponent();           
        }

        void CheckIfFinished()
        {
            if (Button0_0.Content == Button1_0.Content && Button1_0.Content == Button2_0.Content && Button2_0.Content != null)
            {
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button0_0.Content + " wygrał!");
                i = 0;
            }
            else if (Button0_1.Content == Button1_1.Content && Button1_1.Content == Button2_1.Content && Button2_1.Content != null)
            {
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button1_1.Content + " wygrał!");
                i = 0;
            }
            else if(Button0_2.Content == Button1_2.Content && Button1_2.Content == Button2_2.Content && Button2_2.Content != null)
            {
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button1_2.Content + " wygrał!");
                i = 0;
            }
            else if (Button0_0.Content == Button0_1.Content && Button0_1.Content == Button0_2.Content && Button0_2.Content != null)
            {
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button0_1.Content + " wygrał!");
                i = 0;
            }
            else if (Button1_0.Content == Button1_1.Content && Button1_1.Content == Button1_2.Content && Button1_2.Content != null)
            {
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button1_1.Content + " wygrał!");
                i = 0;
            }
            else if (Button2_0.Content == Button2_1.Content && Button2_1.Content == Button2_2.Content && Button2_2.Content != null)
            {
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button2_1.Content + " wygrał!");
                i = 0;
            }
            else if (Button0_0.Content == Button1_1.Content && Button1_1.Content == Button2_2.Content && Button2_2.Content != null)
            {
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button0_0.Content + " wygrał!");
                i = 0;
            }
            else if (Button2_0.Content == Button1_1.Content && Button1_1.Content == Button0_2.Content && Button0_2.Content != null)
            {
                Button2_0.Background = Button1_1.Background = Button0_2.Background = Brushes.GreenYellow;
                MessageBox.Show("Gracz " + Button0_2.Content + " wygrał!");
                i = 0;
            }
            else if (i == 9)
            {               
                MessageBox.Show("Remis!");
                i = 0;
            }
        }

        int i = 0;
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            i++;           
            if(i % 2 == 0)
            {
                button.Content = "X";
                button.Background = new SolidColorBrush(Color.FromArgb(100, 255, 209, 209));
                CheckIfFinished();
                PlayerIndicator.Text = "O";
                PlayerIndicator.Foreground = Brushes.Blue;
            }
            else{             
                button.Content = "O";
                button.Background = new SolidColorBrush(Color.FromArgb(100, 165, 240, 250));
                CheckIfFinished();
                PlayerIndicator.Text = "X";
                PlayerIndicator.Foreground = Brushes.Red;
            }           
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {           
            Button0_0.Content = null;
            Button1_0.Content = null;
            Button2_0.Content = null;
            Button0_1.Content = null;
            Button1_1.Content = null;
            Button2_1.Content = null;
            Button0_2.Content = null;
            Button1_2.Content = null;
            Button2_2.Content = null;
            Button0_0.Background = Brushes.White;
            Button1_0.Background = Brushes.White;
            Button2_0.Background = Brushes.White;
            Button0_1.Background = Brushes.White;
            Button1_1.Background = Brushes.White;
            Button2_1.Background = Brushes.White;
            Button0_2.Background = Brushes.White;
            Button1_2.Background = Brushes.White;
            Button2_2.Background = Brushes.White;
        }
    }
}
