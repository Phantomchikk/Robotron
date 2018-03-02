using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Robotron
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class YoungerExamPage : ContentPage
	{
        int time = 0;
        bool alive = false;

        public YoungerExamPage ()
		{
			InitializeComponent ();
		}

        public async void OnStartFinishButton(object sender, EventArgs e)
        {
            int points = 3;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnTurnButton(object sender, EventArgs e)
        {
            int points = 2;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnCrossButton(object sender, EventArgs e)
        {
            int points = 5;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnRightTurnButton(object sender, EventArgs e)
        {
            int points = 2;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnLineButton(object sender, EventArgs e)
        {
            int points = 1;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnCurveButton(object sender, EventArgs e)
        {
            int points = 3;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnDetourButton(object sender, EventArgs e)
        {
            int points = 10;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnTakingButton(object sender, EventArgs e)
        {
            int points = 10;
            //Дописать логику запоминания баллов и т.д.
        }

        public bool OnTimerTick()
        {
            if (alive)
            {
                time++;
                TimeField.Text = TimeSpan.FromSeconds(time).ToString("T");
                return time == 360 ? false : true;
            }
            return false;
        }

        public void OnStopButton(object sender, EventArgs e)
        {
            if (alive)
            {
                alive = false;
                time = 0;
                TimeField.Text = "00:00:00";
                StartTimerButton.Text = "Старт";
                StartTimerButton.BackgroundColor = Color.GreenYellow;
            }
            else
            {
                alive = true;
                StartTimerButton.Text = "Стоп";
                StartTimerButton.BackgroundColor = Color.Red;
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            }
        }
    }
}