using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace DarioAugurApp
{
    [Activity(Label = "DarioAugurApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private Dario1 scelta = new Dario1();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += Button_Click;

            // Riempio l'array contenente l'mp3 e l'immagine della persona scelta
            scelta.RiempiLista();

        }

        private MediaPlayer _player;

        private void Button_Click(object sender, EventArgs e)
        {

            int numeroRnd = scelta.SelectRandom();
            int mp3Selected = scelta.SelezionaMp3(numeroRnd);
            int imageSelected = scelta.SelezionaImage(numeroRnd);

            var imageView =
                FindViewById<ImageView>(Resource.Id.imageView1);
            imageView.Visibility = ViewStates.Visible;
            imageView.SetImageResource(imageSelected);

            _player = MediaPlayer.Create(this, mp3Selected);
            _player.Start();

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = "Conteggio: " + scelta.ResContatore(numeroRnd).ToString();

        }
    }
}

