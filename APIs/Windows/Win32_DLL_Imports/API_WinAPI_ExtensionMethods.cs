﻿using System;
using System.Linq;
using System.Drawing;  
using System.Windows.Forms;
using System.Drawing.Imaging; 
using System.Diagnostics;
using System.Collections.Generic;
using FluentSharp.CoreLib;
using FluentSharp.WinForms;

//O2File:API_WinAPI.cs

namespace O2.XRules.Database.APIs
{
	public static class WinAPI_ExtensionMethods_IntPtr
	{
		public static IntPtr intPtr(this int value)
		{
			return new IntPtr(value);
		}				
	}
	
	public static class WinAPI_ExtensionMethods_Text
	{
		public static string get_ControlText(this IntPtr handle)
		{
			return WinAPI.GetControlText(handle);
		}
		public static string get_WindowText(this IntPtr handle)
		{
			return WinAPI.GetWindowText(handle);
		}
		public static IntPtr set_ControlText(this IntPtr handle, string text)
		{
			WinAPI.SetControlText(handle, text);
			return handle;
		}
		
		public static IntPtr set_WindowText(this IntPtr handle, string text)
		{
			WinAPI.SetWindowText(handle, text);
			return handle;
		}
	}
	public static class WinAPI_ExtensionMethods_Misc
	{
		public static IntPtr parent(this IntPtr handle)
		{
			return WinAPI.GetParent(handle);
		}
		
		public static IntPtr setParent(this IntPtr handle, Control control)
		{
			return handle.setParent(control.Handle);
		}
		public static IntPtr setParent(this IntPtr handle, IntPtr newParent)
		{
			WinAPI.SetParent(handle, newParent);
			return handle;
		}
		
		public static bool hasChilds(this IntPtr handle)
		{
			return handle.child_Windows().size() > 0;
		}
		public static List<IntPtr> child_Windows(this IntPtr handle)
		{
			return WinAPI.GetChildWindows(handle);
		}
		
		public static List<IntPtr> child_Windows_with_CurrentParent(this IntPtr handle)
		{
			return (from childWindow in handle.child_Windows()
					where childWindow.parent() == handle
					select childWindow).toList();
		}
		
		public static string className(this IntPtr handle)
		{
			return WinAPI.GetClassName(handle);
		}
		
		public static List<string> classNames(this List<IntPtr> handles)
		{
			return (from handle in handles 
					select handle.className()).distinct();
		}
		
		public static Dictionary<string, List<IntPtr>> classNames_Indexed(this List<IntPtr> handles)
		{		
			var indexedClassNames = new Dictionary<string, List<IntPtr>>();			
			foreach (var handle in handles)
				indexedClassNames.add(handle.className(), handle);
			return indexedClassNames;
		}
		public static IntPtr get_Parent(this IntPtr handle)
		{
			return WinAPI.GetParent(handle);
		}
	}
	public static class WinAPI_ExtensionMethods_Window
	{
	
		public static int window_ThreadId(this IntPtr windowHandle)
		{
			IntPtr processId;
			return WinAPI.GetWindowThreadProcessId(windowHandle, out processId).ToInt32();
		}
		
		public static IntPtr window_Move(this IntPtr windowHandle, int x, int y, int width, int height)
		{
			WinAPI.MoveWindow(windowHandle,x,y,width, height,true);
			return windowHandle; 
		}
		public static IntPtr window_Maximized(this IntPtr windowHandle)
		{
			WinAPI.ShowWindow(windowHandle,WinAPI.ShowWindowCommands.ShowMaximized);
			return windowHandle; 
		}
		public static IntPtr window_Minimized(this IntPtr windowHandle)
		{
			WinAPI.ShowWindow(windowHandle,WinAPI.ShowWindowCommands.ShowMinimized);
			return windowHandle; 
		}
		public static IntPtr window_Default(this IntPtr windowHandle)
		{
			WinAPI.ShowWindow(windowHandle,WinAPI.ShowWindowCommands.ShowDefault);
			return windowHandle; 
		}
		
		
		public static IntPtr window_Show(this IntPtr windowHandle)
		{
			WinAPI.ShowWindow(windowHandle,WinAPI.ShowWindowCommands.Show);
			return windowHandle; 
		}
		public static 	IntPtr window_Hide(this IntPtr windowHandle)
		{
			WinAPI.ShowWindow(windowHandle,WinAPI.ShowWindowCommands.Hide);
			return windowHandle; 
		}
		
		public static IntPtr window_AlwaysOnTop(this IntPtr windowHandle)
		{
			WinAPI.SetWindowPos(windowHandle, WinAPI.HWND_TOPMOST, 0, 0, 0, 0, WinAPI.SetWindowPosFlags.IgnoreMoveAndResize);
			return windowHandle;
		}
		public static IntPtr window_BringToTop(this IntPtr windowHandle)
		{
			WinAPI.SetWindowPos(windowHandle, WinAPI.HWND_TOP, 0, 0, 0, 0, WinAPI.SetWindowPosFlags.IgnoreMoveAndResize);
			return windowHandle;
		}
		
