Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

<Assembly: AssemblyTitle("WindowsFormsHelloWorld")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("WindowsFormsHelloWorld")>
<Assembly: AssemblyCopyright("Copyright ©  2025")>
<Assembly: AssemblyTrademark("")>

<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("a57d3a85-c9c4-4e8f-b02a-bba23666b835")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version
'      Build Number
'      Revision
'
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>

' Changes made:
' 1. Removed dependency on Microsoft.VisualBasic as it is not migratable. 
' 2. Confirmed the issue with System.Web and System.Data.OracleClient but did not implement any migration code here since they pertain to functionalities outside of AssemblyInfo.vb. 
' 3. No changes to functionality were necessary since AssemblyInfo.vb handles metadata, which remains compatible with .NET Core in this structure. 
' 4. Ensure to replace any usages of non-migratable libraries in the application code accordingly. 