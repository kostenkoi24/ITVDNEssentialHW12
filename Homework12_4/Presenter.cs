using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12_4
{
    class Presenter
    {
        Model model;

        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();

            this.mainWindow.buttonEquels_Event += MainWindow_buttonEquels_Event;
            

        }

        private void MainWindow_buttonEquels_Event(object sender, EventArgs e)
        {
            string operationSign = this.mainWindow.dataFieldSign.Text;
            double x = this.mainWindow.x;
            double y = this.mainWindow.y;

            switch (operationSign)
            {
                case "+":
                  this.mainWindow.dataField1.Text = this.model.Add(x, y).ToString();
                    break;
                case "-":
                    this.mainWindow.dataField1.Text = this.model.Sub(x, y).ToString();
                    break;
                case "*":
                    this.mainWindow.dataField1.Text = this.model.Mul(x, y).ToString();
                    break;
                case "/":
                    this.mainWindow.dataField1.Text = y==0 ? "Divide by zero" : this.model.Div(x, y).ToString();
                    break;
            }
                        

        }

    }
}
