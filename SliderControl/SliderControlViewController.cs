using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using RadialProgress;

namespace SliderControl
{
    public partial class SliderControlViewController : UIViewController
    {
        RadialProgressView ProgressView{ get; set; }

        public SliderControlViewController(IntPtr handle) : base (handle)
        {
        }
        
        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            
            // Release any cached data, images, etc that aren't in use.
            SliderControl.ValueChanged -= SliderValueChanged;
        }
        
        #region View lifecycle
        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            // Perform any additional setup after loading the view, typically from a nib.
            ProgressView = new RadialProgressView {
                Center = new PointF (View.Center.X, View.Center.Y - 100),
                MaxValue =100,
                MinValue = 0
            };
            ProgressView.Value = 0;
            SliderControl.Value = 0;

            SliderControl.ValueChanged += SliderValueChanged;
            View.AddSubview(ProgressView);

        }

        void SliderValueChanged(object sender, EventArgs e)
        {
            int value = (int)((UISlider)sender).Value;
            InvokeOnMainThread(() => {
                ProgressView.Value = value;
            });
        }
        
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }
        
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }
        
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }
        
        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }
        
        #endregion
        
        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }
    }
}

