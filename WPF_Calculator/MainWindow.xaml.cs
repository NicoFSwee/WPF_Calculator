using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn0.Click += OnButtonClicked;
            btn1.Click += OnButtonClicked;
            btn2.Click += OnButtonClicked;
            btn3.Click += OnButtonClicked;
            btn4.Click += OnButtonClicked;
            btn5.Click += OnButtonClicked;
            btn6.Click += OnButtonClicked;
            btn7.Click += OnButtonClicked;
            btn8.Click += OnButtonClicked;
            btn9.Click += OnButtonClicked;
            btnDelete.Click += OnButtonClicked;
            btnDivide.Click += OnButtonClicked;
            btnEquals.Click += OnButtonClicked;
            btnMinus.Click += OnButtonClicked;
            btnMultiply.Click += OnButtonClicked;
            btnPlus.Click += OnButtonClicked;
        }

        private void OnButtonClicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if(button.Content.ToString() == "=")
            {
                txtIO.Text = CalculateFromString(txtIO.Text);
            }
            else if(button.Content.ToString() == "C")
            {
                txtIO.Text = string.Empty;
            }
            else
            {
                txtIO.Text += button.Content.ToString();
            }
        }

        private string CalculateFromString(string numberString)
        {
            return new DataTable().Compute(numberString, null).ToString();
        }
    }
}
