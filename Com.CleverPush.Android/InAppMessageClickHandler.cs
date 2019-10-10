using CleverPush.Abstractions;

namespace CleverPush
{
   public class InAppMessageClickHandler : Java.Lang.Object, Android.CleverPush.IInAppMessageClickHandler
    {
        public void InAppMessageClicked(Android.OSInAppMessageAction action)
        {
            (CleverPush.Current as CleverPushImplementation).OnInAppMessageClicked(OSInAppMessageClickedActionToNative(action));
        }

        private static OSInAppMessageAction OSInAppMessageClickedActionToNative(Android.OSInAppMessageAction action)
        {
            OSInAppMessageAction inAppMessageAction = new OSInAppMessageAction();
            inAppMessageAction.clickName = action.ClickName;
            inAppMessageAction.clickUrl = action.ClickUrl;
            inAppMessageAction.firstClick = action.FirstClick;
            inAppMessageAction.closesMessage = action.ClosesMessage;
            return inAppMessageAction;
        }
    }
}
