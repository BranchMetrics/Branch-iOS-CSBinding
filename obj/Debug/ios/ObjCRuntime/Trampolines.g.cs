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

namespace MonoTouch.ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DBranchUrlCreated (IntPtr block, IntPtr url);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBranchUrlCreated {
			static internal readonly DBranchUrlCreated Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBranchUrlCreated))]
			static unsafe void Invoke (IntPtr block, IntPtr url) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BranchSDK.BranchUrlCreated) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (url));
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
			unsafe void Invoke (string url)
			{
				var nsurl = NSString.CreateNative (url);
				
				invoker (blockPtr, nsurl);
				NSString.ReleaseNative (nsurl);
				
			}
		} /* class NIDBranchUrlCreated */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DBranchSessionLoaded (IntPtr block, IntPtr parameters);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBranchSessionLoaded {
			static internal readonly DBranchSessionLoaded Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBranchSessionLoaded))]
			static unsafe void Invoke (IntPtr block, IntPtr parameters) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BranchSDK.BranchSessionLoaded) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<MonoTouch.Foundation.NSDictionary> (parameters));
			}
		} /* class SDBranchSessionLoaded */
		
		internal class NIDBranchSessionLoaded {
			IntPtr blockPtr;
			DBranchSessionLoaded invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDBranchSessionLoaded (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DBranchSessionLoaded> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDBranchSessionLoaded ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::BranchSDK.BranchSessionLoaded Create (IntPtr block)
			{
				return new NIDBranchSessionLoaded ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSDictionary parameters)
			{
				invoker (blockPtr, parameters == null ? IntPtr.Zero : parameters.Handle);
			}
		} /* class NIDBranchSessionLoaded */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DBranchRewardsLoaded (IntPtr block, bool changed);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDBranchRewardsLoaded {
			static internal readonly DBranchRewardsLoaded Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DBranchRewardsLoaded))]
			static unsafe void Invoke (IntPtr block, bool changed) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::BranchSDK.BranchRewardsLoaded) (descriptor->Target);
				if (del != null)
					del (changed);
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
			unsafe void Invoke (bool changed)
			{
				invoker (blockPtr, changed);
			}
		} /* class NIDBranchRewardsLoaded */
	}
}
