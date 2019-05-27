using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Ijkplayer.iOS.UI
{
	[Native]
	public enum ZFPlayerPlaybackState : ulong
	{
		Unknown,
		Playing,
		Paused,
		PlayFailed,
		PlayStopped
	}

	[Native]
	public enum ZFPlayerLoadState : ulong
	{
		Unknown = 0,
		Prepare = 1 << 0,
		Playable = 1 << 1,
		PlaythroughOK = 1 << 2,
		Stalled = 1 << 3
	}

	[Native]
	public enum ZFPlayerScalingMode : ulong
	{
		None,
		AspectFit,
		AspectFill,
		Fill
	}

	[Native]
	public enum ZFPlayerScrollDirection : ulong
	{
		None,
		Up,
		Down,
		Left,
		Right
	}

	[Native]
	public enum ZFPlayerScrollViewDirection : ulong
	{
		Vertical,
		Horizontal
	}

	[Native]
	public enum ZFPlayerContainerType : ulong
	{
		Cell,
		View
	}

	[Native]
	public enum ZFFullScreenMode : ulong
	{
		Automatic,
		Landscape,
		Portrait
	}

	[Native]
	public enum ZFRotateType : ulong
	{
		Normal,
		Cell,
		CellOther
	}

	[Native]
	public enum ZFInterfaceOrientationMask : ulong
	{
		Portrait = (1 << 0),
		LandscapeLeft = (1 << 1),
		LandscapeRight = (1 << 2),
		PortraitUpsideDown = (1 << 3),
		Landscape = (LandscapeLeft | LandscapeRight),
		All = (Portrait | LandscapeLeft | LandscapeRight | PortraitUpsideDown),
		AllButUpsideDown = (Portrait | LandscapeLeft | LandscapeRight)
	}

	[Native]
	public enum ZFPlayerGestureType : ulong
	{
		Unknown,
		SingleTap,
		DoubleTap,
		Pan,
		Pinch
	}

	[Native]
	public enum ZFPanDirection : ulong
	{
		Unknown,
		V,
		H
	}

	[Native]
	public enum ZFPanLocation : ulong
	{
		Unknown,
		Left,
		Right
	}

	[Native]
	public enum ZFPanMovingDirection : ulong
	{
		Unkown,
		Top,
		Left,
		Bottom,
		Right
	}

	[Native]
	public enum ZFPlayerDisableGestureTypes : ulong
	{
		None = 0,
		SingleTap = 1 << 0,
		DoubleTap = 1 << 1,
		Pan = 1 << 2,
		Pinch = 1 << 3,
		All = (SingleTap | DoubleTap | Pan | Pinch)
	}

	[Native]
	public enum ZFPlayerDisablePanMovingDirection : ulong
	{
		None = 0,
		Vertical = 1 << 0,
		Horizontal = 1 << 1,
		All = (Vertical | Horizontal)
	}

	[Native]
	public enum ZFReachabilityStatus : long
	{
		Unknown = -1,
		NotReachable = 0,
		ReachableViaWiFi = 1,
		ReachableVia2G = 2,
		ReachableVia3G = 3,
		ReachableVia4G = 4
	}

	static class CFunctions
	{
		// extern NSString * _Nonnull ZFStringFromNetworkReachabilityStatus (ZFReachabilityStatus status);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString ZFStringFromNetworkReachabilityStatus (ZFReachabilityStatus status);
	}

	[Native]
	public enum ZFPlayerBackgroundState : ulong
	{
		Foreground,
		Background
	}

	[Native]
	public enum ZFLoadingType : ulong
	{
		Keep,
		FadeOut
	}

	[Native]
	public enum ZFVolumeBrightnessType : ulong
	{
		Volume,
		umeBrightness
	}
}
