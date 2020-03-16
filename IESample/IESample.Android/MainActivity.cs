
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android;
namespace IESample.Droid
{
    [Activity(Label = "IESample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        const string permission = Manifest.Permission.WriteExternalStorage;
        const int RequestId = 0;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            if (CheckSelfPermission(permission) == (int)Permission.Granted)
            {

            }
            else
            {

                RequestPermissions(new string[] { Manifest.Permission.ReadExternalStorage, Manifest.Permission.WriteExternalStorage }, RequestId);
            }
            LoadApplication(new App());
        }
    }
}

