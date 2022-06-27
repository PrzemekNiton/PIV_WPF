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

namespace TicTacToe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        GameContent _gameContent = new GameContent();
        private Button control;

        // button user 
        private void UserClickArea(object sender, RoutedEventArgs e)
        {
            var SpaceArea = (Button)sender;
            if (!String.IsNullOrWhiteSpace(SpaceArea.Content?.ToString()))
            {
              
                return;
                
            }
            SpaceArea.Content = _gameContent.actualPlayer;

            _gameContent.SetNextUser();
          

        }

        // button event click 
        // Reset Games
        private void restartnewgame_Click(object sender, RoutedEventArgs e)
        {
            foreach(var control in boardGrid.Children)
                {
                if(control is Button)
                {
                    ((Button)control).Content = String.Empty;


                }
                else if (control is Button)
                {

                    MessageBox.Show("The games is end");
                }


            }
            _gameContent = new GameContent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            }

        }
    }

