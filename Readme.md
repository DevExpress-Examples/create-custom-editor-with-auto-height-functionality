<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/TreeListAutoNodeHeight/Form1.cs)
* [Program.cs](./CS/TreeListAutoNodeHeight/Program.cs)
* [CustomAnyControlEdit.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEdit.cs)
* [CustomAnyControlEditPainter.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEditPainter.cs)
* [CustomAnyControlEditRepositoryItem.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEditRepositoryItem.cs)
* [CustomAnyControlEditViewInfo.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEditViewInfo.cs)
<!-- default file list end -->
# How to implement the Auto Height functionality in RepositoryItemAnyControl


<p>To support the <em>Auto Height</em> <em>functionality</em> in your custom editor, implement the <strong>IHeightAdaptable</strong> interface for its <strong>ViewInfo</strong> class and return the required height in its <strong>IHeightAdaptable.CalcHeight</strong> method. This example shows how to calculate the best height based on the editor's text. If your custom editor is more complex, you need to adapt this code to take your custom layout into account.</p>

<br/>


