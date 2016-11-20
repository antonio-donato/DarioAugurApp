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
    public class ImageAdapter : BaseAdapter
    {
        Context context;

        // references to our images
        List<int> thumbIds;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public ImageAdapter(Context c, List<int> d)
        {
            context = c;
            thumbIds = d;
        }

        public override int Count
        {
            get { return thumbIds.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {  // if it's not recycled, initialize some attributes
                imageView = new ImageView(context) {LayoutParameters = new GridView.LayoutParams(100, 100)};
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(2, 2, 2, 2);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(thumbIds[position]);
            return imageView;
        }


    }
}