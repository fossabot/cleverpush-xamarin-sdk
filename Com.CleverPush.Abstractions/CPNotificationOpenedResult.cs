using System;
using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
    public class CPNotificationOpenedResult
    {
        public CPNotification notification;
		public Dictionary<string, object> subscription;
		public Dictionary<string, object> payload;
	}
}
