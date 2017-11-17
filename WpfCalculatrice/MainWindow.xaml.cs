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

namespace WpfCalculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Addition addition;
        public MainWindow()
        {
            InitializeComponent();
            addition = new Addition(0,0);
        }

        private void tbnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblNb1;
            double dblNb2;
            if (double.TryParse(tbxNombre1.Text, out dblNb1) && double.TryParse(tbxNombre2.Text, out dblNb2))
            {
                addition.setVal1(dblNb1);
                addition.setVal2(dblNb2);
                lblResulta.Content = addition.Addtionne().ToString();
            }
            else
            {
                MessageBox.Show("veuillez contrôler le format des nombre saisis !", "Convertion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void tbnSub_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tbnMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbnDiv_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
