using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using DreamConnectApp.DreamConnectClassLibrary;

namespace DreamConnectApp.DreamConnectClassLibrary
{
    public class Profile
    {
        public object ProfileID { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Occupation { get; set; }

        

    }
}
