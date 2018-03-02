using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Robotron
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void OnElderHomeButton(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ElderHomePage());
        }

        public async void OnElderExamButton(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ElderExamPage());
        }

        public async void OnYoungerHomeButton(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new YoungerHomePage());
        }

        public async void OnYoungerExamButton(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new YoungerExamPage());
        }
    }
}
