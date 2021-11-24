using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;


namespace MonkeyConf
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterLabel.Text = $"Current count: {count}";

			SemanticScreenReader.Announce(CounterLabel.Text);
			new Tostadora().HacerTostadas(CounterLabel.Text);
		}

        void OpenSettings_Clicked(System.Object sender, System.EventArgs e)
		{
			new OpenSettings().OpenWifiSettings();
		}
    }
}
