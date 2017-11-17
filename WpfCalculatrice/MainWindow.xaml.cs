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
            addition.setVal1(33);
            addition.setVal2(44);
            lblResulta.Content = addition.Addtionne().ToString();
            MessageBox.Show(addition.Affiche());
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
