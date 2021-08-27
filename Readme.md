<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2880)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyButtonEdit.cs](./CS/WindowsApplication1/CustomEditor/MyButtonEdit.cs) (VB: [MyButtonEditViewInfo.vb](./VB/WindowsApplication1/CustomEditor/MyButtonEditViewInfo.vb))
* [MyButtonEditViewInfo.cs](./CS/WindowsApplication1/CustomEditor/MyButtonEditViewInfo.cs) (VB: [MyButtonEditViewInfo.vb](./VB/WindowsApplication1/CustomEditor/MyButtonEditViewInfo.vb))
* [MyPainter.cs](./CS/WindowsApplication1/CustomEditor/MyPainter.cs) (VB: [MyPainter.vb](./VB/WindowsApplication1/CustomEditor/MyPainter.vb))
* [RepositoryItemMyButtonEdit.cs](./CS/WindowsApplication1/CustomEditor/RepositoryItemMyButtonEdit.cs) (VB: [RepositoryItemMyButtonEdit.vb](./VB/WindowsApplication1/CustomEditor/RepositoryItemMyButtonEdit.vb))
* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to create a custom ButtonEdit that allows displaying readonly RTF/HTML content


<p>This example demonstrates how to create an editor that allows displaying rich content and buttons at the same time.</p><p>In this example we have created a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemButtonEdittopic"><u>RepositoryItemButtonEdit</u></a> descendant with an additional <strong>RichEdit</strong> property. The <strong>RichEdit</strong> property is a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemRichTextEdittopic"><u>RepositoryItemRichTextEdit</u></a> object. It is used to draw the editor content in a required <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditDocumentFormattopic"><u>document format</u></a>. </p><p>In addition, the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemRichTextEdittopic"><u>RepositoryItemRichTextEdit</u></a>  object is used to calculate the row height when this editor is used as an inplace editor in GridControl or TreeList. To enable the auto height calculation feature, the editor should implement the <strong>IAutoHeightControl</strong> interface, and its <strong>ViewInfo</strong> should implement the <strong>IHeightAdaptable interface</strong>.</p>

<br/>


