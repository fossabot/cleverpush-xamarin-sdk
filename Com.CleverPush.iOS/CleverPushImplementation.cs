using System;
using Foundation;
using UserNotifications;
using System.Diagnostics;
using System.Collections.Generic;
using Com.CleverPush.Abstractions;
using CPNotification = Com.CleverPush.Abstractions.CPNotification;
using CPSubscription = Com.CleverPush.Abstractions.CPSubscription;
using CPNotificationOpenedResult = Com.CleverPush.Abstractions.CPNotificationOpenedResult;

namespace Com.CleverPush
{
	public class CleverPushImplementation : CleverPushShared, ICleverPush
	{
		public static Dictionary<string, object> NSDictToPureDict(NSDictionary nsDict)
		{
			if (nsDict == null) {
				return null;
			}
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
			openresult.subscription = CPSubscriptionToXam(result.Subscription);
			openresult.payload = NSDictToPureDict(result.Payload);

			return openresult;
		}

		private CPNotification CPNotificationToXam(iOS.CPNotification nativeNotif)
		{
			var notification = new CPNotification();

			notification.customData = new Dictionary<string, object>();

			notification.id = nativeNotif.Id;
			notification.title = nativeNotif.Title;
			notification.text = nativeNotif.Text;
			notification.url = nativeNotif.Url;
			notification.iconUrl = nativeNotif.IconUrl;
			notification.mediaUrl = nativeNotif.MediaUrl;

			return notification;
		}

		public CPSubscription CPSubscriptionToXam(iOS.CPSubscription nativeSubscription)
		{
			var subscription = new CPSubscription();

			subscription.id = nativeSubscription.Id;

			return subscription;
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

		public void DidReceiveNotificationExtensionRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent)
		{
			iOS.CleverPush.DidReceiveNotificationExtensionRequest(request, replacementContent);
		}

		public void ServiceExtensionTimeWillExpireRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent)
		{
			iOS.CleverPush.ServiceExtensionTimeWillExpireRequest(request, replacementContent);
		}

		public override void Subscribe()
		{
			iOS.CleverPush.Subscribe();
		}

		public override void Unsubscribe()
		{
			iOS.CleverPush.Unsubscribe();
		}

		public override void ShowTopicsDialog()
		{
			iOS.CleverPush.ShowTopicsDialog();
		}

		public override void SetSubscriptionTopics(string[] topicIds)
		{
			var topicsArray = new NSMutableArray<NSString>();
			foreach (var topicId in topicIds)
			{
				var topicString = new NSString(topicId);
				topicsArray.Add(topicString);
			}
			iOS.CleverPush.SetSubscriptionTopics(topicsArray);
		}

		public override ICollection<string> GetSubscriptionTopics()
		{
			var topicIds = new List<string>();
			foreach (NSString topicId in NSArray.FromArray<NSString>(iOS.CleverPush.SubscriptionTopics))
			{
				topicIds.Add(topicId.ToString());
			}
			return topicIds;
		}

		public override void GetAvailableTopics(Abstractions.ChannelTopicsListener listener)
		{
			iOS.CleverPush.GetAvailableTopics(delegate (NSArray topics)
			{
				var finalTopics = new List<CPChannelTopic>();
				foreach (iOS.CPChannelTopic topic in NSArray.FromArray<iOS.CPChannelTopic>(topics))
				{
					var newTopic = new CPChannelTopic();
					newTopic.id = topic.Id;
					newTopic.name = topic.Name;
					finalTopics.Add(newTopic);
				}
				listener(finalTopics);
			});
		}

		public override void AddSubscriptionTag(string tagId)
		{
			iOS.CleverPush.AddSubscriptionTag(tagId);
		}

		public override void RemoveSubscriptionTag(string tagId)
		{
			iOS.CleverPush.RemoveSubscriptionTag(tagId);
		}

		public override bool HasSubscriptionTag(string tagId)
		{
			return iOS.CleverPush.HasSubscriptionTag(tagId);
		}

		public override ICollection<string> GetSubscriptionTags()
		{
			var tagIds = new List<string>();
			foreach (NSString tagId in iOS.CleverPush.SubscriptionTags)
			{
				tagIds.Add(tagId.ToString());
			}
			return tagIds;
		}

		public override void GetAvailableTags(Abstractions.ChannelTagsListener listener)
		{
			iOS.CleverPush.GetAvailableTags(delegate (NSArray tags)
			{
				var finalTags = new List<CPChannelTag>();
				foreach (iOS.CPChannelTag tag in NSArray.FromArray<iOS.CPChannelTag>(tags))
				{
					var newTag = new CPChannelTag();
					newTag.id = tag.Id;
					newTag.name = tag.Name;
					finalTags.Add(newTag);
				}
				listener(finalTags);
			});
		}

		public override object GetSubscriptionAttribute(string attributeId)
		{
			return iOS.CleverPush.GetSubscriptionAttribute(attributeId);
		}

		public override void SetSubscriptionAttribute(string attributeId, string value)
		{
			iOS.CleverPush.SetSubscriptionAttribute(attributeId, value);
		}

		public override void GetAvailableAttributes(Abstractions.ChannelAttributesListener listener)
		{
			iOS.CleverPush.GetAvailableAttributes(delegate (NSDictionary attributes)
			{
				var attributesDict = NSDictToPureDict(attributes);
				var finalAttributes = new List<CPCustomAttribute>();
				foreach (KeyValuePair<string, object> entry in attributesDict)
				{
					var attribute = new CPCustomAttribute();
					attribute.id = entry.Key;
					attribute.name = (string) entry.Value;
					finalAttributes.Add(attribute);
				}
				listener(finalAttributes);
			});
		}

		public override void TrackPageView(string url)
		{
			iOS.CleverPush.TrackPageView(url);
		}

		public override void TrackPageView(string url, Dictionary<string, object> parameters)
		{
			var finalParameters = new NSMutableDictionary();
			foreach (var item in parameters)
			{
				finalParameters.Add(new NSString(item.Key), NSObject.FromObject(item.Value));
			}
			iOS.CleverPush.TrackPageView(url, finalParameters);
		}

		public override ICollection<CPNotification> GetNotifications()
		{
			List<CPNotification> notifications = new List<CPNotification>();
			var iosNotifications = iOS.CleverPush.Notifications;
			foreach (iOS.CPNotification notif in iosNotifications)
			{
				var notification = new CPNotification();

				notification.customData = new Dictionary<string, object>();
				if (notif.CustomData != null)
				{
					var customData = NSDictToPureDict(notif.CustomData);
					foreach (var item in customData)
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
			iOS.CleverPush.TriggerAppBannerEvent(key, value);
		}

		public override void ShowAppBanner(string bannerId)
		{
			iOS.CleverPush.ShowAppBanner(bannerId);
		}

		public override void TrackEvent(string eventName)
		{
			iOS.CleverPush.TrackEvent(eventName);
		}

		public override void TrackEvent(string eventName, float amount)
		{
			iOS.CleverPush.TrackEvent(eventName, amount);
		}

		public override void SetTrackingConsentRequired(bool required)
		{
			iOS.CleverPush.SetTrackingConsentRequired(required);
		}

		public override void SetTrackingConsent(bool consent)
		{
			iOS.CleverPush.SetTrackingConsent(consent);
		}

		public override void SetAutoClearBadge(bool autoClear)
		{
			iOS.CleverPush.SetAutoClearBadge(autoClear);
		}

		public override void SetIncrementBadge(bool increment)
		{
			iOS.CleverPush.SetIncrementBadge(increment);
		}
	}
}
