﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PlanIt.Droid
{
	[Activity (Label = "EventDetails", MainLauncher = true)]			
	public class EventDetails : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
			SetContentView (Resource.Layout.EventDetails);

			RadioButton radio_going = FindViewById<RadioButton>(Resource.Id.radio_going);
			RadioButton radio_maybe = FindViewById<RadioButton>(Resource.Id.radio_maybe);
			RadioButton radio_cannot = FindViewById<RadioButton>(Resource.Id.radio_cannot);

			radio_going.Click += RadioButtonClick;
			radio_maybe.Click += RadioButtonClick;
			radio_cannot.Click += RadioButtonClick;
		}

		private void RadioButtonClick (object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			Toast.MakeText (this, rb.Text, ToastLength.Short).Show ();
		}
	}
}
