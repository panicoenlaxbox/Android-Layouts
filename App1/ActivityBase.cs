using Android.App;
using Android.OS;
using Android.Util;

namespace App1
{
    public class ActivityBase : Activity
    {
        private void Write(string message)
        {
#if DEBUG
            Log.Debug($"My log: {GetType().Name}", message);
#endif
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // The activity is being created
            Write($"OnCreate{(savedInstanceState != null ? " with bundle" : null)}");
        }

        protected override void OnStart()
        {
            base.OnStart();
            // The activity is about to become visible
            Write("OnStart");
        }

        protected override void OnResume()
        {
            base.OnResume();
            // The activity has become visible (it is now "resumed")
            Write("OnResume");
        }

        protected override void OnPause()
        {
            base.OnPause();
            // Another activity is taking focus (this activity is about to be "paused").
            Write("OnPause");
            if (IsFinishing)
            {
                Write("It's finishing");
            }
        }

        protected override void OnStop()
        {
            base.OnStop();
            // The activity is no longer visible (it is now "stopped")
            Write("OnStop");
            if (IsFinishing)
            {
                Write("It's finishing");
            }
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            // The activity is about to be destroyed.
            Write("OnDestroy");
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            Write("OnSaveInstanceState");
        }

        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
            Write($"OnRestoreInstanceState{(savedInstanceState != null ? " with bundle" : null)}");
        }
    }
}