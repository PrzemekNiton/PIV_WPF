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

namespace WPFMenu
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

        public int AddButton { get; private set; }

        

        private void GenerateNewButton_Click(object sender, RoutedEventArgs e)
        {

            
            
            var button = new Button() { Content = "Wow jaki button" }; 
            button.Click += GenerateNewButton_Click;
            UniformGrid1.Children.Add(button); 


        }
    }
}
