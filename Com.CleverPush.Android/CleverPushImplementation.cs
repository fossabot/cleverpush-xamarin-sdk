using Android.App;
using Android.Content;
using System;
using Com.CleverPush.Abstractions;
using System.Collections.Generic;

namespace Com.CleverPush
{
   public class CleverPushImplementation : CleverPushShared, ICleverPush
   {
		public void Init(string channelId)
		{
			Android.CleverPush.GetInstance(Application.Context).Init(channelId, null, null, null, true);
		}

		public override void InitPlatform()
		{
			Init(builder.mChannelId);
		}

		public override void Subscribe()
		{
			Android.CleverPush.GetInstance(Application.Context).Subscribe();
		}

		public override void Unsubscribe()
		{
			Android.CleverPush.GetInstance(Application.Context).Unsubscribe();
		}

		public override void ShowTopicsDialog()
		{
			Android.CleverPush.GetInstance(Application.Context).ShowTopicsDialog();
		}

		public void ShowTopicsDialog(Context context)
		{
			Android.CleverPush.GetInstance(Application.Context).ShowTopicsDialog(context);
		}

		public override void SetSubscriptionTopics(string[] topicIds) {
			Android.CleverPush.GetInstance(Application.Context).SetSubscriptionTopics(topicIds);
		}

		public override ICollection<string> GetSubscriptionTopics()
		{
			return Android.CleverPush.GetInstance(Application.Context).SubscriptionTopics;
		}

		public override void GetAvailableTopics(Abstractions.ChannelTopicsListener listener)
		{
			Android.CleverPush.GetInstance(Application.Context).GetAvailableTopics(new ChannelTopicsListener(listener));
		}

		public override void AddSubscriptionTag(string tagId)
		{
			Android.CleverPush.GetInstance(Application.Context).AddSubscriptionTag(tagId);
		}

		public override void RemoveSubscriptionTag(string tagId)
		{
			Android.CleverPush.GetInstance(Application.Context).RemoveSubscriptionTag(tagId);
		}

		public override bool HasSubscriptionTag(string tagId)
		{
			return Android.CleverPush.GetInstance(Application.Context).HasSubscriptionTag(tagId);
		}

		public override ICollection<string> GetSubscriptionTags()
		{
			return Android.CleverPush.GetInstance(Application.Context).SubscriptionTags;
		}

		public override void GetAvailableTags(Abstractions.ChannelTagsListener listener)
		{
			Android.CleverPush.GetInstance(Application.Context).GetAvailableTags(new ChannelTagsListener(listener));
		}

		public override object GetSubscriptionAttribute(string attributeId)
		{
			return Android.CleverPush.GetInstance(Application.Context).GetSubscriptionAttribute(attributeId);
		}

		public override void SetSubscriptionAttribute(string attributeId, string value)
		{
			Android.CleverPush.GetInstance(Application.Context).SetSubscriptionAttribute(attributeId, value);
		}

		public override void GetAvailableAttributes(Abstractions.ChannelAttributesListener listener)
		{
			Android.CleverPush.GetInstance(Application.Context).GetAvailableAttributes(new ChannelAttributesListener(listener));
		}

		public override void TrackPageView(string url)
		{
			Android.CleverPush.GetInstance(Application.Context).TrackPageView(url);
		}

		public override void TrackPageView(string url, Dictionary<string, object> parameters)
		{
			Android.CleverPush.GetInstance(Application.Context).TrackPageView(url, parameters);
		}

		public override ICollection<CPNotification> GetNotifications()
		{
			List<CPNotification> notifications = new List<CPNotification>();
			var androidNotifications = Android.CleverPush.GetInstance(Application.Context).Notifications;
			foreach (Android.Notification notif in androidNotifications)
			{
				var notification = new CPNotification();

				notification.customData = new Dictionary<string, object>();
				if (notif.CustomData != null)
				{
					foreach (var item in (Dictionary<string, object>)notif.CustomData)
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

				notifications.Add(notification);
			}
			return notifications;
		}

		public override void TriggerAppBannerEvent(string key, string value)
		{
			Android.CleverPush.GetInstance(Application.Context).TriggerAppBannerEvent(key, value);
		}

		public override void ShowAppBanner(string bannerId)
		{
			Android.CleverPush.GetInstance(Application.Context).ShowAppBanner(bannerId);
		}

		public override void TrackEvent(string eventName)
		{
			Android.CleverPush.GetInstance(Application.Context).TrackEvent(eventName);
		}

		public override void TrackEvent(string eventName, float amount)
		{
			Android.CleverPush.GetInstance(Application.Context).TrackEvent(eventName, new Java.Lang.Float(amount));
		}

		public override void SetTrackingConsentRequired(bool required)
		{
			Android.CleverPush.GetInstance(Application.Context).SetTrackingConsentRequired(new Java.Lang.Boolean(required));
		}

		public override void SetTrackingConsent(bool consent)
		{
			Android.CleverPush.GetInstance(Application.Context).SetTrackingConsent(new Java.Lang.Boolean(consent));
		}

		public override void SetAutoClearBadge(bool autoClear)
		{
			Android.CleverPush.GetInstance(Application.Context).AutoClearBadge = autoClear;
		}

		public override void SetIncrementBadge(bool increment)
		{
			Android.CleverPush.GetInstance(Application.Context).IncrementBadge = increment;
		}
	}
}
