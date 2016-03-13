using Xamarin.Forms;
using System.Reflection;

namespace SvgImageDemo
{
	public class SvgImageXamlDemoPageViewModel
	{
		public Assembly SvgAssembly {
			get { return typeof(App).GetTypeInfo ().Assembly; }
		}
	}

	public partial class SvgImageXamlDemoPage : ContentPage
	{
		public SvgImageXamlDemoPage ()
		{
			InitializeComponent ();
		}
	}
}
