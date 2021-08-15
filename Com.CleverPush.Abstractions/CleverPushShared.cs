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
		public abstract void SetSubscriptionTopics(string[] topicIds);
		public abstract ICollection<string> GetSubscriptionTopics();
		public abstract void GetAvailableTopics(ChannelTopicsListener listener);

		public abstract void AddSubscriptionTag(string tagId);
		public abstract void RemoveSubscriptionTag(string tagId);
		public abstract bool HasSubscriptionTag(string tagId);
		public abstract ICollection<string> GetSubscriptionTags();
		public abstract void GetAvailableTags(ChannelTagsListener listener);

		public abstract object GetSubscriptionAttribute(string attributeId);
		public abstract void SetSubscriptionAttribute(string attributeId, string value);
		public abstract void GetAvailableAttributes(ChannelAttributesListener listener);

		public abstract void TrackPageView(string url);
		public abstract void TrackPageView(string url, Dictionary<string, object> parameters);

		public abstract ICollection<CPNotification> GetNotifications();

		public abstract void TriggerAppBannerEvent(string key, string value);
		public abstract void ShowAppBanner(string bannerId);

		public abstract void TrackEvent(string eventName);
		public abstract void TrackEvent(string eventName, float amount);

		public abstract void SetTrackingConsentRequired(bool required);
		public abstract void SetTrackingConsent(bool consent);

		public abstract void SetAutoClearBadge(bool autoClear);
		public abstract void SetIncrementBadge(bool increment);

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
