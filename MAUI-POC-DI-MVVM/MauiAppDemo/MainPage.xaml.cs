using MauiAppDemo.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiAppDemo
{
	public partial class MainPage : ContentPage
	{
        public MainPage(CounterViewModel vwModel)
        {
            InitializeComponent();

            BindingContext = vwModel;
        }
    }
}
