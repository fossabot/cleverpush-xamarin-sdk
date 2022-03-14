using System;

namespace Com.CleverPush
{
    public class NotificationReceivedHandler : Android.NotificationReceivedCallbackListener
    {
        private bool showNotificationsInForeground;

        public NotificationReceivedHandler(bool _showNotificationsInForeground)
        {
            showNotificationsInForeground = _showNotificationsInForeground;
        }

        public override bool NotificationReceivedCallback(Android.NotificationOpenedResult result)
        {
            (CleverPush.Current as CleverPushImplementation).OnNotificationReceived(NotificationOpenedHandler.CPNotificationOpenedResultToNative(result));

            return showNotificationsInForeground;
        }
	}
}
