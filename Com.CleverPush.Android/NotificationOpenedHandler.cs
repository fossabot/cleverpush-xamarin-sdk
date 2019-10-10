using System;
using System.Collections.Generic;
using Com.CleverPush.Abstractions;

namespace Com.CleverPush
{
    public class NotificationOpenedHandler : Java.Lang.Object, Android.INotificationOpenedListener
    {
        public void NotificationOpened(Android.NotificationOpenedResult result)
        {
            (CleverPush.Current as CleverPushImplementation).OnNotificationOpened(CPNotificationOpenedResultToNative(result));
        }

        public static CPNotificationOpenedResult CPNotificationOpenedResultToNative(Android.NotificationOpenedResult result)
        {
            var openresult = new CPNotificationOpenedResult();
            openresult.notification = CPNotificationToNative(result.Notification);

            return openresult;
        }

        public static CPNotification CPNotificationToNative(Android.Notification notif)
        {
            var notification = new CPNotification();

            notification.customData = new Dictionary<string, object>();
            if (notif.CustomData != null)
            {
				foreach (var item in (Dictionary<string, object>) notif.CustomData)
				{
					notification.customData.Add(item.Key, item.Value);
				}
            }

			notification.id = notif.Id;
			notification.title = notif.Title;
			notification.text = notif.Text;
			notification.url = notif.Url;
            notification.mediaUrl = notif.MediaUrl;
			notification.iconUrl = notif.IconUrl;

			return notification;
        }
    }
}
