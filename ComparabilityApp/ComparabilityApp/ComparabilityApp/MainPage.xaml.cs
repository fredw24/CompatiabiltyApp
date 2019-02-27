using ComparabilityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComparabilityApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Registration(object sender, EventArgs e)
        {
            Console.WriteLine("check");

            User user = new User(Email.Text, Password.Text);
            if (user.CheckInformation())
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");

            }
        }
    }
}
