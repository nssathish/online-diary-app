using Android.App;
using Android.Widget;
using Android.OS;

namespace Podo
{
    [Activity(Label = "Podo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView _number;
        Button _increment, _decrement;
        int number = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            _number = FindViewById<TextView>(Resource.Id.number);
            _increment = FindViewById<Button>(Resource.Id.btnIncrement);
            _decrement = FindViewById<Button>(Resource.Id.btnDecrement);

            FindViewById<Button>(Resource.Id.btnIncrement).Click += (o, e) =>
            {
                _number.Text = (++number).ToString();
            };
            FindViewById<Button>(Resource.Id.btnDecrement).Click += (o, e) =>
            {
                _number.Text = (--number).ToString();
            };
        }
    }
}

