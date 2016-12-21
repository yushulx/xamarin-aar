using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Com.Dynamsoft.Barcode;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate {
                Bitmap image = BitmapFactory.DecodeResource(Resources, Resource.Drawable.qr);
                BarcodeReader barcodeReader = new BarcodeReader("license");
                ReadResult result = barcodeReader.ReadSingle(image, Barcode.QrCode);

                button.Text = string.Format("{0} clicks! barcode result: {1}", count++, result.Barcodes[0].DisplayValue);
            };
        }
    }
}

