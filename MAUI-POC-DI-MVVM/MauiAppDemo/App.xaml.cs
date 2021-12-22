using Application = Microsoft.Maui.Controls.Application;

namespace MauiAppDemo
{
	public partial class App : Application
	{
        public App(MainPage page)
        {
            InitializeComponent();

            MainPage = page;
        }
    }
}
