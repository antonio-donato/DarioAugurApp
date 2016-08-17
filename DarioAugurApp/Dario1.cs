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

namespace DarioAugurApp
{
    public class Dario1
    {
        private List<int> _mp3List;
        private List<int> _imageList;
        static Random _rnd = new Random();

        public static Random Rnd
        {
            get { return _rnd; }
            set { _rnd = value; }
        }

        public Dario1()
        {
            _mp3List = new List<int>();
            _imageList = new List<int>();
        }

        public int SelectRandom()
        {
            int r = Rnd.Next(_mp3List.Count);
            return r;
        }

        public void RiempiLista()
        {
            _mp3List.Add(Resource.Raw.Picci);
            _imageList.Add(Resource.Drawable.Picci);

            _mp3List.Add(Resource.Raw.Donny);
            _imageList.Add(Resource.Drawable.Donny);

            _mp3List.Add(Resource.Raw.Simone);
            _imageList.Add(Resource.Drawable.Simone);

            _mp3List.Add(Resource.Raw.Alan);
            _imageList.Add(Resource.Drawable.Alan);

            _mp3List.Add(Resource.Raw.Beppe);
            _imageList.Add(Resource.Drawable.Beppe);

            _mp3List.Add(Resource.Raw.Bruno);
            _imageList.Add(Resource.Drawable.Bruno);

            _mp3List.Add(Resource.Raw.Diego);
            _imageList.Add(Resource.Drawable.Diego);

            _mp3List.Add(Resource.Raw.Fabio);
            _imageList.Add(Resource.Drawable.Fabio);

            _mp3List.Add(Resource.Raw.Fabri);
            _imageList.Add(Resource.Drawable.Fabri);

            _mp3List.Add(Resource.Raw.Faggi);
            _imageList.Add(Resource.Drawable.Faggi);

            _mp3List.Add(Resource.Raw.Gallo);
            _imageList.Add(Resource.Drawable.Gallo);

            _mp3List.Add(Resource.Raw.Mauro);
            _imageList.Add(Resource.Drawable.Mauro);

            _mp3List.Add(Resource.Raw.Nando);
            _imageList.Add(Resource.Drawable.Nando);

            _mp3List.Add(Resource.Raw.Paolo);
            _imageList.Add(Resource.Drawable.Paolo);

            _mp3List.Add(Resource.Raw.Roby);
            _imageList.Add(Resource.Drawable.Roby);

            _mp3List.Add(Resource.Raw.Stefen);
            _imageList.Add(Resource.Drawable.Stefen);

            _mp3List.Add(Resource.Raw.Tabo);
            _imageList.Add(Resource.Drawable.Tabo);

            _mp3List.Add(Resource.Raw.Vale);
            _imageList.Add(Resource.Drawable.Vale);

        }

        public int SelezionaMp3(int numeroRnd)
        {
            return _mp3List[numeroRnd];
        }

        public int SelezionaImage(int numeroRnd)
        {
            return _imageList[numeroRnd];
        }
    }
}