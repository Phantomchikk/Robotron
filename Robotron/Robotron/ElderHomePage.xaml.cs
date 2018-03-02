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
	public partial class ElderHomePage : ContentPage
	{
        int time = 0;
        bool alive = false;

        public ElderHomePage ()
		{
			InitializeComponent ();
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

        public async Task<int> GetPoints(int count)
        {
            string[] mas = new string[count];
            for (int i = 0; i < count; i++)
            {
                mas[i] = (i + 1).ToString();
            }
            var result = await DisplayActionSheet("Поделиться", "Отмена", "Удалить", mas);
            return Convert.ToInt32(result);
        }

        public async void OnM1Button(object sender, EventArgs e)
        {
            int points = 1;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnM2Button(object sender, EventArgs e)
        {
            int points = 1;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnM3Button(object sender, EventArgs e)
        {
            int points = 2;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnM4Button(object sender, EventArgs e)
        {
            int points = 4;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnM5Button(object sender, EventArgs e)
        {
            int points = 5;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnM6Button(object sender, EventArgs e)
        {
            int points = await GetPoints(6);
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnM7Button(object sender, EventArgs e)
        {
            int points = 2;
            //Дописать логику запоминания баллов и т.д.
        }

        public async void OnM8Button(object sender, EventArgs e)
        {
            int points;
            int time1 = time;
            alive = false;
            time = 0;
            StartTimerButton.IsEnabled = false;
            if (time1 >= 360) points = 1;
            if (time1 < 360 && time1 >= 350) points = 2;
            if (time1 < 350 && time1 >= 340) points = 3;
            if (time1 < 340 && time1 >= 330) points = 4;
            if (time1 < 330 && time1 >= 320) points = 5;
            if (time1 < 320 && time1 >= 310) points = 6;
            if (time1 < 310) points = 7;
            //Дописать логику запоминания баллов и т.д.
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