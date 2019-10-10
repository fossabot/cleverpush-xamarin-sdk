using System;
using Foundation;
using UIKit;
using UserNotifications;

namespace Com.CleverPush.iOS
{

	// @interface CPNotificationOpenedResult : NSObject
	[BaseType(typeof(NSObject))]
	interface CPNotificationOpenedResult
	{
		// @property (readonly) NSDictionary * payload;
		[Export("payload")]
		NSDictionary Payload { get; }

		// @property (readonly) NSDictionary * notification;
		[Export("notification")]
		NSDictionary Notification { get; }

		// @property (readonly) NSDictionary * subscription;
		[Export("subscription")]
		NSDictionary Subscription { get; }

		// -(instancetype)initWithPayload:(NSDictionary *)payload;
		[Export("initWithPayload:")]
		IntPtr Constructor(NSDictionary payload);
	}

	// typedef void (^CPResultSuccessBlock)(NSDictionary *);
	delegate void CPResultSuccessBlock(NSDictionary arg0);

	// typedef void (^CPFailureBlock)(NSError *);
	delegate void CPFailureBlock(NSError arg0);

	// typedef void (^CPHandleSubscribedBlock)(NSString *);
	delegate void CPHandleSubscribedBlock(string arg0);

	// typedef void (^CPHandleNotificationOpenedBlock)(CPNotificationOpenedResult *);
	delegate void CPHandleNotificationOpenedBlock(CPNotificationOpenedResult arg0);

