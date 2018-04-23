using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using TreeListAutoNodeHeight.TreeListAutoNodeHeight;

namespace TreeListAutoNodeHeight
{
    [UserRepositoryItem("RegisterCustomAnyControlEdit")]
    [DesignerCategory("")]
    class CustomAnyControlEditRepositoryItem : RepositoryItemAnyControl
    {
        public CustomAnyControlEditRepositoryItem()
        {
        }
        static CustomAnyControlEditRepositoryItem()
        {
            RegisterCustomAnyControlEdit();
        }

        public const string CustomAnyControlEditName = "CustomAnyControlEdit";

        public override string EditorTypeName
        {
            get { return CustomAnyControlEditName; }
        }

        public static void RegisterCustomAnyControlEdit()
        {
            Image img = null;
            try
            {
                img = (Bitmap)Bitmap.FromStream(Assembly.GetExecutingAssembly().
                    GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp"));
            }
            catch
            { }

            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomAnyControlEditName, typeof(CustomAnyControlEdit),
                typeof(CustomAnyControlEditRepositoryItem),
                typeof(CustomAnyControlEditViewInfo), new CustomAnyControlEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                CustomAnyControlEditRepositoryItem source = item as CustomAnyControlEditRepositoryItem;
                if (source == null) return;
            }
            finally
            {
                EndUpdate();
            }
        }
    }
}
