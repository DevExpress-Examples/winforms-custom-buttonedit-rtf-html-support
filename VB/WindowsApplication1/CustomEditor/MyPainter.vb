Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyPainter
		Inherits ButtonEditPainter

		Public Sub New()

		End Sub

		Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
			MyBase.DrawContent(info)
		End Sub

		Protected Overrides Sub DrawText(ByVal info As ControlGraphicsInfoArgs)
			RichTextEditPainter.DrawRTF(GetViewInfo(info), info.Cache)
		End Sub
		Private Function GetViewInfo(ByVal info As ControlGraphicsInfoArgs) As RichTextEditViewInfo
			Dim ri As RepositoryItemMyButtonEdit = TryCast((TryCast(info.ViewInfo, ButtonEditViewInfo)).Item, RepositoryItemMyButtonEdit)
			Dim vi As New RichTextEditViewInfo(ri.RichEdit)
			vi.Bounds = info.ViewInfo.ContentRect
			vi.EditValue = info.ViewInfo.DisplayText
			vi.CalcViewInfo(info.Graphics)
			Return vi

		End Function
	End Class

End Namespace
