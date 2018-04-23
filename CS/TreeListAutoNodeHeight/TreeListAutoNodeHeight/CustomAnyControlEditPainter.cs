using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraEditors.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeListAutoNodeHeight
{
    class CustomAnyControlEditPainter : AnyControlEditPainter
    {
        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            info.ViewInfo.PaintAppearance.DrawBackground(info.Cache, info.Bounds);
            info.ViewInfo.PaintAppearance.DrawString(info.Cache, info.ViewInfo.DisplayText, info.Bounds);
        }
    }
}
