

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Data;
using System.Windows.Input;
using Syncfusion.SfImageEditor.XForms;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace IESample
{
    public partial class ImageEditorGettingStarted : ContentPage
    {

        Assembly assembly;
        public ImageEditorGettingStarted()
        {
            InitializeComponent();
            assembly = typeof(App).GetTypeInfo().Assembly;
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            editor.Source = ImageSource.FromResource("IESample.CustomViewImage1.png", assembly);
            editor.ImageLoaded += (Object sender, ImageLoadedEventArgs args) =>
              {
                  editor.AddShape(ShapeType.Circle, new PenSettings() { Color = Color.Green });
              };
        }

       
    }


}

