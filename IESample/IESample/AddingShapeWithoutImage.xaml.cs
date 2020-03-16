using Syncfusion.SfImageEditor.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IESample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddingShapeWithoutImage : ContentPage
	{
		public AddingShapeWithoutImage()
		{
			InitializeComponent ();
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {
                editor.AddShape(ShapeType.Circle, new PenSettings() { Color = Color.Green });
                return false;
            });

        }
    }
}