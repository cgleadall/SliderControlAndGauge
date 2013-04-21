// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SliderControl
{
	[Register ("SliderControlViewController")]
	partial class SliderControlViewController
	{
		[Outlet]
		MonoTouch.UIKit.UISlider SliderControl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SliderControl != null) {
				SliderControl.Dispose ();
				SliderControl = null;
			}
		}
	}
}
