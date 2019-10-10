using System;
using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
   public delegate void NotificationReceivedListener(CPNotificationOpenedResult notification);

   public delegate void NotificationOpenedListener(CPNotificationOpenedResult result);

   public delegate void SubscribedListener(string subscriptionId);
}
