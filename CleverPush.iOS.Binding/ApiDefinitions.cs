using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using UserNotificationsUI;
using WebKit;

namespace Com.CleverPush.iOS
{

	// @interface CPChatView : UIView <WKNavigationDelegate, WKScriptMessageHandler>
	[BaseType(typeof(UIView))]
	interface CPChatView : IWKNavigationDelegate, IWKScriptMessageHandler
	{
		// @property (nonatomic, strong) WKWebView * webView;
		[Export("webView", ArgumentSemantic.Strong)]
		WKWebView WebView { get; set; }

		// -(id)initWithFrame:(CGRect)frame urlOpenedCallback:(CPChatURLOpenedCallback)urlOpenedBlock subscribeCallback:(CPChatSubscribeCallback)subscribeBlock;
		[Export("initWithFrame:urlOpenedCallback:subscribeCallback:")]
		IntPtr Constructor(CGRect frame, CPChatURLOpenedCallback urlOpenedBlock, CPChatSubscribeCallback subscribeBlock);

		// -(id)initWithFrame:(CGRect)frame urlOpenedCallback:(CPChatURLOpenedCallback)urlOpenedBlock subscribeCallback:(CPChatSubscribeCallback)subscribeBlock headerCodes:(NSString *)headerHtmlCodes;
		[Export("initWithFrame:urlOpenedCallback:subscribeCallback:headerCodes:")]
		IntPtr Constructor(CGRect frame, CPChatURLOpenedCallback urlOpenedBlock, CPChatSubscribeCallback subscribeBlock, string headerHtmlCodes);

		// -(void)loadChat;
		[Export("loadChat")]
		void LoadChat();

		// -(void)loadChatWithSubscriptionId:(NSString *)subscriptionId;
		[Export("loadChatWithSubscriptionId:")]
		void LoadChatWithSubscriptionId(string subscriptionId);

		// -(void)lockChat;
		[Export("lockChat")]
		void LockChat();
	}

	// typedef void (^CPChatURLOpenedCallback)(NSURL *);
	delegate void CPChatURLOpenedCallback(NSUrl arg0);

	// typedef void (^CPChatSubscribeCallback)();
	delegate void CPChatSubscribeCallback();

