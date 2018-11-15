<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/ImageTextEdit/Form1.cs) (VB: [Form1.vb](./VB/ImageTextEdit/Form1.vb))**
* [ImagTextEdit.cs](./CS/ImageTextEdit/ImagTextEdit.cs) (VB: [ImagTextEdit.vb](./VB/ImageTextEdit/ImagTextEdit.vb))
<!-- default file list end -->
# How to create an editor that displays images from ImageCollection


<p>This example shows how to create and use a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsTextEdittopic">TextEdit</a> descendant that will display an image from an <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressUtilsImageCollectiontopic">ImageCollection</a> and provide the capability of runtime image selection.</p><p>This descendant's repository items have two additional properties:</p><p><strong>RepositoryItems.ImageList</strong> - get or set an images source.<br />
<strong>RepositoryItems.ImageIndex</strong> - get or set an index of the image that should be displayed.</p><p>And two additional events<br />
<strong>RepositoryItems.IconClick</strong> - occurs when a user clicks on an image.<br />
<strong>RepositoryItems.OnIconSelection</strong> - this event can be used to specify the index of the image that should be displayed. The event handler receives an argument of the <strong>OnIconSelectionEventArgs</strong> type for providing data related to this event.<br />
The <strong>OnIconSelectionEventArgs</strong> has two properties.<br />
<strong>ImageList</strong> - gets an image source specified in the <strong>RepositoryItems.ImageList</strong> property.<br />
<strong>ImageIndex</strong> - gets or sets the index of the image that should be displayed.<br />
You should assign the index of the image that you want to display to the <strong>OnIconSelectionEventArgs.ImageIndex</strong> property.</p><p>In the attached example the <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressUtilsImageCollectiontopic">ImageCollection</a> control is used for storing images. It is assigned to the <strong>RepositoryItems.ImageList</strong> properties of the created controls. The <strong>RepositoryItems.OnIconSelection</strong> event is used for the image selection according to the editor state. The <strong>RepositoryItems.IconClick</strong> event assigns the <strong>Form.Text</strong> property.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/K18336">How to force a TextEdit to display an image against the text </a></p>

<br/>


