using ObjCRuntime;

[assembly: LinkWith("CleverPush.a", ForceLoad = true, Frameworks = "CoreGraphics, QuartzCore, CoreFoundation, UIKit, SystemConfiguration, UIKit, UserNotifications, StoreKit, WebKit, JavascriptCore, SafariServices")]
