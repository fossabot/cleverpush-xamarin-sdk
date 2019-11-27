using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Com.CleverPush.Abstractions
{
   public abstract class CleverPushShared : ICleverPush
   {
      public XamarinBuilder StartInit(string channelId)
      {
         if (builder == null)
            builder = new XamarinBuilder(channelId, this);

         return builder;
      }

      public abstract void Subscribe();
	  public abstract void Unsubscribe();
		public abstract void ShowTopicsDialog();

		public XamarinBuilder builder;

      public abstract void InitPlatform();

      public void OnNotificationReceived(CPNotificationOpenedResult notification)
      {
         if (builder._notificationReceivedDelegate != null)
         {
            builder._notificationReceivedDelegate(notification);
         }
      }

      public void OnNotificationOpened(CPNotificationOpenedResult result)
      {
         if (builder._notificationOpenedDelegate != null)
         {
            builder._notificationOpenedDelegate(result);
         }
		}

		public void OnSubscribed(string subscriptionId)
		{
			if (builder._subscribedDelegate != null)
			{
				builder._subscribedDelegate(subscriptionId);
			}
		}

	}
}
