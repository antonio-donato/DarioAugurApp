using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DarioAugurApp
{
    [Activity(Label = "Seleziona Auguri", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/MyCustomTheme")]
    public class SceltaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var gridview = FindViewById<GridView>(Resource.Id.gridView1);
            gridview.Adapter = new ImageAdapter(this);

            gridview.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            };
        }
    }
}