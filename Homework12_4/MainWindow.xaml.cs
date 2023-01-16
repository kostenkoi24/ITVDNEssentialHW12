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

namespace Homework12_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public double x, y;
        private bool operSign;
        private bool operEnd;


        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

                
        public event EventHandler buttonEquels_Event = null;
        

        #region
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            Fields(button0.Content.ToString());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Fields(button1.Content.ToString());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Fields(button2.Content.ToString());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Fields(button3.Content.ToString());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Fields(button4.Content.ToString());
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Fields(button5.Content.ToString());
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Fields(button6.Content.ToString());
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Fields(button7.Content.ToString());
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Fields(button8.Content.ToString());
        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Fields(button9.Content.ToString());
        }
        #endregion

        #region
        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            operSign = true;
            dataFieldSign.Text = buttonMul.Content.ToString();
        }

        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            operSign = true;
            dataFieldSign.Text = buttonSub.Content.ToString();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            operSign = true;
            dataFieldSign.Text = buttonAdd.Content.ToString();
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            operSign = true;
            dataFieldSign.Text = buttonDiv.Content.ToString();
        }
        #endregion

        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            operSign = false;
            dataField1.Text = default;
            dataFieldSign.Text = default;
            dataField2.Text = default;
        }

       

        private void buttonEquels_Click(object sender, RoutedEventArgs e)
        {
            buttonEquels_Event.Invoke(sender, e);
            dataFieldSign.Text = default;
            dataField2.Text = default;
            operSign = false;
            operEnd = true;
        }

        private void Fields(string value)
        {
            if (operEnd)
            {
                dataField1.Text = default;
                operEnd = false;
            }
            if (operSign)
            {
                dataField2.Text += value;
                y = double.Parse(dataField2.Text);
            }
            else
            {
                dataField1.Text += value;
                x = double.Parse(dataField1.Text);
            }
            
        }

    }
}
