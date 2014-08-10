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
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
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
		const string selClearUser = "clearUser";
		static readonly IntPtr selClearUserHandle = Selector.GetHandle ("clearUser");
		[CompilerGenerated]
		const string selGetCredits = "getCredits";
		static readonly IntPtr selGetCreditsHandle = Selector.GetHandle ("getCredits");
		[CompilerGenerated]
		const string selGetCreditsForBucket_ = "getCreditsForBucket:";
		static readonly IntPtr selGetCreditsForBucket_Handle = Selector.GetHandle ("getCreditsForBucket:");
		[CompilerGenerated]
		const string selGetInstallReferringParams = "getInstallReferringParams";
		static readonly IntPtr selGetInstallReferringParamsHandle = Selector.GetHandle ("getInstallReferringParams");
		[CompilerGenerated]
		const string selGetReferringParams = "getReferringParams";
		static readonly IntPtr selGetReferringParamsHandle = Selector.GetHandle ("getReferringParams");
		[CompilerGenerated]
		const string selGetShortURLWithCallback_ = "getShortURLWithCallback:";
		static readonly IntPtr selGetShortURLWithCallback_Handle = Selector.GetHandle ("getShortURLWithCallback:");
		[CompilerGenerated]
		const string selGetShortURLWithParamsAndCallback_ = "getShortURLWithParams:andCallback:";
		static readonly IntPtr selGetShortURLWithParamsAndCallback_Handle = Selector.GetHandle ("getShortURLWithParams:andCallback:");
		[CompilerGenerated]
		const string selGetShortURLWithParamsAndTagAndCallback_ = "getShortURLWithParams:andTag:andCallback:";
		static readonly IntPtr selGetShortURLWithParamsAndTagAndCallback_Handle = Selector.GetHandle ("getShortURLWithParams:andTag:andCallback:");
		[CompilerGenerated]
		const string selGetShortURLWithTagAndCallback_ = "getShortURLWithTag:andCallback:";
		static readonly IntPtr selGetShortURLWithTagAndCallback_Handle = Selector.GetHandle ("getShortURLWithTag:andCallback:");
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
		const string selHasIdentity_ = "hasIdentity:";
		static readonly IntPtr selHasIdentity_Handle = Selector.GetHandle ("hasIdentity:");
		[CompilerGenerated]
		const string selHasIdentityWithCallback_ = "hasIdentity:withCallback:";
		static readonly IntPtr selHasIdentityWithCallback_Handle = Selector.GetHandle ("hasIdentity:withCallback:");
		[CompilerGenerated]
		const string selIdentifyUser_ = "identifyUser:";
		static readonly IntPtr selIdentifyUser_Handle = Selector.GetHandle ("identifyUser:");
		[CompilerGenerated]
		const string selInitUserSession = "initUserSession";
		static readonly IntPtr selInitUserSessionHandle = Selector.GetHandle ("initUserSession");
		[CompilerGenerated]
		const string selInitUserSession_ = "initUserSession:";
		static readonly IntPtr selInitUserSession_Handle = Selector.GetHandle ("initUserSession:");
		[CompilerGenerated]
		const string selInitUserSessionWithCallback_ = "initUserSessionWithCallback:";
		static readonly IntPtr selInitUserSessionWithCallback_Handle = Selector.GetHandle ("initUserSessionWithCallback:");
		[CompilerGenerated]
		const string selInitUserSessionWithCallbackAndIsReferrable_ = "initUserSessionWithCallback:andIsReferrable:";
		static readonly IntPtr selInitUserSessionWithCallbackAndIsReferrable_Handle = Selector.GetHandle ("initUserSessionWithCallback:andIsReferrable:");
		[CompilerGenerated]
		const string selInitUserSessionWithCallbackAndIsReferrableWithLaunchOptions_ = "initUserSessionWithCallback:andIsReferrable:withLaunchOptions:";
		static readonly IntPtr selInitUserSessionWithCallbackAndIsReferrableWithLaunchOptions_Handle = Selector.GetHandle ("initUserSessionWithCallback:andIsReferrable:withLaunchOptions:");
		[CompilerGenerated]
		const string selInitUserSessionWithLaunchOptions_ = "initUserSessionWithLaunchOptions:";
		static readonly IntPtr selInitUserSessionWithLaunchOptions_Handle = Selector.GetHandle ("initUserSessionWithLaunchOptions:");
		[CompilerGenerated]
		const string selInitUserSessionWithLaunchOptionsAndIsReferrable_ = "initUserSessionWithLaunchOptions:andIsReferrable:";
		static readonly IntPtr selInitUserSessionWithLaunchOptionsAndIsReferrable_Handle = Selector.GetHandle ("initUserSessionWithLaunchOptions:andIsReferrable:");
		[CompilerGenerated]
		const string selLoadActionCountsWithCallback_ = "loadActionCountsWithCallback:";
		static readonly IntPtr selLoadActionCountsWithCallback_Handle = Selector.GetHandle ("loadActionCountsWithCallback:");
		[CompilerGenerated]
		const string selLoadRewardsWithCallback_ = "loadRewardsWithCallback:";
		static readonly IntPtr selLoadRewardsWithCallback_Handle = Selector.GetHandle ("loadRewardsWithCallback:");
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

		[Export ("clearUser")]
		[CompilerGenerated]
		public virtual void ClearUser ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selClearUserHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selClearUserHandle);
			}
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
		
		[Export ("getInstallReferringParams")]
		[CompilerGenerated]
		public virtual NSDictionary GetInstallReferringParams ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selGetInstallReferringParamsHandle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGetInstallReferringParamsHandle));
			}
		}
		
		[Export ("getReferringParams")]
		[CompilerGenerated]
		public virtual NSDictionary GetReferringParams ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selGetReferringParamsHandle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGetReferringParamsHandle));
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
		
		[Export ("getShortURLWithTag:andCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetShortUrlWithCallback (string tag, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchUrlCreated))]BranchUrlCreated callback)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nstag = NSString.CreateNative (tag);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchUrlCreated.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selGetShortURLWithTagAndCallback_Handle, nstag, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selGetShortURLWithTagAndCallback_Handle, nstag, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nstag);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getShortURLWithParams:andTag:andCallback:")]
		[CompilerGenerated]
		public unsafe virtual void GetShortUrlWithCallback (NSDictionary parameters, string tag, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchUrlCreated))]BranchUrlCreated callback)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nstag = NSString.CreateNative (tag);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchUrlCreated.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selGetShortURLWithParamsAndTagAndCallback_Handle, parameters.Handle, nstag, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selGetShortURLWithParamsAndTagAndCallback_Handle, parameters.Handle, nstag, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nstag);
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
		
		[Export ("hasIdentity:")]
		[CompilerGenerated]
		public virtual bool HasIdentity ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selHasIdentity_Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasIdentity_Handle);
			}
		}
		
		[Export ("identifyUser:")]
		[CompilerGenerated]
		public virtual void IdentifyUser (string identity)
		{
			if (identity == null)
				throw new ArgumentNullException ("identity");
			var nsidentity = NSString.CreateNative (identity);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selIdentifyUser_Handle, nsidentity);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selIdentifyUser_Handle, nsidentity);
			}
			NSString.ReleaseNative (nsidentity);
			
		}
		
		[Export ("hasIdentity:withCallback:")]
		[CompilerGenerated]
		public unsafe virtual void IdentifyUser (string identity, [BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchSessionLoaded))]BranchSessionLoaded callback)
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
			block_callback.SetupBlock (Trampolines.SDBranchSessionLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selHasIdentityWithCallback_Handle, nsidentity, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selHasIdentityWithCallback_Handle, nsidentity, (IntPtr) block_ptr_callback);
			}
			NSString.ReleaseNative (nsidentity);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initUserSession")]
		[CompilerGenerated]
		public virtual void InitUserSession ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selInitUserSessionHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selInitUserSessionHandle);
			}
		}
		
		[Export ("initUserSession:")]
		[CompilerGenerated]
		public virtual void InitUserSession (bool isReferralble)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selInitUserSession_Handle, isReferralble);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selInitUserSession_Handle, isReferralble);
			}
		}
		
		[Export ("initUserSessionWithCallback:")]
		[CompilerGenerated]
		public unsafe virtual void InitUserSessionWithCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchSessionLoaded))]BranchSessionLoaded callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchSessionLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInitUserSessionWithCallback_Handle, (IntPtr) block_ptr_callback);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitUserSessionWithCallback_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initUserSessionWithCallback:andIsReferrable:")]
		[CompilerGenerated]
		public unsafe virtual void InitUserSessionWithCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchSessionLoaded))]BranchSessionLoaded callback, bool isReferrable)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchSessionLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selInitUserSessionWithCallbackAndIsReferrable_Handle, (IntPtr) block_ptr_callback, isReferrable);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selInitUserSessionWithCallbackAndIsReferrable_Handle, (IntPtr) block_ptr_callback, isReferrable);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initUserSessionWithCallback:andIsReferrable:withLaunchOptions:")]
		[CompilerGenerated]
		public unsafe virtual void InitUserSessionWithCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDBranchSessionLoaded))]BranchSessionLoaded callback, bool isReferrable, NSDictionary launchOptions)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDBranchSessionLoaded.Handler, callback);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, selInitUserSessionWithCallbackAndIsReferrableWithLaunchOptions_Handle, (IntPtr) block_ptr_callback, isReferrable, launchOptions.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr (this.SuperHandle, selInitUserSessionWithCallbackAndIsReferrableWithLaunchOptions_Handle, (IntPtr) block_ptr_callback, isReferrable, launchOptions.Handle);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("initUserSessionWithLaunchOptions:andIsReferrable:")]
		[CompilerGenerated]
		public virtual void InitUserSessionWithLaunchOption (NSDictionary launchOptions, bool isReferrable)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selInitUserSessionWithLaunchOptionsAndIsReferrable_Handle, launchOptions.Handle, isReferrable);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selInitUserSessionWithLaunchOptionsAndIsReferrable_Handle, launchOptions.Handle, isReferrable);
			}
		}
		
		[Export ("initUserSessionWithLaunchOptions:")]
		[CompilerGenerated]
		public virtual void InitUserSessionWithLaunchOptions (NSDictionary launchOptions)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInitUserSessionWithLaunchOptions_Handle, launchOptions.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitUserSessionWithLaunchOptions_Handle, launchOptions.Handle);
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
	public delegate void BranchRewardsLoaded (bool changed);
	public delegate void BranchSessionLoaded (NSDictionary parameters);
	public delegate void BranchUrlCreated (string url);
}
