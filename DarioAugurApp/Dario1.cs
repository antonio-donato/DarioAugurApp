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
        private string _path;
        static Random _rnd = new Random();
        private string _searchPattern;

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