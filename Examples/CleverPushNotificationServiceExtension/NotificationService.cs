using System;
using Foundation;
using UIKit;
using UserNotifications;
using Com.CleverPush;
using Com.CleverPush.Abstractions;

namespace CleverPushNotificationServiceExtension
{
  [Register("NotificationService")]
  public class NotificationService : UNNotificationServiceExtension
  {
    Action<UNNotificationContent> ContentHandler { get; set; }
    UNMutableNotificationContent BestAttemptContent { get; set; }
    UNNotificationRequest ReceivedRequest { get; set; }

    protected NotificationService(IntPtr handle) : base(handle)
    {

    }

    public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
    {
      ReceivedRequest = request;
      ContentHandler = contentHandler;
      BestAttemptContent = (UNMutableNotificationContent)request.Content.MutableCopy();

      (CleverPush.Current as CleverPushImplementation).DidReceiveNotificationExtensionRequest(request, BestAttemptContent);

      ContentHandler(BestAttemptContent);
    }

    public override void TimeWillExpire()
    {
      (CleverPush.Current as CleverPushImplementation).ServiceExtensionTimeWillExpireRequest(ReceivedRequest, BestAttemptContent);

      ContentHandler(BestAttemptContent);
    }
  }
}
