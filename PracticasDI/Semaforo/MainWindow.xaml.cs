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

namespace Semaforo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (RBRed.IsFocused)
            {
                eRojo.Visibility = Visibility.Visible;
                eAmbar.Visibility = Visibility.Hidden;
                eVerde.Visibility = Visibility.Hidden;
            }
            else
            {
                if (RBOrange.IsFocused)
                {
                    eRojo.Visibility = Visibility.Hidden;
                    eAmbar.Visibility = Visibility.Visible;
                    eVerde.Visibility = Visibility.Hidden;
                }
                else
                {
                    if (RBGreen.IsFocused)
                    {
                        eRojo.Visibility = Visibility.Hidden;
                        eAmbar.Visibility = Visibility.Hidden;
                        eVerde.Visibility = Visibility.Visible;
                    }
                }
            }

        }
    }
}
