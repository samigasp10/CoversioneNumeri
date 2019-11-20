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

namespace CoversioneNumeri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string numero;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            string n = txtNumero.Text;
            if (cmBase.SelectedIndex == 0)
            {
                int decimale = Convert.ToInt32(n, 2);
                txtConversione.Text = decimale.ToString();

            }
            if (cmBase.SelectedIndex == 1)
            {
                string binario = Convert.ToString(int.Parse(numero), 2);
                txtConversione.Text = binario.ToString();

            }
        }
    }
}
