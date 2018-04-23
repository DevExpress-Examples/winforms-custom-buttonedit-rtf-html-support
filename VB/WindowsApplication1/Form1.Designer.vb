Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.repositoryItemRichTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
            Me.repositoryItemRichTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
            Me.myButtonEdit1 = New WindowsApplication1.MyButtonEdit
            CType(Me.repositoryItemRichTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'repositoryItemRichTextEdit2
            '
            Me.repositoryItemRichTextEdit2.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html
            Me.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2"
            '
            'repositoryItemRichTextEdit3
            '
            Me.repositoryItemRichTextEdit3.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html
            Me.repositoryItemRichTextEdit3.Name = "repositoryItemRichTextEdit3"
            '
            'myButtonEdit1
            '
            Me.myButtonEdit1.Dock = System.Windows.Forms.DockStyle.Top
            Me.myButtonEdit1.Location = New System.Drawing.Point(0, 0)
            Me.myButtonEdit1.Margin = New System.Windows.Forms.Padding(2)
            Me.myButtonEdit1.Name = "myButtonEdit1"
            Me.myButtonEdit1.Properties.AutoHeight = False
            Me.myButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.myButtonEdit1.Properties.RichEdit = Me.repositoryItemRichTextEdit2
            Me.myButtonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.myButtonEdit1.Size = New System.Drawing.Size(579, 107)
            Me.myButtonEdit1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(579, 420)
            Me.Controls.Add(Me.myButtonEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.repositoryItemRichTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private myButtonEdit1 As MyButtonEdit
        Private repositoryItemRichTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
		Private repositoryItemRichTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
	End Class
End Namespace

