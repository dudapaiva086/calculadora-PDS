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
//Eduarda e Maria Eduarda
namespace WpfAppCalculadoraPds
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btDivisao_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbConta1.Text);
            Double b = Convert.ToDouble(tbConta2.Text);
            Double t = a / b;
            tbResultado.Text = a.ToString() + "/" + b.ToString() + "=" + t.ToString();
        }

        private void btMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbConta1.Text);
            Double b = Convert.ToDouble(tbConta2.Text);
            Double t = a * b;
            tbResultado.Text = a.ToString() + "*" + b.ToString() + "=" + t.ToString();
        }

        private void btAdicao_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbConta1.Text);
            Double b = Convert.ToDouble(tbConta2.Text);
            Double t = a + b;
            tbResultado.Text = a.ToString() + "+" + b.ToString() + "=" + t.ToString();
        }

        private void btSubtracao_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(tbConta1.Text);
            Double b = Convert.ToDouble(tbConta2.Text);
            Double t = a - b;
            tbResultado.Text = a.ToString() + "-" + b.ToString() + "=" + t.ToString();
        }
    }
}
