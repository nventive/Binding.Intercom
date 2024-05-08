using ObjCRuntime;

namespace Binding.Intercom.iOS;

[Native]
public enum ICMHelpCenterDataError : long
{
    contentNotAvailable = 1,
    networkError,
    somethingWentWrong,
    noUserRegistered,
    noAppRegistered
}

[Native]
public enum ContentType : long
{
    article,
    survey,
    carousel,
    helpCenterCollections,
    conversation
}

[Native]
public enum Space : long
{
    home,
    helpCenter,
    messages,
    tickets
}
