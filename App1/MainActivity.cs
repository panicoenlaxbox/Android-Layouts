using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1
{
    class Person : IParcelable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IntPtr Handle { get; }
        public int DescribeContents()
        {
            throw new NotImplementedException();
        }

        public void WriteToParcel(Parcel dest, ParcelableWriteFlags flags)
        {
            throw new NotImplementedException();
        }
    }
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ActivityBase
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button linearLayoutExample = FindViewById<Button>(Resource.Id.linearLayoutExample);

            linearLayoutExample.Click +=
                (sender, args) => StartActivity(typeof(LinearLayoutExample));
        }
    }
}

