// This file is part of the OWASP O2 Platform (http://www.owasp.org/index.php/OWASP_O2_Platform) and is released under the Apache 2.0 License (http://www.apache.org/licenses/LICENSE-2.0)
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using O2.Kernel;
using O2.Kernel.ExtensionMethods; 
using O2.DotNetWrappers.ExtensionMethods;
using O2.XRules.Database.Utils.O2;
using O2.XRules.Database.APIs; 

namespace O2.XRules.Database.APIs
{
	public class CWE_Data
    {
    	public List<CWE_Weakness> Weaknesses { get; set; }
    	
    	public CWE_Data()
    	{
    	 	Weaknesses = new List<CWE_Weakness>();
    	}
    }
    
    public class CWE_Weakness
    {
    	public string Title { get; set;}
    	public string Content { get; set;}
    	public string Technology { get; set;}
    	public string Phase { get; set;}
    	public string Type { get; set;}
    	public string Category { get; set;}
    }
}
    	