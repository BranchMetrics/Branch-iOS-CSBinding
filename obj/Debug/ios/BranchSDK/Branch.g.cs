//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.SceneKit;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.AddressBook;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace BranchSDK {
	[Register("Branch", true)]
	public unsafe partial class Branch : NSObject {
		[CompilerGenerated]
		const string selGetCreditHistoryForBucketAndCallback_ = "getCreditHistoryForBucket:andCallback:";
		static readonly IntPtr selGetCreditHistoryForBucketAndCallback_Handle = Selector.GetHandle ("getCreditHistoryForBucket:andCallback:");
		[CompilerGenerated]
		const string selGetCreditHistoryWithCallback_ = "getCreditHistoryWithCallback:";
		static readonly IntPtr selGetCreditHistoryWithCallback_Handle = Selector.GetHandle ("getCreditHistoryWithCallback:");
		[CompilerGenerated]
		const string selGetCredits = "getCredits";
		static readonly IntPtr selGetCreditsHandle = Selector.GetHandle ("getCredits");
		[CompilerGenerated]
		const string selGetCreditsForBucket_ = "getCreditsForBucket:";
		static readonly IntPtr selGetCreditsForBucket_Handle = Selector.GetHandle ("getCreditsForBucket:");
		[CompilerGenerated]
		const string selGetFirstReferringParams = "getFirstReferringParams";
		static readonly IntPtr selGetFirstReferringParamsHandle = Selector.GetHandle ("getFirstReferringParams");
		[CompilerGenerated]
		const string selGetLatestReferringParams = "getLatestReferringParams";
		static readonly IntPtr selGetLatestReferringParamsHandle = Selector.GetHandle ("getLatestReferringParams");
		[CompilerGenerated]
		const string selGetShortURLWithCallback_ = "getShortURLWithCallback:";
		static readonly IntPtr selGetShortURLWithCallback_Handle = Selector.GetHandle ("getShortURLWithCallback:");
		[CompilerGenerated]
		const string selGetShortURLWithParamsAndCallback_ = "getShortURLWithParams:andCallback:";
		static readonly IntPtr selGetShortURLWithParamsAndCallback_Handle = Selector.GetHandle ("getShortURLWithParams:andCallback:");
		[CompilerGenerated]
		const string selGetShortURLWithParamsAndChannelAndFeatureAndCallback_ = "getShortURLWithParams:andChannel:andFeature:andCallback:";
		static readonly IntPtr selGetShortURLWithParamsAndChannelAndFeatureAndCallback_Handle = Selector.GetHandle ("getShortURLWithParams:andChannel:andFeature:andCallback:");
		[CompilerGenerated]
		const string selGetShortURLWithParamsAndChannelAndFeatureAndStageAndCallback_ = "getShortURLWithParams:andChannel:andFeature:andStage:andCallback:";
		static readonly IntPtr selGetShortURLWithParamsAndChannelAndFeatureAndStageAndCallback_Handle = Selector.GetHandle ("getShortURLWithParams:andChannel:andFeature:andStage:andCallback:");
		[CompilerGenerated]
		const string selGetShortURLWithParamsAndTagsAndChannelAndFeatureAndStageAndCallback_ = "getShortURLWithParams:andTags:andChannel:andFeature:andStage:andCallback:";
		static readonly IntPtr selGetShortURLWithParamsAndTagsAndChannelAndFeatureAndStageAndCallback_Handle = Selector.GetHandle ("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andCallback:");
		[CompilerGenerated]
		const string selGetTotalCountsForAction_ = "getTotalCountsForAction:";
		static readonly IntPtr selGetTotalCountsForAction_Handle = Selector.GetHandle ("getTotalCountsForAction:");
		[CompilerGenerated]
		const string selGetUniqueCountsForAction_ = "getUniqueCountsForAction:";
		static readonly IntPtr selGetUniqueCountsForAction_Handle = Selector.GetHandle ("getUniqueCountsForAction:");
		[CompilerGenerated]
		const string selHandleDeepLink_ = "handleDeepLink:";
		static readonly IntPtr selHandleDeepLink_Handle = Selector.GetHandle ("handleDeepLink:");
		[CompilerGenerated]
		const string selInitSession = "initSession";
		static readonly IntPtr selInitSessionHandle = Selector.GetHandle ("initSession");
		[CompilerGenerated]
		const string selInitSession_ = "initSession:";
		static readonly IntPtr selInitSession_Handle = Selector.GetHandle ("initSession:");
		[CompilerGenerated]
		const string selInitSessionAndRegisterDeepLinkHandler_ = "initSessionAndRegisterDeepLinkHandler:";
		static readonly IntPtr selInitSessionAndRegisterDeepLinkHandler_Handle = Selector.GetHandle ("initSessionAndRegisterDeepLinkHandler:");
		[CompilerGenerated]
		const string selInitSessionWithLaunchOptions_ = "initSessionWithLaunchOptions:";
		static readonly IntPtr selInitSessionWithLaunchOptions_Handle = Selector.GetHandle ("initSessionWithLaunchOptions:");
		[CompilerGenerated]
		const string selInitSessionWithLaunchOptionsAndIsReferrable_ = "initSessionWithLaunchOptions:andIsReferrable:";
		static readonly IntPtr selInitSessionWithLaunchOptionsAndIsReferrable_Handle = Selector.GetHandle ("initSessionWithLaunchOptions:andIsReferrable:");
		[CompilerGenerated]
		const string selInitSessionWithLaunchOptionsAndIsReferrableAndRegisterDeepLinkHandler_ = "initSessionWithLaunchOptions:andIsReferrable:andRegisterDeepLinkHandler:";
		static readonly IntPtr selInitSessionWithLaunchOptionsAndIsReferrableAndRegisterDeepLinkHandler_Handle = Selector.GetHandle ("initSessionWithLaunchOptions:andIsReferrable:andRegisterDeepLinkHandler:");
		[CompilerGenerated]
		const string selInitSessionWithLaunchOptionsAndRegisterDeepLinkHandler_ = "initSessionWithLaunchOptions:andRegisterDeepLinkHandler:";
		static readonly IntPtr selInitSessionWithLaunchOptionsAndRegisterDeepLinkHandler_Handle = Selector.GetHandle ("initSessionWithLaunchOptions:andRegisterDeepLinkHandler:");
		[CompilerGenerated]
		const string selLoadActionCountsWithCallback_ = "loadActionCountsWithCallback:";
		static readonly IntPtr selLoadActionCountsWithCallback_Handle = Selector.GetHandle ("loadActionCountsWithCallback:");
		[CompilerGenerated]
		const string selLoadRewardsWithCallback_ = "loadRewardsWithCallback:";
		static readonly IntPtr selLoadRewardsWithCallback_Handle = Selector.GetHandle ("loadRewardsWithCallback:");
		[CompilerGenerated]
		const string selLogout = "logout";
		static readonly IntPtr selLogoutHandle = Selector.GetHandle ("logout");
		[CompilerGenerated]
		const string selRedeemRewards = "redeemRewards";
		static readonly IntPtr selRedeemRewardsHandle = Selector.GetHandle ("redeemRewards");
		[CompilerGenerated]
		const string selRedeemRewardsForBucket_ = "redeemRewards:forBucket:";
		static readonly IntPtr selRedeemRewardsForBucket_Handle = Selector.GetHandle ("redeemRewards:forBucket:");
		[CompilerGenerated]
		const string selResetUserSession = "resetUserSession";
		static readonly IntPtr selResetUserSessionHandle = Selector.GetHandle ("resetUserSession");
		[CompilerGenerated]
		const string selSetIdentity_ = "setIdentity:";
		static readonly IntPtr selSetIdentity_Handle = Selector.GetHandle ("setIdentity:");
		[CompilerGenerated]
		const string selSetIdentityWithCallback_ = "setIdentity:withCallback:";
		static readonly IntPtr selSetIdentityWithCallback_Handle = Selector.GetHandle ("setIdentity:withCallback:");
		[CompilerGenerated]
		const string selUserCompletedAction_ = "userCompletedAction:";
		static readonly IntPtr selUserCompletedAction_Handle = Selector.GetHandle ("userCompletedAction:");
		[CompilerGenerated]
		const string selUserCompletedActionWithState_ = "userCompletedAction:withState:";
		static readonly IntPtr selUserCompletedActionWithState_Handle = Selector.GetHandle ("userCompletedAction:withState:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Branch");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Branch () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public Branch (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Branch (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public Branch (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getCreditHistoryWithCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetCreditHistoryWithCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchListLoaded))]BranchListLoaded callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchListLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetCreditHistoryWithCallback_Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetCreditHistoryWithCallback_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getCreditHistoryForBucket:andCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetCreditHistoryWithCallback (string bucket, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchListLoaded))]BranchListLoaded callback)
		{
			if (bucket == null)
				throw new ArgumentNullException ("bucket");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsbucket = NSString.CreateNative (bucket);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchListLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selGetCreditHistoryForBucketAndCallback_Handle, nsbucket, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selGetCreditHistoryForBucketAndCallback_Handle, nsbucket, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsbucket);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getCredits")]
		[CompilerGenerated]
		public virtual int GetCredits ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.int_objc_msgSend (this.Handle, selGetCreditsHandle);
			} else {
				return ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, selGetCreditsHandle);
			}
		}
		
		[Export ("getCreditsForBucket:")]
		[CompilerGenerated]
		public virtual int GetCredits (string bucket)
		{
			if (bucket == null)
				throw new ArgumentNullException ("bucket");
			var nsbucket = NSString.CreateNative (bucket);
			
			int ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, selGetCreditsForBucket_Handle, nsbucket);
			} else {
				ret = ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetCreditsForBucket_Handle, nsbucket);
			}
			NSString.ReleaseNative (nsbucket);
			
			return ret;
		}
		
		[Export ("getFirstReferringParams")]
		[CompilerGenerated]
		public virtual NSDictionary GetFirstReferringParams ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selGetFirstReferringParamsHandle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGetFirstReferringParamsHandle));
			}
		}
		
		[Export ("getLatestReferringParams")]
		[CompilerGenerated]
		public virtual NSDictionary GetLatestReferringParams ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selGetLatestReferringParamsHandle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGetLatestReferringParamsHandle));
			}
		}
		
		[Export ("getShortURLWithCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetShortUrlWithCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchUrlCreated))]BranchUrlCreated callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchUrlCreated.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetShortURLWithCallback_Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetShortURLWithCallback_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getShortURLWithParams:andCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetShortUrlWithCallback (NSDictionary parameters, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchUrlCreated))]BranchUrlCreated callback)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchUrlCreated.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selGetShortURLWithParamsAndCallback_Handle, parameters.Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selGetShortURLWithParamsAndCallback_Handle, parameters.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetShortUrlWithCallback (NSDictionary parameters, NSArray tags, string channel, string feature, string stage, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchUrlCreated))]BranchUrlCreated callback)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (tags == null)
				throw new ArgumentNullException ("tags");
			if (channel == null)
				throw new ArgumentNullException ("channel");
			if (feature == null)
				throw new ArgumentNullException ("feature");
			if (stage == null)
				throw new ArgumentNullException ("stage");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nschannel = NSString.CreateNative (channel);
			var nsfeature = NSString.CreateNative (feature);
			var nsstage = NSString.CreateNative (stage);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchUrlCreated.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGetShortURLWithParamsAndTagsAndChannelAndFeatureAndStageAndCallback_Handle, parameters.Handle, tags.Handle, nschannel, nsfeature, nsstage, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGetShortURLWithParamsAndTagsAndChannelAndFeatureAndStageAndCallback_Handle, parameters.Handle, tags.Handle, nschannel, nsfeature, nsstage, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nschannel);
			NSString.ReleaseNative (nsfeature);
			NSString.ReleaseNative (nsstage);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getShortURLWithParams:andChannel:andFeature:andStage:andCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetShortUrlWithCallback (NSDictionary parameters, string channel, string feature, string stage, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchUrlCreated))]BranchUrlCreated callback)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (channel == null)
				throw new ArgumentNullException ("channel");
			if (feature == null)
				throw new ArgumentNullException ("feature");
			if (stage == null)
				throw new ArgumentNullException ("stage");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nschannel = NSString.CreateNative (channel);
			var nsfeature = NSString.CreateNative (feature);
			var nsstage = NSString.CreateNative (stage);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchUrlCreated.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGetShortURLWithParamsAndChannelAndFeatureAndStageAndCallback_Handle, parameters.Handle, nschannel, nsfeature, nsstage, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGetShortURLWithParamsAndChannelAndFeatureAndStageAndCallback_Handle, parameters.Handle, nschannel, nsfeature, nsstage, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nschannel);
			NSString.ReleaseNative (nsfeature);
			NSString.ReleaseNative (nsstage);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getShortURLWithParams:andChannel:andFeature:andCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetShortUrlWithCallback (NSDictionary parameters, string channel, string feature, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchUrlCreated))]BranchUrlCreated callback)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (channel == null)
				throw new ArgumentNullException ("channel");
			if (feature == null)
				throw new ArgumentNullException ("feature");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nschannel = NSString.CreateNative (channel);
			var nsfeature = NSString.CreateNative (feature);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchUrlCreated.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selGetShortURLWithParamsAndChannelAndFeatureAndCallback_Handle, parameters.Handle, nschannel, nsfeature, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGetShortURLWithParamsAndChannelAndFeatureAndCallback_Handle, parameters.Handle, nschannel, nsfeature, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nschannel);
			NSString.ReleaseNative (nsfeature);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getTotalCountsForAction:")]
		[CompilerGenerated]
		public virtual int GetTotalCountsForAction (string action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			
			int ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, selGetTotalCountsForAction_Handle, nsaction);
			} else {
				ret = ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetTotalCountsForAction_Handle, nsaction);
			}
			NSString.ReleaseNative (nsaction);
			
			return ret;
		}
		
		[Export ("getUniqueCountsForAction:")]
		[CompilerGenerated]
		public virtual int GetUniqueCountsForAction (string action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			
			int ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, selGetUniqueCountsForAction_Handle, nsaction);
			} else {
				ret = ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetUniqueCountsForAction_Handle, nsaction);
			}
			NSString.ReleaseNative (nsaction);
			
			return ret;
		}
		
		[Export ("handleDeepLink:")]
		[CompilerGenerated]
		public virtual bool HandleDeepLink (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selHandleDeepLink_Handle, url.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selHandleDeepLink_Handle, url.Handle);
			}
		}
		
		[Export ("setIdentity:")]
		[CompilerGenerated]
		public virtual void IdentifyUser (string identity)
		{
			if (identity == null)
				throw new ArgumentNullException ("identity");
			var nsidentity = NSString.CreateNative (identity);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIdentity_Handle, nsidentity);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIdentity_Handle, nsidentity);
			}
			NSString.ReleaseNative (nsidentity);
			
		}
		
		[Export ("setIdentity:withCallback:")]
		[CompilerGenerated]
		public unsafe virtual void IdentifyUser (string identity, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchDeepLinkHandler))]BranchDeepLinkHandler callback)
		{
			if (identity == null)
				throw new ArgumentNullException ("identity");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsidentity = NSString.CreateNative (identity);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchDeepLinkHandler.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetIdentityWithCallback_Handle, nsidentity, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetIdentityWithCallback_Handle, nsidentity, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsidentity);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initSession")]
		[CompilerGenerated]
		public virtual void InitSession ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selInitSessionHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selInitSessionHandle);
			}
		}
		
		[Export ("initSession:")]
		[CompilerGenerated]
		public virtual void InitSession (bool isReferralble)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selInitSession_Handle, isReferralble);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selInitSession_Handle, isReferralble);
			}
		}
		
		[Export ("initSessionAndRegisterDeepLinkHandler:")]
		[CompilerGenerated]
		public unsafe virtual void InitSessionAndRegisterDeepLinkHandler ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchDeepLinkHandler))]BranchDeepLinkHandler callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchDeepLinkHandler.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInitSessionAndRegisterDeepLinkHandler_Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitSessionAndRegisterDeepLinkHandler_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initSessionWithLaunchOptions:andRegisterDeepLinkHandler:")]
		[CompilerGenerated]
		public unsafe virtual void InitSessionAndRegisterDeepLinkHandler (NSDictionary launchOptions, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchDeepLinkHandler))]BranchDeepLinkHandler callback)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchDeepLinkHandler.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitSessionWithLaunchOptionsAndRegisterDeepLinkHandler_Handle, launchOptions.Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitSessionWithLaunchOptionsAndRegisterDeepLinkHandler_Handle, launchOptions.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initSessionWithLaunchOptions:andIsReferrable:andRegisterDeepLinkHandler:")]
		[CompilerGenerated]
		public unsafe virtual void InitSessionAndRegisterDeepLinkHandler (NSDictionary launchOptions, bool isReferrable, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchDeepLinkHandler))]BranchDeepLinkHandler callback)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchDeepLinkHandler.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, selInitSessionWithLaunchOptionsAndIsReferrableAndRegisterDeepLinkHandler_Handle, launchOptions.Handle, isReferrable, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr (this.SuperHandle, selInitSessionWithLaunchOptionsAndIsReferrableAndRegisterDeepLinkHandler_Handle, launchOptions.Handle, isReferrable, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initSessionWithLaunchOptions:andIsReferrable:")]
		[CompilerGenerated]
		public virtual void InitSessionWithLaunchOption (NSDictionary launchOptions, bool isReferrable)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selInitSessionWithLaunchOptionsAndIsReferrable_Handle, launchOptions.Handle, isReferrable);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selInitSessionWithLaunchOptionsAndIsReferrable_Handle, launchOptions.Handle, isReferrable);
			}
		}
		
		[Export ("initSessionWithLaunchOptions:")]
		[CompilerGenerated]
		public virtual void InitSessionWithLaunchOptions (NSDictionary launchOptions)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInitSessionWithLaunchOptions_Handle, launchOptions.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitSessionWithLaunchOptions_Handle, launchOptions.Handle);
			}
		}
		
		[Export ("loadActionCountsWithCallback:")]
		[CompilerGenerated]
		public unsafe virtual void LoadActionCountsWithCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchRewardsLoaded))]BranchRewardsLoaded callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchRewardsLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLoadActionCountsWithCallback_Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoadActionCountsWithCallback_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("loadRewardsWithCallback:")]
		[CompilerGenerated]
		public unsafe virtual void LoadRewardsWithCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchRewardsLoaded))]BranchRewardsLoaded callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchRewardsLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLoadRewardsWithCallback_Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoadRewardsWithCallback_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("logout")]
		[CompilerGenerated]
		public virtual void Logout ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selLogoutHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selLogoutHandle);
			}
		}
		
		[Export ("redeemRewards")]
		[CompilerGenerated]
		public virtual void RedeemRewards (int count)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selRedeemRewardsHandle, count);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selRedeemRewardsHandle, count);
			}
		}
		
		[Export ("redeemRewards:forBucket:")]
		[CompilerGenerated]
		public virtual void RedeemRewards (int count, string bucket)
		{
			if (bucket == null)
				throw new ArgumentNullException ("bucket");
			var nsbucket = NSString.CreateNative (bucket);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, selRedeemRewardsForBucket_Handle, count, nsbucket);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selRedeemRewardsForBucket_Handle, count, nsbucket);
			}
			NSString.ReleaseNative (nsbucket);
			
		}
		
		[Export ("resetUserSession")]
		[CompilerGenerated]
		public virtual void ResetUserSession ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selResetUserSessionHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selResetUserSessionHandle);
			}
		}
		
		[Export ("userCompletedAction:")]
		[CompilerGenerated]
		public virtual void UserCompletedAction (string action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			var nsaction = NSString.CreateNative (action);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUserCompletedAction_Handle, nsaction);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUserCompletedAction_Handle, nsaction);
			}
			NSString.ReleaseNative (nsaction);
			
		}
		
		[Export ("userCompletedAction:withState:")]
		[CompilerGenerated]
		public virtual void UserCompletedAction (string action, NSDictionary state)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (state == null)
				throw new ArgumentNullException ("state");
			var nsaction = NSString.CreateNative (action);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selUserCompletedActionWithState_Handle, nsaction, state.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selUserCompletedActionWithState_Handle, nsaction, state.Handle);
			}
			NSString.ReleaseNative (nsaction);
			
		}
		
	} /* class Branch */
	public delegate void BranchDeepLinkHandler (NSDictionary parameters, NSError error);
	public delegate void BranchListLoaded (NSArray history, NSError error);
	public delegate void BranchRewardsLoaded (bool changed, NSError error);
	public delegate void BranchUrlCreated (string url, NSError error);
}
