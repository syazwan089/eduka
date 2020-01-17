using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Eduka.Control;
using Eduka.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(FontAwesomeIconRenderer))]
namespace Eduka.Droid.Renderer
{
    public class FontAwesomeIconRenderer : LabelRenderer
    {
  
            private readonly Context _context;

            public FontAwesomeIconRenderer(Context context) : base(context)
            {
                _context = context;
            }

            protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
            {
                base.OnElementChanged(e);
                if (e.OldElement == null)
                {
                    //The ttf in /Assets is CaseSensitive, so name it FontAwesome.ttf
                    Control.Typeface = Typeface.CreateFromAsset(_context.Assets, FontAwesomeIcon.Typeface + ".ttf");
                }
            }
        
    }
}