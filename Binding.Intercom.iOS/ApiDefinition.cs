using System;
using Foundation;
using ObjCRuntime;
using UserNotifications;

namespace Binding.Intercom.iOS;

// @interface ICMUserAttributes : NSObject
[BaseType(typeof(NSObject))]
interface ICMUserAttributes
{
    // @property (copy, nonatomic) NSString * _Nullable email;
    [NullAllowed, Export("email")]
    string Email { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable userId;
    [NullAllowed, Export("userId")]
    string UserId { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable name;
    [NullAllowed, Export("name")]
    string Name { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable phone;
    [NullAllowed, Export("phone")]
    string Phone { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable languageOverride;
    [NullAllowed, Export("languageOverride")]
    string LanguageOverride { get; set; }

    // @property (nonatomic, strong) NSDate * _Nullable signedUpAt;
    [NullAllowed, Export("signedUpAt", ArgumentSemantic.Strong)]
    NSDate SignedUpAt { get; set; }

    // @property (assign, nonatomic) BOOL unsubscribedFromEmails;
    [Export("unsubscribedFromEmails")]
    bool UnsubscribedFromEmails { get; set; }

    // @property (nonatomic, strong) NSArray<ICMCompany *> * _Nullable companies;
    [NullAllowed, Export("companies", ArgumentSemantic.Strong)]
    ICMCompany[] Companies { get; set; }

    // @property (nonatomic, strong) NSDictionary<NSString *,id> * _Nullable customAttributes;
    [NullAllowed, Export("customAttributes", ArgumentSemantic.Strong)]
    NSDictionary<NSString, NSObject> CustomAttributes { get; set; }

    // +(NSString * _Nonnull)nullStringAttribute;
    [Static]
    [Export("nullStringAttribute")]
    string NullStringAttribute { get; }

    // +(NSNumber * _Nonnull)nullNumberAttribute;
    [Static]
    [Export("nullNumberAttribute")]
    NSNumber NullNumberAttribute { get; }

    // +(NSDate * _Nonnull)nullDateAttribute;
    [Static]
    [Export("nullDateAttribute")]
    NSDate NullDateAttribute { get; }

    // -(NSDictionary<NSString *,id> * _Nonnull)attributes;
    [Export("attributes")]
    NSDictionary<NSString, NSObject> Attributes { get; }

    // -(NSDictionary<NSNumber *,NSString *> * _Nonnull)registrationAttributes;
    [Export("registrationAttributes")]
    NSDictionary<NSNumber, NSString> RegistrationAttributes { get; }
}

// @interface ICMCompany : NSObject
[BaseType(typeof(NSObject))]
interface ICMCompany
{
    // @property (copy, nonatomic) NSString * _Nullable companyId;
    [NullAllowed, Export("companyId")]
    string CompanyId { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable name;
    [NullAllowed, Export("name")]
    string Name { get; set; }

    // @property (nonatomic, strong) NSDate * _Nullable createdAt;
    [NullAllowed, Export("createdAt", ArgumentSemantic.Strong)]
    NSDate CreatedAt { get; set; }

    // @property (nonatomic, strong) NSNumber * _Nullable monthlySpend;
    [NullAllowed, Export("monthlySpend", ArgumentSemantic.Strong)]
    NSNumber MonthlySpend { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable plan;
    [NullAllowed, Export("plan")]
    string Plan { get; set; }

    // @property (nonatomic, strong) NSDictionary<NSString *,id> * _Nullable customAttributes;
    [NullAllowed, Export("customAttributes", ArgumentSemantic.Strong)]
    NSDictionary<NSString, NSObject> CustomAttributes { get; set; }

    // +(NSString * _Nonnull)nullStringAttribute;
    [Static]
    [Export("nullStringAttribute")]
    string NullStringAttribute { get; }

    // +(NSNumber * _Nonnull)nullNumberAttribute;
    [Static]
    [Export("nullNumberAttribute")]
    NSNumber NullNumberAttribute { get; }

    // +(NSDate * _Nonnull)nullDateAttribute;
    [Static]
    [Export("nullDateAttribute")]
    NSDate NullDateAttribute { get; }

    // -(NSDictionary<NSString *,id> * _Nonnull)attributes;
    [Export("attributes")]
    NSDictionary<NSString, NSObject> Attributes { get; }
}

// @interface ICMHelpCenterCollection : NSObject
[BaseType(typeof(NSObject))]
interface ICMHelpCenterCollection : INativeObject
{
    // @property (copy, nonatomic) NSString * _Nonnull collectionId;
    [Export("collectionId")]
    string CollectionId { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable summary;
    [NullAllowed, Export("summary")]
    string Summary { get; set; }

    // @property (assign, nonatomic) NSInteger articleCount;
    [Export("articleCount")]
    nint ArticleCount { get; set; }

    // @property (assign, nonatomic) NSInteger collectionCount;
    [Export("collectionCount")]
    nint CollectionCount { get; set; }

    // -(instancetype _Nonnull)initWithCollectionId:(NSString * _Nonnull)collectionId title:(NSString * _Nonnull)title summary:(NSString * _Nullable)summary articleCount:(NSInteger)articleCount __attribute__((deprecated("'-initWithCollectionId:title:summary:articleCount:' intializer is deprecated and will be removed in a future release. Use '-initWithCollectionId:title:summary:articleCount:collectionCount:' instead.")));
    [Export("initWithCollectionId:title:summary:articleCount:")]
    NativeHandle Constructor(string collectionId, string title, [NullAllowed] string summary, nint articleCount);

    // -(instancetype _Nonnull)initWithCollectionId:(NSString * _Nonnull)collectionId title:(NSString * _Nonnull)title summary:(NSString * _Nullable)summary articleCount:(NSInteger)articleCount collectionCount:(NSInteger)collectionCount;
    [Export("initWithCollectionId:title:summary:articleCount:collectionCount:")]
    NativeHandle Constructor(string collectionId, string title, [NullAllowed] string summary, nint articleCount, nint collectionCount);
}

// @interface ICMHelpCenterCollectionContent : NSObject
[BaseType(typeof(NSObject))]
interface ICMHelpCenterCollectionContent
{
    // @property (copy, nonatomic) NSString * _Nonnull collectionId;
    [Export("collectionId")]
    string CollectionId { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable summary;
    [NullAllowed, Export("summary")]
    string Summary { get; set; }

    // @property (nonatomic, strong) NSArray<ICMHelpCenterArticle *> * _Nonnull articles;
    [Export("articles", ArgumentSemantic.Strong)]
    ICMHelpCenterArticle[] Articles { get; set; }

    // @property (assign, nonatomic) NSInteger articleCount;
    [Export("articleCount")]
    nint ArticleCount { get; set; }

    // @property (nonatomic, strong) DEPRECATED_MSG_ATTRIBUTE("'sections' property is deprecated and will be removed in a future release. Use 'collections' instead.") NSArray<ICMHelpCenterSection *> * sections __attribute__((deprecated("'sections' property is deprecated and will be removed in a future release. Use 'collections' instead.")));
    [Export("sections", ArgumentSemantic.Strong)]
    ICMHelpCenterSection[] Sections { get; set; }

    // @property (nonatomic, strong) NSArray<ICMHelpCenterCollection *> * _Nonnull collections;
    [Export("collections", ArgumentSemantic.Strong)]
    ICMHelpCenterCollection[] Collections { get; set; }

    // @property (copy, nonatomic) NSArray<ICMHelpCenterArticleAuthor *> * _Nonnull authors;
    [Export("authors", ArgumentSemantic.Copy)]
    ICMHelpCenterArticleAuthor[] Authors { get; set; }

    // -(instancetype _Nonnull)initWithCollectionId:(NSString * _Nonnull)collectionId title:(NSString * _Nonnull)title summary:(NSString * _Nullable)summary articles:(NSArray<ICMHelpCenterArticle *> * _Nonnull)articles articleCount:(NSInteger)articleCount sections:(NSArray<ICMHelpCenterSection *> * _Nonnull)sections authors:(NSArray<ICMHelpCenterArticleAuthor *> * _Nonnull)authors __attribute__((deprecated("'initWithCollectionId:title:summary:articles:articleCount:sections:authors:' is deprecated and will be removed in a future release. Use 'initWithCollectionId:title:summary:articles:articleCount:collections:authors:' instead.")));
    [Export("initWithCollectionId:title:summary:articles:articleCount:sections:authors:")]
    NativeHandle Constructor(string collectionId, string title, [NullAllowed] string summary, ICMHelpCenterArticle[] articles, nint articleCount, ICMHelpCenterSection[] sections, ICMHelpCenterArticleAuthor[] authors);

    // -(instancetype _Nonnull)initWithCollectionId:(NSString * _Nonnull)collectionId title:(NSString * _Nonnull)title summary:(NSString * _Nullable)summary articles:(NSArray<ICMHelpCenterArticle *> * _Nonnull)articles articleCount:(NSInteger)articleCount collections:(NSArray<ICMHelpCenterCollection *> * _Nonnull)collections authors:(NSArray<ICMHelpCenterArticleAuthor *> * _Nonnull)authors;
    [Export("initWithCollectionId:title:summary:articles:articleCount:collections:authors:")]
    NativeHandle Constructor(string collectionId, string title, [NullAllowed] string summary, ICMHelpCenterArticle[] articles, nint articleCount, ICMHelpCenterCollection[] collections, ICMHelpCenterArticleAuthor[] authors);
}

// @interface ICMHelpCenterArticleSearchResult : NSObject
[BaseType(typeof(NSObject))]
interface ICMHelpCenterArticleSearchResult : INativeObject
{
    // @property (copy, nonatomic) NSString * _Nonnull articleId;
    [Export("articleId")]
    string ArticleId { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull summary;
    [Export("summary")]
    string Summary { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull matchingSnippet;
    [Export("matchingSnippet")]
    string MatchingSnippet { get; set; }

    // -(instancetype _Nonnull)initWithArticleId:(NSString * _Nonnull)articleId title:(NSString * _Nonnull)title summary:(NSString * _Nullable)summary matchingSnippet:(NSString * _Nullable)matchingSnippet;
    [Export("initWithArticleId:title:summary:matchingSnippet:")]
    NativeHandle Constructor(string articleId, string title, [NullAllowed] string summary, [NullAllowed] string matchingSnippet);
}

// @interface ICMHelpCenterSection : NSObject
[BaseType(typeof(NSObject))]
interface ICMHelpCenterSection
{
    // @property (copy, nonatomic) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // @property (nonatomic, strong) NSArray<ICMHelpCenterArticle *> * _Nonnull articles;
    [Export("articles", ArgumentSemantic.Strong)]
    ICMHelpCenterArticle[] Articles { get; set; }

    // -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title articles:(NSArray<ICMHelpCenterArticle *> * _Nonnull)articles;
    [Export("initWithTitle:articles:")]
    NativeHandle Constructor(string title, ICMHelpCenterArticle[] articles);
}

[Static]
partial interface Constants
{
    // extern const NSErrorDomain _Nonnull ICMHelpCenterDataErrorDomain;
    [Field("ICMHelpCenterDataErrorDomain", "__Internal")]
    NSString ICMHelpCenterDataErrorDomain { get; }
}

// @interface ICMHelpCenterArticle : NSObject
[BaseType(typeof(NSObject))]
interface ICMHelpCenterArticle
{
    // @property (copy, nonatomic) NSString * _Nonnull articleId;
    [Export("articleId")]
    string ArticleId { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // -(instancetype _Nonnull)initWithArticleId:(NSString * _Nonnull)articleId title:(NSString * _Nonnull)title;
    [Export("initWithArticleId:title:")]
    NativeHandle Constructor(string articleId, string title);
}

// @interface ICMHelpCenterArticleAuthor : NSObject
[BaseType(typeof(NSObject))]
interface ICMHelpCenterArticleAuthor
{
    // @property (copy, nonatomic) NSString * _Nonnull authorId;
    [Export("authorId")]
    string AuthorId { get; set; }

    // @property (copy, nonatomic) NSString * _Nonnull displayName;
    [Export("displayName")]
    string DisplayName { get; set; }

    // @property (copy, nonatomic) NSURL * _Nullable avatarURL;
    [NullAllowed, Export("avatarURL", ArgumentSemantic.Copy)]
    NSUrl AvatarURL { get; set; }

    // -(instancetype _Nonnull)initWithAuthorId:(NSString * _Nonnull)authorId displayName:(NSString * _Nonnull)displayName avatarURL:(NSURL * _Nullable)avatarURL;
    [Export("initWithAuthorId:displayName:avatarURL:")]
    NativeHandle Constructor(string authorId, string displayName, [NullAllowed] NSUrl avatarURL);
}

// @protocol IntercomContentProtocol <NSObject>
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
[Protocol]
[BaseType(typeof(NSObject))]
interface IIntercomContentProtocol
{
    // @required @property (assign, nonatomic) ContentType type;
    [Abstract]
    [Export("type", ArgumentSemantic.Assign)]
    ContentType Type { get; set; }

    // @required @property (nonatomic, strong) id _Nonnull contentId;
    [Abstract]
    [Export("contentId", ArgumentSemantic.Strong)]
    NSObject ContentId { get; set; }
}

// @interface IntercomContent : NSObject <IntercomContentProtocol>
[BaseType(typeof(NSObject))]
interface IntercomContent : IIntercomContentProtocol
{
    // +(IntercomContent * _Nonnull)articleWithId:(NSString * _Nonnull)articleId;
    [Static]
    [Export("articleWithId:")]
    IntercomContent ArticleWithId(string articleId);

    // +(IntercomContent * _Nonnull)carouselWithId:(NSString * _Nonnull)carouselId;
    [Static]
    [Export("carouselWithId:")]
    IntercomContent CarouselWithId(string carouselId);

    // +(IntercomContent * _Nonnull)surveyWithId:(NSString * _Nonnull)surveyId;
    [Static]
    [Export("surveyWithId:")]
    IntercomContent SurveyWithId(string surveyId);

    // +(IntercomContent * _Nonnull)helpCenterCollectionsWithIds:(NSArray<NSString *> * _Nonnull)collectionIds;
    [Static]
    [Export("helpCenterCollectionsWithIds:")]
    IntercomContent HelpCenterCollectionsWithIds(string[] collectionIds);

    // +(IntercomContent * _Nonnull)conversationWithId:(NSString * _Nonnull)conversationId;
    [Static]
    [Export("conversationWithId:")]
    IntercomContent ConversationWithId(string conversationId);
}

// @interface Intercom : NSObject
[BaseType(typeof(NSObject))]
interface Intercom
{
    // +(void)setApiKey:(NSString * _Nonnull)apiKey forAppId:(NSString * _Nonnull)appId;
    [Static]
    [Export("setApiKey:forAppId:")]
    void SetApiKey(string apiKey, string appId);

    // +(void)setUserHash:(NSString * _Nonnull)userHash;
    [Static]
    [Export("setUserHash:")]
    void SetUserHash(string userHash);

    // +(void)loginUnidentifiedUserWithSuccess:(void (^ _Nullable)(void))success failure:(void (^ _Nullable)(NSError * _Nonnull))failure __attribute__((swift_private));
    [Static]
    [Export("loginUnidentifiedUserWithSuccess:failure:")]
    void LoginUnidentifiedUserWithSuccess([NullAllowed] Action success, [NullAllowed] Action<NSError> failure);

    // +(void)loginUserWithUserAttributes:(ICMUserAttributes * _Nonnull)userAttributes success:(void (^ _Nullable)(void))success failure:(void (^ _Nullable)(NSError * _Nonnull))failure __attribute__((swift_private));
    [Static]
    [Export("loginUserWithUserAttributes:success:failure:")]
    void LoginUserWithUserAttributes(ICMUserAttributes userAttributes, [NullAllowed] Action success, [NullAllowed] Action<NSError> failure);

    // +(void)logout;
    [Static]
    [Export("logout")]
    void Logout();

    // +(void)updateUser:(ICMUserAttributes * _Nonnull)userAttributes success:(void (^ _Nullable)(void))success failure:(void (^ _Nullable)(NSError * _Nonnull))failure __attribute__((swift_private));
    [Static]
    [Export("updateUser:success:failure:")]
    void UpdateUser(ICMUserAttributes userAttributes, [NullAllowed] Action success, [NullAllowed] Action<NSError> failure);

    // +(void)logEventWithName:(NSString * _Nonnull)name;
    [Static]
    [Export("logEventWithName:")]
    void LogEventWithName(string name);

    // +(void)logEventWithName:(NSString * _Nonnull)name metaData:(NSDictionary * _Nonnull)metaData;
    [Static]
    [Export("logEventWithName:metaData:")]
    void LogEventWithName(string name, NSDictionary metaData);

    // +(void)presentIntercom;
    [Static]
    [Export("presentIntercom")]
    void PresentIntercom();

    // +(void)presentIntercom:(Space)space;
    [Static]
    [Export("presentIntercom:")]
    void PresentIntercom(Space space);

    // +(void)presentContent:(IntercomContent * _Nonnull)content __attribute__((swift_private));
    [Static]
    [Export("presentContent:")]
    void PresentContent(IntercomContent content);

    // +(void)presentMessageComposer:(NSString * _Nullable)initialMessage;
    [Static]
    [Export("presentMessageComposer:")]
    void PresentMessageComposer([NullAllowed] string initialMessage);

    // +(void)fetchHelpCenterCollectionsWithCompletion:(void (^ _Nonnull)(NSArray<ICMHelpCenterCollection *> * _Nullable, NSError * _Nullable))completion __attribute__((swift_private));
    [Static]
    [Export("fetchHelpCenterCollectionsWithCompletion:")]
    void FetchHelpCenterCollectionsWithCompletion(Action<NSArray<ICMHelpCenterCollection>, NSError> completion);

    // +(void)fetchHelpCenterCollection:(NSString * _Nonnull)collectionId withCompletion:(void (^ _Nonnull)(ICMHelpCenterCollectionContent * _Nullable, NSError * _Nullable))completion __attribute__((swift_private));
    [Static]
    [Export("fetchHelpCenterCollection:withCompletion:")]
    void FetchHelpCenterCollection(string collectionId, Action<ICMHelpCenterCollectionContent, NSError> completion);

    // +(void)searchHelpCenter:(NSString * _Nonnull)searchTerm withCompletion:(void (^ _Nonnull)(NSArray<ICMHelpCenterArticleSearchResult *> * _Nullable, NSError * _Nullable))completion __attribute__((swift_private));
    [Static]
    [Export("searchHelpCenter:withCompletion:")]
    void SearchHelpCenter(string searchTerm, Action<NSArray<ICMHelpCenterArticleSearchResult>, NSError> completion);

    // +(void)setDeviceToken:(NSData * _Nonnull)deviceToken failure:(void (^ _Nullable)(NSError * _Nullable))failure;
    [Static]
    [Export("setDeviceToken:failure:")]
    void SetDeviceToken(NSData deviceToken, [NullAllowed] Action<NSError> failure);

    // +(BOOL)isIntercomPushNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isIntercomPushNotification:")]
    bool IsIntercomPushNotification(NSDictionary userInfo);

    // +(void)handleIntercomPushNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("handleIntercomPushNotification:")]
    void HandleIntercomPushNotification(NSDictionary userInfo);

    // +(void)handleIntercomRichPushNotificationContent:(UNNotificationContent * _Nonnull)notificationContent withContentHandler:(void (^ _Nonnull)(UNNotificationContent * _Nonnull))contentHandler;
    [Static]
    [Export("handleIntercomRichPushNotificationContent:withContentHandler:")]
    void HandleIntercomRichPushNotificationContent(UNNotificationContent notificationContent, Action<UNNotificationContent> contentHandler);

    // +(void)setBottomPadding:(CGFloat)bottomPadding;
    [Static]
    [Export("setBottomPadding:")]
    void SetBottomPadding(nfloat bottomPadding);

    // +(void)setInAppMessagesVisible:(BOOL)visible;
    [Static]
    [Export("setInAppMessagesVisible:")]
    void SetInAppMessagesVisible(bool visible);

    // +(void)setLauncherVisible:(BOOL)visible;
    [Static]
    [Export("setLauncherVisible:")]
    void SetLauncherVisible(bool visible);

    // +(void)hideIntercom;
    [Static]
    [Export("hideIntercom")]
    void HideIntercom();

    // +(NSUInteger)unreadConversationCount;
    [Static]
    [Export("unreadConversationCount")]
    nuint UnreadConversationCount { get; }

    // +(void)enableLogging;
    [Static]
    [Export("enableLogging")]
    void EnableLogging();

    // +(void)setNeedsStatusBarAppearanceUpdate;
    [Static]
    [Export("setNeedsStatusBarAppearanceUpdate")]
    void SetNeedsStatusBarAppearanceUpdate();
}

partial interface Constants
{
    // extern NSString *const _Nonnull IntercomUnreadConversationCountDidChangeNotification __attribute__((visibility("default")));
    [Field("IntercomUnreadConversationCountDidChangeNotification", "__Internal")]
    NSString IntercomUnreadConversationCountDidChangeNotification { get; }

    // extern NSString *const _Nonnull IntercomWindowWillShowNotification __attribute__((visibility("default")));
    [Field("IntercomWindowWillShowNotification", "__Internal")]
    NSString IntercomWindowWillShowNotification { get; }

    // extern NSString *const _Nonnull IntercomWindowDidShowNotification __attribute__((visibility("default")));
    [Field("IntercomWindowDidShowNotification", "__Internal")]
    NSString IntercomWindowDidShowNotification { get; }

    // extern NSString *const _Nonnull IntercomWindowWillHideNotification __attribute__((visibility("default")));
    [Field("IntercomWindowWillHideNotification", "__Internal")]
    NSString IntercomWindowWillHideNotification { get; }

    // extern NSString *const _Nonnull IntercomWindowDidHideNotification __attribute__((visibility("default")));
    [Field("IntercomWindowDidHideNotification", "__Internal")]
    NSString IntercomWindowDidHideNotification { get; }

    // extern NSString *const _Nonnull IntercomDidStartNewConversationNotification __attribute__((visibility("default")));
    [Field("IntercomDidStartNewConversationNotification", "__Internal")]
    NSString IntercomDidStartNewConversationNotification { get; }
}
