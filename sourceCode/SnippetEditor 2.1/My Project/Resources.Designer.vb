﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SnippetEditor.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;html&gt;
        '''&lt;head&gt;
        '''&lt;title&gt;About&lt;/title&gt;
        '''&lt;style type=&quot;text/css&quot;&gt;p{font-family: Verdana;font-size: 9pt;text-align: justify;}&lt;/style&gt;
        '''&lt;/head&gt;
        '''&lt;body&gt;
        '''
        '''&lt;p&gt;
        '''The VB Snippet Editor started its journey into the world back in the early days
        '''of Visual Studio 2005 betas. An unidentified &amp;quot;intern&amp;quot; working at Microsoft wrote
        '''the initial code to edit a snippet. Microsoft decided not to put any more effort
        '''into developing the editor, instead placing it as an unfinished open source
        '''project on GotDotNet. &lt;/p&gt; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property About_HTML() As String
            Get
                Return ResourceManager.GetString("About_HTML", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property ani_bottle() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ani_bottle", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;{0}&apos; attribute is expected for node:.
        '''</summary>
        Friend ReadOnly Property Attribute_Expected() As String
            Get
                Return ResourceManager.GetString("Attribute_Expected", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to find a snippet in file.
        '''</summary>
        Friend ReadOnly Property Cannot_Find_CodeSnippet() As String
            Get
                Return ResourceManager.GetString("Cannot_Find_CodeSnippet", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to find the snippets collection in file.
        '''</summary>
        Friend ReadOnly Property Cannot_Find_CodeSnippets() As String
            Get
                Return ResourceManager.GetString("Cannot_Find_CodeSnippets", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error#.
        '''</summary>
        Friend ReadOnly Property Compile_Error() As String
            Get
                Return ResourceManager.GetString("Compile_Error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compilation found {0} error(s).
        '''</summary>
        Friend ReadOnly Property Compile_Errors() As String
            Get
                Return ResourceManager.GetString("Compile_Errors", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  at line.
        '''</summary>
        Friend ReadOnly Property Compile_Line() As String
            Get
                Return ResourceManager.GetString("Compile_Line", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Compiled code:.
        '''</summary>
        Friend ReadOnly Property Compiled_Code() As String
            Get
                Return ResourceManager.GetString("Compiled_Code", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;{0}&apos; element is expected for node:.
        '''</summary>
        Friend ReadOnly Property Element_Expected() As String
            Get
                Return ResourceManager.GetString("Element_Expected", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error while loading the code snippet....
        '''</summary>
        Friend ReadOnly Property Error_Loading_Code_Snippet() As String
            Get
                Return ResourceManager.GetString("Error_Loading_Code_Snippet", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error loading XML file....
        '''</summary>
        Friend ReadOnly Property Error_Loading_Xml_File() As String
            Get
                Return ResourceManager.GetString("Error_Loading_Xml_File", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The following file could not be read :.
        '''</summary>
        Friend ReadOnly Property Error_Opening_File() As String
            Get
                Return ResourceManager.GetString("Error_Opening_File", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to open file....
        '''</summary>
        Friend ReadOnly Property Error_Opening_File_Tile() As String
            Get
                Return ResourceManager.GetString("Error_Opening_File_Tile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error saving to file....
        '''</summary>
        Friend ReadOnly Property Error_Saving_To_File() As String
            Get
                Return ResourceManager.GetString("Error_Saving_To_File", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Make sure the file is not read-only and that you have the appropriate permissions to access it..
        '''</summary>
        Friend ReadOnly Property Error_Saving_To_File_Message() As String
            Get
                Return ResourceManager.GetString("Error_Saving_To_File_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Visual Studio Community Content Installer File (*.vsi)|*.vsi.
        '''</summary>
        Friend ReadOnly Property Export_SaveTypeFilter() As String
            Get
                Return ResourceManager.GetString("Export_SaveTypeFilter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to export operation cancelled.
        '''</summary>
        Friend ReadOnly Property Export_Snippet_Cancelled() As String
            Get
                Return ResourceManager.GetString("Export_Snippet_Cancelled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  unable to export snippet to VSI.
        '''</summary>
        Friend ReadOnly Property Export_Snippet_Error() As String
            Get
                Return ResourceManager.GetString("Export_Snippet_Error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Snippet successfully exported to .VSI .
        '''</summary>
        Friend ReadOnly Property Export_Snippet_Success() As String
            Get
                Return ResourceManager.GetString("Export_Snippet_Success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Export snippet to VSI.
        '''</summary>
        Friend ReadOnly Property Export_Title() As String
            Get
                Return ResourceManager.GetString("Export_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select Folder to open....
        '''</summary>
        Friend ReadOnly Property Folder_Browser_Description() As String
            Get
                Return ResourceManager.GetString("Folder_Browser_Description", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to please see the documentation on gotdotnet.
        '''</summary>
        Friend ReadOnly Property Help_Text() As String
            Get
                Return ResourceManager.GetString("Help_Text", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property img_book_open() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_book_open", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Close() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Close", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Close_trans() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Close_trans", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Collapse_large() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Collapse_large", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Delete() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Delete", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Expand_large() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Expand_large", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Folder_closed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Folder_closed", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Folder_closed_hidden() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Folder_closed_hidden", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Folder_closed_virtual() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Folder_closed_virtual", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Folder_open() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Folder_open", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Folder_open_hidden() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Folder_open_hidden", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Folder_open_virtual() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Folder_open_virtual", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Folders() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Folders", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Help() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Help", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Idea() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Idea", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_NewDocument() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_NewDocument", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_newFolder() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_newFolder", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Options() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Options", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_RefreshDocView() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_RefreshDocView", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Save() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Save", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Snippet() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Snippet", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_SychronizeList() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_SychronizeList", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_ToVSI() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_ToVSI", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property img_Zoom() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("img_Zoom", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Press OK to continue loading or press Cancel to abort..
        '''</summary>
        Friend ReadOnly Property Item_Missing_Choice_Explanation() As String
            Get
                Return ResourceManager.GetString("Item_Missing_Choice_Explanation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Language not supported..
        '''</summary>
        Friend ReadOnly Property Language_Not_Supported() As String
            Get
                Return ResourceManager.GetString("Language_Not_Supported", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property message_in_a_bottle() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("message_in_a_bottle", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete.
        '''</summary>
        Friend ReadOnly Property Mnu_Delete() As String
            Get
                Return ResourceManager.GetString("Mnu_Delete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove.
        '''</summary>
        Friend ReadOnly Property Mnu_Remove() As String
            Get
                Return ResourceManager.GetString("Mnu_Remove", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select a folder to add to your snippet collection.
        '''</summary>
        Friend ReadOnly Property Msg_Add_Existing_Folder_Prompt() As String
            Get
                Return ResourceManager.GetString("Msg_Add_Existing_Folder_Prompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to MyFolder.
        '''</summary>
        Friend ReadOnly Property Msg_Add_New_Folder_Default() As String
            Get
                Return ResourceManager.GetString("Msg_Add_New_Folder_Default", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add New Folder.
        '''</summary>
        Friend ReadOnly Property Msg_Add_New_Folder_Prompt() As String
            Get
                Return ResourceManager.GetString("Msg_Add_New_Folder_Prompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enter a name for the new folder.
        '''</summary>
        Friend ReadOnly Property Msg_Add_New_Folder_Title() As String
            Get
                Return ResourceManager.GetString("Msg_Add_New_Folder_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NewSnippet.
        '''</summary>
        Friend ReadOnly Property Msg_Add_New_Snippet_Default() As String
            Get
                Return ResourceManager.GetString("Msg_Add_New_Snippet_Default", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enter a name for the new snippet.
        '''</summary>
        Friend ReadOnly Property Msg_Add_New_Snippet_Prompt() As String
            Get
                Return ResourceManager.GetString("Msg_Add_New_Snippet_Prompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add New Snippet.
        '''</summary>
        Friend ReadOnly Property Msg_Add_New_Snippet_Title() As String
            Get
                Return ResourceManager.GetString("Msg_Add_New_Snippet_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Warning: This will permanetly remove the snippet from your file system. Are you sure you want to delete this snippet ?.
        '''</summary>
        Friend ReadOnly Property Msg_Delete_File_Prompt() As String
            Get
                Return ResourceManager.GetString("Msg_Delete_File_Prompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete Snippet.
        '''</summary>
        Friend ReadOnly Property Msg_Delete_File_Title() As String
            Get
                Return ResourceManager.GetString("Msg_Delete_File_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to delete the folder : .
        '''</summary>
        Friend ReadOnly Property Msg_Delete_Folder_Prompt() As String
            Get
                Return ResourceManager.GetString("Msg_Delete_Folder_Prompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Delete Folder.
        '''</summary>
        Friend ReadOnly Property Msg_Delete_Folder_Title() As String
            Get
                Return ResourceManager.GetString("Msg_Delete_Folder_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Are you sure you want to remove from the snippet collection the folder : .
        '''</summary>
        Friend ReadOnly Property Msg_Remove_Folder_Prompt() As String
            Get
                Return ResourceManager.GetString("Msg_Remove_Folder_Prompt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Remove Folder.
        '''</summary>
        Friend ReadOnly Property Msg_Remove_Folder_Title() As String
            Get
                Return ResourceManager.GetString("Msg_Remove_Folder_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to \Visual Studio\8.0\Code Snippets\VB\My Code Snippets\.
        '''</summary>
        Friend ReadOnly Property MyDocs_Snippets_Path() As String
            Get
                Return ResourceManager.GetString("MyDocs_Snippets_Path", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NewLiteral.
        '''</summary>
        Friend ReadOnly Property NewLiteral() As String
            Get
                Return ResourceManager.GetString("NewLiteral", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NewObject.
        '''</summary>
        Friend ReadOnly Property NewObject() As String
            Get
                Return ResourceManager.GetString("NewObject", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open Snippet....
        '''</summary>
        Friend ReadOnly Property Open_Snippet() As String
            Get
                Return ResourceManager.GetString("Open_Snippet", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Visual Studio Snippets (*.snippet)|*.snippet|All files (*.*)|*.*.
        '''</summary>
        Friend ReadOnly Property OpenSaveTypeFilter() As String
            Get
                Return ResourceManager.GetString("OpenSaveTypeFilter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save Snippet As....
        '''</summary>
        Friend ReadOnly Property Save_Snippet_As() As String
            Get
                Return ResourceManager.GetString("Save_Snippet_As", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to save operation cancelled.
        '''</summary>
        Friend ReadOnly Property Save_Snippet_Cancelled() As String
            Get
                Return ResourceManager.GetString("Save_Snippet_Cancelled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  unable to save snippet .
        '''</summary>
        Friend ReadOnly Property Save_Snippet_Error() As String
            Get
                Return ResourceManager.GetString("Save_Snippet_Error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  snippet successfully saved .
        '''</summary>
        Friend ReadOnly Property Save_Snippet_Success() As String
            Get
                Return ResourceManager.GetString("Save_Snippet_Success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The opened snippet is about to be closed..
        '''</summary>
        Friend ReadOnly Property Snippet_Closing1() As String
            Get
                Return ResourceManager.GetString("Snippet_Closing1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Do you want to save the changes?.
        '''</summary>
        Friend ReadOnly Property Snippet_Closing2() As String
            Get
                Return ResourceManager.GetString("Snippet_Closing2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Snippet Editor.
        '''</summary>
        Friend ReadOnly Property Snippet_Editor() As String
            Get
                Return ResourceManager.GetString("Snippet_Editor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to snippet.
        '''</summary>
        Friend ReadOnly Property Snippet_Extension() As String
            Get
                Return ResourceManager.GetString("Snippet_Extension", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property splash() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("splash", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Untitled.
        '''</summary>
        Friend ReadOnly Property Untitled() As String
            Get
                Return ResourceManager.GetString("Untitled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;html&gt;
        '''&lt;head&gt;
        '''&lt;title&gt;VB Snippet Editor Tips&lt;/title&gt;
        '''&lt;style type=&quot;text/css&quot;&gt;blockquote{font-family: Verdana;text-align: justify;}&lt;/style&gt;
        '''&lt;/head&gt;
        '''
        '''&lt;body&gt;
        '''
        '''
        '''
        '''&lt;h3&gt;Quick Start Tips:&lt;/h3&gt;
        '''&lt;blockquote&gt;
        '''&lt;ul&gt;
        '''&lt;li&gt;Double click on a snippet in the treeview to &lt;b&gt;
        '''edit&lt;/b&gt; it&lt;br&gt;
        '''&amp;nbsp;&lt;/li&gt;
        '''&lt;li&gt;To create a &lt;b&gt;new&lt;/b&gt; snippet, select the
        '''folder you want to add it to, then right click on that folder and select &lt;i&gt;Add
        '''New Snippet&lt;/i&gt; from the context menu&lt;br&gt;
        '''&amp;nbsp;&lt;/li&gt;
        '''&lt;li&gt;Use the filter to help &lt;b [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Welcome_HTML() As String
            Get
                Return ResourceManager.GetString("Welcome_HTML", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
