'-----------------------------------------------------------------
' Copyright (c) Bill McCarthy.  
' This code and information are provided "as is"  without warranty
' of any kind either expressed or implied. Use at your own risk.
'-----------------------------------------------------------------

Option Strict On : Option Explicit On : Option Compare Binary : Option Infer On

Imports System
Imports System.Collections.Generic



Namespace CodeColorisers

   ''' <summary>
   ''' Default code coloriser for XML
   ''' </summary>
   ''' <remarks></remarks>
	Friend Class XmlCodeColoriser
		Implements IColorTokenProvider


      Public Function GetColorTokens(ByVal sourceCode As String, Optional ByVal offset As Integer = 0) As IList(Of ColorToken) Implements IColorTokenProvider.GetColorTokens
         ' TODO: provide coloring for XML
         ' return an empty list to make it easy for callee enumeration code 
         Return New List(Of ColorToken)
      End Function

	End Class



End Namespace



