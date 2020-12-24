using Practice7Xamarin.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Practice7Xamarin.ViewModels
{
    public class DependencyServiceViewModel : ViewModelBase
    {
        public string Orientation { get; set; }
        public ICommand OrientationCommand { get; set; }
        public DependencyServiceViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Dependecy Service";
            Orientation = "Orientation";
            OrientationCommand = new DelegateCommand(OnOrientation);
        }

        public void OnOrientation()
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
            Orientation = orientation.ToString();
        }
    }
}
