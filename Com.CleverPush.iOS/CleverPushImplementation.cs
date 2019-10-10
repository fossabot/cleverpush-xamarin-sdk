using System;
using Foundation;
using UserNotifications;
using System.Diagnostics;
using System.Collections.Generic;
using Com.CleverPush.Abstractions;
using CPNotification = Com.CleverPush.Abstractions.CPNotification;
using CPNotificationOpenedResult = Com.CleverPush.Abstractions.CPNotificationOpenedResult;

namespace Com.CleverPush
{
	public class CleverPushImplementation : CleverPushShared, ICleverPush
   {
      public static Dictionary<string, object> NSDictToPureDict(NSDictionary nsDict)
      {
         if (nsDict == null)
            return null;
         NSError error;
         NSData jsonData = NSJsonSerialization.Serialize(nsDict, 0, out error);
         NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
         string jsonString = jsonNSString.ToString();
         return Json.Deserialize(jsonString) as Dictionary<string, object>;
      }

      private CPNotificationOpenedResult CPNotificationOpenedResultToXam(iOS.CPNotificationOpenedResult result)
      {
         var openresult = new CPNotificationOpenedResult();
         openresult.notification = CPNotificationToXam(result.Notification);
			openresult.subscription = NSDictToPureDict(result.Subscription);
			openresult.payload = NSDictToPureDict(result.Payload);

			return openresult;
      }

		private CPNotification CPNotificationToXam(NSDictionary nativeNotif)
        {
			var notif = NSDictToPureDict(nativeNotif);

			var notification = new CPNotification();

         notification.customData = new Dictionary<string, object>();
        
         notification.id = (string)notif["_id"];
			notification.title = (string)notif["title"];
			notification.text = (string)notif["text"];
			notification.url = (string) notif["url"];


			return notification;
		}

		public void NotificationOpenedListener(iOS.CPNotificationOpenedResult result)
		{
			OnNotificationOpened(CPNotificationOpenedResultToXam(result));
		}

		public void NotificationReceivedListener(iOS.CPNotificationOpenedResult result)
		{
			OnNotificationReceived(CPNotificationOpenedResultToXam(result));
		}

		public void SubscribedListener(string subscriptionId)
		{
			OnSubscribed(subscriptionId);
		}

		public override void InitPlatform()
      {
         Init(builder.mChannelId);
      }

      public void Init(string channelId)
      {
         iOS.CleverPush.InitWithLaunchOptions(new NSDictionary(), channelId, NotificationOpenedListener, SubscribedListener);
      }

      public override void Subscribe()
      {
         iOS.CleverPush.Subscribe();
	  }

	  public override void Unsubscribe()
	  {
		  iOS.CleverPush.Unsubscribe();
	  }

		public void DidReceiveNotificationExtensionRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent)
		{
			iOS.CleverPush.DidReceiveNotificationExtensionRequest(request, replacementContent);
		}

		public void ServiceExtensionTimeWillExpireRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent)
		{
			iOS.CleverPush.ServiceExtensionTimeWillExpireRequest(request, replacementContent);
		}
	}
}
