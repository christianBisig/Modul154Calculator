using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using static Android.Widget.TextView;

namespace App1.Droid
{
	[Activity (Label = "App1.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        float zahl1 = 0;
        float zahl2 = 0;
        float result = 0;
        String operationszeichen = null;


        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
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

            TextView textView = FindViewById<TextView>(Resource.Id.textView3);
            textView.SetText("", BufferType.Editable);
            //button.Click += delegate {
            //	button.Text = string.Format ("{0} clicks!", count++);
            //};

            button0.Click += delegate {saveNumber(0);};
            button1.Click += delegate { saveNumber(1); };
            button2.Click += delegate { saveNumber(2); };
            button3.Click += delegate { saveNumber(3); };
            button4.Click += delegate { saveNumber(4); };
            button5.Click += delegate { saveNumber(5); };
            button6.Click += delegate { saveNumber(6); };
            button7.Click += delegate { saveNumber(7); };
            button8.Click += delegate { saveNumber(8); };
            button9.Click += delegate { saveNumber(9); };

            buttonPunkt.Click += delegate { saveNumber(0); };

            buttonDivi.Click += delegate { setOperator("/"); };
            buttonMulti.Click += delegate { setOperator("*"); };
            buttonSummi.Click += delegate { setOperator("+"); };
            buttonSub.Click += delegate { setOperator("-"); };

            buttonEnter.Click += delegate {
                Calculator c = new Calculator();
                result = c.Calculate(operationszeichen, zahl1, zahl2);
                textView.SetText(result.ToString(), BufferType.Editable);
                operationszeichen = null;
                zahl1 = 0;
                zahl2 = 0;
            };





        }

        private void saveNumber(int zahl)
        {
            if (operationszeichen == null)
            {
                TextView textView = FindViewById<TextView>(Resource.Id.textView3);
                zahl1 = zahl1 *10 + zahl;
                textView.SetText(zahl1.ToString(), BufferType.Editable);
            }
            else
            {
                TextView textView = FindViewById<TextView>(Resource.Id.textView3);
                zahl2 = zahl2 *10 + zahl;
                textView.SetText(zahl2.ToString(), BufferType.Editable);
            }
        }

        private void setOperator(String zeichen)
        {
            TextView textView = FindViewById<TextView>(Resource.Id.textView3);
            operationszeichen = zeichen;
            textView.SetText(operationszeichen.ToString(), BufferType.Editable);
        }


        
    }
}


