﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyProduct("MVC.Utilities.Azure (Debug)")]
[assembly: AssemblyConfiguration("Debug")]
#else
    [assembly: AssemblyProduct("MVC.Utilities.Azure (Release)")]
    [assembly: AssemblyConfiguration("Release")]
#endif


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("MVC.Utilities.Azure")]
[assembly: AssemblyDescription("Azure AppFabric Cache provider for MVC.Utilities")]
[assembly: AssemblyTrademark("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3d5b58db-60c0-4c05-a596-26a2df183b7b")]