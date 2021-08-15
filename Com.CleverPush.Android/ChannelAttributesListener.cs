using System;
using System.Collections;
using System.Collections.Generic;
using Com.CleverPush.Abstractions;

namespace Com.CleverPush
{
    public class ChannelAttributesListener : Java.Lang.Object, Android.IChannelAttributesListener
    {
        readonly Abstractions.ChannelAttributesListener _ready;

        public ChannelAttributesListener(Abstractions.ChannelAttributesListener ready) => _ready = ready;

        public void Ready(ICollection<Android.CustomAttribute> attributes)
        {
            _ready?.Invoke(CPChannelAttributesToNative(attributes));
        }

        public static ICollection<CPCustomAttribute> CPChannelAttributesToNative(ICollection<Android.CustomAttribute> attributes)
        {
            List<CPCustomAttribute> list = new List<CPCustomAttribute>();
            foreach (var attribute in attributes)
            {
                list.Add(CPChannelAttributeToNative(attribute));
            }

            return list;
        }

        public static CPCustomAttribute CPChannelAttributeToNative(Android.CustomAttribute attribute)
        {
            var newAttribute = new CPCustomAttribute();

            newAttribute.id = attribute.Id;
            newAttribute.name = attribute.Name;

            return newAttribute;
        }
    }
}
