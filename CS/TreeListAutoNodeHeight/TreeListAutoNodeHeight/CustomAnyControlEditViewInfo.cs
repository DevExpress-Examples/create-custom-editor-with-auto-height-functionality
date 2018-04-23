using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeListAutoNodeHeight
{
    class CustomAnyControlEditViewInfo : AnyControlEditViewInfo, IHeightAdaptable
    {
        public CustomAnyControlEditViewInfo(RepositoryItem item) : base(item) { }

        int IHeightAdaptable.CalcHeight(GraphicsCache cache, int width)
        {
            Rectangle textRect = new Rectangle(0, 0, width, 100);
            if (!(BorderPainter is EmptyBorderPainter) && !(BorderPainter is InplaceBorderPainter))
                textRect.Inflate(-1, -1);
            string text = string.Empty;
            {
                text = DisplayText;
                if (text != null && text.Length > 0)
                {
                    char lastChar = text[text.Length - 1];
                    if (lastChar == 13 || lastChar == 10) text += "W";
                }
            }
            int height = CalcTextSizeCore(cache, text, textRect.Width).Height + 1;
            return (height + 100 - textRect.Bottom) + 1;
        }
    }
}
