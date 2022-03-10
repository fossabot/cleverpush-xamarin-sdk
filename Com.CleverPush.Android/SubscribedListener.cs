namespace Com.CleverPush
{
    public class SubscribedListener : Java.Lang.Object, Android.ISubscribedListener
    {
        public void Subscribed(string subscriptionId)
        {
            (CleverPush.Current as CleverPushImplementation).OnSubscribed(subscriptionId);
        }
    }
}
