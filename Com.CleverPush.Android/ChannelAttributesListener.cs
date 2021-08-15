using System;
using System.Collections;
using System.Collections.Generic;
using Com.CleverPush.Abstractions;

namespace Com.CleverPush
{
    public class ChannelTagsListener : Java.Lang.Object, Android.IChannelTagsListener
    {
        readonly Abstractions.ChannelTagsListener _ready;

        public ChannelTagsListener(Abstractions.ChannelTagsListener ready) => _ready = ready;


        public void Ready(ICollection<Android.ChannelTag> tags)
        {
            _ready?.Invoke(CPChannelTagsToNative(tags));
        }

        public static ICollection<CPChannelTag> CPChannelTagsToNative(ICollection<Android.ChannelTag> tags)
        {
            List<CPChannelTag> list = new List<CPChannelTag>();
            foreach (var tag in tags)
            {
                list.Add(CPChannelTagToNative(tag));
            }

            return list;
        }

        public static CPChannelTag CPChannelTagToNative(Android.ChannelTag tag)
        {
            var newTag = new CPChannelTag();

            newTag.id = tag.Id;
            newTag.name = tag.Name;

			return newTag;
        }
    }
}
