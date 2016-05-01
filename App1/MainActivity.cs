using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ActivityBase
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var linearLayoutExample = FindViewById<Button>(Resource.Id.linearLayoutExample);
            linearLayoutExample.Click +=
                (sender, args) => StartActivity(typeof(LinearLayoutExample));

            var tableLayoutExample = FindViewById<Button>(Resource.Id.tableLayoutExample);
            tableLayoutExample.Click +=
                (sender, args) => StartActivity(typeof(TableLayoutExample));

            var relativeLayoutExample1 = FindViewById<Button>(Resource.Id.relativeLayoutExample1);
            relativeLayoutExample1.Click +=
                (sender, args) => StartActivity(typeof(RelativeLayoutExample1));

            var relativeLayoutExample2 = FindViewById<Button>(Resource.Id.relativeLayoutExample2);
            relativeLayoutExample2.Click +=
                (sender, args) => StartActivity(typeof(RelativeLayoutExample2));
        }
    }
}

