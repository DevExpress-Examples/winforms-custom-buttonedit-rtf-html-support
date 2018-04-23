﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
	Friend Class MyButtonEditViewInfo
		Inherits ButtonEditViewInfo
		Implements IHeightAdaptable
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub
		Public Function CalcHeight(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal width As Integer) As Integer Implements IHeightAdaptable.CalcHeight
			Dim ri As RepositoryItemMyButtonEdit = (TryCast(Item, RepositoryItemMyButtonEdit))
			Dim vi As New RichTextEditViewInfo(ri.RichEdit)
			vi.EditValue = Me.EditValue
			Return vi.CalcHeight(width) + 6
		End Function
	End Class
End Namespace
