<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637768/14.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T236498)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


