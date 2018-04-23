Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsApplication1

	Public Class MyButtonEdit
		Inherits ButtonEdit
		Implements IAutoHeightControl
		Shared Sub New()
			RepositoryItemMyButtonEdit.Register()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyButtonEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyButtonEdit)
			End Get
		End Property


		Private ReadOnly Property SupportsAutoHeight() As Boolean Implements IAutoHeightControl.SupportsAutoHeight
			Get
				Return True
			End Get
		End Property
		Public Event heightChanged As EventHandler
        Private Custom Event HeightChanged1 As EventHandler Implements IAutoHeightControl.HeightChanged
            AddHandler(ByVal value As EventHandler)
                AddHandler heightChanged, value
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler heightChanged, value
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
            End RaiseEvent
        End Event
		Protected Sub RaiseHeightChanged()
			RaiseEvent heightChanged(Me, EventArgs.Empty)
		End Sub

		Private Function CalcHeight(ByVal cache As GraphicsCache) As Integer Implements IAutoHeightControl.CalcHeight
			If ViewInfo.IsReady Then
				Dim ih As IHeightAdaptable = TryCast(ViewInfo, IHeightAdaptable)
				If ih IsNot Nothing Then
					Return ih.CalcHeight(cache, Width)
				End If
			End If
			Return Height

		End Function
	End Class
End Namespace
