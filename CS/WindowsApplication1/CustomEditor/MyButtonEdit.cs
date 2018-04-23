using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{

    public class MyButtonEdit : ButtonEdit, IAutoHeightControl
    {
        static MyButtonEdit()
        {
            RepositoryItemMyButtonEdit.Register();
        }
     
        public override string EditorTypeName
        {
            get { return RepositoryItemMyButtonEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemMyButtonEdit; }
        }


        bool IAutoHeightControl.SupportsAutoHeight { get { return true; } }
        public event EventHandler heightChanged;
        event EventHandler IAutoHeightControl.HeightChanged
        {
            add { heightChanged += value; }
            remove { heightChanged -= value; }
        }
        protected void RaiseHeightChanged()
        {
            if (heightChanged != null)
                heightChanged(this, EventArgs.Empty);
        }

        int IAutoHeightControl.CalcHeight(GraphicsCache cache)
        {
            if (ViewInfo.IsReady)
            {
                IHeightAdaptable ih = ViewInfo as IHeightAdaptable;
                if (ih != null) return ih.CalcHeight(cache, Width);
            }
            return Height;

        }
    }
}
