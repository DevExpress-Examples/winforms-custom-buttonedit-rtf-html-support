# How to create a custom ButtonEdit that allows displaying readonly RTF/HTML content


<p>This example demonstrates how to create an editor that allows displaying rich content and buttons at the same time.</p><p>In this example we have created a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemButtonEdittopic"><u>RepositoryItemButtonEdit</u></a> descendant with an additional <strong>RichEdit</strong> property. The <strong>RichEdit</strong> property is a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemRichTextEdittopic"><u>RepositoryItemRichTextEdit</u></a> object. It is used to draw the editor content in a required <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditDocumentFormattopic"><u>document format</u></a>. </p><p>In addition, the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemRichTextEdittopic"><u>RepositoryItemRichTextEdit</u></a>  object is used to calculate the row height when this editor is used as an inplace editor in GridControl or TreeList. To enable the auto height calculation feature, the editor should implement the <strong>IAutoHeightControl</strong> interface, and its <strong>ViewInfo</strong> should implement the <strong>IHeightAdaptable interface</strong>.</p>

<br/>