	// @interface CleverPush : NSObject
	[BaseType(typeof(NSObject))]
	interface CleverPush
	{
		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId;
		[Static]
		[Export("initWithLaunchOptions:channelId:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationOpened:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationOpened:autoRegister:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleSubscribed:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleSubscribed:autoRegister:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationOpened:handleSubscribed:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions;
		[Static]
		[Export("initWithLaunchOptions:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Static]
		[Export("initWithLaunchOptions:handleNotificationOpened:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, CPHandleNotificationOpenedBlock openedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export("initWithLaunchOptions:handleSubscribed:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export("initWithLaunchOptions:handleNotificationOpened:handleSubscribed:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationOpened:handleSubscribed:autoRegister:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// +(NSString *)channelId;
		[Static]
		[Export("channelId")]
		string ChannelId { get; }

		// +(BOOL)isSubscribed;
		[Static]
		[Export("isSubscribed")]
		bool IsSubscribed { get; }

		// +(void)subscribe;
		[Static]
		[Export("subscribe")]
		void Subscribe();

		// +(void)unsubscribe;
		[Static]
		[Export("unsubscribe")]
		void Unsubscribe();

		// +(void)didRegisterForRemoteNotifications:(UIApplication *)app deviceToken:(NSData *)inDeviceToken;
		[Static]
		[Export("didRegisterForRemoteNotifications:deviceToken:")]
		void DidRegisterForRemoteNotifications(UIApplication app, NSData inDeviceToken);

		// +(void)handleDidFailRegisterForRemoteNotification:(NSError *)err;
		[Static]
		[Export("handleDidFailRegisterForRemoteNotification:")]
		void HandleDidFailRegisterForRemoteNotification(NSError err);

		// +(void)handleNotificationReceived:(NSDictionary *)messageDict isActive:(BOOL)isActive;
		[Static]
		[Export("handleNotificationReceived:isActive:")]
		void HandleNotificationReceived(NSDictionary messageDict, bool isActive);

		// +(void)handleNotificationReceived:(NSDictionary *)messageDict isActive:(BOOL)isActive wasOpened:(BOOL)wasOpened;
		[Static]
		[Export("handleNotificationReceived:isActive:wasOpened:")]
		void HandleNotificationReceived(NSDictionary messageDict, bool isActive, bool wasOpened);

		// +(BOOL)handleSilentNotificationReceived:(UIApplication *)application UserInfo:(NSDictionary *)messageDict completionHandler:(void (^)(UIBackgroundFetchResult))completionHandler;
		[Static]
		[Export("handleSilentNotificationReceived:UserInfo:completionHandler:")]
		bool HandleSilentNotificationReceived(UIApplication application, NSDictionary messageDict, Action<UIBackgroundFetchResult> completionHandler);

		// +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent;
		[Static]
		[Export("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent DidReceiveNotificationExtensionRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// +(UNMutableNotificationContent *)serviceExtensionTimeWillExpireRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent;
		[Static]
		[Export("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// +(void)processLocalActionBasedNotification:(UILocalNotification *)notification identifier:(NSString *)identifier;
		[Static]
		[Export("processLocalActionBasedNotification:identifier:")]
		void ProcessLocalActionBasedNotification(UILocalNotification notification, string identifier);

		// +(void)enqueueRequest:(NSURLRequest *)request onSuccess:(CPResultSuccessBlock)successBlock onFailure:(CPFailureBlock)failureBlock;
		[Static]
		[Export("enqueueRequest:onSuccess:onFailure:")]
		void EnqueueRequest(NSUrlRequest request, CPResultSuccessBlock successBlock, CPFailureBlock failureBlock);

		// +(void)handleJSONNSURLResponse:(NSURLResponse *)response data:(NSData *)data error:(NSError *)error onSuccess:(CPResultSuccessBlock)successBlock onFailure:(CPFailureBlock)failureBlock;
		[Static]
		[Export("handleJSONNSURLResponse:data:error:onSuccess:onFailure:")]
		void HandleJSONNSURLResponse(NSUrlResponse response, NSData data, NSError error, CPResultSuccessBlock successBlock, CPFailureBlock failureBlock);

		// +(void)addSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export("addSubscriptionTag:")]
		void AddSubscriptionTag(string tagId);

		// +(void)removeSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export("removeSubscriptionTag:")]
		void RemoveSubscriptionTag(string tagId);

		// +(void)setSubscriptionAttribute:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export("setSubscriptionAttribute:value:")]
		void SetSubscriptionAttribute(string attributeId, string value);

		// +(NSArray *)getAvailableTags;
		[Static]
		[Export("getAvailableTags")]
		NSObject[] AvailableTags { get; }

		// +(NSDictionary *)getAvailableAttributes;
		[Static]
		[Export("getAvailableAttributes")]
		NSDictionary AvailableAttributes { get; }

		// +(NSArray *)getSubscriptionTags;
		[Static]
		[Export("getSubscriptionTags")]
		NSObject[] SubscriptionTags { get; }

		// +(BOOL)hasSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export("hasSubscriptionTag:")]
		bool HasSubscriptionTag(string tagId);

		// +(NSDictionary *)getSubscriptionAttributes;
		[Static]
		[Export("getSubscriptionAttributes")]
		NSDictionary SubscriptionAttributes { get; }

		// +(NSString *)getSubscriptionAttribute:(NSString *)attributeId;
		[Static]
		[Export("getSubscriptionAttribute:")]
		string GetSubscriptionAttribute(string attributeId);

		// +(void)setSubscriptionLanguage:(NSString *)language;
		[Static]
		[Export("setSubscriptionLanguage:")]
		void SetSubscriptionLanguage(string language);

		// +(void)setSubscriptionCountry:(NSString *)country;
		[Static]
		[Export("setSubscriptionCountry:")]
		void SetSubscriptionCountry(string country);

		// +(NSMutableArray *)getSubscriptionTopics;
		[Static]
		[Export("getSubscriptionTopics")]
		NSMutableArray SubscriptionTopics { get; }

		// +(void)setSubscriptionTopics:(NSMutableArray *)topics;
		[Static]
		[Export("setSubscriptionTopics:")]
		void SetSubscriptionTopics(NSMutableArray topics);

		// +(void)setBrandingColor:(UIColor *)color;
		[Static]
		[Export("setBrandingColor:")]
		void SetBrandingColor(UIColor color);

		// +(void)showTopicsDialog;
		[Static]
		[Export("showTopicsDialog")]
		void ShowTopicsDialog();

		// +(void)showAppBanners;
		[Static]
		[Export("showAppBanners")]
		void ShowAppBanners();

		// +(void)showAppBanners:(void (^)(NSString *))urlOpenedCallback;
		[Static]
		[Export("showAppBanners:")]
		void ShowAppBanners(Action<NSString> urlOpenedCallback);

		// +(NSArray *)getNotifications;
		[Static]
		[Export("getNotifications")]
		NSObject[] Notifications { get; }
	}

	partial interface Constants
	{
		// extern NSString *const CLEVERPUSH_SDK_VERSION;
		[Field("CLEVERPUSH_SDK_VERSION", "__Internal")]
		NSString CLEVERPUSH_SDK_VERSION { get; }
	}
}
