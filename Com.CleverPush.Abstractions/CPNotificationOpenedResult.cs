using System;
using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
    public class CPNotificationOpenedResult
    {
        public CPNotification notification;
		public CPSubscription subscription;
		public Dictionary<string, object> payload;
	}
}
