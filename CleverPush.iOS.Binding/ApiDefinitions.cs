using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;

namespace Com.CleverPush.iOS
{
	// @interface CPNotification : NSObject
	[BaseType (typeof(NSObject))]
	interface CPNotification
	{
		// @property (nonatomic, strong) NSString * _Nonnull id;
		[Export ("id", ArgumentSemantic.Strong)]
		string Id { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull tag;
		[Export ("tag", ArgumentSemantic.Strong)]
		string Tag { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull text;
		[Export ("text", ArgumentSemantic.Strong)]
		string Text { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull url;
		[Export ("url", ArgumentSemantic.Strong)]
		string Url { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull iconUrl;
		[Export ("iconUrl", ArgumentSemantic.Strong)]
		string IconUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull mediaUrl;
		[Export ("mediaUrl", ArgumentSemantic.Strong)]
		string MediaUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull soundFilename;
		[Export ("soundFilename", ArgumentSemantic.Strong)]
		string SoundFilename { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull appBanner;
		[Export ("appBanner", ArgumentSemantic.Strong)]
		string AppBanner { get; set; }

		// @property (nonatomic, strong) NSArray * _Nonnull actions;
		[Export ("actions", ArgumentSemantic.Strong)]
		NSObject[] Actions { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nonnull customData;
		[Export ("customData", ArgumentSemantic.Strong)]
		NSDictionary CustomData { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nonnull carouselItems;
		[Export ("carouselItems", ArgumentSemantic.Strong)]
		NSDictionary CarouselItems { get; set; }

		// @property (readwrite, nonatomic) BOOL chatNotification;
		[Export ("chatNotification")]
		bool ChatNotification { get; set; }

		// @property (readwrite, nonatomic) BOOL carouselEnabled;
		[Export ("carouselEnabled")]
		bool CarouselEnabled { get; set; }

		// @property (readwrite, nonatomic) BOOL silent;
		[Export ("silent")]
		bool Silent { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable expiresAt;
		[NullAllowed, Export ("expiresAt", ArgumentSemantic.Strong)]
		NSDate ExpiresAt { get; set; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export ("initWithJson:")]
		CPNotification InitWithJson (NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export ("parseJson:")]
		void ParseJson (NSDictionary json);
	}

	// @interface CPSubscription : NSObject
	[BaseType (typeof(NSObject))]
	interface CPSubscription
	{
		// @property (readonly) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export ("initWithJson:")]
		CPSubscription InitWithJson (NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export ("parseJson:")]
		void ParseJson (NSDictionary json);
	}

	// @interface CPUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface CPUtils
	{
		// +(NSString *)downloadMedia:(NSString *)urlString;
		[Static]
		[Export ("downloadMedia:")]
		string DownloadMedia (string urlString);

		// +(NSDictionary *)dictionaryWithPropertiesOfObject:(id)obj;
		[Static]
		[Export ("dictionaryWithPropertiesOfObject:")]
		NSDictionary DictionaryWithPropertiesOfObject (NSObject obj);

		// +(NSInteger)daysBetweenDate:(NSDate *)fromDateTime andDate:(NSDate *)toDateTime;
		[Static]
		[Export ("daysBetweenDate:andDate:")]
		nint DaysBetweenDate (NSDate fromDateTime, NSDate toDateTime);

		// +(void)updateLastTopicCheckedTime;
		[Static]
		[Export ("updateLastTopicCheckedTime")]
		void UpdateLastTopicCheckedTime ();

		// +(NSDate *)getLastTopicCheckedTime;
		[Static]
		[Export ("getLastTopicCheckedTime")]
		NSDate LastTopicCheckedTime { get; }

		// +(NSString *)hexStringFromColor:(UIColor *)color;
		[Static]
		[Export ("hexStringFromColor:")]
		string HexStringFromColor (UIColor color);

		// +(BOOL)fontFamilyExists:(NSString *)fontFamily;
		[Static]
		[Export ("fontFamilyExists:")]
		bool FontFamilyExists (string fontFamily);

		// +(BOOL)isEmpty:(id)thing;
		[Static]
		[Export ("isEmpty:")]
		bool IsEmpty (NSObject thing);

		// +(CGFloat)frameHeightWithoutSafeArea;
		[Static]
		[Export ("frameHeightWithoutSafeArea")]
		nfloat FrameHeightWithoutSafeArea { get; }

		// +(NSString *)deviceName;
		[Static]
		[Export ("deviceName")]
		string DeviceName { get; }

		// +(void)updateLastTimeAutomaticallyShowed;
		[Static]
		[Export ("updateLastTimeAutomaticallyShowed")]
		void UpdateLastTimeAutomaticallyShowed ();

		// +(NSDate *)getLastTimeAutomaticallyShowed;
		[Static]
		[Export ("getLastTimeAutomaticallyShowed")]
		NSDate LastTimeAutomaticallyShowed { get; }

		// +(BOOL)newTopicAdded:(NSDictionary *)config;
		[Static]
		[Export ("newTopicAdded:")]
		bool NewTopicAdded (NSDictionary config);

		// +(NSDate *)getLocalDateTimeFromUTC:(NSString *)dateString;
		[Static]
		[Export ("getLocalDateTimeFromUTC:")]
		NSDate GetLocalDateTimeFromUTC (string dateString);

		// +(NSString *)getCurrentDateString;
		[Static]
		[Export ("getCurrentDateString")]
		string CurrentDateString { get; }

		// +(NSInteger)secondsBetweenDate:(NSDate *)fromDateTime andDate:(NSDate *)toDateTime;
		[Static]
		[Export ("secondsBetweenDate:andDate:")]
		nint SecondsBetweenDate (NSDate fromDateTime, NSDate toDateTime);

		// +(NSBundle *)getAssetsBundle;
		[Static]
		[Export ("getAssetsBundle")]
		NSBundle AssetsBundle { get; }

		// +(NSString *)timeAgoStringFromDate:(NSDate *)date;
		[Static]
		[Export ("timeAgoStringFromDate:")]
		string TimeAgoStringFromDate (NSDate date);

		// +(NSUserDefaults *)getUserDefaultsAppGroup;
		[Static]
		[Export ("getUserDefaultsAppGroup")]
		NSUserDefaults UserDefaultsAppGroup { get; }
	}

	// @interface CPChannelTag : NSObject
	[BaseType (typeof(NSObject))]
	interface CPChannelTag
	{
		// @property (readonly) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; }

		// @property (readonly) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly) NSString * _Nullable autoAssignPath;
		[NullAllowed, Export ("autoAssignPath")]
		string AutoAssignPath { get; }

		// @property (readonly) NSString * _Nullable autoAssignFunction;
		[NullAllowed, Export ("autoAssignFunction")]
		string AutoAssignFunction { get; }

		// @property (readonly) NSString * _Nullable autoAssignSelector;
		[NullAllowed, Export ("autoAssignSelector")]
		string AutoAssignSelector { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignVisits;
		[NullAllowed, Export ("autoAssignVisits")]
		NSNumber AutoAssignVisits { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignSessions;
		[NullAllowed, Export ("autoAssignSessions")]
		NSNumber AutoAssignSessions { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignSeconds;
		[NullAllowed, Export ("autoAssignSeconds")]
		NSNumber AutoAssignSeconds { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignDays;
		[NullAllowed, Export ("autoAssignDays")]
		NSNumber AutoAssignDays { get; }

		// @property (readonly) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt")]
		NSDate CreatedAt { get; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export ("initWithJson:")]
		CPChannelTag InitWithJson (NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export ("parseJson:")]
		void ParseJson (NSDictionary json);
	}

	// @interface CPChannelTopic : NSObject
	[BaseType (typeof(NSObject))]
	interface CPChannelTopic
	{
		// @property (readonly) NSString * _Nullable id;
		[NullAllowed, Export ("id")]
		string Id { get; }

		// @property (readonly) NSString * _Nullable parentTopic;
		[NullAllowed, Export ("parentTopic")]
		string ParentTopic { get; }

		// @property (readonly) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly) NSString * _Nullable fcmBroadcastTopic;
		[NullAllowed, Export ("fcmBroadcastTopic")]
		string FcmBroadcastTopic { get; }

		// @property (readonly) NSString * _Nullable externalId;
		[NullAllowed, Export ("externalId")]
		string ExternalId { get; }

		// @property (readonly) NSNumber * _Nullable sort;
		[NullAllowed, Export ("sort")]
		NSNumber Sort { get; }

		// @property (readonly) NSDictionary * _Nullable customData;
		[NullAllowed, Export ("customData")]
		NSDictionary CustomData { get; }

		// @property (readonly) NSDate * _Nullable createdAt;
		[NullAllowed, Export ("createdAt")]
		NSDate CreatedAt { get; }

		// @property (readwrite, nonatomic) BOOL defaultUnchecked;
		[Export ("defaultUnchecked")]
		bool DefaultUnchecked { get; set; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export ("initWithJson:")]
		CPChannelTopic InitWithJson (NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export ("parseJson:")]
		void ParseJson (NSDictionary json);
	}

	// @interface CPNotificationReceivedResult : NSObject
	[BaseType (typeof(NSObject))]
	interface CPNotificationReceivedResult
	{
		// @property (readonly) NSDictionary * payload;
		[Export ("payload")]
		NSDictionary Payload { get; }

		// @property (readonly) CPNotification * notification;
		[Export ("notification")]
		CPNotification Notification { get; }

		// @property (readonly) CPSubscription * subscription;
		[Export ("subscription")]
		CPSubscription Subscription { get; }

		// -(instancetype)initWithPayload:(NSDictionary *)payload;
		[Export ("initWithPayload:")]
		IntPtr Constructor (NSDictionary payload);
	}

	// @interface CPNotificationOpenedResult : NSObject
	[BaseType (typeof(NSObject))]
	interface CPNotificationOpenedResult
	{
		// @property (readonly) NSDictionary * payload;
		[Export ("payload")]
		NSDictionary Payload { get; }

		// @property (readonly) CPNotification * notification;
		[Export ("notification")]
		CPNotification Notification { get; }

		// @property (readonly) CPSubscription * subscription;
		[Export ("subscription")]
		CPSubscription Subscription { get; }

		// @property (readonly) NSString * action;
		[Export ("action")]
		string Action { get; }

		// -(instancetype)initWithPayload:(NSDictionary *)payload action:(NSString *)action;
		[Export ("initWithPayload:action:")]
		IntPtr Constructor (NSDictionary payload, string action);
	}

	// typedef void (^CPResultSuccessBlock)(NSDictionary *);
	delegate void CPResultSuccessBlock (NSDictionary arg0);

	// typedef void (^CPFailureBlock)(NSError *);
	delegate void CPFailureBlock (NSError arg0);

	// typedef void (^CPHandleSubscribedBlock)(NSString *);
	delegate void CPHandleSubscribedBlock (string arg0);

	// typedef void (^CPHandleNotificationReceivedBlock)(CPNotificationReceivedResult *);
	delegate void CPHandleNotificationReceivedBlock (CPNotificationReceivedResult arg0);

	// typedef void (^CPHandleNotificationOpenedBlock)(CPNotificationOpenedResult *);
	delegate void CPHandleNotificationOpenedBlock (CPNotificationOpenedResult arg0);

	[Static]
	partial interface Constants
	{
		// extern NSString *const kCPSettingsKeyInFocusDisplayOption;
		[Field ("kCPSettingsKeyInFocusDisplayOption", "__Internal")]
		NSString kCPSettingsKeyInFocusDisplayOption { get; }
	}

	// @interface CleverPushInstance : NSObject
	[BaseType (typeof(NSObject))]
	interface CleverPushInstance
	{
		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId;
		[Export ("initWithLaunchOptions:channelId:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback autoRegister:(BOOL)autoRegister;
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:autoRegister:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, bool autoRegister);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback autoRegister:(BOOL)autoRegister;
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:autoRegister:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, bool autoRegister);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Export ("initWithLaunchOptions:channelId:handleSubscribed:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleSubscribedBlock subscribedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Export ("initWithLaunchOptions:channelId:handleSubscribed:autoRegister:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:handleSubscribed:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:handleSubscribed:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions;
		[Export ("initWithLaunchOptions:")]
		IntPtr Constructor (NSDictionary launchOptions);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Export ("initWithLaunchOptions:handleNotificationOpened:")]
		IntPtr Constructor (NSDictionary launchOptions, CPHandleNotificationOpenedBlock openedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Export ("initWithLaunchOptions:handleSubscribed:")]
		IntPtr Constructor (NSDictionary launchOptions, CPHandleSubscribedBlock subscribedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Export ("initWithLaunchOptions:handleNotificationOpened:handleSubscribed:")]
		IntPtr Constructor (NSDictionary launchOptions, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:handleSubscribed:autoRegister:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// -(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:handleSubscribed:autoRegister:")]
		IntPtr Constructor (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// -(void)setTrackingConsentRequired:(BOOL)required;
		[Export ("setTrackingConsentRequired:")]
		void SetTrackingConsentRequired (bool required);

		// -(void)setTrackingConsent:(BOOL)consent;
		[Export ("setTrackingConsent:")]
		void SetTrackingConsent (bool consent);

		// -(void)enableDevelopmentMode;
		[Export ("enableDevelopmentMode")]
		void EnableDevelopmentMode ();

		// -(void)subscribe;
		[Export ("subscribe")]
		void Subscribe ();

		// -(void)subscribe:(CPHandleSubscribedBlock)subscribedBlock;
		[Export ("subscribe:")]
		void Subscribe (CPHandleSubscribedBlock subscribedBlock);

		// -(void)subscribe:(CPHandleSubscribedBlock)subscribedBlock failure:(CPFailureBlock)failureBlock;
		[Export ("subscribe:failure:")]
		void Subscribe (CPHandleSubscribedBlock subscribedBlock, CPFailureBlock failureBlock);

		// -(void)disableAppBanners;
		[Export ("disableAppBanners")]
		void DisableAppBanners ();

		// -(void)enableAppBanners;
		[Export ("enableAppBanners")]
		void EnableAppBanners ();

		// -(BOOL)popupVisible;
		[Export ("popupVisible")]
		bool PopupVisible { get; }

		// -(void)unsubscribe;
		[Export ("unsubscribe")]
		void Unsubscribe ();

		// -(void)unsubscribe:(void (^)(BOOL))callback;
		[Export ("unsubscribe:")]
		void Unsubscribe (Action<bool> callback);

		// -(void)syncSubscription;
		[Export ("syncSubscription")]
		void SyncSubscription ();

		// -(void)didRegisterForRemoteNotifications:(UIApplication *)app deviceToken:(NSData *)inDeviceToken;
		[Export ("didRegisterForRemoteNotifications:deviceToken:")]
		void DidRegisterForRemoteNotifications (UIApplication app, NSData inDeviceToken);

		// -(void)handleDidFailRegisterForRemoteNotification:(NSError *)err;
		[Export ("handleDidFailRegisterForRemoteNotification:")]
		void HandleDidFailRegisterForRemoteNotification (NSError err);

		// -(void)handleNotificationOpened:(NSDictionary *)messageDict isActive:(BOOL)isActive actionIdentifier:(NSString *)actionIdentifier;
		[Export ("handleNotificationOpened:isActive:actionIdentifier:")]
		void HandleNotificationOpened (NSDictionary messageDict, bool isActive, string actionIdentifier);

		// -(void)handleNotificationReceived:(NSDictionary *)messageDict isActive:(BOOL)isActive;
		[Export ("handleNotificationReceived:isActive:")]
		void HandleNotificationReceived (NSDictionary messageDict, bool isActive);

		// -(void)addSubscriptionTags:(NSArray *)tagIds callback:(void (^)(NSArray *))callback;
		[Export ("addSubscriptionTags:callback:")]
		void AddSubscriptionTags (NSObject[] tagIds, Action<NSArray> callback);

		// -(void)addSubscriptionTag:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Export ("addSubscriptionTag:callback:")]
		void AddSubscriptionTag (string tagId, Action<NSString> callback);

		// -(void)addSubscriptionTags:(NSArray *)tagIds;
		[Export ("addSubscriptionTags:")]
		void AddSubscriptionTags (NSObject[] tagIds);

		// -(void)addSubscriptionTag:(NSString *)tagId;
		[Export ("addSubscriptionTag:")]
		void AddSubscriptionTag (string tagId);

		// -(void)removeSubscriptionTags:(NSArray *)tagIds callback:(void (^)(NSArray *))callback;
		[Export ("removeSubscriptionTags:callback:")]
		void RemoveSubscriptionTags (NSObject[] tagIds, Action<NSArray> callback);

		// -(void)removeSubscriptionTag:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Export ("removeSubscriptionTag:callback:")]
		void RemoveSubscriptionTag (string tagId, Action<NSString> callback);

		// -(void)removeSubscriptionTags:(NSArray *)tagIds;
		[Export ("removeSubscriptionTags:")]
		void RemoveSubscriptionTags (NSObject[] tagIds);

		// -(void)removeSubscriptionTag:(NSString *)tagId;
		[Export ("removeSubscriptionTag:")]
		void RemoveSubscriptionTag (string tagId);

		// -(void)setSubscriptionAttribute:(NSString *)attributeId value:(NSString *)value;
		[Export ("setSubscriptionAttribute:value:")]
		void SetSubscriptionAttribute (string attributeId, string value);

		// -(void)pushSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Export ("pushSubscriptionAttributeValue:value:")]
		void PushSubscriptionAttributeValue (string attributeId, string value);

		// -(void)pullSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Export ("pullSubscriptionAttributeValue:value:")]
		void PullSubscriptionAttributeValue (string attributeId, string value);

		// -(BOOL)hasSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Export ("hasSubscriptionAttributeValue:value:")]
		bool HasSubscriptionAttributeValue (string attributeId, string value);

		// -(void)getAvailableTags:(void (^)(NSArray *))callback;
		[Export ("getAvailableTags:")]
		void GetAvailableTags (Action<NSArray> callback);

		// -(void)getAvailableTopics:(void (^)(NSArray *))callback;
		[Export ("getAvailableTopics:")]
		void GetAvailableTopics (Action<NSArray> callback);

		// -(void)getAvailableAttributes:(void (^)(NSDictionary *))callback;
		[Export ("getAvailableAttributes:")]
		void GetAvailableAttributes (Action<NSDictionary> callback);

		// -(void)setSubscriptionLanguage:(NSString *)language;
		[Export ("setSubscriptionLanguage:")]
		void SetSubscriptionLanguage (string language);

		// -(void)setSubscriptionCountry:(NSString *)country;
		[Export ("setSubscriptionCountry:")]
		void SetSubscriptionCountry (string country);

		// -(void)setTopicsDialogWindow:(UIWindow *)window;
		[Export ("setTopicsDialogWindow:")]
		void SetTopicsDialogWindow (UIWindow window);

		// -(void)setSubscriptionTopics:(NSMutableArray *)topics;
		[Export ("setSubscriptionTopics:")]
		void SetSubscriptionTopics (NSMutableArray topics);

		// -(void)setBrandingColor:(UIColor *)color;
		[Export ("setBrandingColor:")]
		void SetBrandingColor (UIColor color);

		// -(void)setNormalTintColor:(UIColor *)color;
		[Export ("setNormalTintColor:")]
		void SetNormalTintColor (UIColor color);

		// -(UIColor *)getNormalTintColor;
		[Export ("getNormalTintColor")]
		UIColor NormalTintColor { get; }

		// -(void)setChatBackgroundColor:(UIColor *)color;
		[Export ("setChatBackgroundColor:")]
		void SetChatBackgroundColor (UIColor color);

		// -(void)setAutoClearBadge:(BOOL)autoClear;
		[Export ("setAutoClearBadge:")]
		void SetAutoClearBadge (bool autoClear);

		// -(void)setIncrementBadge:(BOOL)increment;
		[Export ("setIncrementBadge:")]
		void SetIncrementBadge (bool increment);

		// -(void)setShowNotificationsInForeground:(BOOL)show;
		[Export ("setShowNotificationsInForeground:")]
		void SetShowNotificationsInForeground (bool show);

		// -(void)setIgnoreDisabledNotificationPermission:(BOOL)ignore;
		[Export ("setIgnoreDisabledNotificationPermission:")]
		void SetIgnoreDisabledNotificationPermission (bool ignore);

		// -(void)showTopicsDialog;
		[Export ("showTopicsDialog")]
		void ShowTopicsDialog ();

		// -(void)showTopicDialogOnNewAdded;
		[Export ("showTopicDialogOnNewAdded")]
		void ShowTopicDialogOnNewAdded ();

		// -(void)showTopicsDialog:(UIWindow *)targetWindow;
		[Export ("showTopicsDialog:")]
		void ShowTopicsDialog (UIWindow targetWindow);

		// -(void)getChannelConfig:(void (^)(NSDictionary *))callback;
		[Export ("getChannelConfig:")]
		void GetChannelConfig (Action<NSDictionary> callback);

		// -(void)getSubscriptionId:(void (^)(NSString *))callback;
		[Export ("getSubscriptionId:")]
		void GetSubscriptionId (Action<NSString> callback);

		// -(void)trackEvent:(NSString *)eventName;
		[Export ("trackEvent:")]
		void TrackEvent (string eventName);

		// -(void)trackEvent:(NSString *)eventName amount:(NSNumber *)amount;
		[Export ("trackEvent:amount:")]
		void TrackEvent (string eventName, NSNumber amount);

		// -(void)trackPageView:(NSString *)url;
		[Export ("trackPageView:")]
		void TrackPageView (string url);

		// -(void)trackPageView:(NSString *)url params:(NSDictionary *)params;
		[Export ("trackPageView:params:")]
		void TrackPageView (string url, NSDictionary @params);

		// -(void)increaseSessionVisits;
		[Export ("increaseSessionVisits")]
		void IncreaseSessionVisits ();

		// -(void)showAppBanner:(NSString *)bannerId;
		[Export ("showAppBanner:")]
		void ShowAppBanner (string bannerId);

		// -(void)getAppBanners:(NSString *)channelId callback:(void (^)(NSArray *))callback;
		[Export ("getAppBanners:callback:")]
		void GetAppBanners (string channelId, Action<NSArray> callback);

		// -(void)triggerAppBannerEvent:(NSString *)key value:(NSString *)value;
		[Export ("triggerAppBannerEvent:value:")]
		void TriggerAppBannerEvent (string key, string value);

		// -(void)setApiEndpoint:(NSString *)apiEndpoint;
		[Export ("setApiEndpoint:")]
		void SetApiEndpoint (string apiEndpoint);

		// -(void)updateBadge:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Export ("updateBadge:")]
		void UpdateBadge (UNMutableNotificationContent replacementContent);

		// -(void)updateDeselectFlag:(BOOL)value;
		[Export ("updateDeselectFlag:")]
		void UpdateDeselectFlag (bool value);

		// -(void)setOpenWebViewEnabled:(BOOL)opened;
		[Export ("setOpenWebViewEnabled:")]
		void SetOpenWebViewEnabled (bool opened);

		// -(void)setUnsubscribeStatus:(BOOL)status;
		[Export ("setUnsubscribeStatus:")]
		void SetUnsubscribeStatus (bool status);

		// -(UIViewController *)topViewController;
		[Export ("topViewController")]
		UIViewController TopViewController { get; }

		// -(NSArray *)getSubscriptionTags;
		[Export ("getSubscriptionTags")]
		NSObject[] SubscriptionTags { get; }

		// -(NSArray<CPNotification *> *)getNotifications;
		[Export ("getNotifications")]
		CPNotification[] Notifications { get; }

		// -(void)removeNotification:(NSString *)notificationId;
		[Export ("removeNotification:")]
		void RemoveNotification (string notificationId);

		// -(NSArray *)getSeenStories;
		[Export ("getSeenStories")]
		NSObject[] SeenStories { get; }

		// -(NSMutableArray *)getSubscriptionTopics;
		[Export ("getSubscriptionTopics")]
		NSMutableArray SubscriptionTopics { get; }

		// -(NSArray *)getAvailableTags __attribute__((deprecated("")));
		[Export ("getAvailableTags")]
		NSObject[] AvailableTags { get; }

		// -(NSArray *)getAvailableTopics __attribute__((deprecated("")));
		[Export ("getAvailableTopics")]
		NSObject[] AvailableTopics { get; }

		// -(NSString *)getSubscriptionAttribute:(NSString *)attributeId;
		[Export ("getSubscriptionAttribute:")]
		string GetSubscriptionAttribute (string attributeId);

		// -(NSString *)getSubscriptionId;
		[Export ("getSubscriptionId")]
		string SubscriptionId { get; }

		// -(NSString *)getApiEndpoint;
		[Export ("getApiEndpoint")]
		string ApiEndpoint { get; }

		// -(NSString *)channelId;
		[Export ("channelId")]
		string ChannelId { get; }

		// -(UIColor *)getBrandingColor;
		[Export ("getBrandingColor")]
		UIColor BrandingColor { get; }

		// -(UIColor *)getChatBackgroundColor;
		[Export ("getChatBackgroundColor")]
		UIColor ChatBackgroundColor { get; }

		// -(NSDictionary *)getAvailableAttributes __attribute__((deprecated("")));
		[Export ("getAvailableAttributes")]
		NSDictionary AvailableAttributes { get; }

		// -(NSDictionary *)getSubscriptionAttributes;
		[Export ("getSubscriptionAttributes")]
		NSDictionary SubscriptionAttributes { get; }

		// -(BOOL)isDevelopmentModeEnabled;
		[Export ("isDevelopmentModeEnabled")]
		bool IsDevelopmentModeEnabled { get; }

		// -(BOOL)isSubscribed;
		[Export ("isSubscribed")]
		bool IsSubscribed { get; }

		// -(BOOL)handleSilentNotificationReceived:(UIApplication *)application UserInfo:(NSDictionary *)messageDict completionHandler:(void (^)(UIBackgroundFetchResult))completionHandler;
		[Export ("handleSilentNotificationReceived:UserInfo:completionHandler:")]
		bool HandleSilentNotificationReceived (UIApplication application, NSDictionary messageDict, Action<UIBackgroundFetchResult> completionHandler);

		// -(BOOL)hasSubscriptionTag:(NSString *)tagId;
		[Export ("hasSubscriptionTag:")]
		bool HasSubscriptionTag (string tagId);

		// -(BOOL)hasSubscriptionTopic:(NSString *)topicId;
		[Export ("hasSubscriptionTopic:")]
		bool HasSubscriptionTopic (string topicId);

		// -(BOOL)getDeselectValue;
		[Export ("getDeselectValue")]
		bool DeselectValue { get; }

		// -(BOOL)getUnsubscribeStatus;
		[Export ("getUnsubscribeStatus")]
		bool UnsubscribeStatus { get; }

		// -(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent DidReceiveNotificationExtensionRequest (UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// -(UNMutableNotificationContent *)serviceExtensionTimeWillExpireRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Export ("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest (UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// -(void)processLocalActionBasedNotification:(UILocalNotification *)notification actionIdentifier:(NSString *)actionIdentifier;
		[Export ("processLocalActionBasedNotification:actionIdentifier:")]
		void ProcessLocalActionBasedNotification (UILocalNotification notification, string actionIdentifier);

		// -(NSString *)getChannelIdFromBundle;
		[Export ("getChannelIdFromBundle")]
		string GetChannelIdFromBundle ();

		// -(NSString *)getChannelIdFromUserDefault;
		[Export ("getChannelIdFromUserDefault")]
		string GetChannelIdFromUserDefault ();

		// -(BOOL)getPendingChannelConfigRequest;
		[Export ("getPendingChannelConfigRequest")]
		bool GetPendingChannelConfigRequest ();

		// -(NSInteger)getAppOpens;
		[Export ("getAppOpens")]
		nint GetAppOpens ();

		// -(void)incrementAppOpens;
		[Export ("incrementAppOpens")]
		void IncrementAppOpens ();

		// -(void)getChannelConfigFromBundleId:(NSString *)configPath;
		[Export ("getChannelConfigFromBundleId:")]
		void GetChannelConfigFromBundleId (string configPath);

		// -(void)getChannelConfigFromChannelId:(NSString *)configPath;
		[Export ("getChannelConfigFromChannelId:")]
		void GetChannelConfigFromChannelId (string configPath);

		// -(NSString *)getBundleName;
		[Export ("getBundleName")]
		string GetBundleName ();

		// -(BOOL)isChannelIdChanged:(NSString *)channelId;
		[Export ("isChannelIdChanged:")]
		bool IsChannelIdChanged (string channelId);

		// -(void)addOrUpdateChannelId:(NSString *)channelId;
		[Export ("addOrUpdateChannelId:")]
		void AddOrUpdateChannelId (string channelId);

		// -(void)clearSubscriptionData;
		[Export ("clearSubscriptionData")]
		void ClearSubscriptionData ();

		// -(void)fireChannelConfigListeners;
		[Export ("fireChannelConfigListeners")]
		void FireChannelConfigListeners ();

		// -(BOOL)getAutoClearBadge;
		[Export ("getAutoClearBadge")]
		bool GetAutoClearBadge ();

		// -(BOOL)clearBadge:(BOOL)fromNotificationOpened;
		[Export ("clearBadge:")]
		bool ClearBadge (bool fromNotificationOpened);

		// -(BOOL)notificationsEnabled;
		[Export ("notificationsEnabled")]
		bool NotificationsEnabled ();

		// -(BOOL)shouldSync;
		[Export ("shouldSync")]
		bool ShouldSync ();

		// -(void)setHandleSubscribedCalled:(BOOL)subscribed;
		[Export ("setHandleSubscribedCalled:")]
		void SetHandleSubscribedCalled (bool subscribed);

		// -(BOOL)getHandleSubscribedCalled;
		[Export ("getHandleSubscribedCalled")]
		bool GetHandleSubscribedCalled ();

		// -(CPHandleSubscribedBlock)getSubscribeHandler;
		[Export ("getSubscribeHandler")]
		CPHandleSubscribedBlock GetSubscribeHandler ();

		// -(void)setSubscribeHandler:(CPHandleSubscribedBlock)subscribedCallback;
		[Export ("setSubscribeHandler:")]
		void SetSubscribeHandler (CPHandleSubscribedBlock subscribedCallback);

		// -(void)initFeatures;
		[Export ("initFeatures")]
		void InitFeatures ();

		// -(void)initAppReview;
		[Export ("initAppReview")]
		void InitAppReview ();

		// -(BOOL)hasNewTopicAfterOneHour:(NSDictionary *)config initialDifference:(NSInteger)initialDifference displayDialogDifference:(NSInteger)displayAfter;
		[Export ("hasNewTopicAfterOneHour:initialDifference:displayDialogDifference:")]
		bool HasNewTopicAfterOneHour (NSDictionary config, nint initialDifference, nint displayAfter);

		// -(NSInteger)secondsAfterLastCheck;
		[Export ("secondsAfterLastCheck")]
		nint SecondsAfterLastCheck ();

		// -(void)showPendingTopicsDialog;
		[Export ("showPendingTopicsDialog")]
		void ShowPendingTopicsDialog ();

		// -(BOOL)hasSubscriptionTopics;
		[Export ("hasSubscriptionTopics")]
		bool HasSubscriptionTopics ();

		// -(BOOL)isSubscriptionInProgress;
		[Export ("isSubscriptionInProgress")]
		bool IsSubscriptionInProgress ();

		// -(void)setSubscriptionInProgress:(BOOL)progress;
		[Export ("setSubscriptionInProgress:")]
		void SetSubscriptionInProgress (bool progress);

		// -(NSDictionary *)getAvailableAttributesFromConfig:(NSDictionary *)channelConfig;
		[Export ("getAvailableAttributesFromConfig:")]
		NSDictionary GetAvailableAttributesFromConfig (NSDictionary channelConfig);

		// -(NSString *)getCurrentPageUrl;
		[Export ("getCurrentPageUrl")]
		string GetCurrentPageUrl ();

		// -(void)checkTags:(NSString *)urlStr params:(NSDictionary *)params;
		[Export ("checkTags:params:")]
		void CheckTags (string urlStr, NSDictionary @params);

		// -(void)autoAssignTagMatches:(CPChannelTag *)tag pathname:(NSString *)pathname params:(NSDictionary *)params callback:(void (^)(BOOL))callback;
		[Export ("autoAssignTagMatches:pathname:params:callback:")]
		void AutoAssignTagMatches (CPChannelTag tag, string pathname, NSDictionary @params, Action<bool> callback);

		// -(NSString *)getDeviceToken;
		[Export ("getDeviceToken")]
		string GetDeviceToken ();

		// -(BOOL)getTrackingConsentRequired;
		[Export ("getTrackingConsentRequired")]
		bool GetTrackingConsentRequired ();

		// -(BOOL)getHasTrackingConsent;
		[Export ("getHasTrackingConsent")]
		bool GetHasTrackingConsent ();

		// -(BOOL)getHasTrackingConsentCalled;
		[Export ("getHasTrackingConsentCalled")]
		bool GetHasTrackingConsentCalled ();

		// -(void)waitForTrackingConsent:(void (^)(void))callback;
		[Export ("waitForTrackingConsent:")]
		void WaitForTrackingConsent (Action callback);

		// -(void)addSubscriptionTagstoServer:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Export ("addSubscriptionTagstoServer:callback:")]
		void AddSubscriptionTagstoServer (string tagId, Action<NSString> callback);

		// -(void)removeSubscriptionTagsfromServer:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Export ("removeSubscriptionTagsfromServer:callback:")]
		void RemoveSubscriptionTagsfromServer (string tagId, Action<NSString> callback);

		// -(void)initTopicsDialogData:(NSDictionary *)config syncToBackend:(BOOL)syncToBackend;
		[Export ("initTopicsDialogData:syncToBackend:")]
		void InitTopicsDialogData (NSDictionary config, bool syncToBackend);
	}

	partial interface Constants
	{
		// extern NSString *const CLEVERPUSH_SDK_VERSION;
		[Field ("CLEVERPUSH_SDK_VERSION", "__Internal")]
		NSString CLEVERPUSH_SDK_VERSION { get; }
	}

	// typedef void (^CPNotificationClickBlock)(CPNotification *);
	delegate void CPNotificationClickBlock (CPNotification arg0);

	// @interface CleverPush : NSObject
	[BaseType (typeof(NSObject))]
	interface CleverPush
	{
		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId;
		[Static]
		[Export ("initWithLaunchOptions:channelId:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:autoRegister:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:autoRegister:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleSubscribed:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleSubscribed:autoRegister:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:handleSubscribed:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:handleSubscribed:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions;
		[Static]
		[Export ("initWithLaunchOptions:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Static]
		[Export ("initWithLaunchOptions:handleNotificationOpened:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, CPHandleNotificationOpenedBlock openedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export ("initWithLaunchOptions:handleSubscribed:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export ("initWithLaunchOptions:handleNotificationOpened:handleSubscribed:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:handleSubscribed:autoRegister:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export ("initWithLaunchOptions:channelId:handleNotificationOpened:handleSubscribed:autoRegister:")]
		NSObject InitWithLaunchOptions (NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// +(void)setTrackingConsentRequired:(BOOL)required;
		[Static]
		[Export ("setTrackingConsentRequired:")]
		void SetTrackingConsentRequired (bool required);

		// +(void)setTrackingConsent:(BOOL)consent;
		[Static]
		[Export ("setTrackingConsent:")]
		void SetTrackingConsent (bool consent);

		// +(void)enableDevelopmentMode;
		[Static]
		[Export ("enableDevelopmentMode")]
		void EnableDevelopmentMode ();

		// +(void)subscribe;
		[Static]
		[Export ("subscribe")]
		void Subscribe ();

		// +(void)subscribe:(CPHandleSubscribedBlock)subscribedBlock;
		[Static]
		[Export ("subscribe:")]
		void Subscribe (CPHandleSubscribedBlock subscribedBlock);

		// +(void)subscribe:(CPHandleSubscribedBlock)subscribedBlock failure:(CPFailureBlock)failureBlock;
		[Static]
		[Export ("subscribe:failure:")]
		void Subscribe (CPHandleSubscribedBlock subscribedBlock, CPFailureBlock failureBlock);

		// +(void)disableAppBanners;
		[Static]
		[Export ("disableAppBanners")]
		void DisableAppBanners ();

		// +(void)enableAppBanners;
		[Static]
		[Export ("enableAppBanners")]
		void EnableAppBanners ();

		// +(BOOL)popupVisible;
		[Static]
		[Export ("popupVisible")]
		bool PopupVisible { get; }

		// +(void)unsubscribe;
		[Static]
		[Export ("unsubscribe")]
		void Unsubscribe ();

		// +(void)unsubscribe:(void (^)(BOOL))callback;
		[Static]
		[Export ("unsubscribe:")]
		void Unsubscribe (Action<bool> callback);

		// +(void)syncSubscription;
		[Static]
		[Export ("syncSubscription")]
		void SyncSubscription ();

		// +(void)didRegisterForRemoteNotifications:(UIApplication *)app deviceToken:(NSData *)inDeviceToken;
		[Static]
		[Export ("didRegisterForRemoteNotifications:deviceToken:")]
		void DidRegisterForRemoteNotifications (UIApplication app, NSData inDeviceToken);

		// +(void)handleDidFailRegisterForRemoteNotification:(NSError *)err;
		[Static]
		[Export ("handleDidFailRegisterForRemoteNotification:")]
		void HandleDidFailRegisterForRemoteNotification (NSError err);

		// +(void)handleNotificationOpened:(NSDictionary *)messageDict isActive:(BOOL)isActive actionIdentifier:(NSString *)actionIdentifier;
		[Static]
		[Export ("handleNotificationOpened:isActive:actionIdentifier:")]
		void HandleNotificationOpened (NSDictionary messageDict, bool isActive, string actionIdentifier);

		// +(void)handleNotificationReceived:(NSDictionary *)messageDict isActive:(BOOL)isActive;
		[Static]
		[Export ("handleNotificationReceived:isActive:")]
		void HandleNotificationReceived (NSDictionary messageDict, bool isActive);

		// +(void)addSubscriptionTags:(NSArray *)tagIds callback:(void (^)(NSArray *))callback;
		[Static]
		[Export ("addSubscriptionTags:callback:")]
		void AddSubscriptionTags (NSObject[] tagIds, Action<NSArray> callback);

		// +(void)addSubscriptionTag:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Static]
		[Export ("addSubscriptionTag:callback:")]
		void AddSubscriptionTag (string tagId, Action<NSString> callback);

		// +(void)addSubscriptionTags:(NSArray *)tagIds;
		[Static]
		[Export ("addSubscriptionTags:")]
		void AddSubscriptionTags (NSObject[] tagIds);

		// +(void)addSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export ("addSubscriptionTag:")]
		void AddSubscriptionTag (string tagId);

		// +(void)removeSubscriptionTags:(NSArray *)tagIds callback:(void (^)(NSArray *))callback;
		[Static]
		[Export ("removeSubscriptionTags:callback:")]
		void RemoveSubscriptionTags (NSObject[] tagIds, Action<NSArray> callback);

		// +(void)removeSubscriptionTag:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Static]
		[Export ("removeSubscriptionTag:callback:")]
		void RemoveSubscriptionTag (string tagId, Action<NSString> callback);

		// +(void)removeSubscriptionTags:(NSArray *)tagIds;
		[Static]
		[Export ("removeSubscriptionTags:")]
		void RemoveSubscriptionTags (NSObject[] tagIds);

		// +(void)removeSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export ("removeSubscriptionTag:")]
		void RemoveSubscriptionTag (string tagId);

		// +(void)setSubscriptionAttribute:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export ("setSubscriptionAttribute:value:")]
		void SetSubscriptionAttribute (string attributeId, string value);

		// +(void)pushSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export ("pushSubscriptionAttributeValue:value:")]
		void PushSubscriptionAttributeValue (string attributeId, string value);

		// +(void)pullSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export ("pullSubscriptionAttributeValue:value:")]
		void PullSubscriptionAttributeValue (string attributeId, string value);

		// +(BOOL)hasSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export ("hasSubscriptionAttributeValue:value:")]
		bool HasSubscriptionAttributeValue (string attributeId, string value);

		// +(void)getAvailableTags:(void (^)(NSArray *))callback;
		[Static]
		[Export ("getAvailableTags:")]
		void GetAvailableTags (Action<NSArray> callback);

		// +(void)getAvailableTopics:(void (^)(NSArray *))callback;
		[Static]
		[Export ("getAvailableTopics:")]
		void GetAvailableTopics (Action<NSArray> callback);

		// +(void)getAvailableAttributes:(void (^)(NSDictionary *))callback;
		[Static]
		[Export ("getAvailableAttributes:")]
		void GetAvailableAttributes (Action<NSDictionary> callback);

		// +(void)setSubscriptionLanguage:(NSString *)language;
		[Static]
		[Export ("setSubscriptionLanguage:")]
		void SetSubscriptionLanguage (string language);

		// +(void)setSubscriptionCountry:(NSString *)country;
		[Static]
		[Export ("setSubscriptionCountry:")]
		void SetSubscriptionCountry (string country);

		// +(void)setTopicsDialogWindow:(UIWindow *)window;
		[Static]
		[Export ("setTopicsDialogWindow:")]
		void SetTopicsDialogWindow (UIWindow window);

		// +(void)setSubscriptionTopics:(NSMutableArray *)topics;
		[Static]
		[Export ("setSubscriptionTopics:")]
		void SetSubscriptionTopics (NSMutableArray topics);

		// +(void)setBrandingColor:(UIColor *)color;
		[Static]
		[Export ("setBrandingColor:")]
		void SetBrandingColor (UIColor color);

		// +(void)setNormalTintColor:(UIColor *)color;
		[Static]
		[Export ("setNormalTintColor:")]
		void SetNormalTintColor (UIColor color);

		// +(UIColor *)getNormalTintColor;
		[Static]
		[Export ("getNormalTintColor")]
		UIColor NormalTintColor { get; }

		// +(void)setChatBackgroundColor:(UIColor *)color;
		[Static]
		[Export ("setChatBackgroundColor:")]
		void SetChatBackgroundColor (UIColor color);

		// +(void)setAutoClearBadge:(BOOL)autoClear;
		[Static]
		[Export ("setAutoClearBadge:")]
		void SetAutoClearBadge (bool autoClear);

		// +(void)setIncrementBadge:(BOOL)increment;
		[Static]
		[Export ("setIncrementBadge:")]
		void SetIncrementBadge (bool increment);

		// +(void)setShowNotificationsInForeground:(BOOL)show;
		[Static]
		[Export ("setShowNotificationsInForeground:")]
		void SetShowNotificationsInForeground (bool show);

		// +(void)setIgnoreDisabledNotificationPermission:(BOOL)ignore;
		[Static]
		[Export ("setIgnoreDisabledNotificationPermission:")]
		void SetIgnoreDisabledNotificationPermission (bool ignore);

		// +(void)showTopicsDialog;
		[Static]
		[Export ("showTopicsDialog")]
		void ShowTopicsDialog ();

		// +(void)showTopicDialogOnNewAdded;
		[Static]
		[Export ("showTopicDialogOnNewAdded")]
		void ShowTopicDialogOnNewAdded ();

		// +(void)showTopicsDialog:(UIWindow *)targetWindow;
		[Static]
		[Export ("showTopicsDialog:")]
		void ShowTopicsDialog (UIWindow targetWindow);

		// +(void)getChannelConfig:(void (^)(NSDictionary *))callback;
		[Static]
		[Export ("getChannelConfig:")]
		void GetChannelConfig (Action<NSDictionary> callback);

		// +(void)getSubscriptionId:(void (^)(NSString *))callback;
		[Static]
		[Export ("getSubscriptionId:")]
		void GetSubscriptionId (Action<NSString> callback);

		// +(void)trackEvent:(NSString *)eventName;
		[Static]
		[Export ("trackEvent:")]
		void TrackEvent (string eventName);

		// +(void)trackEvent:(NSString *)eventName amount:(NSNumber *)amount;
		[Static]
		[Export ("trackEvent:amount:")]
		void TrackEvent (string eventName, NSNumber amount);

		// +(void)trackPageView:(NSString *)url;
		[Static]
		[Export ("trackPageView:")]
		void TrackPageView (string url);

		// +(void)trackPageView:(NSString *)url params:(NSDictionary *)params;
		[Static]
		[Export ("trackPageView:params:")]
		void TrackPageView (string url, NSDictionary @params);

		// +(void)increaseSessionVisits;
		[Static]
		[Export ("increaseSessionVisits")]
		void IncreaseSessionVisits ();

		// +(void)showAppBanner:(NSString *)bannerId;
		[Static]
		[Export ("showAppBanner:")]
		void ShowAppBanner (string bannerId);

		// +(void)getAppBanners:(NSString *)channelId callback:(void (^)(NSArray *))callback;
		[Static]
		[Export ("getAppBanners:callback:")]
		void GetAppBanners (string channelId, Action<NSArray> callback);

		// +(void)triggerAppBannerEvent:(NSString *)key value:(NSString *)value;
		[Static]
		[Export ("triggerAppBannerEvent:value:")]
		void TriggerAppBannerEvent (string key, string value);

		// +(void)setApiEndpoint:(NSString *)apiEndpoint;
		[Static]
		[Export ("setApiEndpoint:")]
		void SetApiEndpoint (string apiEndpoint);

		// +(void)updateBadge:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Static]
		[Export ("updateBadge:")]
		void UpdateBadge (UNMutableNotificationContent replacementContent);

		// +(void)updateDeselectFlag:(BOOL)value;
		[Static]
		[Export ("updateDeselectFlag:")]
		void UpdateDeselectFlag (bool value);

		// +(void)setOpenWebViewEnabled:(BOOL)opened;
		[Static]
		[Export ("setOpenWebViewEnabled:")]
		void SetOpenWebViewEnabled (bool opened);

		// +(void)setUnsubscribeStatus:(BOOL)status;
		[Static]
		[Export ("setUnsubscribeStatus:")]
		void SetUnsubscribeStatus (bool status);

		// +(UIViewController *)topViewController;
		[Static]
		[Export ("topViewController")]
		UIViewController TopViewController { get; }

		// +(BOOL)hasSubscriptionTopic:(NSString *)topicId;
		[Static]
		[Export ("hasSubscriptionTopic:")]
		bool HasSubscriptionTopic (string topicId);

		// +(NSArray *)getAvailableTags __attribute__((deprecated("")));
		[Static]
		[Export ("getAvailableTags")]
		NSObject[] AvailableTags { get; }

		// +(NSArray *)getAvailableTopics __attribute__((deprecated("")));
		[Static]
		[Export ("getAvailableTopics")]
		NSObject[] AvailableTopics { get; }

		// +(NSArray *)getSubscriptionTags;
		[Static]
		[Export ("getSubscriptionTags")]
		NSObject[] SubscriptionTags { get; }

		// +(NSArray<CPNotification *> *)getNotifications;
		[Static]
		[Export ("getNotifications")]
		CPNotification[] Notifications { get; }

		// +(void)getNotifications:(BOOL)combineWithApi callback:(void (^)(NSArray *))callback;
		[Static]
		[Export ("getNotifications:callback:")]
		void GetNotifications (bool combineWithApi, Action<NSArray> callback);

		// +(void)removeNotification:(NSString *)notificationId;
		[Static]
		[Export ("removeNotification:")]
		void RemoveNotification (string notificationId);

		// +(NSArray *)getSeenStories;
		[Static]
		[Export ("getSeenStories")]
		NSObject[] SeenStories { get; }

		// +(NSMutableArray *)getSubscriptionTopics;
		[Static]
		[Export ("getSubscriptionTopics")]
		NSMutableArray SubscriptionTopics { get; }

		// +(NSString *)getSubscriptionAttribute:(NSString *)attributeId;
		[Static]
		[Export ("getSubscriptionAttribute:")]
		string GetSubscriptionAttribute (string attributeId);

		// +(NSString *)getSubscriptionId;
		[Static]
		[Export ("getSubscriptionId")]
		string SubscriptionId { get; }

		// +(NSString *)getApiEndpoint;
		[Static]
		[Export ("getApiEndpoint")]
		string ApiEndpoint { get; }

		// +(NSString *)channelId;
		[Static]
		[Export ("channelId")]
		string ChannelId { get; }

		// +(UIColor *)getBrandingColor;
		[Static]
		[Export ("getBrandingColor")]
		UIColor BrandingColor { get; }

		// +(UIColor *)getChatBackgroundColor;
		[Static]
		[Export ("getChatBackgroundColor")]
		UIColor ChatBackgroundColor { get; }

		// +(NSDictionary *)getAvailableAttributes __attribute__((deprecated("")));
		[Static]
		[Export ("getAvailableAttributes")]
		NSDictionary AvailableAttributes { get; }

		// +(NSDictionary *)getSubscriptionAttributes;
		[Static]
		[Export ("getSubscriptionAttributes")]
		NSDictionary SubscriptionAttributes { get; }

		// +(BOOL)isDevelopmentModeEnabled;
		[Static]
		[Export ("isDevelopmentModeEnabled")]
		bool IsDevelopmentModeEnabled { get; }

		// +(BOOL)isSubscribed;
		[Static]
		[Export ("isSubscribed")]
		bool IsSubscribed { get; }

		// +(BOOL)handleSilentNotificationReceived:(UIApplication *)application UserInfo:(NSDictionary *)messageDict completionHandler:(void (^)(UIBackgroundFetchResult))completionHandler;
		[Static]
		[Export ("handleSilentNotificationReceived:UserInfo:completionHandler:")]
		bool HandleSilentNotificationReceived (UIApplication application, NSDictionary messageDict, Action<UIBackgroundFetchResult> completionHandler);

		// +(BOOL)hasSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export ("hasSubscriptionTag:")]
		bool HasSubscriptionTag (string tagId);

		// +(BOOL)getDeselectValue;
		[Static]
		[Export ("getDeselectValue")]
		bool DeselectValue { get; }

		// +(BOOL)getUnsubscribeStatus;
		[Static]
		[Export ("getUnsubscribeStatus")]
		bool UnsubscribeStatus { get; }

		// +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Static]
		[Export ("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent DidReceiveNotificationExtensionRequest (UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// +(UNMutableNotificationContent *)serviceExtensionTimeWillExpireRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Static]
		[Export ("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest (UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// +(void)processLocalActionBasedNotification:(UILocalNotification *)notification actionIdentifier:(NSString *)actionIdentifier;
		[Static]
		[Export ("processLocalActionBasedNotification:actionIdentifier:")]
		void ProcessLocalActionBasedNotification (UILocalNotification notification, string actionIdentifier);
	}
}
