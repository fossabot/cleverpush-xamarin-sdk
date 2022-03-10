using System;
using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
	public class XamarinBuilder
	{
		public string mChannelId;
		public NotificationReceivedListener _notificationReceivedDelegate;
		public NotificationOpenedListener _notificationOpenedDelegate;
		public SubscribedListener _subscribedDelegate;
		public bool _autoRegister = true;
		CleverPushShared mCleverPushShared;

		internal XamarinBuilder(string channelId, CleverPushShared cleverPushShared)
		{
			mChannelId = channelId;
			mCleverPushShared = cleverPushShared;
		}

		public XamarinBuilder HandleNotificationReceived(NotificationReceivedListener inNotificationReceivedDelegate)
		{
			_notificationReceivedDelegate = inNotificationReceivedDelegate;
			return this;
		}

		public XamarinBuilder HandleNotificationOpened(NotificationOpenedListener inNotificationOpenedDelegate)
		{
			_notificationOpenedDelegate = inNotificationOpenedDelegate;
			return this;
		}

		public XamarinBuilder HandleSubscribed(SubscribedListener inSubscribedDelegate)
		{
			_subscribedDelegate = inSubscribedDelegate;
			return this;
		}

		public XamarinBuilder AutoRegister(bool autoRegister)
		{
			_autoRegister = autoRegister;
			return this;
		}

		public void EndInit()
		{
			mCleverPushShared.InitPlatform();
		}
	}
}
