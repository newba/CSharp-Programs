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

namespace Teste_repetiçao
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        int cont = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string texto = text1.Text;
            int qtdecopy = Convert.ToInt32(text2.Text);
            string result = "";

            while (qtdecopy > 0)
            {
                result = String.Concat(result, " ", texto);
                qtdecopy--;
            }

            text3.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cont++;
            text2.Text = cont.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text3.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            text1.Clear();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tchau");
            Application.Current.Shutdown();


        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text3.Copy();
        }

        private void text2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            text3.Focus();


            text3.SelectAll();
        }
        }


    }
