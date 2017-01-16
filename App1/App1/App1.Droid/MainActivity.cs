using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App1.Droid
{
	[Activity (Label = "App1.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
        float zahl1 = -1;
        float zahl2 = -1;
        String operationszeichen = null;


        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

            Button button0 = FindViewById<Button>(Resource.Id.button14);
            Button button1 = FindViewById<Button>(Resource.Id.button9);
            Button button2 = FindViewById<Button>(Resource.Id.button10);
            Button button3 = FindViewById<Button>(Resource.Id.button11);
            Button button4 = FindViewById<Button>(Resource.Id.button5);
            Button button5 = FindViewById<Button>(Resource.Id.button6);
            Button button6 = FindViewById<Button>(Resource.Id.button7);
            Button button7 = FindViewById<Button>(Resource.Id.button1);
            Button button8 = FindViewById<Button>(Resource.Id.button2);
            Button button9 = FindViewById<Button>(Resource.Id.button3);

            Button buttonPunkt = FindViewById<Button>(Resource.Id.button15);
            Button buttonEnter = FindViewById<Button>(Resource.Id.button16);

            Button buttonDivi = FindViewById<Button>(Resource.Id.button4);
            Button buttonMulti = FindViewById<Button>(Resource.Id.button8);
            Button buttonSummi = FindViewById<Button>(Resource.Id.button17);
            Button buttonSub = FindViewById<Button>(Resource.Id.button12);

            //button.Click += delegate {
            //	button.Text = string.Format ("{0} clicks!", count++);
            //};

            button0.Click += delegate {
                //button.Text = string.Format("{0} clicks!", count++);
                if (zahl1 != -1)
                {

                }
            };
        }
	}
}


