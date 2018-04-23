using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    class MyButtonEditViewInfo : ButtonEditViewInfo, IHeightAdaptable
    {
        public MyButtonEditViewInfo(RepositoryItem item) : base(item) { }
        public int CalcHeight(DevExpress.Utils.Drawing.GraphicsCache cache, int width)
        {
            RepositoryItemMyButtonEdit ri = (Item as RepositoryItemMyButtonEdit);
            RichTextEditViewInfo vi = new RichTextEditViewInfo(ri.RichEdit);
            vi.EditValue = this.EditValue;
            return vi.CalcHeight(width) + 6;
        }
    }
}
