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

#if __ANDROID__
			var context = MainApplication.Context;
            var tostada = new Android.Widget.Toast(context);
            tostada.SetText(CounterLabel.Text);
            tostada.Show();
#endif
		}

        void OpenSettings_Clicked(System.Object sender, System.EventArgs e)
		{
#if __ANDROID__
			var intent = new Android.Content.Intent(Android.Provider.Settings.ActionWifiSettings);
			intent.SetFlags(Android.Content.ActivityFlags.NewTask);
			Android.App.Application.Context.StartActivity(intent);
#endif
#if __IOS__
            UIKit.UIApplication.SharedApplication.OpenUrl(new Foundation.NSUrl(UIKit.UIApplication.OpenSettingsUrlString));

#endif
		}
    }
}
