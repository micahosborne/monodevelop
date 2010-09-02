// 
// MonoDroidSdkSettings.cs
//  
// Author:
//       Michael Hutchinson <mhutchinson@novell.com>
// 
// Copyright (c) 2010 Novell, Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.Ide.Gui.Dialogs;
using MonoDevelop.Core;

namespace MonoDevelop.MonoDroid.Gui
{
	class MonoDroidSdkSettings : OptionsPanel
	{
		MonoDroidSdkSettingsWidget w;
		
		public override Gtk.Widget CreatePanelWidget ()
		{
			return w = new MonoDroidSdkSettingsWidget ();
		}
		
		public override void ApplyChanges ()
		{
			w.ApplyChanges ();
		}
	}
	
	partial class MonoDroidSdkSettingsWidget : Gtk.Bin
	{
		string[] pathDirs;
		
		public MonoDroidSdkSettingsWidget ()
		{
			this.Build ();
			
			var path = Environment.GetEnvironmentVariable ("PATH");
			pathDirs = path.Split (new char[] { System.IO.Path.PathSeparator }, StringSplitOptions.RemoveEmptyEntries);
			
			
			string configuredAndroidSdk, configuredJavaSdk;
			MonoDroidSettings.GetConfiguredSdkLocations (out configuredAndroidSdk, out configuredJavaSdk);
			
			androidFolderEntry.Path = configuredAndroidSdk ?? "";
			javaFolderEntry.Path = configuredJavaSdk ?? "";
			
			androidFolderEntry.PathChanged += delegate {
				ValidateAndroid ();
			};
			javaFolderEntry.PathChanged += delegate {
				ValidateJava ();
			};
			
			ValidateAndroid ();
			ValidateJava ();
		}
		
		void ValidateAndroid ()
		{
			FilePath location = androidFolderEntry.Path;
			
			if (!location.IsNullOrEmpty) {
				if (!MonoDroidFramework.ValidateAndroidSdkLocation (location)) {
					androidLocationMessage.Text = GettextCatalog.GetString ("No SDK found at specified location.");
					androidLocationIcon.Stock = Gtk.Stock.Cancel;
				} else {
					androidLocationMessage.Text = GettextCatalog.GetString ("SDK found at specified location.");
					androidLocationIcon.Stock = Gtk.Stock.Apply;
				}
				return;
			}
			
			location = MonoDroidFramework.FindAndroidSdk (pathDirs);
			if (location.IsNullOrEmpty) {
				androidLocationMessage.Text = GettextCatalog.GetString ("SDK not found. Please specify location.");
				androidLocationIcon.Stock = Gtk.Stock.Cancel;
			} else {
				androidLocationMessage.Text = GettextCatalog.GetString ("SDK found automatically.");
				androidLocationIcon.Stock = Gtk.Stock.Apply;
			}
		}
		
		void ValidateJava ()
		{
			FilePath location = javaFolderEntry.Path;
			
			if (!location.IsNullOrEmpty) {
				if (!MonoDroidFramework.ValidateJavaSdkLocation (location)) {
					javaLocationMessage.Text = GettextCatalog.GetString ("No SDK found at specified location.");
					javaLocationIcon.Stock = Gtk.Stock.Cancel;
				} else {
					javaLocationMessage.Text = GettextCatalog.GetString ("SDK found at specified location.");
					javaLocationIcon.Stock = Gtk.Stock.Apply;
				}
				return;
			}
			
			location = MonoDroidFramework.FindJavaSdk (pathDirs);
			if (location.IsNullOrEmpty) {
				javaLocationMessage.Text = GettextCatalog.GetString ("SDK not found. Please specify location.");
				javaLocationIcon.Stock = Gtk.Stock.Cancel;
			} else {
				javaLocationMessage.Text = GettextCatalog.GetString ("SDK found automatically.");
				javaLocationIcon.Stock = Gtk.Stock.Apply;
			}
		}
		
		public void ApplyChanges ()
		{
			MonoDroidSettings.SetConfiguredSdkLocations (
				NullIfEmpty (androidFolderEntry.Path),
				NullIfEmpty (javaFolderEntry.Path));
		}
		
		string NullIfEmpty (string s)
		{
			if (s == null || s.Length != 0)
				return s;
			return null;
		}
	}
}
