using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Homework12_3
{
    class Presenter
    {
        Model model;

        MainWindow mainWindow;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

                

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.SomeEvent += MainWindow_SomeEvent;
            this.mainWindow.StopEvent += MainWindow_StopEvent;
            this.mainWindow.ResetEvent += MainWindow_ResetEvent;

            
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += MainWindow_SomeEvent;
            

        }

        private void MainWindow_ResetEvent(object sender, EventArgs e)
        {
            dispatcherTimer.Stop();
            this.mainWindow.timerField.Content = this.model.Reset();
         
        }

        private void MainWindow_StopEvent(object sender, EventArgs e)
        {
            dispatcherTimer.Stop();
        }

        private void MainWindow_SomeEvent(object sender, EventArgs e)
        {

            dispatcherTimer.Start();
            this.mainWindow.timerField.Content = this.model.SomeMthod(this.mainWindow.timerField.Content.ToString());
        }
    }
}
