# How to implement the Auto Height functionality in RepositoryItemAnyControl


<p>To support the <em>Auto Height</em> <em>functionality</em> in your custom editor, implement the <strong>IHeightAdaptable</strong> interface for its <strong>ViewInfo</strong> class and return the required height in its <strong>IHeightAdaptable.CalcHeight</strong> method. This example shows how to calculate the best height based on the editor's text. If your custom editor is more complex, you need to adapt this code to take your custom layout into account.</p>

<br/>