	// @interface CPStoryContentPreview : NSObject
	[BaseType(typeof(NSObject))]
	interface CPStoryContentPreview
	{
		// @property (nonatomic, strong) NSString * _Nonnull publisher;
		[Export("publisher", ArgumentSemantic.Strong)]
		string Publisher { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull publisherLogoSrc;
		[Export("publisherLogoSrc", ArgumentSemantic.Strong)]
		string PublisherLogoSrc { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull posterPortraitSrc;
		[Export("posterPortraitSrc", ArgumentSemantic.Strong)]
		string PosterPortraitSrc { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull publisherLogoWidth;
		[Export("publisherLogoWidth", ArgumentSemantic.Strong)]
		string PublisherLogoWidth { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull publisherLogoHeight;
		[Export("publisherLogoHeight", ArgumentSemantic.Strong)]
		string PublisherLogoHeight { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull posterLandscapeSrc;
		[Export("posterLandscapeSrc", ArgumentSemantic.Strong)]
		string PosterLandscapeSrc { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull posterSquareSrc;
		[Export("posterSquareSrc", ArgumentSemantic.Strong)]
		string PosterSquareSrc { get; set; }

		// -(id _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);
	}

	// @interface CPStoryContentMeta : NSObject
	[BaseType(typeof(NSObject))]
	interface CPStoryContentMeta
	{
		// @property (nonatomic, strong) NSString * _Nonnull articleBody;
		[Export("articleBody", ArgumentSemantic.Strong)]
		string ArticleBody { get; set; }

		// -(id _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);
	}

	// @interface CPStoryContent : NSObject
	[BaseType(typeof(NSObject))]
	interface CPStoryContent
	{
		// @property (nonatomic, strong) NSString * _Nonnull version;
		[Export("version", ArgumentSemantic.Strong)]
		string Version { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull canonicalUrl;
		[Export("canonicalUrl", ArgumentSemantic.Strong)]
		string CanonicalUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull slug;
		[Export("slug", ArgumentSemantic.Strong)]
		string Slug { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull pages;
		[Export("pages", ArgumentSemantic.Strong)]
		string Pages { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull subtitle;
		[Export("subtitle", ArgumentSemantic.Strong)]
		string Subtitle { get; set; }

		// @property (nonatomic, strong) CPStoryContentPreview * _Nonnull preview;
		[Export("preview", ArgumentSemantic.Strong)]
		CPStoryContentPreview Preview { get; set; }

		// @property (nonatomic, strong) CPStoryContentMeta * _Nonnull meta;
		[Export("meta", ArgumentSemantic.Strong)]
		CPStoryContentMeta Meta { get; set; }

		// @property (readwrite, nonatomic) BOOL supportsLandscape;
		[Export("supportsLandscape")]
		bool SupportsLandscape { get; set; }

		// @property (readwrite, nonatomic) BOOL published;
		[Export("published")]
		bool Published { get; set; }

		// -(id _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);
	}

	// @interface CPStory : NSObject
	[BaseType(typeof(NSObject))]
	interface CPStory
	{
		// @property (nonatomic, strong) NSString * _Nonnull id;
		[Export("id", ArgumentSemantic.Strong)]
		string Id { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull channel;
		[Export("channel", ArgumentSemantic.Strong)]
		string Channel { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull slug;
		[Export("slug", ArgumentSemantic.Strong)]
		string Slug { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull code;
		[Export("code", ArgumentSemantic.Strong)]
		string Code { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull user;
		[Export("user", ArgumentSemantic.Strong)]
		string User { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull views;
		[Export("views", ArgumentSemantic.Strong)]
		string Views { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull completions;
		[Export("completions", ArgumentSemantic.Strong)]
		string Completions { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull widgetViews;
		[Export("widgetViews", ArgumentSemantic.Strong)]
		string WidgetViews { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull clicks;
		[Export("clicks", ArgumentSemantic.Strong)]
		string Clicks { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull viewsWidget;
		[Export("viewsWidget", ArgumentSemantic.Strong)]
		string ViewsWidget { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull viewsOrganic;
		[Export("viewsOrganic", ArgumentSemantic.Strong)]
		string ViewsOrganic { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull createdAt;
		[Export("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull validatedAt;
		[Export("validatedAt", ArgumentSemantic.Strong)]
		NSDate ValidatedAt { get; set; }

		// @property (readwrite, nonatomic) BOOL valid;
		[Export("valid")]
		bool Valid { get; set; }

		// @property (readwrite, nonatomic) BOOL published;
		[Export("published")]
		bool Published { get; set; }

		// @property (nonatomic, strong) CPStoryContent * _Nonnull content;
		[Export("content", ArgumentSemantic.Strong)]
		CPStoryContent Content { get; set; }

		// @property (nonatomic, strong) NSMutableArray<NSString *> * _Nonnull redirectUrls;
		[Export("redirectUrls", ArgumentSemantic.Strong)]
		NSMutableArray<NSString> RedirectUrls { get; set; }

		// @property (nonatomic, strong) NSMutableArray<NSString *> * _Nonnull fontFamilies;
		[Export("fontFamilies", ArgumentSemantic.Strong)]
		NSMutableArray<NSString> FontFamilies { get; set; }

		// @property (nonatomic, strong) NSMutableArray<NSString *> * _Nonnull keywords;
		[Export("keywords", ArgumentSemantic.Strong)]
		NSMutableArray<NSString> Keywords { get; set; }

		// -(id _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);
	}

	// @interface CPStoryWidget : NSObject
	[BaseType(typeof(NSObject))]
	interface CPStoryWidget
	{
		// @property (nonatomic) CPWidgetVariant variant;
		// [Export ("variant", ArgumentSemantic.Assign)]
		// CPWidgetVariant Variant { get; set; }

		// @property (nonatomic) CPWidgetPosition position;
		// [Export ("position", ArgumentSemantic.Assign)]
		// CPWidgetPosition Position { get; set; }

		// @property (nonatomic) CPWidgetDisplay display;
		// [Export ("display", ArgumentSemantic.Assign)]
		// CPWidgetDisplay Display { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull id;
		[Export("id", ArgumentSemantic.Strong)]
		string Id { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull channel;
		[Export("channel", ArgumentSemantic.Strong)]
		string Channel { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull maxStoriesNumber;
		[Export("maxStoriesNumber", ArgumentSemantic.Strong)]
		string MaxStoriesNumber { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull storyHeight;
		[Export("storyHeight", ArgumentSemantic.Strong)]
		string StoryHeight { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull margin;
		[Export("margin", ArgumentSemantic.Strong)]
		string Margin { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull createdAt;
		[Export("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSMutableArray<CPStory *> * _Nonnull selectedStories;
		[Export("selectedStories", ArgumentSemantic.Strong)]
		NSMutableArray SelectedStories { get; set; }

		// -(id _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Export ("initWithJson:")]
		IntPtr Constructor(NSDictionary json);
	}

	// @interface CleverPush (UIImageView)
	[Category]
	[BaseType(typeof(UIImageView))]
	interface UIImageView_CleverPush
	{
		// -(void)setImageWithURL:(NSURL *)imageURL;
		[Export("setImageWithURL:")]
		void SetImageWithURL(NSUrl imageURL);
	}

	// @interface CPStoryView : UIView <UICollectionViewDelegate, UICollectionViewDataSource, UICollectionViewDelegateFlowLayout>
	[BaseType(typeof(UIView))]
	interface CPStoryView : IUICollectionViewDelegate, IUICollectionViewDataSource, IUICollectionViewDelegateFlowLayout
	{
		// @property (nonatomic, strong) UICollectionView * storyCollection;
		[Export("storyCollection", ArgumentSemantic.Strong)]
		UICollectionView StoryCollection { get; set; }

		// @property (nonatomic, strong) UIView * emptyView;
		[Export("emptyView", ArgumentSemantic.Strong)]
		UIView EmptyView { get; set; }

		// @property (nonatomic, strong) CPStoryWidget * widget;
		[Export("widget", ArgumentSemantic.Strong)]
		CPStoryWidget Widget { get; set; }

		// @property (nonatomic, strong) NSMutableArray<CPStory *> * stories;
		[Export("stories", ArgumentSemantic.Strong)]
		// NSMutableArray<CPStory> Stories { get; set; }

		// @property (nonatomic, strong) NSMutableArray * readStories;
		// [Export ("readStories", ArgumentSemantic.Strong)]
		NSMutableArray ReadStories { get; set; }

		// @property (nonatomic, strong) UIColor * ringBorderColor;
		[Export("ringBorderColor", ArgumentSemantic.Strong)]
		UIColor RingBorderColor { get; set; }

		// @property (nonatomic, strong) UIColor * textColor;
		[Export("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) NSString * fontStyle;
		[Export("fontStyle", ArgumentSemantic.Strong)]
		string FontStyle { get; set; }

		// -(id)initWithFrame:(CGRect)frame backgroundColor:(UIColor *)backgroundColor textColor:(UIColor *)textColor fontFamily:(NSString *)fontFamily borderColor:(UIColor *)borderColor storyWidgetId:(NSString *)id;
		[Export("initWithFrame:backgroundColor:textColor:fontFamily:borderColor:storyWidgetId:")]
		IntPtr Constructor(CGRect frame, UIColor backgroundColor, UIColor textColor, string fontFamily, UIColor borderColor, string id);
	}

	// @interface CleverPushiCarousel : UIView
	[BaseType(typeof(UIView))]
	interface CleverPushiCarousel
	{
		[Wrap("WeakDataSource")]
		[NullAllowed]
		iCarouselDataSource DataSource { get; set; }

		// @property (nonatomic, unsafe_unretained) id<iCarouselDataSource> _Nullable dataSource __attribute__((iboutlet));
		[NullAllowed, Export("dataSource", ArgumentSemantic.Assign)]
		NSObject WeakDataSource { get; set; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		iCarouselDelegate Delegate { get; set; }

		// @property (nonatomic, unsafe_unretained) id<iCarouselDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) iCarouselType type;
		[Export("type", ArgumentSemantic.Assign)]
		// iCarouselType Type { get; set; }

		// @property (getter = isScrollEnabled, assign, nonatomic) BOOL scrollEnabled;
		// [Export ("scrollEnabled")]
		bool ScrollEnabled { [Bind("isScrollEnabled")] get; set; }

		// @property (getter = isPagingEnabled, assign, nonatomic) BOOL pagingEnabled;
		[Export("pagingEnabled")]
		bool PagingEnabled { [Bind("isPagingEnabled")] get; set; }

		// @property (getter = isVertical, assign, nonatomic) BOOL vertical;
		[Export("vertical")]
		bool Vertical { [Bind("isVertical")] get; set; }

		// @property (readonly, getter = isWrapEnabled, nonatomic) BOOL wrapEnabled;
		[Export("wrapEnabled")]
		bool WrapEnabled { [Bind("isWrapEnabled")] get; }

		// @property (readonly, getter = isDragging, nonatomic) BOOL dragging;
		[Export("dragging")]
		bool Dragging { [Bind("isDragging")] get; }

		// @property (readonly, getter = isDecelerating, nonatomic) BOOL decelerating;
		[Export("decelerating")]
		bool Decelerating { [Bind("isDecelerating")] get; }

		// @property (readonly, getter = isScrolling, nonatomic) BOOL scrolling;
		[Export("scrolling")]
		bool Scrolling { [Bind("isScrolling")] get; }

		// @property (readonly, getter = isScrolling, nonatomic) BOOL scrollingTest;
		// [Export("scrollingTest")]
		// bool ScrollingTest { [Bind("isScrolling")] get; }

		// @property (assign, nonatomic) BOOL bounces;
		[Export("bounces")]
		bool Bounces { get; set; }

		// @property (assign, nonatomic) BOOL stopAtItemBoundary;
		[Export("stopAtItemBoundary")]
		bool StopAtItemBoundary { get; set; }

		// @property (assign, nonatomic) BOOL scrollToItemBoundary;
		[Export("scrollToItemBoundary")]
		bool ScrollToItemBoundary { get; set; }

		// @property (assign, nonatomic) BOOL ignorePerpendicularSwipes;
		[Export("ignorePerpendicularSwipes")]
		bool IgnorePerpendicularSwipes { get; set; }

		// @property (assign, nonatomic) BOOL centerItemWhenSelected;
		[Export("centerItemWhenSelected")]
		bool CenterItemWhenSelected { get; set; }

		// @property (assign, nonatomic) CGFloat perspective;
		[Export("perspective")]
		nfloat Perspective { get; set; }

		// @property (assign, nonatomic) CGFloat decelerationRate;
		[Export("decelerationRate")]
		nfloat DecelerationRate { get; set; }

		// @property (assign, nonatomic) CGFloat scrollSpeed;
		[Export("scrollSpeed")]
		nfloat ScrollSpeed { get; set; }

		// @property (assign, nonatomic) CGFloat bounceDistance;
		[Export("bounceDistance")]
		nfloat BounceDistance { get; set; }

		// @property (assign, nonatomic) CGFloat scrollOffset;
		[Export("scrollOffset")]
		nfloat ScrollOffset { get; set; }

		// @property (assign, nonatomic) CGFloat autoscroll;
		[Export("autoscroll")]
		nfloat Autoscroll { get; set; }

		// @property (readonly, nonatomic) CGFloat offsetMultiplier;
		[Export("offsetMultiplier")]
		nfloat OffsetMultiplier { get; }

		// @property (readonly, nonatomic) CGFloat itemWidth;
		[Export("itemWidth")]
		nfloat ItemWidth { get; }

		// @property (readonly, nonatomic) CGFloat toggle;
		[Export("toggle")]
		nfloat Toggle { get; }

		// @property (assign, nonatomic) NSInteger currentItemIndex;
		[Export("currentItemIndex")]
		nint CurrentItemIndex { get; set; }

		// @property (readonly, nonatomic) NSInteger numberOfItems;
		[Export("numberOfItems")]
		nint NumberOfItems { get; }

		// @property (readonly, nonatomic) NSInteger numberOfPlaceholders;
		[Export("numberOfPlaceholders")]
		nint NumberOfPlaceholders { get; }

		// @property (readonly, nonatomic) NSInteger numberOfVisibleItems;
		[Export("numberOfVisibleItems")]
		nint NumberOfVisibleItems { get; }

		// @property (assign, nonatomic) CGSize contentOffset;
		[Export("contentOffset", ArgumentSemantic.Assign)]
		CGSize ContentOffset { get; set; }

		// @property (assign, nonatomic) CGSize viewpointOffset;
		[Export("viewpointOffset", ArgumentSemantic.Assign)]
		CGSize ViewpointOffset { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nullable currentItemView;
		[NullAllowed, Export("currentItemView", ArgumentSemantic.Strong)]
		UIView CurrentItemView { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull contentView;
		[Export("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull indexesForVisibleItems;
		[Export("indexesForVisibleItems", ArgumentSemantic.Strong)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] IndexesForVisibleItems { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull visibleItemViews;
		[Export("visibleItemViews", ArgumentSemantic.Strong)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] VisibleItemViews { get; }

		// -(void)scrollByOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export("scrollByOffset:duration:")]
		void ScrollByOffset(nfloat offset, double duration);

		// -(void)scrollToOffset:(CGFloat)offset duration:(NSTimeInterval)duration;
		[Export("scrollToOffset:duration:")]
		void ScrollToOffset(nfloat offset, double duration);

		// -(void)scrollByNumberOfItems:(NSInteger)itemCount duration:(NSTimeInterval)duration;
		[Export("scrollByNumberOfItems:duration:")]
		void ScrollByNumberOfItems(nint itemCount, double duration);

		// -(void)scrollToItemAtIndex:(NSInteger)index duration:(NSTimeInterval)duration;
		[Export("scrollToItemAtIndex:duration:")]
		void ScrollToItemAtIndex(nint index, double duration);

		// -(void)scrollToItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("scrollToItemAtIndex:animated:")]
		void ScrollToItemAtIndex(nint index, bool animated);

		// -(CGFloat)offsetForItemAtIndex:(NSInteger)index;
		[Export("offsetForItemAtIndex:")]
		nfloat OffsetForItemAtIndex(nint index);

		// -(UIView * _Nullable)itemViewAtPoint:(CGPoint)point;
		[Export("itemViewAtPoint:")]
		[return: NullAllowed]
		UIView ItemViewAtPoint(CGPoint point);

		// -(UIView * _Nullable)itemViewAtIndex:(NSInteger)index;
		[Export("itemViewAtIndex:")]
		[return: NullAllowed]
		UIView ItemViewAtIndex(nint index);

		// -(NSInteger)indexOfItemView:(UIView * _Nonnull)view;
		[Export("indexOfItemView:")]
		nint IndexOfItemView(UIView view);

		// -(NSInteger)indexOfItemViewOrSubview:(UIView * _Nonnull)view;
		[Export("indexOfItemViewOrSubview:")]
		nint IndexOfItemViewOrSubview(UIView view);

		// -(void)removeItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("removeItemAtIndex:animated:")]
		void RemoveItemAtIndex(nint index, bool animated);

		// -(void)insertItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("insertItemAtIndex:animated:")]
		void InsertItemAtIndex(nint index, bool animated);

		// -(void)reloadItemAtIndex:(NSInteger)index animated:(BOOL)animated;
		[Export("reloadItemAtIndex:animated:")]
		void ReloadItemAtIndex(nint index, bool animated);

		// -(void)reloadData;
		[Export("reloadData")]
		void ReloadData();
	}

	// @protocol iCarouselDataSource <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface iCarouselDataSource
	{
		// @required -(NSInteger)numberOfItemsInCarousel:(CleverPushiCarousel * _Nonnull)carousel;
		[Abstract]
		[Export("numberOfItemsInCarousel:")]
		nint NumberOfItemsInCarousel(CleverPushiCarousel carousel);

		// @required -(UIView * _Nonnull)carousel:(CleverPushiCarousel * _Nonnull)carousel viewForItemAtIndex:(NSInteger)index reusingView:(UIView * _Nullable)view;
		[Abstract]
		[Export("carousel:viewForItemAtIndex:reusingView:")]
		UIView Carousel(CleverPushiCarousel carousel, nint index, [NullAllowed] UIView view);

		// @optional -(NSInteger)numberOfPlaceholdersInCarousel:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("numberOfPlaceholdersInCarousel:")]
		nint NumberOfPlaceholdersInCarousel(CleverPushiCarousel carousel);

		// @optional -(UIView * _Nonnull)carousel:(CleverPushiCarousel * _Nonnull)carousel placeholderViewAtIndex:(NSInteger)index reusingView:(UIView * _Nullable)view;
		// [Export ("carousel:placeholderViewAtIndex:reusingView:")]
		// UIView Carousel (CleverPushiCarousel carousel, nint index, [NullAllowed] UIView view);
	}

	// @protocol iCarouselDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface iCarouselDelegate
	{
		// @optional -(void)carouselWillBeginScrollingAnimation:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("carouselWillBeginScrollingAnimation:")]
		void CarouselWillBeginScrollingAnimation(CleverPushiCarousel carousel);

		// @optional -(void)carouselDidEndScrollingAnimation:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("carouselDidEndScrollingAnimation:")]
		void CarouselDidEndScrollingAnimation(CleverPushiCarousel carousel);

		// @optional -(void)carouselDidScroll:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("carouselDidScroll:")]
		void CarouselDidScroll(CleverPushiCarousel carousel);

		// @optional -(void)carouselCurrentItemIndexDidChange:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("carouselCurrentItemIndexDidChange:")]
		void CarouselCurrentItemIndexDidChange(CleverPushiCarousel carousel);

		// @optional -(void)carouselWillBeginDragging:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("carouselWillBeginDragging:")]
		void CarouselWillBeginDragging(CleverPushiCarousel carousel);

		// @optional -(void)carouselDidEndDragging:(CleverPushiCarousel * _Nonnull)carousel willDecelerate:(BOOL)decelerate;
		[Export("carouselDidEndDragging:willDecelerate:")]
		void CarouselDidEndDragging(CleverPushiCarousel carousel, bool decelerate);

		// @optional -(void)carouselWillBeginDecelerating:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("carouselWillBeginDecelerating:")]
		void CarouselWillBeginDecelerating(CleverPushiCarousel carousel);

		// @optional -(void)carouselDidEndDecelerating:(CleverPushiCarousel * _Nonnull)carousel;
		[Export("carouselDidEndDecelerating:")]
		void CarouselDidEndDecelerating(CleverPushiCarousel carousel);

		// @optional -(BOOL)carousel:(CleverPushiCarousel * _Nonnull)carousel shouldSelectItemAtIndex:(NSInteger)index;
		//[Export("carousel:shouldSelectItemAtIndex:")]
		// bool Carousel(CleverPushiCarousel carousel, nint index);

		// @optional -(void)carousel:(CleverPushiCarousel * _Nonnull)carousel didSelectItemAtIndex:(NSInteger)index;
		 [Export("carousel:didSelectItemAtIndex:")]
		 void Carousel (CleverPushiCarousel carousel, nint index);

		// @optional -(CGFloat)carouselItemWidth:(CleverPushiCarousel * _Nonnull)carousel;
		[Export ("carouselItemWidth:")]
		nfloat CarouselItemWidth(CleverPushiCarousel carousel);

		// @optional -(CATransform3D)carousel:(CleverPushiCarousel * _Nonnull)carousel itemTransformForOffset:(CGFloat)offset baseTransform:(CATransform3D)transform;
		[Export("carousel:itemTransformForOffset:baseTransform:")]
		CATransform3D Carousel(CleverPushiCarousel carousel, nfloat offset, CATransform3D transform);

		// @optional -(CGFloat)carousel:(CleverPushiCarousel * _Nonnull)carousel valueForOption:(iCarouselOption)option withDefault:(CGFloat)value;
		// [Export ("carousel:valueForOption:withDefault:")]
		// nfloat Carousel (CleverPushiCarousel carousel, iCarouselOption option, nfloat value);
	}

	// @interface CPNotificationViewController : UIViewController <iCarouselDataSource, iCarouselDelegate>
	[BaseType (typeof(UIViewController))]
	interface CPNotificationViewController
	{
		// @property UIImageView * backgroundImageView;
		[Export ("backgroundImageView", ArgumentSemantic.Assign)]
		UIImageView BackgroundImageView { get; set; }

		// @property CleverPushiCarousel * carousel;
		[Export ("carousel", ArgumentSemantic.Assign)]
		CleverPushiCarousel Carousel { get; set; }

		// @property UIPageControl * pageControl;
		[Export ("pageControl", ArgumentSemantic.Assign)]
		UIPageControl PageControl { get; set; }

		// -(void)cleverpushDidReceiveNotification:(UNNotification *)notification __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Export ("cleverpushDidReceiveNotification:")]
		void CleverpushDidReceiveNotification (UNNotification notification);

		// -(void)cleverpushDidReceiveNotificationResponse:(UNNotificationResponse *)response completionHandler:(void (^)(UNNotificationContentExtensionResponseOption))completion __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Export ("cleverpushDidReceiveNotificationResponse:completionHandler:")]
		void CleverpushDidReceiveNotificationResponse (UNNotificationResponse response, Action<UNNotificationContentExtensionResponseOption> completion);
	}

	// @interface CleverPushHTTPClient : NSObject
	[BaseType(typeof(NSObject))]
	interface CleverPushHTTPClient
	{
		// +(CleverPushHTTPClient *)sharedClient;
		[Static]
		[Export("sharedClient")]
		// [Verify (MethodToProperty)]
		CleverPushHTTPClient SharedClient { get; }

		// @property (readonly, nonatomic) NSURL * apiEndpoint;
		[Export("apiEndpoint")]
		NSUrl ApiEndpoint { get; }

		// -(NSMutableURLRequest *)requestWithMethod:(NSString *)method path:(NSString *)path;
		[Export("requestWithMethod:path:")]
		NSMutableUrlRequest RequestWithMethod(string method, string path);
	}

	// @interface CPAppBannerAction : NSObject
	[BaseType(typeof(NSObject))]
	interface CPAppBannerAction
	{
		// @property (nonatomic, strong) NSURL * url;
		[Export("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; set; }

		// @property (nonatomic, strong) NSString * urlType;
		[Export("urlType", ArgumentSemantic.Strong)]
		string UrlType { get; set; }

		// @property (nonatomic, strong) NSString * name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * type;
		[Export("type", ArgumentSemantic.Strong)]
		string Type { get; set; }

		// @property (nonatomic) BOOL dismiss;
		[Export("dismiss")]
		bool Dismiss { get; set; }

		// @property (nonatomic) BOOL openInWebview;
		[Export("openInWebview")]
		bool OpenInWebview { get; set; }

		// -(id)initWithJson:(NSDictionary *)json;
		[Export("initWithJson:")]
		IntPtr Constructor(NSDictionary json);
	}

	// @interface CPNotification : NSObject
	[BaseType(typeof(NSObject))]
	interface CPNotification
	{
		// @property (nonatomic, strong) NSString * _Nonnull id;
		[Export("id", ArgumentSemantic.Strong)]
		string Id { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull tag;
		[Export("tag", ArgumentSemantic.Strong)]
		string Tag { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull title;
		[Export("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull text;
		[Export("text", ArgumentSemantic.Strong)]
		string Text { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull url;
		[Export("url", ArgumentSemantic.Strong)]
		string Url { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull iconUrl;
		[Export("iconUrl", ArgumentSemantic.Strong)]
		string IconUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull mediaUrl;
		[Export("mediaUrl", ArgumentSemantic.Strong)]
		string MediaUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull soundFilename;
		[Export("soundFilename", ArgumentSemantic.Strong)]
		string SoundFilename { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull appBanner;
		[Export("appBanner", ArgumentSemantic.Strong)]
		string AppBanner { get; set; }

		// @property (nonatomic, strong) NSArray * _Nonnull actions;
		[Export("actions", ArgumentSemantic.Strong)]
		// [Verify (StronglyTypedNSArray)]
		NSObject[] Actions { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nonnull customData;
		[Export("customData", ArgumentSemantic.Strong)]
		NSDictionary CustomData { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nonnull carouselItems;
		[Export("carouselItems", ArgumentSemantic.Strong)]
		NSDictionary CarouselItems { get; set; }

		// @property (readwrite, nonatomic) BOOL chatNotification;
		[Export("chatNotification")]
		bool ChatNotification { get; set; }

		// @property (readwrite, nonatomic) BOOL carouselEnabled;
		[Export("carouselEnabled")]
		bool CarouselEnabled { get; set; }

		// @property (readwrite, nonatomic) BOOL silent;
		[Export("silent")]
		bool Silent { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull createdAt;
		[Export("createdAt", ArgumentSemantic.Strong)]
		NSDate CreatedAt { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull expiresAt;
		[Export("expiresAt", ArgumentSemantic.Strong)]
		NSDate ExpiresAt { get; set; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export("initWithJson:")]
		CPNotification InitWithJson(NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export("parseJson:")]
		void ParseJson(NSDictionary json);
	}

	// @interface CPSubscription : NSObject
	[BaseType(typeof(NSObject))]
	interface CPSubscription
	{
		// @property (readonly) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export("initWithJson:")]
		CPSubscription InitWithJson(NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export("parseJson:")]
		void ParseJson(NSDictionary json);
	}

	// @interface CPChannelTag : NSObject
	[BaseType(typeof(NSObject))]
	interface CPChannelTag
	{
		// @property (readonly) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }

		// @property (readonly) NSString * _Nullable autoAssignPath;
		[NullAllowed, Export("autoAssignPath")]
		string AutoAssignPath { get; }

		// @property (readonly) NSString * _Nullable autoAssignFunction;
		[NullAllowed, Export("autoAssignFunction")]
		string AutoAssignFunction { get; }

		// @property (readonly) NSString * _Nullable autoAssignSelector;
		[NullAllowed, Export("autoAssignSelector")]
		string AutoAssignSelector { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignVisits;
		[NullAllowed, Export("autoAssignVisits")]
		NSNumber AutoAssignVisits { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignSessions;
		[NullAllowed, Export("autoAssignSessions")]
		NSNumber AutoAssignSessions { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignSeconds;
		[NullAllowed, Export("autoAssignSeconds")]
		NSNumber AutoAssignSeconds { get; }

		// @property (readonly) NSNumber * _Nullable autoAssignDays;
		[NullAllowed, Export("autoAssignDays")]
		NSNumber AutoAssignDays { get; }

		// @property (readonly) NSDate * _Nullable createdAt;
		[NullAllowed, Export("createdAt")]
		NSDate CreatedAt { get; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export("initWithJson:")]
		CPChannelTag InitWithJson(NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export("parseJson:")]
		void ParseJson(NSDictionary json);
	}

	// @interface CPChannelTopic : NSObject
	[BaseType(typeof(NSObject))]
	interface CPChannelTopic
	{
		// @property (readonly) NSString * _Nullable id;
		[NullAllowed, Export("id")]
		string Id { get; }

		// @property (readonly) NSString * _Nullable parentTopic;
		[NullAllowed, Export("parentTopic")]
		string ParentTopic { get; }

		// @property (readonly) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }

		// @property (readonly) NSString * _Nullable fcmBroadcastTopic;
		[NullAllowed, Export("fcmBroadcastTopic")]
		string FcmBroadcastTopic { get; }

		// @property (readonly) NSString * _Nullable externalId;
		[NullAllowed, Export("externalId")]
		string ExternalId { get; }

		// @property (readonly) NSNumber * _Nullable sort;
		[NullAllowed, Export("sort")]
		NSNumber Sort { get; }

		// @property (readonly) NSDictionary * _Nullable customData;
		[NullAllowed, Export("customData")]
		NSDictionary CustomData { get; }

		// @property (readonly) NSDate * _Nullable createdAt;
		[NullAllowed, Export("createdAt")]
		NSDate CreatedAt { get; }

		// @property (readwrite, nonatomic) BOOL defaultUnchecked;
		[Export("defaultUnchecked")]
		bool DefaultUnchecked { get; set; }

		// +(instancetype _Nonnull)initWithJson:(NSDictionary * _Nonnull)json;
		[Static]
		[Export("initWithJson:")]
		CPChannelTopic InitWithJson(NSDictionary json);

		// -(void)parseJson:(NSDictionary * _Nonnull)json;
		[Export("parseJson:")]
		void ParseJson(NSDictionary json);
	}

	// @interface CPNotificationReceivedResult : NSObject
	[BaseType(typeof(NSObject))]
	interface CPNotificationReceivedResult
	{
		// @property (readonly) NSDictionary * payload;
		[Export("payload")]
		NSDictionary Payload { get; }

		// @property (readonly) CPNotification * notification;
		[Export("notification")]
		CPNotification Notification { get; }

		// @property (readonly) CPSubscription * subscription;
		[Export("subscription")]
		CPSubscription Subscription { get; }

		// -(instancetype)initWithPayload:(NSDictionary *)payload;
		[Export("initWithPayload:")]
		IntPtr Constructor(NSDictionary payload);
	}

	// @interface CPNotificationOpenedResult : NSObject
	[BaseType(typeof(NSObject))]
	interface CPNotificationOpenedResult
	{
		// @property (readonly) NSDictionary * payload;
		[Export("payload")]
		NSDictionary Payload { get; }

		// @property (readonly) CPNotification * notification;
		[Export("notification")]
		CPNotification Notification { get; }

		// @property (readonly) CPSubscription * subscription;
		[Export("subscription")]
		CPSubscription Subscription { get; }

		// @property (readonly) NSString * action;
		[Export("action")]
		string Action { get; }

		// -(instancetype)initWithPayload:(NSDictionary *)payload action:(NSString *)action;
		[Export("initWithPayload:action:")]
		IntPtr Constructor(NSDictionary payload, string action);
	}

	// typedef void (^CPResultSuccessBlock)(NSDictionary *);
	delegate void CPResultSuccessBlock(NSDictionary arg0);

	// typedef void (^CPFailureBlock)(NSError *);
	delegate void CPFailureBlock(NSError arg0);

	// typedef void (^CPHandleSubscribedBlock)(NSString *);
	delegate void CPHandleSubscribedBlock(string arg0);

	// typedef void (^CPHandleNotificationReceivedBlock)(CPNotificationReceivedResult *);
	delegate void CPHandleNotificationReceivedBlock(CPNotificationReceivedResult arg0);

	// typedef void (^CPHandleNotificationOpenedBlock)(CPNotificationOpenedResult *);
	delegate void CPHandleNotificationOpenedBlock(CPNotificationOpenedResult arg0);

	// typedef void (^CPResultSuccessBlock)(NSDictionary *);
	// delegate void CPResultSuccessBlock (NSDictionary arg0);

	// typedef void (^CPFailureBlock)(NSError *);
	// delegate void CPFailureBlock (NSError arg0);

	// typedef void (^CPAppBannerActionBlock)(CPAppBannerAction *);
	delegate void CPAppBannerActionBlock(CPAppBannerAction arg0);

	[Static]
	// [Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const kCPSettingsKeyInFocusDisplayOption;
		[Field("kCPSettingsKeyInFocusDisplayOption", "__Internal")]
		NSString kCPSettingsKeyInFocusDisplayOption { get; }
	}

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

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationOpened:autoRegister:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:autoRegister:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, bool autoRegister);

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

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:handleSubscribed:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback);

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

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationReceived:(CPHandleNotificationReceivedBlock)receivedCallback handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationReceived:handleNotificationOpened:handleSubscribed:autoRegister:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationReceivedBlock receivedCallback, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// +(id)initWithLaunchOptions:(NSDictionary *)launchOptions channelId:(NSString *)channelId handleNotificationOpened:(CPHandleNotificationOpenedBlock)openedCallback handleSubscribed:(CPHandleSubscribedBlock)subscribedCallback autoRegister:(BOOL)autoRegister;
		[Static]
		[Export("initWithLaunchOptions:channelId:handleNotificationOpened:handleSubscribed:autoRegister:")]
		NSObject InitWithLaunchOptions(NSDictionary launchOptions, string channelId, CPHandleNotificationOpenedBlock openedCallback, CPHandleSubscribedBlock subscribedCallback, bool autoRegister);

		// +(void)setTrackingConsentRequired:(BOOL)required;
		[Static]
		[Export("setTrackingConsentRequired:")]
		void SetTrackingConsentRequired(bool required);

		// +(void)setTrackingConsent:(BOOL)consent;
		[Static]
		[Export("setTrackingConsent:")]
		void SetTrackingConsent(bool consent);

		// +(void)enableDevelopmentMode;
		[Static]
		[Export("enableDevelopmentMode")]
		void EnableDevelopmentMode();

		// +(void)subscribe;
		[Static]
		[Export("subscribe")]
		void Subscribe();

		// +(void)subscribe:(CPHandleSubscribedBlock)subscribedBlock;
		[Static]
		[Export("subscribe:")]
		void Subscribe(CPHandleSubscribedBlock subscribedBlock);

		// +(void)disableAppBanners;
		[Static]
		[Export("disableAppBanners")]
		void DisableAppBanners();

		// +(void)enableAppBanners;
		[Static]
		[Export("enableAppBanners")]
		void EnableAppBanners();

		// +(BOOL)popupVisible;
		[Static]
		[Export("popupVisible")]
		// [Verify (MethodToProperty)]
		bool PopupVisible { get; }

		// +(void)unsubscribe;
		[Static]
		[Export("unsubscribe")]
		void Unsubscribe();

		// +(void)unsubscribe:(void (^)(BOOL))callback;
		[Static]
		[Export("unsubscribe:")]
		void Unsubscribe(Action<bool> callback);

		// +(void)syncSubscription;
		[Static]
		[Export("syncSubscription")]
		void SyncSubscription();

		// +(void)didRegisterForRemoteNotifications:(UIApplication *)app deviceToken:(NSData *)inDeviceToken;
		[Static]
		[Export("didRegisterForRemoteNotifications:deviceToken:")]
		void DidRegisterForRemoteNotifications(UIApplication app, NSData inDeviceToken);

		// +(void)handleDidFailRegisterForRemoteNotification:(NSError *)err;
		[Static]
		[Export("handleDidFailRegisterForRemoteNotification:")]
		void HandleDidFailRegisterForRemoteNotification(NSError err);

		// +(void)handleNotificationOpened:(NSDictionary *)messageDict isActive:(BOOL)isActive actionIdentifier:(NSString *)actionIdentifier;
		[Static]
		[Export("handleNotificationOpened:isActive:actionIdentifier:")]
		void HandleNotificationOpened(NSDictionary messageDict, bool isActive, string actionIdentifier);

		// +(void)handleNotificationReceived:(NSDictionary *)messageDict isActive:(BOOL)isActive;
		[Static]
		[Export("handleNotificationReceived:isActive:")]
		void HandleNotificationReceived(NSDictionary messageDict, bool isActive);

		// +(void)enqueueRequest:(NSURLRequest *)request onSuccess:(CPResultSuccessBlock)successBlock onFailure:(CPFailureBlock)failureBlock;
		[Static]
		[Export("enqueueRequest:onSuccess:onFailure:")]
		void EnqueueRequest(NSUrlRequest request, CPResultSuccessBlock successBlock, CPFailureBlock failureBlock);

		// +(void)handleJSONNSURLResponse:(NSURLResponse *)response data:(NSData *)data error:(NSError *)error onSuccess:(CPResultSuccessBlock)successBlock onFailure:(CPFailureBlock)failureBlock;
		[Static]
		[Export("handleJSONNSURLResponse:data:error:onSuccess:onFailure:")]
		void HandleJSONNSURLResponse(NSUrlResponse response, NSData data, NSError error, CPResultSuccessBlock successBlock, CPFailureBlock failureBlock);

		// +(void)addSubscriptionTags:(NSArray *)tagIds callback:(void (^)(NSArray *))callback;
		[Static]
		[Export("addSubscriptionTags:callback:")]
		// [Verify (StronglyTypedNSArray)]
		void AddSubscriptionTags(NSObject[] tagIds, Action<NSArray> callback);

		// +(void)addSubscriptionTag:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Static]
		[Export("addSubscriptionTag:callback:")]
		void AddSubscriptionTag(string tagId, Action<NSString> callback);

		// +(void)addSubscriptionTags:(NSArray *)tagIds;
		[Static]
		[Export("addSubscriptionTags:")]
		// [Verify (StronglyTypedNSArray)]
		void AddSubscriptionTags(NSObject[] tagIds);

		// +(void)addSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export("addSubscriptionTag:")]
		void AddSubscriptionTag(string tagId);

		// +(void)removeSubscriptionTags:(NSArray *)tagIds callback:(void (^)(NSArray *))callback;
		[Static]
		[Export("removeSubscriptionTags:callback:")]
		// [Verify (StronglyTypedNSArray)]
		void RemoveSubscriptionTags(NSObject[] tagIds, Action<NSArray> callback);

		// +(void)removeSubscriptionTag:(NSString *)tagId callback:(void (^)(NSString *))callback;
		[Static]
		[Export("removeSubscriptionTag:callback:")]
		void RemoveSubscriptionTag(string tagId, Action<NSString> callback);

		// +(void)removeSubscriptionTags:(NSArray *)tagIds;
		[Static]
		[Export("removeSubscriptionTags:")]
		// [Verify (StronglyTypedNSArray)]
		void RemoveSubscriptionTags(NSObject[] tagIds);

		// +(void)removeSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export("removeSubscriptionTag:")]
		void RemoveSubscriptionTag(string tagId);

		// +(void)setSubscriptionAttribute:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export("setSubscriptionAttribute:value:")]
		void SetSubscriptionAttribute(string attributeId, string value);

		// +(void)pushSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export("pushSubscriptionAttributeValue:value:")]
		void PushSubscriptionAttributeValue(string attributeId, string value);

		// +(void)pullSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export("pullSubscriptionAttributeValue:value:")]
		void PullSubscriptionAttributeValue(string attributeId, string value);

		// +(BOOL)hasSubscriptionAttributeValue:(NSString *)attributeId value:(NSString *)value;
		[Static]
		[Export("hasSubscriptionAttributeValue:value:")]
		bool HasSubscriptionAttributeValue(string attributeId, string value);

		// +(void)getAvailableTags:(void (^)(NSArray *))callback;
		[Static]
		[Export("getAvailableTags:")]
		void GetAvailableTags(Action<NSArray> callback);

		// +(void)getAvailableTopics:(void (^)(NSArray *))callback;
		[Static]
		[Export("getAvailableTopics:")]
		void GetAvailableTopics(Action<NSArray> callback);

		// +(void)getAvailableAttributes:(void (^)(NSDictionary *))callback;
		[Static]
		[Export("getAvailableAttributes:")]
		void GetAvailableAttributes(Action<NSDictionary> callback);

		// +(void)setSubscriptionLanguage:(NSString *)language;
		[Static]
		[Export("setSubscriptionLanguage:")]
		void SetSubscriptionLanguage(string language);

		// +(void)setSubscriptionCountry:(NSString *)country;
		[Static]
		[Export("setSubscriptionCountry:")]
		void SetSubscriptionCountry(string country);

		// +(void)setTopicsDialogWindow:(UIWindow *)window;
		[Static]
		[Export("setTopicsDialogWindow:")]
		void SetTopicsDialogWindow(UIWindow window);

		// +(void)setSubscriptionTopics:(NSMutableArray *)topics;
		[Static]
		[Export("setSubscriptionTopics:")]
		void SetSubscriptionTopics(NSMutableArray topics);

		// +(void)setBrandingColor:(UIColor *)color;
		[Static]
		[Export("setBrandingColor:")]
		void SetBrandingColor(UIColor color);

		// +(void)setNormalTintColor:(UIColor *)color;
		[Static]
		[Export("setNormalTintColor:")]
		void SetNormalTintColor(UIColor color);

		// +(void)setChatBackgroundColor:(UIColor *)color;
		[Static]
		[Export("setChatBackgroundColor:")]
		void SetChatBackgroundColor(UIColor color);

		// +(void)setAutoClearBadge:(BOOL)autoClear;
		[Static]
		[Export("setAutoClearBadge:")]
		void SetAutoClearBadge(bool autoClear);

		// +(void)setIncrementBadge:(BOOL)increment;
		[Static]
		[Export("setIncrementBadge:")]
		void SetIncrementBadge(bool increment);

		// +(void)addChatView:(CPChatView *)chatView;
		[Static]
		[Export("addChatView:")]
		void AddChatView(CPChatView chatView);

		// +(void)showTopicsDialog;
		[Static]
		[Export("showTopicsDialog")]
		void ShowTopicsDialog();

		// +(void)showTopicsDialog:(UIWindow *)targetWindow;
		[Static]
		[Export("showTopicsDialog:")]
		void ShowTopicsDialog(UIWindow targetWindow);

		// +(void)getChannelConfig:(void (^)(NSDictionary *))callback;
		[Static]
		[Export("getChannelConfig:")]
		void GetChannelConfig(Action<NSDictionary> callback);

		// +(void)getSubscriptionId:(void (^)(NSString *))callback;
		[Static]
		[Export("getSubscriptionId:")]
		void GetSubscriptionId(Action<NSString> callback);

		// +(void)trackEvent:(NSString *)eventName;
		[Static]
		[Export("trackEvent:")]
		void TrackEvent(string eventName);

		// +(void)trackEvent:(NSString *)eventName amount:(NSNumber *)amount;
		[Static]
		[Export("trackEvent:amount:")]
		void TrackEvent(string eventName, NSNumber amount);

		// +(void)trackPageView:(NSString *)url;
		[Static]
		[Export("trackPageView:")]
		void TrackPageView(string url);

		// +(void)trackPageView:(NSString *)url params:(NSDictionary *)params;
		[Static]
		[Export("trackPageView:params:")]
		void TrackPageView(string url, NSDictionary @params);

		// +(void)increaseSessionVisits;
		[Static]
		[Export("increaseSessionVisits")]
		void IncreaseSessionVisits();

		// +(void)showAppBanner:(NSString *)bannerId;
		[Static]
		[Export("showAppBanner:")]
		void ShowAppBanner(string bannerId);

		// +(void)setAppBannerOpenedCallback:(CPAppBannerActionBlock)callback;
		[Static]
		[Export("setAppBannerOpenedCallback:")]
		void SetAppBannerOpenedCallback(CPAppBannerActionBlock callback);

		// +(void)triggerAppBannerEvent:(NSString *)key value:(NSString *)value;
		[Static]
		[Export("triggerAppBannerEvent:value:")]
		void TriggerAppBannerEvent(string key, string value);

		// +(void)setApiEndpoint:(NSString *)apiEndpoint;
		[Static]
		[Export("setApiEndpoint:")]
		void SetApiEndpoint(string apiEndpoint);

		// +(void)updateBadge:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS(10, 0)]
		[Static]
		[Export("updateBadge:")]
		void UpdateBadge(UNMutableNotificationContent replacementContent);

		// +(void)addStoryView:(CPStoryView *)storyView;
		[Static]
		[Export("addStoryView:")]
		void AddStoryView(CPStoryView storyView);

		// +(void)updateDeselectFlag:(BOOL)value;
		[Static]
		[Export("updateDeselectFlag:")]
		void UpdateDeselectFlag(bool value);

		// +(UIViewController *)topViewController;
		[Static]
		[Export("topViewController")]
		// [Verify (MethodToProperty)]
		UIViewController TopViewController { get; }

		// +(NSArray *)getAvailableTags __attribute__((deprecated("")));
		[Static]
		[Export("getAvailableTags")]
		// [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] AvailableTags { get; }

		// +(NSArray *)getAvailableTopics __attribute__((deprecated("")));
		[Static]
		[Export("getAvailableTopics")]
		// [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] AvailableTopics { get; }

		// +(NSArray *)getSubscriptionTags;
		[Static]
		[Export("getSubscriptionTags")]
		// [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] SubscriptionTags { get; }

		// +(NSArray *)getNotifications;
		[Static]
		[Export("getNotifications")]
		// [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Notifications { get; }

		// +(NSArray *)getSeenStories;
		[Static]
		[Export("getSeenStories")]
		// [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] SeenStories { get; }

		// +(NSMutableArray *)getSubscriptionTopics;
		[Static]
		[Export("getSubscriptionTopics")]
		// [Verify (MethodToProperty)]
		NSMutableArray SubscriptionTopics { get; }

		// +(NSString *)getSubscriptionAttribute:(NSString *)attributeId;
		[Static]
		[Export("getSubscriptionAttribute:")]
		string GetSubscriptionAttribute(string attributeId);

		// +(NSString *)getSubscriptionId;
		[Static]
		[Export("getSubscriptionId")]
		// [Verify (MethodToProperty)]
		string SubscriptionId { get; }

		// +(NSString *)getApiEndpoint;
		[Static]
		[Export("getApiEndpoint")]
		// [Verify (MethodToProperty)]
		string ApiEndpoint { get; }

		// +(NSString *)channelId;
		[Static]
		[Export("channelId")]
		// [Verify (MethodToProperty)]
		string ChannelId { get; }

		// +(UIColor *)getBrandingColor;
		[Static]
		[Export("getBrandingColor")]
		// [Verify (MethodToProperty)]
		UIColor BrandingColor { get; }

		// +(UIColor *)getChatBackgroundColor;
		[Static]
		[Export("getChatBackgroundColor")]
		// [Verify (MethodToProperty)]
		UIColor ChatBackgroundColor { get; }

		// +(NSDictionary *)getAvailableAttributes __attribute__((deprecated("")));
		[Static]
		[Export("getAvailableAttributes")]
		// [Verify (MethodToProperty)]
		NSDictionary AvailableAttributes { get; }

		// +(NSDictionary *)getSubscriptionAttributes;
		[Static]
		[Export("getSubscriptionAttributes")]
		// [Verify (MethodToProperty)]
		NSDictionary SubscriptionAttributes { get; }

		// +(BOOL)isDevelopmentModeEnabled;
		[Static]
		[Export("isDevelopmentModeEnabled")]
		// [Verify (MethodToProperty)]
		bool IsDevelopmentModeEnabled { get; }

		// +(BOOL)isSubscribed;
		[Static]
		[Export("isSubscribed")]
		// [Verify (MethodToProperty)]
		bool IsSubscribed { get; }

		// +(BOOL)handleSilentNotificationReceived:(UIApplication *)application UserInfo:(NSDictionary *)messageDict completionHandler:(void (^)(UIBackgroundFetchResult))completionHandler;
		[Static]
		[Export("handleSilentNotificationReceived:UserInfo:completionHandler:")]
		bool HandleSilentNotificationReceived(UIApplication application, NSDictionary messageDict, Action<UIBackgroundFetchResult> completionHandler);

		// +(BOOL)hasSubscriptionTag:(NSString *)tagId;
		[Static]
		[Export("hasSubscriptionTag:")]
		bool HasSubscriptionTag(string tagId);

		// +(BOOL)getDeselectValue;
		[Static]
		[Export("getDeselectValue")]
		// [Verify (MethodToProperty)]
		bool DeselectValue { get; }

		// +(UNMutableNotificationContent *)didReceiveNotificationExtensionRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS(10, 0)]
		[Static]
		[Export("didReceiveNotificationExtensionRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent DidReceiveNotificationExtensionRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// +(UNMutableNotificationContent *)serviceExtensionTimeWillExpireRequest:(UNNotificationRequest *)request withMutableNotificationContent:(UNMutableNotificationContent *)replacementContent __attribute__((availability(ios, introduced=10.0)));
		[iOS(10, 0)]
		[Static]
		[Export("serviceExtensionTimeWillExpireRequest:withMutableNotificationContent:")]
		UNMutableNotificationContent ServiceExtensionTimeWillExpireRequest(UNNotificationRequest request, UNMutableNotificationContent replacementContent);

		// +(void)processLocalActionBasedNotification:(UILocalNotification *)notification actionIdentifier:(NSString *)actionIdentifier;
		[Static]
		[Export("processLocalActionBasedNotification:actionIdentifier:")]
		void ProcessLocalActionBasedNotification(UILocalNotification notification, string actionIdentifier);
	}

	// [Static]
	// [Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const CLEVERPUSH_SDK_VERSION;
		[Field("CLEVERPUSH_SDK_VERSION", "__Internal")]
		NSString CLEVERPUSH_SDK_VERSION { get; }
	}
}