using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Homework12_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public event EventHandler SomeEvent = null;
        public event EventHandler StopEvent = null;
        public event EventHandler ResetEvent = null;
        

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);

        }

        
        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            
            SomeEvent.Invoke(sender, e);
        }

                

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            StopEvent.Invoke(sender, e);
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            ResetEvent.Invoke(sender, e);
        }
    }
}
