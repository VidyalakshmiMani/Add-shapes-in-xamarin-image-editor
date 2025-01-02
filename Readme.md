# How-to-add-shapes-to-the-Xamarin.Forms-Image-Editor-on-initial-loading

This demo sample explaing how the [shapes](https://help.syncfusion.com/xamarin/image-editor/shapes) in the image editor can be annotated on initial loading scenario. Please refer KB links for more details,

[How to add shapes to the Xamarin.Forms Image Editor on initial loading](https://www.syncfusion.com/kb/11273/how-to-add-shapes-to-the-xamarin-forms-image-editor-on-initial-loading)

While programmatically adding a shape to the image editor, we can either fall into two valid scenarios with or without an image on the editor.

Shape was added with the help of [AddShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms~Syncfusion.SfImageEditor.XForms.SfImageEditor~AddShape.html)() method, which passed the desired shape and its pen settings.

## With Image

If the image has been loaded, you can add the shape to the [ImageLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfImageEditor.XForms~Syncfusion.SfImageEditor.XForms.SfImageEditor~ImageLoaded_EV.html) event as shown in the code snippet as follows.

```

editor.ImageLoaded += (Object sender, ImageLoadedEventArgs args) =>
 {
                  editor.AddShape(ShapeType.Circle,new PenSettings() { Color=Color.Green}); 
 } 

```

## Without Image

When image editor does not have a loaded image, add a shape with some time delay to the timer as shown in the code snippet as follows.

**C#**

```

   Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
                {
                 editor.AddShape(ShapeType.Circle,new PenSettings() { Color=Color.Green});  
                    return false;
                });

```

See Also:

[How do I add a shape to an image?](https://help.syncfusion.com/xamarin/image-editor/shapes)

[How do I notify the image that is loaded in the SfImageEditor control?](https://help.syncfusion.com/xamarin/image-editor/save#imageloaded-event)

Also refer our [feature tour](https://www.syncfusion.com/xamarin-ui-controls/xamarin-image-editor) page to know more features available in our SfImageEditor.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## Syncfusion controls:

This project used the following Syncfusion control(s):
* [SfImageEditor](https://www.syncfusion.com/xamarin-ui-controls/xamarin-image-editor)

## Requirements to run the sample

Refer to the following link for more details - [System Requirements](https://help.syncfusion.com/xamarin/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.xaml.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

			InitializeComponent();

			MainPage = new App1.MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/xamarin/licensing/overview) for more details.

3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples. 
