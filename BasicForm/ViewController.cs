using System;

using AppKit;
using Foundation;

namespace BasicForm
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void SubmitBtnAction(NSButton sender)
        {
            var name = NameOutlet.StringValue;
            var email = EmailOutlet.StringValue;
            var checkbox = CheckboxOutlet.State;
            string data = "Value of Name field: " + name + " Value of Email field: " + email + " Value of Subscribe checkbox field: " + checkbox;
            Console.WriteLine(data);
        }
    }
}
