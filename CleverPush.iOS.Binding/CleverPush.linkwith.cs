using ObjCRuntime;

[assembly: LinkWith ("CleverPush.a", ForceLoad = true, Frameworks= "SystemConfiguration UserNotifications WebKit CoreGraphics UIKit")]
