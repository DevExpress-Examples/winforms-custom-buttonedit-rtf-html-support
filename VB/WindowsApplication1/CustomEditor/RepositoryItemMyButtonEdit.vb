Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1

    <UserRepositoryItem("Register")>
    <System.ComponentModel.DesignerCategory("")>
    Public Class RepositoryItemMyButtonEdit
        Inherits RepositoryItemButtonEdit

        Private _RichRI As RepositoryItemRichTextEdit = New RepositoryItemRichTextEdit()

        Public Property RichEdit As RepositoryItemRichTextEdit
            Get
                Return _RichRI
            End Get

            Set(ByVal value As RepositoryItemRichTextEdit)
                _RichRI = value
            End Set
        End Property

        Shared Sub New()
            Call Register()
        End Sub

        Public Sub New()
        End Sub

        Friend Const EditorName As String = "MyButtonEdit"

        Public Shared Sub Register()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(MyButtonEditViewInfo), New MyPainter(), True, CType(Nothing, System.Drawing.Image)))
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return EditorName
            End Get
        End Property

        Public Overrides Property TextEditStyle As TextEditStyles
            Get
                Return TextEditStyles.DisableTextEditor
            End Get

            Set(ByVal value As TextEditStyles)
            End Set
        End Property

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            MyBase.Assign(item)
            RichEdit.Assign(TryCast(item, RepositoryItemMyButtonEdit).RichEdit)
        End Sub
    End Class
End Namespace
