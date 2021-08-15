using System;
using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
	public class CPNotification
	{
		public string id;
		public string title;
		public string text;
		public string url;
		public Dictionary<string, object> customData;
		public string iconUrl;
		public string mediaUrl;
	}
}
