﻿namespace uTinyRipper.Classes.Shaders
{
	public enum ZTest
	{
		None		= 0,
		Unknown		= 1,
		Less		= 2,
		Equal		= 3,
		LEqual		= 4,
		Greater		= 5,
		NotEqual	= 6,
		GEqual		= 7,
		Always		= 8,
	}

	public static class ZTestExtensions
	{
		public static bool IsLEqual(this ZTest _this)
		{
			return _this == ZTest.LEqual;
		}
	}
}