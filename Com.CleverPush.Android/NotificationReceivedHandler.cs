using System;

namespace Com.CleverPush
{
    public class NotificationReceivedHandler : Java.Lang.Object, Android.INotificationReceivedListener
	{
        public void NotificationReceived(Android.NotificationOpenedResult result)
        {
            (CleverPush.Current as CleverPushImplementation).OnNotificationReceived(NotificationOpenedHandler.CPNotificationOpenedResultToNative(result));
        }
    }
}
