using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyPainter : ButtonEditPainter
    {

        public MyPainter()
        {

        }

        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            base.DrawContent(info);
        }

        protected override void DrawText(ControlGraphicsInfoArgs info)
        {
            RichTextEditPainter.DrawRTF(GetViewInfo(info), info.Cache);
        }
        private RichTextEditViewInfo GetViewInfo(ControlGraphicsInfoArgs info)
        {
            RepositoryItemMyButtonEdit ri = (info.ViewInfo as ButtonEditViewInfo).Item as RepositoryItemMyButtonEdit;
            RichTextEditViewInfo vi = new RichTextEditViewInfo(ri.RichEdit);
            vi.Bounds = info.ViewInfo.ContentRect;
            vi.EditValue = info.ViewInfo.DisplayText;
            vi.CalcViewInfo(info.Graphics);
            return vi;

        }
    }

}
