using System;
using Com.CleverPush.Example.Shared;
using UIKit;

namespace Com.CleverPush.Example.iOS
{
   public class ExternalIdTextViewDelegate : UITextFieldDelegate
   {
      public override bool ShouldReturn(UITextField textField)
      {
         textField.ResignFirstResponder();
         return false;
      }
   }

   public partial class ViewController : UIViewController
   {
      protected ViewController(IntPtr handle) : base(handle)
      {

      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();

			SubscribedSwitch.ValueChanged += delegate {
				if (SubscribedSwitch.On)
				{
					SharedPush.Subscribe();
				}
				else
				{
					SharedPush.Unsubscribe();
				}
			};
		}

      public override void DidReceiveMemoryWarning()
      {
         base.DidReceiveMemoryWarning();
      }
   }
}
