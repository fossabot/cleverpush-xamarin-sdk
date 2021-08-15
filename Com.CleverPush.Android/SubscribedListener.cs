using System;

using Com.CleverPush.Abstractions;
using Com.CleverPush.Android;

namespace Com.CleverPush
{
    public class SubscribedListener : Java.Lang.Object, Android.ISubscribedListener
    {
		readonly Abstractions.SubscribedListener _subscribed;

		public SubscribedListener(Abstractions.SubscribedListener subscribed) => _subscribed = subscribed;

        public void Subscribed(string subscriptionId)
        {
			_subscribed?.Invoke(subscriptionId);
        }
    }
}
