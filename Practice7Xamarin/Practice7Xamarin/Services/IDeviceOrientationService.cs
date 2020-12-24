using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Practice7Xamarin.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
