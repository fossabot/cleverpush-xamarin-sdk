using System;
using System.Collections;
using System.Collections.Generic;
using Com.CleverPush.Abstractions;

namespace Com.CleverPush
{
    public class ChannelTopicsListener : Java.Lang.Object, Android.IChannelTopicsListener
    {
        readonly Abstractions.ChannelTopicsListener _ready;

        public ChannelTopicsListener(Abstractions.ChannelTopicsListener ready) => _ready = ready;

        public void Ready(ICollection<Android.ChannelTopic> topics)
        {
            _ready?.Invoke(CPChannelTopicsToNative(topics));
        }

        public static ICollection<CPChannelTopic> CPChannelTopicsToNative(ICollection<Android.ChannelTopic> topics)
        {
            List<CPChannelTopic> list = new List<CPChannelTopic>();
            foreach (var topic in topics)
            {
                list.Add(CPChannelTopicToNative(topic));
            }

            return list;
        }

        public static CPChannelTopic CPChannelTopicToNative(Android.ChannelTopic topic)
        {
            var newTopic = new CPChannelTopic();

            newTopic.id = topic.Id;
            newTopic.name = topic.Name;

			return newTopic;
        }
    }
}