		public static IntPtr window_MoveTo(this IntPtr windowHandle, int top, int left)
		{
			WinAPI.SetWindowPos(windowHandle, WinAPI.HWND_TOP, top, left, 0, 0, WinAPI.SetWindowPosFlags.IgnoreResize);
			return windowHandle;
		}
		
		
		public static IntPtr window_Redraw(this IntPtr windowHandle)
		{
			var hWnd = windowHandle;
			IntPtr parent = windowHandle.get_Parent();
			if (parent != IntPtr.Zero)
			{
				hWnd = parent;
			}
			WinAPI.InvalidateRect(hWnd, IntPtr.Zero, true);
			WinAPI.UpdateWindow(hWnd);
			WinAPI.RedrawWindow(hWnd, IntPtr.Zero, IntPtr.Zero, 1921u);
			
			return windowHandle;
		}		
		
		public static IntPtr window_Highlight(this IntPtr windowHandle)
		{
			
			WinAPI.RECT rECT = new WinAPI.RECT(0, 0, 0, 0);
			WinAPI.GetWindowRect(windowHandle, ref rECT);
			WinAPI.GetParent(windowHandle);
			IntPtr windowDC = WinAPI.GetWindowDC(windowHandle);
			if (windowDC != IntPtr.Zero)
			{
				Graphics graphics = Graphics.FromHdc(windowDC, windowHandle);
				var drawPen = new Pen(Brushes.Red, 2f);
				graphics.DrawRectangle(drawPen, 1, 1, rECT.Width - 2, rECT.Height - 2);
				graphics.Dispose();
				WinAPI.ReleaseDC(windowHandle, windowDC);
			}
			
			return windowHandle;
		}
		
		public static WinAPI.RECT window_Rectangle(this IntPtr windowHandle)
		{
			WinAPI.RECT rect = new WinAPI.RECT(0, 0, 0, 0);
			WinAPI.GetWindowRect(windowHandle, ref rect);
			return rect;
		}
		
		//public static Bitmap PrintWindow(IntPtr hwnd)    
		public static Bitmap window_ScreenShot(this IntPtr windowHandle)
		{					
		    WinAPI.RECT rc = default(WinAPI.RECT);         
		    WinAPI.GetWindowRect(windowHandle, ref rc);
		
		    Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format32bppArgb);        
		    Graphics gfxBmp = Graphics.FromImage(bmp);        
		    IntPtr hdcBitmap = gfxBmp.GetHdc();        
		
		    WinAPI.PrintWindow(windowHandle, hdcBitmap, 0);  
		
		    gfxBmp.ReleaseHdc(hdcBitmap);               
		    gfxBmp.Dispose(); 
		
		    return bmp;   		
		}
		public static Point pointToScreen(this Control control)
		{
			return control.invokeOnThread(()=> control.PointToScreen(System.Drawing.Point.Empty));
		}
		
		
	}
	public static class WinAPI_ExtensionMethods_Process_TO_MOVE_TO_CORELIB
	{
		public static IntPtr handle(this Process process)
		{			
			if (process.notNull())
				return process.MainWindowHandle;
			return IntPtr.Zero;
		}
	}
	public static class WinAPI_ExtensionMethods_Process
	{				
		public static Process window_AlwaysOnTop(this Process process)
		{
			process.handle().window_AlwaysOnTop();			
			return process;
		}
		
		public static Process set_Title(this Process process, string text)
		{			
			process.handle().set_WindowText(text);			
			return process;
		}
		
		public static List<IntPtr> child_Windows(this Process process)
		{
			return process.handle().child_Windows();
		}
		
		
		public static Process resizeProcessToControlSize(this Process process, Control controlToSync)
        {        	
            if (controlToSync.notNull() && process.notNull())
            {             	
            	var mainWindowHandle = process.MainWindowHandle;                            	
            	process.MainWindowHandle.resizeWindowToControlSize(controlToSync);
	        }
	        return process;
	    }	    
       	public static IntPtr resizeWindowToControlSize(this IntPtr handle, Control controlToSync)
       	{            
        	var point = controlToSync.pointToScreen();                    
            var x = point.X;
			var y = point.Y;
			return handle.resizeWindowToControlSize(controlToSync, x, y);			
		}
		public static IntPtr resizeWindowToControlSize(this IntPtr handle, Control controlToSync, int x, int y)
		{
			if (handle != IntPtr.Zero)
            {
                var width = controlToSync.width();
                var height = controlToSync.height();                    
                handle.window_Move(x, y, width,height);
                "Setting window with handle {0} to {0}x{1} : {2}x{3}".info(handle, x, y, width, height);
            }
            return handle;                                
		}
	}
}