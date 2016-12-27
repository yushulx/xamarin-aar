# Xamarin Project with Android AAR

## Download
Get the latest [Dynamsoft SDK package for Android][0] - **DynamsoftBarcodeReader.aar**.

## What's included?
* library: convert **DynamsoftBarcodeReader.aar** to a Xamarin.Android Java Bindings Library.
* app: a Xamarin Android project for reading barcode.

## How to Run?
1. Build the library project to generate **DBRAndroid.dll** in **Visual Studio 2015**.
2. Open the Android project and add the reference.
3. Build the Android project and run the app on your mobile device or emulator.

## Code Snippet
```CSharp
using Com.Dynamsoft.Barcode;

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
```

## Reference
* [Binding an .AAR][1]

## Blog
[How to Use Android AAR File in Xamarin Project][2]

[0]:http://www.dynamsoft.com/Downloads/Dynamic-Barcode-Reader-Download.aspx
[1]:https://developer.xamarin.com/guides/android/advanced_topics/binding-a-java-library/binding-an-aar/
[2]:http://www.codepool.biz/xamarin-use-android-aar-file.html
