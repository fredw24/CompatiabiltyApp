using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComparabilityApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Question : ContentPage
	{
		public Question ()
		{
            Console.WriteLine("landed");
            InitializeComponent();

		}

        public async void QuestionLoad(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Result());
        }
	}
}