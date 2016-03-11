using System;

using Xamarin.Forms;

namespace SvgImageDemo
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new ContentPage {
				Content = new ScrollView {
					Padding = new Thickness (0, Device.OnPlatform(iOS: 20.0, Android: 0, WinPhone: 0), 0, 0),
					HorizontalOptions = LayoutOptions.Fill,
					VerticalOptions = LayoutOptions.Fill,
					Content = new StackLayout {
						Children = {
							new Label {
								HorizontalTextAlignment = TextAlignment.Center,
								Text = "PNG Image (48x48)"
							},
							new Image {
								Source = "logo",
								HeightRequest = 48,
								WidthRequest = 48,
							},
							new Label {
								HorizontalTextAlignment = TextAlignment.Center,
								Text = "PNG Image (48x48, rendered 175x175)"
							},
							new Image {
								Source = "logo",
								HeightRequest = 175,
								WidthRequest = 175,
							},
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

