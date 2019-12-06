using Syncfusion.XForms.iOS.Expander;
using Syncfusion.XForms.iOS.Border;using Syncfusion.XForms.iOS.Buttons;
using Syncfusion.SfChart.XForms.iOS.Renderers;
using Syncfusion.SfRating.XForms.iOS;
using Syncfusion.SfRotator.XForms.iOS;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.XForms.iOS.Core;
using Syncfusion.SfMaps.XForms.iOS;
using Syncfusion.XForms.iOS.Graphics;
using Syncfusion.SfCalendar.XForms.iOS;
using Syncfusion.XForms.iOS.ComboBox;
using  Syncfusion.XForms.iOS.Graphics;
using Syncfusion.XForms.iOS.Border;
using Syncfusion.XForms.iOS.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace PayVantage.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            SfSegmentedControlRenderer.Init();
            SfExpanderRenderer.Init();
            SfChartRenderer.Init();
            SfRatingRenderer.Init();
            SfRotatorRenderer.Init();
            SfListViewRenderer.Init();
            Core.Init();
            SfMapsRenderer.Init();
            SfComboBoxRenderer.Init();
            SfCalendarRenderer.Init();
            SfGradientViewRenderer.Init();
            SfBorderRenderer.Init();
            SfButtonRenderer.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
