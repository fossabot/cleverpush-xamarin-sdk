using System;
using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
   public interface ICleverPush
   {
		XamarinBuilder StartInit(string channelId);

		void Subscribe();
		void Unsubscribe();

		void ShowTopicsDialog();
		void SetSubscriptionTopics(string[] topicIds);
		ICollection<string> GetSubscriptionTopics();
		void GetAvailableTopics(ChannelTopicsListener listener);

		void AddSubscriptionTag(string tagId);
		void RemoveSubscriptionTag(string tagId);
		bool HasSubscriptionTag(string tagId);
		ICollection<string> GetSubscriptionTags();
		void GetAvailableTags(ChannelTagsListener listener);

		object GetSubscriptionAttribute(string attributeId);
		void SetSubscriptionAttribute(string attributeId, string value);
		void GetAvailableAttributes(ChannelAttributesListener listener);

		void TrackPageView(string url);
		void TrackPageView(string url, Dictionary<string, object> parameters);

		ICollection<CPNotification> GetNotifications();

		void TriggerAppBannerEvent(string key, string value);
		void ShowAppBanner(string bannerId);

		void TrackEvent(string eventName);
		void TrackEvent(string eventName, float amount);

		void SetTrackingConsentRequired(bool required);
		void SetTrackingConsent(bool consent);

		void SetAutoClearBadge(bool autoClear);
		void SetIncrementBadge(bool increment);
	}
}
