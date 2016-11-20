using System;
using System.Collections.Generic;

namespace DarioAugurApp
{
    public class Dario1
    {
        public List<int> _mp3List;
        public List<int> _imageList;
        private List<int> _contatoriList;
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
            _contatoriList = new List<int>();
        }

        // Selezioan un numero random con massimo il numero di elementi della lista mp3 
        public int SelectRandom()
        {
            int r = Rnd.Next(_mp3List.Count);
            _contatoriList[r] += 1;
            return r;
        }


        // Riempi le liste di MP3 ed immagini con quelle fornite
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

            _mp3List.Add(Resource.Raw.Ges_);
            _imageList.Add(Resource.Drawable.Ges_);

            foreach (var i in _mp3List)
            {
                _contatoriList.Add(0);
            }

        }

        // restituisce l'mp3 dell'elemento selezionato
        public int SelezionaMp3(int indice)
        {
            return _mp3List[indice];
        }

        //restituisce l'immagine dell'elemento selezioanto
        public int SelezionaImage(int indice)
        {
            return _imageList[indice];
        }

        // Restituisce il totale del conteggio dell'elemento
        public int ResContatore(int indice)
        {
            return _contatoriList[indice];
        }
    }
}