using App1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace App1.Windows
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private String operationszeichen;
        private float zahl1;
        private float zahl2;
        private object result;

        

        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(7);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(8);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(9);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(4);
        }
        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(5);
        }
        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(6);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(1);
        }
        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(2);
        }
        private void button2_Copy1_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(3);
        }
        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            saveNumber(0);
        }

        private void button1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void button3_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Calculator c = new Calculator();
            result = c.Calculate(operationszeichen, zahl1, zahl2);
            textBox.Text = result.ToString();

            operationszeichen = null;
            zahl1 = 0;
            zahl2 = 0;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            setOperator("/");
        }
        private void button3_Copy_Click(object sender, RoutedEventArgs e)
        {
            setOperator("*");
        }
        private void button3_Copy1_Click(object sender, RoutedEventArgs e)
        {
            setOperator("-");
        }
        private void button2_Copy2_Click(object sender, RoutedEventArgs e)
        {
            setOperator("+");
        }


        private void saveNumber(int zahl)
        {
            if (operationszeichen == null)
            {
                zahl1 = zahl1 * 10 + zahl;
                textBox.Text = zahl1.ToString();
            }
            else
            {
                zahl2 = zahl2 * 10 + zahl;
                textBox.Text = zahl2.ToString();
            }
        }

        private void setOperator(String zeichen)
        {
            
            operationszeichen = zeichen;
            textBox.Text = operationszeichen.ToString();
        }

    }
}
