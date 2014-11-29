using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libBranch-SDK.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator64 | LinkTarget.Simulator, ForceLoad = true)]
