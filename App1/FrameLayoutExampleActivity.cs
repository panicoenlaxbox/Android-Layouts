using Android.App;
using Android.OS;

namespace App1
{
    [Activity(Label = "FrameLayoutExample")]
    public class FrameLayoutExampleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.frameLayoutExample);
        }
    }
}