using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;
using Newtonsoft.Json;

namespace DarioAugurApp
{
    [Activity(Label = "DarioAugurApp", MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait, Theme = "@style/MyCustomTheme")]
    public class MainActivity : Activity
    {

        private Dario1 _scelta = new Dario1();
        private MediaPlayer _player;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ImageButton image = FindViewById<ImageButton>(Resource.Id.imageButton1);
            Button buttonRandom = FindViewById<Button>(Resource.Id.buttonRandom);
            Button buttonSelection = FindViewById<Button>(Resource.Id.buttonSelection);

            // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            image.Click += ButtonRandom_Click;

            // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            buttonRandom.Click += ButtonRandom_Click;

            // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            buttonSelection.Click += delegate
            {
                var sceltaActivity = new Intent(this, typeof(SceltaActivity));
                sceltaActivity.PutExtra("MyData", JsonConvert.SerializeObject(_scelta));
                StartActivity(sceltaActivity);
            };

            // Riempio l'array contenente l'mp3 e l'immagine della persona scelta
            _scelta.RiempiLista();

        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {

            int numeroRnd = _scelta.SelectRandom();
            int mp3Selected = _scelta.SelezionaMp3(numeroRnd);
            int imageSelected = _scelta.SelezionaImage(numeroRnd);

            var imageButton =
                FindViewById<ImageButton>(Resource.Id.imageButton1);
            imageButton.SetImageResource(imageSelected);

            _player = MediaPlayer.Create(this, mp3Selected);
            _player.Start();

            String volte = _scelta.ResContatore(numeroRnd) < 2 ? "volta" : "volte";
            String testoToast = "Visualizzato " + _scelta.ResContatore(numeroRnd).ToString() + " " + volte;
            Toast.MakeText(this, testoToast, ToastLength.Short).Show();
        }
    }
}

