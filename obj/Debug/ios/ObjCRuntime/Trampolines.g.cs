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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DBranchListLoaded (IntPtr block, IntPtr history, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBranchListLoaded {
			static internal readonly DBranchListLoaded Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBranchListLoaded))]
			static unsafe void Invoke (IntPtr block, IntPtr history, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BranchSDK.BranchListLoaded) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<MonoTouch.Foundation.NSArray> (history),  Runtime.GetNSObject<MonoTouch.Foundation.NSError> (error));
			}
		} /* class SDBranchListLoaded */
		
		internal class NIDBranchListLoaded {
			IntPtr blockPtr;
			DBranchListLoaded invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDBranchListLoaded (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DBranchListLoaded> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDBranchListLoaded ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::BranchSDK.BranchListLoaded Create (IntPtr block)
			{
				return new NIDBranchListLoaded ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSArray history, NSError error)
			{
				invoker (blockPtr, history == null ? IntPtr.Zero : history.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDBranchListLoaded */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DBranchUrlCreated (IntPtr block, IntPtr url, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBranchUrlCreated {
			static internal readonly DBranchUrlCreated Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBranchUrlCreated))]
			static unsafe void Invoke (IntPtr block, IntPtr url, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BranchSDK.BranchUrlCreated) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (url),  Runtime.GetNSObject<MonoTouch.Foundation.NSError> (error));
			}
		} /* class SDBranchUrlCreated */
		
		internal class NIDBranchUrlCreated {
			IntPtr blockPtr;
			DBranchUrlCreated invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDBranchUrlCreated (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DBranchUrlCreated> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDBranchUrlCreated ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::BranchSDK.BranchUrlCreated Create (IntPtr block)
			{
				return new NIDBranchUrlCreated ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string url, NSError error)
			{
				var nsurl = NSString.CreateNative (url);
				
				invoker (blockPtr, nsurl, error == null ? IntPtr.Zero : error.Handle);
				NSString.ReleaseNative (nsurl);
				
			}
		} /* class NIDBranchUrlCreated */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DBranchDeepLinkHandler (IntPtr block, IntPtr parameters, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBranchDeepLinkHandler {
			static internal readonly DBranchDeepLinkHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBranchDeepLinkHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr parameters, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BranchSDK.BranchDeepLinkHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<MonoTouch.Foundation.NSDictionary> (parameters),  Runtime.GetNSObject<MonoTouch.Foundation.NSError> (error));
			}
		} /* class SDBranchDeepLinkHandler */
		
		internal class NIDBranchDeepLinkHandler {
			IntPtr blockPtr;
			DBranchDeepLinkHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDBranchDeepLinkHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DBranchDeepLinkHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDBranchDeepLinkHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::BranchSDK.BranchDeepLinkHandler Create (IntPtr block)
			{
				return new NIDBranchDeepLinkHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSDictionary parameters, NSError error)
			{
				invoker (blockPtr, parameters == null ? IntPtr.Zero : parameters.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDBranchDeepLinkHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DBranchRewardsLoaded (IntPtr block, bool changed, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBranchRewardsLoaded {
			static internal readonly DBranchRewardsLoaded Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBranchRewardsLoaded))]
			static unsafe void Invoke (IntPtr block, bool changed, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BranchSDK.BranchRewardsLoaded) (descriptor->Target);
				if (del != null)
					del (changed,  Runtime.GetNSObject<MonoTouch.Foundation.NSError> (error));
			}
		} /* class SDBranchRewardsLoaded */
		
		internal class NIDBranchRewardsLoaded {
			IntPtr blockPtr;
			DBranchRewardsLoaded invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDBranchRewardsLoaded (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DBranchRewardsLoaded> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDBranchRewardsLoaded ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::BranchSDK.BranchRewardsLoaded Create (IntPtr block)
			{
				return new NIDBranchRewardsLoaded ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool changed, NSError error)
			{
				invoker (blockPtr, changed, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDBranchRewardsLoaded */
	}
}
