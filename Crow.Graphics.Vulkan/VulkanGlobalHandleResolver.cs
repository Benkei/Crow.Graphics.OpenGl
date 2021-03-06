﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Crow.Graphics.Vulkan
{
	public class VulkanGlobalHandleResolver : IHandleResolver, IDisposable
	{
		[DllImport ( "kernel32.dll" )]
		static extern IntPtr GetProcAddress(IntPtr hModule, IntPtr procedureName);
		[DllImport ( "kernel32.dll" )]
		static extern IntPtr LoadLibrary(string dllToLoad);
		[DllImport ( "kernel32.dll" )]
		static extern bool FreeLibrary(IntPtr hModule);


		private IntPtr vulkanLib;

		public void Dispose()
		{
			if ( vulkanLib != IntPtr.Zero )
			{
				FreeLibrary ( vulkanLib );
				vulkanLib = IntPtr.Zero;
			}
		}

		public void LoadHandle<TDelegate>(IntPtr functionName, out TDelegate result)
			where TDelegate : class
		{
			LoadLib ();

			IntPtr proc = GetProcAddress ( vulkanLib, functionName );
			if ( proc == IntPtr.Zero )
			{
				Debug.WriteLine ( "Could not load function: {0}", functionName );
				result = null;
				return;
			}
			result = (TDelegate)(object)Marshal.GetDelegateForFunctionPointer ( proc, typeof ( TDelegate ) );
		}

		private void LoadLib()
		{
			if ( vulkanLib == IntPtr.Zero )
			{
				vulkanLib = LoadLibrary ( "vulkan-1.dll" );
				if ( vulkanLib == IntPtr.Zero )
				{
					throw new System.DllNotFoundException ( "Vulkan library not found 'vulkan-1.dll'." );
				}
			}
		}
	}
}
