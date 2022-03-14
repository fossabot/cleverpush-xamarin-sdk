using System.Collections.Generic;

namespace Com.CleverPush.Abstractions
{
	public delegate void NotificationReceivedListener(CPNotificationOpenedResult notification);

	public delegate bool NotificationReceivedCallbackListener(CPNotificationOpenedResult notification);

	public delegate void NotificationOpenedListener(CPNotificationOpenedResult result);

	public delegate void SubscribedListener(string subscriptionId);

	public delegate void ChannelTagsListener(ICollection<CPChannelTag> tags);

	public delegate void ChannelTopicsListener(ICollection<CPChannelTopic> topics);

	public delegate void ChannelAttributesListener(ICollection<CPCustomAttribute> attributes);
}
