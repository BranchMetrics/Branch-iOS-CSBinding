using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.AdSupport;
using MonoTouch.CoreTelephony;

namespace BranchSDK
{
	public delegate void BranchDeepLinkHandler (NSDictionary parameters, NSError error);
	public delegate void BranchUrlCreated (string url, NSError error);
	public delegate void BranchRewardsLoaded (bool changed, NSError error);
	public delegate void BranchListLoaded (NSArray history, NSError error);

	[BaseType (typeof (NSObject))]
	public interface Branch {

		[Export ("initSession")]
		void InitSession ();

		[Export ("initSessionWithLaunchOptions:")]
		void InitSessionWithLaunchOptions (NSDictionary launchOptions);

		[Export ("initSession:")]
		void InitSession (bool isReferralble);

		[Export ("initSessionWithLaunchOptions:andIsReferrable:")]
		void InitSessionWithLaunchOption (NSDictionary launchOptions, bool isReferrable);

		[Export ("initSessionAndRegisterDeepLinkHandler:")]
		void InitSessionAndRegisterDeepLinkHandler (BranchDeepLinkHandler callback);

		[Export ("initSessionWithLaunchOptions:andRegisterDeepLinkHandler:")]
		void InitSessionAndRegisterDeepLinkHandler (NSDictionary launchOptions, BranchDeepLinkHandler callback);

		[Export ("initSessionWithLaunchOptions:andIsReferrable:andRegisterDeepLinkHandler:")]
		void InitSessionAndRegisterDeepLinkHandler (NSDictionary launchOptions, bool isReferrable, BranchDeepLinkHandler callback);

		[Export ("getFirstReferringParams")]
		NSDictionary GetFirstReferringParams ();

		[Export ("getLatestReferringParams")]
		NSDictionary GetLatestReferringParams ();

		[Export ("resetUserSession")]
		void ResetUserSession ();

		[Export ("handleDeepLink:")]
		bool HandleDeepLink (NSUrl url);

		[Export ("setIdentity:")]
		void IdentifyUser (string identity);

		[Export ("setIdentity:withCallback:")]
		void IdentifyUser (string identity, BranchDeepLinkHandler callback);

		[Export ("logout")]
		void Logout ();

		[Export ("loadRewardsWithCallback:")]
		void LoadRewardsWithCallback (BranchRewardsLoaded callback);

		[Export ("loadActionCountsWithCallback:")]
		void LoadActionCountsWithCallback (BranchRewardsLoaded callback);

		[Export ("getCredits")]
		int GetCredits ();

		[Export ("getCreditsForBucket:")]
		int GetCredits (string bucket);

		[Export ("redeemRewards")]
		void RedeemRewards (int count);

		[Export ("redeemRewards:forBucket:")]
		void RedeemRewards (int count, string bucket);

		[Export ("getCreditHistoryWithCallback:")]
		void GetCreditHistoryWithCallback (BranchListLoaded callback);

		[Export ("getCreditHistoryForBucket:andCallback:")]
		void GetCreditHistoryWithCallback (string bucket, BranchListLoaded callback);

		[Export ("userCompletedAction:")]
		void UserCompletedAction (string action);

		[Export ("userCompletedAction:withState:")]
		void UserCompletedAction (string action, NSDictionary state);

		[Export ("getTotalCountsForAction:")]
		int GetTotalCountsForAction (string action);

		[Export ("getUniqueCountsForAction:")]
		int GetUniqueCountsForAction (string action);

		[Export ("getShortURLWithCallback:")]
		void GetShortUrlWithCallback (BranchUrlCreated callback);

		[Export ("getShortURLWithParams:andCallback:")]
		void GetShortUrlWithCallback (NSDictionary parameters, BranchUrlCreated callback);

		[Export ("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andCallback:")]
		void GetShortUrlWithCallback (NSDictionary parameters, NSArray tags, string channel, string feature, string stage, BranchUrlCreated callback);

		[Export ("getShortURLWithParams:andChannel:andFeature:andStage:andCallback:")]
		void GetShortUrlWithCallback (NSDictionary parameters, string channel, string feature, string stage, BranchUrlCreated callback);

		[Export ("getShortURLWithParams:andChannel:andFeature:andCallback:")]
		void GetShortUrlWithCallback (NSDictionary parameters, string channel, string feature, BranchUrlCreated callback);
	}

	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//
}

