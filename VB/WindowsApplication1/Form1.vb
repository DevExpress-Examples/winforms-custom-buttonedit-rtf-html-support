Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Private HtmlString As String = "<html>
<body>

<h1>My First Heading</h1>

<p>My first paragraph.</p>

</body>
</html>
"

        Public Sub New()
            InitializeComponent()
            myButtonEdit1.EditValue = HtmlString
        End Sub
    End Class
End Namespace
