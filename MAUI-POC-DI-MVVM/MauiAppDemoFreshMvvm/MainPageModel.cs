using FreshMvvm.Maui;
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace MauiAppDemoFreshMvvm
{
    internal class MainPageModel : FreshBasePageModel
    {
        public string MyHello { get; set; } = "Hellow!";

        ICommand clickCommand;

        private int count;
        public ICommand ClickCommand => clickCommand ?? (clickCommand = new Command(IncrementCount));
        
        private void IncrementCount(object obj)
        {
            Count = Count + 5;
        }
        public int Count
        {
            get => count;
            set
            {
                count = value;
                RaisePropertyChanged("Count");
            }
        }
    }
}
