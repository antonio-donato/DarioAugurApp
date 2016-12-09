using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Newtonsoft.Json.JsonConvert;

namespace DarioAugurApp
{
    [Activity(Label = "SceltaActivity", ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/MyCustomTheme")]
    public class SceltaActivity : Activity
    {
        private Dario1 _scelta;
        private MediaPlayer _player;
        List<int> _thumbsIds = new List<int>();
        private List<int> _mp3List;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SceltaActivity);

            this.Title = "Scegli il tuo omino!";
            _scelta = DeserializeObject<Dario1>(Intent.GetStringExtra("MyData"));
            _thumbsIds = _scelta._imageList;
            _mp3List = _scelta._mp3List;

            var gridview = FindViewById<GridView>(Resource.Id.gridView1);
            gridview.Adapter = new ImageAdapter(this, _thumbsIds);
            //String _extra = Intent.GetStringExtra("MyData");

            gridview.ItemClick += ButtonClick;
            //gridview.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs args)
            //{
            //    Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            //};

        }

        private void ButtonClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            int numero = args.Position;
            int mp3Selected = _mp3List[numero];

            _player = MediaPlayer.Create(this, mp3Selected);
            _player.Start();
        }
    }
}