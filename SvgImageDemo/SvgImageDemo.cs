using System;
// Add this reference for `GetTypeInfo` extension.
using System.Reflection;
using Xamarin.Forms;
using TwinTechsForms.NControl;

namespace SvgImageDemo
{
	public class App : Application
	{
		public App ()
		{
//			MainPage = new SvgImageXamlDemoPage ();
//			MainPage.BindingContext = new SvgImageXamlDemoPageViewModel ();
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
							new Label {
								HorizontalTextAlignment = TextAlignment.Center,
								Text = "SVG Image (173x173, rendered 48x48)"
							},
							new SvgImageView {
								SvgAssembly = typeof(App).GetTypeInfo().Assembly,
								SvgPath = "SvgImageDemo.Resources.logo.svg",
								WidthRequest = 48,
								HeightRequest = 48,
							},
							new Label {
								HorizontalTextAlignment = TextAlignment.Center,
								Text = "SVG Image (173x173, rendered 175x175)"
							},
							new SvgImageView {
								SvgAssembly = typeof(App).GetTypeInfo().Assembly,
								SvgPath = "SvgImageDemo.Resources.logo.svg",
								WidthRequest = 175,
								HeightRequest = 175,
							},
							new Label {
								HorizontalTextAlignment = TextAlignment.Center,
								Text = "SVG Image (173x173, rendered 300x300)"
							},
							new SvgImageView {
								SvgAssembly = typeof(App).GetTypeInfo().Assembly,
								SvgPath = "SvgImageDemo.Resources.logo.svg",
								WidthRequest = 300,
								HeightRequest = 300,
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

