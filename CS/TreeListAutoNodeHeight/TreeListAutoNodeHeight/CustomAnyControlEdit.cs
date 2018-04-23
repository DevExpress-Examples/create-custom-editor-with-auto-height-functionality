using DevExpress.XtraEditors.CustomEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TreeListAutoNodeHeight.TreeListAutoNodeHeight
{
    [ToolboxItem(true)]
    [DesignerCategory("")]
    class CustomAnyControlEdit : AnyControlEdit
    {
        static CustomAnyControlEdit()
        {
            CustomAnyControlEditRepositoryItem.RegisterCustomAnyControlEdit();
        }

        public CustomAnyControlEdit()
        {
        }


        protected internal virtual CustomAnyControlEditViewInfo CustomAnyControlViewInfo { get { return ViewInfo as CustomAnyControlEditViewInfo; } }

        public override string EditorTypeName
        {
            get { return CustomAnyControlEditRepositoryItem.CustomAnyControlEditName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new CustomAnyControlEditRepositoryItem Properties
        {
            get { return base.Properties as CustomAnyControlEditRepositoryItem; }
        }
    }
}
