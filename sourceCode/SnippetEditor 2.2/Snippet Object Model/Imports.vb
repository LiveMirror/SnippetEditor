﻿'-----------------------------------------------------------------
' Copyright (c) Bill McCarthy.  
' This code and information are provided "as is"  without warranty
' of any kind either expressed or implied. Use at your own risk.
'-----------------------------------------------------------------

Option Strict On : Option Explicit On : Option Compare Binary : Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Xml
Imports System.Xml.Linq
Imports <xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">


Namespace SnippetRepresentation
   ''' <summary>
   ''' represents the CodeSnippet\Snippet\Imports element
   ''' </summary>
   ''' <remarks></remarks>
   Public Class [Imports]

      Private _Imports As List(Of Import)


      Public Sub New()
         Me.New(Nothing)
      End Sub

      Public Sub New(ByVal el As XElement)
         If el Is Nothing Then
            _Imports = New List(Of Import)
         Else
            _Imports = (From item In el.<Import> Select New Import(item)).ToList
         End If
      End Sub



      Public ReadOnly Property List() As List(Of Import)
         Get
            Return _Imports
         End Get
      End Property


#Region "equality methods"


      Public Overrides Function Equals(ByVal obj As Object) As Boolean

         Dim imprt As [Imports] = TryCast(obj, [Imports])
         If imprt Is Nothing Then Return False

         If (Me.List.Count <> imprt.List.Count) Then Return False
         For i As Int32 = 0 To Me.List.Count - 1
            If (Not Me.List.Item(i).Equals(imprt.List.Item(i))) Then
               Return False
            End If
         Next
         Return True

      End Function


      Public Overrides Function GetHashCode() As Integer
         Return MyBase.GetHashCode()
      End Function

#End Region

   End Class

End Namespace

