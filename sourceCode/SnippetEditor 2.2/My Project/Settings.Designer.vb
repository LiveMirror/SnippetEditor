﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.261
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4")>  _
        Public Property TabSize() As Integer
            Get
                Return CType(Me("TabSize"),Integer)
            End Get
            Set
                Me("TabSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Courier New, 12pt")>  _
        Public Property EditorFont() As Global.System.Drawing.Font
            Get
                Return CType(Me("EditorFont"),Global.System.Drawing.Font)
            End Get
            Set
                Me("EditorFont") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ImageAndText")>  _
        Public Property Toolbar_DisplayStyle() As Global.System.Windows.Forms.ToolStripItemDisplayStyle
            Get
                Return CType(Me("Toolbar_DisplayStyle"),Global.System.Windows.Forms.ToolStripItemDisplayStyle)
            End Get
            Set
                Me("Toolbar_DisplayStyle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Visual Studio 2008")>  _
        Public Property SelectedProduct() As String
            Get
                Return CType(Me("SelectedProduct"),String)
            End Get
            Set
                Me("SelectedProduct") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Title")>  _
        Public Property NodeDisplayStyle() As Global.SnippetEditor.SnippetExplorer.NodeDisplayStyle
            Get
                Return CType(Me("NodeDisplayStyle"),Global.SnippetEditor.SnippetExplorer.NodeDisplayStyle)
            End Get
            Set
                Me("NodeDisplayStyle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("970")>  _
        Public Property Form_Width() As Integer
            Get
                Return CType(Me("Form_Width"),Integer)
            End Get
            Set
                Me("Form_Width") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("845")>  _
        Public Property Form_Height() As Integer
            Get
                Return CType(Me("Form_Height"),Integer)
            End Get
            Set
                Me("Form_Height") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PropertiesPanel_Collapsed() As Boolean
            Get
                Return CType(Me("PropertiesPanel_Collapsed"),Boolean)
            End Get
            Set
                Me("PropertiesPanel_Collapsed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ReferencesPanel_Collapsed() As Boolean
            Get
                Return CType(Me("ReferencesPanel_Collapsed"),Boolean)
            End Get
            Set
                Me("ReferencesPanel_Collapsed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ImportsPanel_Collapsed() As Boolean
            Get
                Return CType(Me("ImportsPanel_Collapsed"),Boolean)
            End Get
            Set
                Me("ImportsPanel_Collapsed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CodePanel_Collapsed() As Boolean
            Get
                Return CType(Me("CodePanel_Collapsed"),Boolean)
            End Get
            Set
                Me("CodePanel_Collapsed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("381")>  _
        Public Property CodeWindowHeight() As Integer
            Get
                Return CType(Me("CodeWindowHeight"),Integer)
            End Get
            Set
                Me("CodeWindowHeight") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("353")>  _
        Public Property SplitterPosition() As Integer
            Get
                Return CType(Me("SplitterPosition"),Integer)
            End Get
            Set
                Me("SplitterPosition") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("   <ArrayOfProduct xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"       "& _ 
            "xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Name>V"& _ 
            "isual Studio 2005</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE\Microsoft\VisualStudio"& _ 
            "\8.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Name>Visual Ba"& _ 
            "sic 2005 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE\Microsoft\VBExp"& _ 
            "ress\8.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Name>Visua"& _ 
            "l C# 2005 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE\Microsoft\VCSE"& _ 
            "xpress\8.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Name>Vis"& _ 
            "ual Web Developer 2005 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE\M"& _ 
            "icrosoft\VWDExpress\8.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"     "& _ 
            "    <Name>Visual Studio 2008</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE\Microsoft\V"& _ 
            "isualStudio\9.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Nam"& _ 
            "e>Visual Basic 2008 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE\Micr"& _ 
            "osoft\VBExpress\9.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         "& _ 
            "<Name>Visual C# 2008 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE\Mic"& _ 
            "rosoft\VCSExpress\9.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"       "& _ 
            "  <Name>Visual Web Developer 2008 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath"& _ 
            ">SOFTWARE\Microsoft\VWDExpress\9.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product >"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Pro"& _ 
            "duct>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Name>Visual Studio 2010</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>SOFTWARE"& _ 
            "\Microsoft\VisualStudio\10.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)& _ 
            "         <Name>Visual Basic 2010 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPath>"& _ 
            "SOFTWARE\Microsoft\VBExpress\10.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Produ"& _ 
            "ct>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Name>Visual C# 2010 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <RegistryPat"& _ 
            "h>SOFTWARE\Microsoft\VCSExpress\10.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Product>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      <Pr"& _ 
            "oduct>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"         <Name>Visual Web Developer 2010 Express Edition</Name>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"       "& _ 
            "  <RegistryPath>SOFTWARE\Microsoft\VWDExpress\10.0</RegistryPath>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      </Produ"& _ 
            "ct >"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"   </ArrayOfProduct>")>  _
        Public Property Products() As Global.SnippetEditor.Utility.ProductCollection
            Get
                Return CType(Me("Products"),Global.SnippetEditor.Utility.ProductCollection)
            End Get
            Set
                Me("Products") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SnippetEditor.My.MySettings
            Get
                Return Global.SnippetEditor.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
