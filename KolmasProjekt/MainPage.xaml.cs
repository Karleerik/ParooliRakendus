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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KolmasProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string username = "Kasutaja";
            string password = "Parool";

            if (textbox1.Text == username && textbox2.Text == password)
            {
                textblock3.Text = "Õige parool ja kasutajanimi!";
            }
            else
            {
                textblock3.Text = "Vale parool või kasutajanimi!!";

            }

            int LoginAttempts = 0;

            for (int i = 0; i < 3; i++)
            {
                if (username != "Kasutaja" || password != "Parool")
                    LoginAttempts++;
                else
                    break;
            }

            if (LoginAttempts > 3)
            {
                textblock3.Text = "Liiga palju kordi valesti!";
            }
            else
            {
                textblock3.Text = "Sisselogimine õnnestus!";
            }
        }
    }
}
