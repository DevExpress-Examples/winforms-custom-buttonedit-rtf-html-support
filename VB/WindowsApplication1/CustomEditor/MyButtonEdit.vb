Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
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

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemMyButtonEdit.EditorName
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemMyButtonEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemMyButtonEdit)
            End Get
        End Property

        Private ReadOnly Property SupportsAutoHeight As Boolean Implements IAutoHeightControl.SupportsAutoHeight
            Get
                Return True
            End Get
        End Property

        Public Event eHeightChanged As EventHandler

        Private Custom Event HeightChanged As EventHandler Implements IAutoHeightControl.HeightChanged
            AddHandler(ByVal value As EventHandler)
                AddHandler eHeightChanged, value
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler eHeightChanged, value
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
                RaiseEvent eHeightChanged(sender, e)
            End RaiseEvent
        End Event

        Protected Sub RaiseHeightChanged()
            RaiseEvent eHeightChanged(Me, EventArgs.Empty)
        End Sub

        Private Function CalcHeight(ByVal cache As GraphicsCache) As Integer Implements IAutoHeightControl.CalcHeight
            If ViewInfo.IsReady Then
                Dim ih As IHeightAdaptable = TryCast(ViewInfo, IHeightAdaptable)
                If ih IsNot Nothing Then Return ih.CalcHeight(cache, Width)
            End If

            Return Height
        End Function
    End Class
End Namespace
