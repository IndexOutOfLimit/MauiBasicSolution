using Microsoft.Maui.Controls;
using System;
using System.Windows.Input;

namespace MauiAppDemo.ViewModels
{
    public class CounterViewModel : BaseViewModel
    {
        ICommand clickCommand;

        private int count;
        public ICommand ClickCommand => clickCommand ?? (clickCommand = new Command(IncrementCount));

        ICommand navigateCommand;

        public ICommand NavigateCommand => navigateCommand ?? (navigateCommand = new Command(NavigateToPage));

        private void NavigateToPage(object obj)
        {
            //        
        }

        private void IncrementCount(object obj)
        {
            Count = Count+5;
        }
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }
    }
}
