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
using AndroidSQLite.Resources.Model;
using Java.Lang;

namespace AndroidSQLite.Resources
{
    public class ViewHolder : Java.Lang.Object
    {
        public TextView txtName { get; set; }

    }
    public class ListViewAdapter:BaseAdapter
    {
        private Activity activity;
        private List<Grocery> lstGrocery;
        public ListViewAdapter(Activity activity, List<Grocery> lstGrocery)
        {
            this.activity = activity;
            this.lstGrocery = lstGrocery;
        }

        public override int Count
        {
            get
            {
                return lstGrocery.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return lstGrocery[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.list_view_dataTemplate, parent, false);

            var txtName = view.FindViewById<TextView>(Resource.Id.textView1);

            txtName.Text = lstGrocery[position].Name;
    

            return view;
        }
    }
}