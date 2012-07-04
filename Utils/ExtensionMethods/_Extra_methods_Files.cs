// This file is part of the OWASP O2 Platform (http://www.owasp.org/index.php/OWASP_O2_Platform) and is released under the Apache 2.0 License (http://www.apache.org/licenses/LICENSE-2.0)
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using O2.Kernel;
using O2.Kernel.ExtensionMethods;
using O2.DotNetWrappers.ExtensionMethods;
using O2.DotNetWrappers.DotNet;
using O2.DotNetWrappers.Windows;
 
namespace O2.XRules.Database.Utils
{	
	public static class _Extra_ExtensionMethods_Files
	{		
		public static DirectoryInfo directoryInfo(this string directoryPath)
		{
			return new DirectoryInfo(directoryPath);
		}
		
		public static string file_Copy(this string file, string folder)
		{
			return file.file_CopyToFolder(folder);
		}
		
		public static List<string> files_Copy(this List<string> files, string targetFolder)
		{
			foreach(var file in files)
				Files.Copy(file,targetFolder);
			return files;
		}
		
		//replace pathCombine with this one
		

		
	}
	
}
    	