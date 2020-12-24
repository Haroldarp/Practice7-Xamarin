using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice7Xamarin.ViewModels
{
    public class FocusedEffectPageViewModel : ViewModelBase
    {
        public FocusedEffectPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Focused Effect";
        }
    }
}
