// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BasicForm
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton CheckboxOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField EmailOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField NameOutlet { get; set; }

		[Action ("SubmitBtnAction:")]
		partial void SubmitBtnAction (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CheckboxOutlet != null) {
				CheckboxOutlet.Dispose ();
				CheckboxOutlet = null;
			}

			if (EmailOutlet != null) {
				EmailOutlet.Dispose ();
				EmailOutlet = null;
			}

			if (NameOutlet != null) {
				NameOutlet.Dispose ();
				NameOutlet = null;
			}
		}
	}
}
