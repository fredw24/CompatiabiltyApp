using ComparabilityApp.Models;
using ComparabilityApp.Views;
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
        public async void QuestionsButton(object sender, System.EventArgs e)
        {
            Console.WriteLine("Question");
            await Navigation.PushAsync(new Question());
        }

        public async void UpdateButton(object sender, System.EventArgs e)
        {
            Console.WriteLine("Update");
            await Navigation.PushAsync(new Update());
        }
        public async void ResultButton(object sender, System.EventArgs e)
        {
            Console.WriteLine("Result");
            await Navigation.PushAsync(new Result());
        }
        public async void AboutButton(object sender, System.EventArgs e)
        {
            Console.WriteLine("About");
            await Navigation.PushAsync(new About());
        }
    }
}
