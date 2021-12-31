using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace KnittersCompanion.ViewModels
{
    public class CounterViewModel : BaseViewModel
    {
        public CounterViewModel()
        {
            Title = "StitchRowCounter";
            IncreaseCount = new Command(OnIncrease);
            //BindingContext = this;
        }

        public ICommand IncreaseCount { get; }

        int count = 0;
        string countDisplay = "0";
        
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;
                countDisplay = value;
                OnPropertyChanged();
            }
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"{count}";
        }
    }
}