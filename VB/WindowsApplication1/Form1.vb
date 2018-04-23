Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private HtmlString As String = "<html>" & ControlChars.CrLf & "<body>" & ControlChars.CrLf & ControlChars.CrLf & "<h1>My First Heading</h1>" & ControlChars.CrLf & ControlChars.CrLf & "<p>My first paragraph.</p>" & ControlChars.CrLf & ControlChars.CrLf & "</body>" & ControlChars.CrLf & "</html>" & ControlChars.CrLf & ""

		Public Sub New()
			InitializeComponent()
            myButtonEdit1.EditValue = HtmlString
        End Sub
	End Class
End Namespace
