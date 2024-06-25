<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637768/14.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T236498)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to create a custom editor with the Auto Height functionality

This example demonstrates how to create a custom in-place editor (`CustomAnyControlEdit`) with the Auto Height functionality. The example implements the `IHeightAdaptable` interface for the editor's `ViewInfo` class, calculates the height required to display the content of the editor, and returns the height in the `IHeightAdaptable.CalcHeight` method.


## Files to Review

* [Form1.cs](./CS/TreeListAutoNodeHeight/Form1.cs)
* [CustomAnyControlEdit.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEdit.cs)
* [CustomAnyControlEditPainter.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEditPainter.cs)
* [CustomAnyControlEditRepositoryItem.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEditRepositoryItem.cs)
* [CustomAnyControlEditViewInfo.cs](./CS/TreeListAutoNodeHeight/TreeListAutoNodeHeight/CustomAnyControlEditViewInfo.cs)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=create-custom-editor-with-auto-height-functionality&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=create-custom-editor-with-auto-height-functionality&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
